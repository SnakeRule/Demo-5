using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_4
{
    class Inventory
    {
        public List<Weapons> heavies;
        public List<Weapons> pistols;
        public List<Weapons> rifles;
        public List<Weapons> supports;
        public List<Weapons> loadout;


        public Inventory()
        {
            heavies = new List<Weapons>();
            rifles = new List<Weapons>();
            pistols = new List<Weapons>();
            supports = new List<Weapons>();
            loadout = new List<Weapons>();
        }


        public void CreateHeavyList(Weapons heavy1, Weapons heavy2)
        {
            heavies.Add(heavy1);
            heavies.Add(heavy2);
        }

        public void CreateRifleList(Weapons rifle1, Weapons rifle2)
        {
            rifles.Add(rifle1);
            rifles.Add(rifle2);
        }

        public void CreatePistolList(Weapons pistol1, Weapons pistol2)
        {
            pistols.Add(pistol1);
            pistols.Add(pistol2);
        }

        public void CreateSupportList(Weapons support1, Weapons support2)
        {
            supports.Add(support1);
            supports.Add(support2);
        }

        public void CreateLoudOut()
        {
            int i;
            Console.WriteLine("Choose Heavy Weapon 1-2. Any other number will skip the selection");
            ShowHeavyList();
            i = int.Parse(Console.ReadLine());
            if (i <= 2 && i >= 1)
                loadout.Add(heavies[i - 1]);
            else Console.WriteLine("Selection skipped!");

            Console.WriteLine("Choose Rifle 1-2. Any other number will skip the selection");
            ShowRifleList();
            i = int.Parse(Console.ReadLine());
            if (i <= 2 && i >= 1)
                loadout.Add(rifles[i - 1]);
            else Console.WriteLine("Selection skipped!");

            Console.WriteLine("Choose Pistol 1-2. Any other number will skip the selection");
            ShowPistolList();
            i = int.Parse(Console.ReadLine());
            if (i <= 2 && i >= 1)
                loadout.Add(pistols[i - 1]);
            else Console.WriteLine("Selection skipped!");

            Console.WriteLine("Choose Support weapon 1-2. Any other number will skip the selection");
            ShowSupportList();
            i = int.Parse(Console.ReadLine());
            if (i <= 2 && i >= 1)
                loadout.Add(supports[i - 1]);
            else Console.WriteLine("Selection skipped!");

            Console.Clear();
            Console.WriteLine("Loadout Created!");
        }


        public void ShowHeavyList()
        {
            Console.WriteLine("Heavy Weapons: \n");
            foreach (Weapons heavies in heavies)
            {
                Console.WriteLine("Weapon Name: " + heavies.Name + "\nType : " + heavies.Type + "\nAmmo : " + heavies.Ammo + "\nWeight : " + heavies.Weight + " KG\n");
            }
            Console.WriteLine();
        }

        public void ShowRifleList()
        {
            Console.WriteLine("Rifles: \n");
            foreach (Weapons rifles in rifles)
            {
                Console.WriteLine("Weapon Name: " + rifles.Name + "\nType : " + rifles.Type + "\nAmmo : " + rifles.Ammo + "\nWeight : " + rifles.Weight + " KG\n");
            }
            Console.WriteLine();
        }

        public void ShowPistolList()
        {
            Console.WriteLine("Pistols: \n");
            foreach (Weapons pistols in pistols)
            {
                Console.WriteLine("Weapon Name: " + pistols.Name + "\nType : " + pistols.Type + "\nAmmo : " + pistols.Ammo + "\nWeight : " + pistols.Weight + " KG\n");
            }
            Console.WriteLine();
        }

        public void ShowSupportList()
        {
            Console.WriteLine("Support Weapons: \n");
            foreach (Weapons supports in supports)
            {
                Console.WriteLine("Weapon Name: " + supports.Name + "\nType : " + supports.Type + "\nAmmo : " + supports.Ammo + "\nWeight : " + supports.Weight + " KG\n");
            }
            Console.WriteLine();
        }

        public void ShowLoadOut()
        {
            Console.WriteLine("Loadout: \n");
            foreach (Weapons loadout in loadout)
            {
                Console.WriteLine("Weapon Name: " + loadout.Name + "\nType : " + loadout.Type + "\nAmmo : " + loadout.Ammo + "\nWeight : " + loadout.Weight + " KG\n");
            }
            Console.WriteLine();
        }
    }
}
