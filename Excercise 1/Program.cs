using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create tyre
            Tyre tyre1 = new Tyre { Name = "Nokia", Model = "Hakkapeliitta", Size = "205R16" };
            Tyre tyre2 = new Tyre { Name = "Pirelli", Model = "JokuPirelli", Size = "225R16" };



            // Create a car
            Vehicle car = new Vehicle { Name = "Dodge", Model = "Viper" };

            car.AddTyre(tyre1);
            car.AddTyre(tyre1);
            car.AddTyre(tyre2);
            car.AddTyre(tyre2);

            Console.WriteLine(car.ToString());
        }
    }
}
