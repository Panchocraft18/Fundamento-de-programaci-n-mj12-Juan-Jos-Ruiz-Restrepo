using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Vector
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Llene un arreglo con 15 números ingresados por teclado. Una vez registrado el total de valores, muestre en pantalla todos los elementos del arreglo. Finalmente, determine cuál es el número mayor y cuál es el número menor, junto con la posición que ocupa cada uno dentro del arreglo.*/

            int[] numeros = new int[15];

            
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero:{i+1}");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"{numeros[i]} |");
            }

            int mayor = numeros[0];
            int menor = numeros[0];

            int posicionMayor = 0;
            int posicionMenor = 0;

            //Busqueda de mayor y menor
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                    posicionMayor = i;
                }
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                    posicionMenor = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"El número mayor es: {mayor}");
            Console.WriteLine($"El número mayor está en la posición: {posicionMayor}");

            Console.WriteLine($"El número menor es: {menor}");
            Console.WriteLine($"El número menor está en la posición: {posicionMenor}");
        }
    }
}
