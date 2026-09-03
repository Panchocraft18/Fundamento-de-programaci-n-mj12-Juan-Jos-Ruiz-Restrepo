using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Ciclowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que pida números enteros positivos  al usuario hasta que el mismo ingrese un número negativo, luego mostrar la suma de todos los números ingresados.
            //variable bandera 
            int SumaEntero = 0;
            int numero = 0 ;
            Console.WriteLine("Ingrese un número entero positivo para sumar :");
             numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                SumaEntero += numero;
                Console.WriteLine("Ingrese un número entero positivo para sumar ");
                numero = int.Parse(Console.ReadLine());
            }
                Console.WriteLine($"La suma de todos los números ingresados es:  + { SumaEntero}");
        }
    }
}

