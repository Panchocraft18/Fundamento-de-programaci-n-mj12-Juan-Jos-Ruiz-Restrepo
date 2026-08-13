using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.condicionalesMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Condicionales Múltiples
            // crear un algoritmo que muester x pantalla 5 opciones y un mensaje que diga la opcion seleccionada 

            int respuesta = 0;
            Console.WriteLine("--------------Menu--------------");
            Console.WriteLine("1. Opción 1               2.Opción 2");
            Console.WriteLine("3. Opción 3               4.Opción 4");
            Console.WriteLine("5. Opción 5");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Eliga uno de nuestros menus");
            respuesta=int.Parse(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("Usted eligió la opción 1");
                    break;

                case 2:
                    Console.WriteLine("Uestese eligió la opción 2");
                    break;
                case 3:
                    Console.WriteLine("Usted eligió la opción 3");
                    break;
                case 4:
                    Console.WriteLine("Usted eligió la opción 4");
                    break;
                    case 5:
                    Console.WriteLine("Usted eligió la opción 5");
                    break;
                    default:
                    Console.WriteLine("Elige una opción válida");
                    break;

            }




        }
    }
}
