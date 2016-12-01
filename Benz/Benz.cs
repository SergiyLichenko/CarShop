using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Model.Benz
{
    [Common.CommonInterfacesClasses.CarInfo(VendorName = "Mercedes")]
    public class Benz : Common.CommonInterfacesClasses.ICarModel
    {
        public List<System.Drawing.Color> Colors
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }
        public Benz()
        {
            this.Name = "Benz";
            this.Colors = new List<System.Drawing.Color>();
            Colors.Add(System.Drawing.Color.Beige);
            Colors.Add(System.Drawing.Color.Orange);
            Colors.Add(System.Drawing.Color.Pink);
        }
    }
}
