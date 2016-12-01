using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarShop.Common;

namespace CarShop.Model.Cadet
{
    [CarShop.Common.CommonInterfacesClasses.CarInfo(VendorName ="Opel")]
    public class Cadet : CommonInterfacesClasses.ICarModel
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

        public Cadet()
        {
            this.Name = "Cadet";
            this.Colors = new List<System.Drawing.Color>();
            this.Colors.Add(System.Drawing.Color.Azure);
            this.Colors.Add(System.Drawing.Color.Beige);
            this.Colors.Add(System.Drawing.Color.Black);
            this.Colors.Add(System.Drawing.Color.Indigo);
        }
    }
}
