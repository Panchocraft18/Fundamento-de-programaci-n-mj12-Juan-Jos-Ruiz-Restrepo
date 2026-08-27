using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1While_final_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un algoritmo que le permita al ususario infresr por teclnado numero enteros al alzar. //Al usuaerio el corresponder ingresar la cantidas de numero qeu va a introcurir // mostar numero mayores a 0, menores a 0 y iguales a 0*//*

            int numeros = 0;
            int cantidad, mayores = 0, menores = 0, iguales = 0;

            Console.WriteLine("Ingrese la cantidad de numeros que desea ingresar: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            int contador = 1;

            while (contador <= cantidad)
            {
                Console.WriteLine("Ingrese el número " + contador);
                numeros = Convert.ToInt32(Console.ReadLine());

                if (numeros > 0)
                {
                    mayores++;
                }
                else if (numeros < 0)
                {
                    menores++;
                }
                else
                {
                    iguales++;
                }

                contador++;
            }

            Console.WriteLine("Mayores a 0: " + mayores);
            Console.WriteLine("Menores a 0: " + menores);
            Console.WriteLine("Iguales a 0: " + iguales);+*/


             //Escribir yn algoritmo que cuente cuantos numeros hay pares en ese rango de numero del 1 al numero n (operador mod en c#)
                int numeropares = 1;
            int numero_usuario = 0;
            int numero = 0;

            Console.WriteLine("Ingrese la cantidad de numeros que desea evaluar si son par : ");
            numero_usuario = int.Parse(Console.ReadLine());
            while (numeropares <= numero_usuario)
            {
                if (numeropares % 2 == 0)
                {
                    numero++;
                }
                numeropares++;
            }
            Console.WriteLine("La cantidad de numeros pares es: " + numero);
        }
    }
}
