using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_4
{
    class Inventory
    {
        public List<HeavyWeapons> heavy;
        public List<Pistols> pistols;
        public List<Rifles> rifles;
        public List<SupportWeapons> support;



        public void CreateLoadout()
        {
            heavy = new List<HeavyWeapons>();
            pistols = new List<Pistols>();
            rifles = new List<Rifles>();
            support = new List<SupportWeapons>();
        }

        public Inventory()
        {
            
        }
    }
}
