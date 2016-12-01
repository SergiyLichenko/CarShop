using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Model.Omega
{
    [Common.CommonInterfacesClasses.CarInfo(VendorName = "Opel")]
    public class Omega:Common.CommonInterfacesClasses.ICarModel
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
        public Omega()
        {
            this.Name = "Omega";
            this.Colors = new List<System.Drawing.Color>();
            Colors.Add(System.Drawing.Color.Green);
            Colors.Add(System.Drawing.Color.Maroon);
            Colors.Add(System.Drawing.Color.Lime);
        }

    }
}
