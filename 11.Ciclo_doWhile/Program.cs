using System;
using System.Diagnostics.Eventing.Reader;


namespace _11.Ciclo_doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ciclo do while
            int contador = 1;
            int acomulador = 0;

            do
            {
                acomulador += contador;
                contador++;
            } while (contador <= 10);

            Console.WriteLine($"La suma de los cicnco primeros números enteros es:  {acomulador}");*/

            // algortimo un número y genere su correspodiente tabla de multiplica desde el 1 hastas el 10 asi sucesivamente hastas que el usuario ya no desee continuar generando tablas de multiplicar

            /*int contador = 1;

            int numero;
            char continuar = ' ';
            do
            {


                Console.WriteLine("Ingrese un número para generar su tabla de multiplicar: ");
                numero = int.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine($"el resultado es{numero}x{contador}={numero * contador}");

                    contador++;
                    
                } while (contador <= 10);
                contador = 1;
                Console.WriteLine("Desea generar otra tabla de multiplicar? (Y/N)");
                continuar = char.Parse(Console.ReadLine());
            } while (continuar == 'y');*/

            //Crear un algortimo que permita calcular y mostrar por pantalla los números primos hastas el número 1007
            int numero = 0;
            Console.WriteLine("Ingrese lel numero hasta el cual desea calcular los números primos: ");
             numero = int.Parse(Console.ReadLine());

            int contador = 1;
            int cantidadPares = 0;

            while (contador <= numero)
            {
                if (contador % 2 == 0)
                {
                    cantidadPares++;
                }

                contador++;
            }
        }
    }
 }
    

