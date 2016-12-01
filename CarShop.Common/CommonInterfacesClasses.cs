using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace CarShop.Common
{
    public class CommonInterfacesClasses
    {
        public interface IVentor
        {
            string VendorName { get; }
            IList<ICarModel> GetProductionList();
        }
        public abstract class BaseVentor : IVentor
        {
            public string VendorName
            {
                get;
                set;
            }

            public IList<ICarModel> GetProductionList()
            {
                IList<ICarModel> models = new List<ICarModel>();
                string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
                string[] files = Directory.GetFiles(directoryPath, "*.dll");

                foreach (string item in files)
                {
                    Assembly assembly = null;
                    try { assembly = Assembly.LoadFile(item); }
                    catch (ReflectionTypeLoadException e) { }

                    foreach (Type type in assembly.GetTypes())
                    {
                        Type temp = type.GetInterface("ICarModel");
                        if (temp != null)
                        {
                            CarInfoAttribute atr = (CarInfoAttribute)type.GetCustomAttribute(typeof(CarInfoAttribute));
                            if (atr != null && atr.VendorName == this.VendorName)
                            {
                                ICarModel model = Activator.CreateInstance(type) as ICarModel;
                                models.Add(model);
                            }
                        }
                    }
                }
                return models;
            }
        }
        public interface ICarModel
        {
            string Name { get; }
            List<Color> Colors { get; }
        }
        public sealed class CarInfoAttribute : Attribute
        {
            public string VendorName { get; set; }
        }
        public class OrderedCar
        {
            public string VendorName { get; set; }
            public string ModelName { get; set; }
            public Color ModelColor { get; set; }
            public int Count { get; set; }

            public OrderedCar(string vendorName, string modelName, Color color, int count)
            {
                this.VendorName = vendorName;
                this.ModelName = modelName;
                this.ModelColor = color;
                this.Count = count;
            }
        }
    }
}
