using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_rpg
{
    internal class Enemy
    {
        public int HP { get; set; }
        public int Atacar()
        {
            return 15; // daño que aflige el enemigo
        }
    }
}
