using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Coliclo_while3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
                Escribe un algoritmo en el que el computador elija un número aleatorio entre 1 y 100. El usuario debe adivinar el número, y el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto. Usa un ciclo while para seguir pidiendo intentos hasta que el usuario adivine el número. Utilizar la función Random para elegir el número aleatorio.*/

            int user = 0;
            int numerorandom = new Random().Next(1, 101);
           
            do

            {
                // Genera un número aleatorio entre 1 y 100
                Console.WriteLine("Adivina el número entre 1 y 100");
                user = int.Parse(Console.ReadLine());
                if (user < numerorandom)
                {
                    Console.WriteLine("Demasiado bajo, intenta de nuevo");
                }

                else if (user > numerorandom)
                {
                    Console.WriteLine("Demasiado alto, intenta de nuevo");
                }



            } while (user != numerorandom); // El ciclo se repetirá hasta que el usuario ingrese 0 para salir
            Console.WriteLine($"¡Felicidades! Adivinaste el número: " + numerorandom);
           
        }
    }
}