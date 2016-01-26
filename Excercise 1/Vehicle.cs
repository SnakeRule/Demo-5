using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public List<Tyre> tyres { get; }

        public Vehicle()
        {
            tyres = new List<Tyre>();
        }

        public void AddTyre(Tyre tyre)
        {
        tyres.Add(tyre);
        }

        public override string ToString()
        {
            string sVehicle = "Vehicle Name: " + Name + "\nModel : " + Model + "\nTyres:\n";
            foreach(Tyre tyre in tyres)
            {
                sVehicle += tyre.ToString() + "\n";
            }
            return sVehicle;
        }
    }
}
