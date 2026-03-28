using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_rpg
{
    internal class juego
    {
        //variable
        bool Fin;
        bool Win;// :D
        // funciones provadas
        private void  InitVariables()
        {
            
            this.Fin = false;
            this.Win = false;
        }
        public juego()
        {
            this.InitVariables();
            //constructor y destructor

            Console.WriteLine("bienvenido aventurero");

        }
        public void Run()
        {
            Console.WriteLine("Ingresa tu vida (HP):");
            int hp = Convert.ToInt32(Console.ReadLine());
            Enemy enemigo = new Enemy();
            enemigo.HP = 50; // vida del NPC
            while (this.Fin == false)

            {
                Console.WriteLine("elige un arma: arco(1) o espada(2)");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                    this.Fin = true;
                if (number > 2)
                    this.Fin = true;
                //ola profe
                if (number == 1)
                {
                    Console.WriteLine("has elegido el arco, ¡disparas!" + number);
                    enemigo.HP = enemigo.HP - 10;
                }
                else
                {
                    Console.WriteLine("has elegido la espada ¡rebanas!" + number);
                    enemigo.HP = enemigo.HP - 20;
                }
                Console.WriteLine("HP del enemigo: " + enemigo.HP);
                // enemigo contraataca SOLO si sigue vivo
                if (enemigo.HP > 0)
                {
                    int daño = enemigo.Atacar();
                    hp = hp - daño;

                    Console.WriteLine("El enemigo te ataca!" + daño + " HP)");
                    Console.WriteLine("Tu HP: " + hp);
                }
                // si te quedas sin hp mueres
                if (hp <= 0)
                {
                    Console.WriteLine("Has sido derrotado 💀");
                    this.Fin = true;
                }

                if (enemigo.HP <= 0)
                {
                    Console.WriteLine("El enemigo ha sido derrotado 💀");
                    Console.WriteLine("¡Has ganado! :D");
                    this.Fin = true;
                    this.Win = true;
                }

            }
            if (!this.Win)
            {
                Console.WriteLine("adiós");
            }

        }
    }
}
