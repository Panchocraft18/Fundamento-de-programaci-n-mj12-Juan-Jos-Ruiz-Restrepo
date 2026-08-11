using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Condicionales_anidado
{
    internal class Program
    {
        // condicionales anidados
        //Diseñar un alggoritmo que lea trs números A, B,C visualice en pantalla el valor más grande. 
        //El usuario debe ingresar tres valores diferentes 
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Por favor ingrese 3 valores diferentes: ");
            Console.WriteLine("Ingrese el valor del numero 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del numero 2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del numero 3");
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                //verdaedro 
                if (num1 > num3)
                {
                    Console.WriteLine("El numero 1 es el mayor ");
                }
                else
                {
                    Console.WriteLine("El numero 3 es mayor");
                }
            }
            else
            {
                //falso
                if (num2 > num3)
                {
                    Console.WriteLine("El numero 2 es el mayor");
                }
                else
                {
                    Console.WriteLine("El numero 3 es el mayor");
                }

            }
        }
    }
}