using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yggdrasil_The_Tree_of_Worlds
{
   abstract  class Unit
    {
        protected int health;
        protected int attackPower;

        public string Name;

        public void GetDamage()
        {
            health -= attackPower;
        }
    }
}
