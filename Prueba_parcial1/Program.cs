using System;


namespace Prueba_parcial1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1, 
            //numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son
            //diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
            //pantalla los números de menor a mayor.
            //Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben
            //ingresar números diferentes.
            //
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
            if (num1 == num2 || num1 == num3 || num2 == num3)
            {
                Console.WriteLine("Debe ingresar números diferentes");
            }
            else

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
            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine(num1);

                if (num2 < num3)
                {
                    Console.WriteLine(num2);
                    Console.WriteLine(num3);
                }
                else
                {
                    Console.WriteLine(num3);
                    Console.WriteLine(num2);
                }
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine(num2);

                if (num1 < num3)
                {
                    Console.WriteLine(num1);
                    Console.WriteLine(num3);
                }
                else
                {
                    Console.WriteLine(num3);
                    Console.WriteLine(num1);
                }
            }
            else
            {
                Console.WriteLine(num3);

                if (num1 < num2)
                {
                    Console.WriteLine(num1);
                    Console.WriteLine(num2);
                }
                else
                {
                    Console.WriteLine(num2);
                    Console.WriteLine(num1);
                }
            }

        }
    }
}