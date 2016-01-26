using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_4
{
    class HeavyWeapons : ItemBase
    {
        HeavyWeapons lmg = new HeavyWeapons { Name = "Light machinegun", Type = "Heavy Weapon", Ammo = 500 };
        HeavyWeapons rpg = new HeavyWeapons { Name = "RPG", Type = "Heavy Weapon", Ammo = 5 };

    }
}
