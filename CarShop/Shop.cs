using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CarShop.Common;
using System.IO;
using System.Reflection;

namespace CarShop
{
    public partial class Shop : Form
    {
        private IList<CommonInterfacesClasses.IVentor> vendors;
        private IList<CommonInterfacesClasses.ICarModel> curentModels;
        private List<Color> currentColors;
        private List<CommonInterfacesClasses.OrderedCar> orderList;
        private List<CommonInterfacesClasses.OrderedCar> finishList;
        public Shop()
        {
            InitializeComponent();

            this.finishList = new List<CommonInterfacesClasses.OrderedCar>();
            this.vendors = new List<CommonInterfacesClasses.IVentor>();
            this.curentModels = new List<CommonInterfacesClasses.ICarModel>();
            this.orderList = new List<CommonInterfacesClasses.OrderedCar>();
            this.listBox_ventors.DisplayMember = "VendorName";
            FillVentors();
        }

        private void FillVentors()
        {
            string pathFolder = System.AppDomain.CurrentDomain.BaseDirectory;
            string[] dllFiles = Directory.GetFiles(pathFolder, "*.dll");

            foreach (string item in dllFiles)
            {
                try
                {
                    Assembly assembly = Assembly.LoadFile(item);
                    foreach (Type type in assembly.GetTypes())
                    {
                        Type iface = type.GetInterface("IVentor");
                        if (iface != null && !type.IsAbstract)
                        {

                            CommonInterfacesClasses.IVentor ventor = (CommonInterfacesClasses.IVentor)
                                Activator.CreateInstance(type);
                            this.vendors.Add(ventor);
                            this.listBox_ventors.Items.Add(ventor);
                        }
                    }
                }
                catch (ReflectionTypeLoadException e)
                {
                    MessageBox.Show("Ошибка загрузки плагина \n" + e.Message);
                }
            }
        }

        private void listBox_ventors_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox_Models.Items.Clear();
            this.listBox_Colors.Items.Clear();

            CommonInterfacesClasses.IVentor temp = (CommonInterfacesClasses.IVentor)((ListBox)sender).SelectedItem;
            curentModels = temp.GetProductionList();

            if (this.curentModels.Count != 0)
                foreach (CommonInterfacesClasses.ICarModel item in curentModels)
                    this.listBox_Models.Items.Add(item.Name);
        }

        private void listBox_Models_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox_Colors.Items.Clear();
            foreach (CommonInterfacesClasses.ICarModel item in curentModels)
                if (this.listBox_Models.SelectedItem != null && item.Name == this.listBox_Models.SelectedItem.ToString())
                {
                    this.currentColors = item.Colors;
                    if (this.currentColors != null)
                        foreach (Color color in currentColors)
                            listBox_Colors.Items.Add(color.Name);
                }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            if (this.vendors != null && this.vendors.Count != 0)
                this.vendors.Clear();
            if (this.currentColors != null && this.currentColors.Count != 0)
                this.currentColors.Clear();
            if (this.curentModels != null && this.curentModels.Count != 0)
                this.curentModels.Clear();
            if (this.orderList != null && this.orderList.Count != 0)
                this.orderList.Clear();
            if (this.finishList != null && this.finishList.Count != 0)
                this.finishList.Clear();

            this.listBox_Colors.Items.Clear();
            this.listBox_Models.Items.Clear();
            this.listBox_ventors.Items.Clear();
            this.listBox_Ordered.Items.Clear();
            this.listBox_allCars.Items.Clear();
            this.finishList.Clear();

            this.numericUpDown1.Value = 0;
            this.FillVentors();
        }

        private void button_ADD_Click(object sender, EventArgs e)
        {
            if (!(this.listBox_ventors.SelectedIndex > -1 &&
                this.listBox_Colors.SelectedIndex > -1 &&
                this.listBox_Models.SelectedIndex > -1 &&
                this.numericUpDown1.Value > 0))
            {
                MessageBox.Show("Укажите все параметры");
                return;
            }
            CommonInterfacesClasses.OrderedCar orderCar =
                new CommonInterfacesClasses.OrderedCar(
                    this.vendors[this.listBox_ventors.SelectedIndex].VendorName,
                    this.curentModels[this.listBox_Models.SelectedIndex].Name,
                    this.currentColors[this.listBox_Colors.SelectedIndex],
                    (int)this.numericUpDown1.Value);

            orderList.Add(orderCar);

            this.listBox_Ordered.Items.Add(orderCar.VendorName + " " + orderCar.ModelName +
                " " + orderCar.ModelColor.Name + " " + orderCar.Count);
        }

        private void button_makeOrder_Click(object sender, EventArgs e)
        {
            if (this.listBox_Ordered.SelectedIndex < 0)
            {
                MessageBox.Show("Ничего не выбрано");
                return;
            }

            for (int i = 0; i < this.orderList[this.listBox_Ordered.SelectedIndex].Count; i++)
            {
                this.listBox_allCars.Items.Add(this.orderList[this.listBox_Ordered.SelectedIndex].VendorName + " " +
                    this.orderList[this.listBox_Ordered.SelectedIndex].ModelName + " " +
                    this.orderList[this.listBox_Ordered.SelectedIndex].ModelColor.Name);

                this.finishList.Add(new CommonInterfacesClasses.OrderedCar(
                    this.orderList[this.listBox_Ordered.SelectedIndex].VendorName,
                    this.orderList[this.listBox_Ordered.SelectedIndex].ModelName,
                    this.orderList[this.listBox_Ordered.SelectedIndex].ModelColor, -1));
            }
            this.orderList.RemoveAt(this.listBox_Ordered.SelectedIndex);
            this.listBox_Ordered.Items.RemoveAt(this.listBox_Ordered.SelectedIndex);

        }

        private void button_Buy_Click(object sender, EventArgs e)
        {
            if (this.listBox_allCars.Items.Count == 0)
            {
                MessageBox.Show("Накладная не заполнена");
                return;
            }
            string message = String.Empty;
            for (int i = 0; i < this.listBox_allCars.Items.Count; i++)
                message += String.Format("{0}, {1}, {2}\n", this.finishList[i].VendorName,
                    this.finishList[i].ModelName, this.finishList[i].ModelColor.Name);

            this.finishList.Clear();
            this.listBox_allCars.Items.Clear();

            MessageBox.Show(message);
        }
    }
}
