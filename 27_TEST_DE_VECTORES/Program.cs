using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _27_TEST_DE_VECTORES
{
    internal class Program
    {
        /*Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego 
        encuentre y muestre el valor máximo y mínimo de los números ingresados. */
      
        static void Main(string[] args)
        {

            /*int[] numero = new int[10];

            int mayor = 0;
            int menor = 0;

            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine($"Ingrese un numero {i + 1}: ");
                numero[i] = int.Parse(Console.ReadLine());
                if (numero[i] > mayor)
                {
                    mayor = numero[i];
                }
                if (numero[i] < menor)
                {
                    menor = numero[i];
                }
            }

          Console.Write($"El numero mayor es: {mayor} y el numero menor es: {menor}");

            Escribir un algoritmo que permita:
            a.Crear dos vectores del mismo tamaño. 
            b.Llenarlos con números.
            c.Comparar posición por posición. 
            d.Indicar cuántos elementos son iguales.*/
            int[] numero = new int[10];
            int[] num = new int[10];
            int iguales = 0;
            //int posicion = 0;


            for (int i = 0; i < numero.Length; i++)
            
             {
                Console.WriteLine($"Ingrese un numero {i + 1} para el primer vector: ");
                 numero[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < num.Length; i++)
            { 
                 Console.WriteLine($"Ingrese un numero {i + 1} para el segundo vector: ");
                 num[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();

            for (int i = 0; i < numero.Length; i++)
            {
               Console.Write($" \nPrimer vector: {numero[i]}");
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($" \n\nSegundo vector: {num[i]}");
            }
            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i] == num[i])
                {
                    iguales++;
                }
            }

            Console.WriteLine($"\nCantidad de elementos iguales: {iguales}");





        } 
    }
}
