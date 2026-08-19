using System;
using System.Diagnostics.Eventing.Reader;

namespace disparo_pew_pew
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int numero;
            bool invesible;
            Random rnd = new Random();
            numero = rnd.Next(0, 6);



            Console.WriteLine("Hola, ¿qué lo que?");
            Console.WriteLine("Tu munición actual es " + numero);
            Console.WriteLine("¿Estás en estado invisible?");


            invesible = Convert.ToBoolean(Console.ReadLine());
            if (invesible == true)
            {
                if (numero > 0)
                {
                    Console.WriteLine("puedes disparar ");
                }
                else
                {
                    Console.WriteLine("no puedes disparar");
                }
            }
            else
            {
                invesible = false;
                Console.WriteLine("No estás invisible");
            }
        }
    }
}