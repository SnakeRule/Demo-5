using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapons heavy1 = new Weapons { Name = "LPG-61", Type = "Light Machinegun", Ammo = 500, Weight = 6 };
            Weapons heavy2 = new Weapons { Name = "RPG", Type = "Rocket Propelled Grenade Launcher", Ammo = 5, Weight = 10 };
            Weapons rifle1 = new Weapons { Name = "AM MRS-4", Type = "Rifle", Ammo = 200, Weight = 3 };
            Weapons rifle2 = new Weapons { Name = "M2000", Type = "Sniper rifle", Ammo = 40, Weight = 5 };
            Weapons pistol1 = new Weapons { Name = "WU Tranq pistol", Type = "Tranq. Pistol", Ammo = 50, Weight = 1.5 };
            Weapons pistol2 = new Weapons { Name = "WU S333", Type = "Revolver", Ammo = 30, Weight = 1.5 };
            Weapons support1 = new Weapons { Name = "M21 D-Mine", Type = "Claymore", Ammo = 3, Weight = 2 };
            Weapons support2 = new Weapons { Name = "Plushie", Type = "Cute Plushie Decoy", Ammo = 3, Weight = 0.5 };


            Inventory inventory = new Inventory();

            inventory.CreateHeavyList(heavy1, heavy2);
            inventory.CreateRifleList(rifle1, rifle2);
            inventory.CreatePistolList(pistol1, pistol2);
            inventory.CreateSupportList(support1, support2);

            bool loop = true;
            int input;

            do {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Show Heavy Weapons");
                Console.WriteLine("2. Show Rifles");
                Console.WriteLine("3. Show Pistols");
                Console.WriteLine("4. Show Support weapons");
                Console.WriteLine("5. Create Loadout");
                Console.WriteLine("6. View Loadout");
                Console.WriteLine("7. Quit");
                input = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (input)
                {
                    case 1: inventory.ShowHeavyList(); break;

                    case 2: inventory.ShowRifleList(); break;

                    case 3: inventory.ShowPistolList(); break;

                    case 4: inventory.ShowSupportList(); break;

                    case 5:
                        {
                            inventory.CreateLoudOut();
                            break;
                        }

                    case 6: inventory.ShowLoadOut(); break;

                    case 7: loop = false; break;
                }
            } while (loop == true);
        }
    }
}
