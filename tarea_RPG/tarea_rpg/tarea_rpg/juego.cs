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
        // funciones provadas
        private void  InitVariables()
        {
            
            this.Fin = false;
        }
        public juego()
        {
            this.InitVariables();
            //constructor y destructor

            Console.WriteLine("bienvenido aventurero");

        }
        public void Run()
        {
            while (this.Fin == false)
            {
                Console.WriteLine("elige un arma: arco(1) o espada(2)");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                    this.Fin = true;
                if (number > 2)
                    this.Fin = true;

                if (number == 1)
                {
                    Console.WriteLine(" has elegido el arco" + number);
                }
                else
                {
                    Console.WriteLine(" has elegido la espada" + number);
                }

            }
            Console.WriteLine("adiós");

        }
    }
}
