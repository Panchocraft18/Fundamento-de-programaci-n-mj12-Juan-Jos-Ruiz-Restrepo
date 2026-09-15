using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15ArrsyAreglosUnidimesionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//arreglos Unidimesionales - vectores
            int[] numeros= new int[5]; //declaracion de un arreglo de 5 elementos
            numeros[0] = 10; //asignacion de valores a cada elemento del arreglo
            numeros[1] = 56;
            numeros[2] = 22;
            numeros[3] = 45;
            numeros[4] = 102;
            //numeros[5] = 14; //esto genera un error de indice fuera de rango o/ matriz
            Console.WriteLine($"El número almacenado en las posicion 3 con indice 2 es: {numeros[2]}");
            char[] simbolos = new char[] { '!', '@', '#', '$', 'a' };
            bool[] variablesVerdad = {true, false, true, false, true, false ,false }; 

            // Recorrer para almacenar datosstring
            string[] nombres = new string[7];
            for(int i =0;i < 7; i ++)
            {
                Console.WriteLine($"Ingrese el nombre de la P {i + 1} Indice {i}: ");
                nombres[i] = Console.ReadLine();
            }
            Console.Clear();
            //Recorrer para recuperar datos
            for (int i =0; i< nombres.Length; i++) //Length devuelve el tamaño del arreglo las posiciones que tiene
            {
                Console.Write($"{nombres[i]} |"); 
            
                 }
            */
            // crear un arreglo llamado " numeros de 100 elementos asiganar el numero 10 en cada una de las posicioens del arreglo leer el conteindo de cada elemento y escribilo en pantalla }

            /*int[] numeros = new int[100];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 10;
                Console.Write($"{numeros[i]} ");
            }*/
            //Algoritmo que permita solicitar 10 numero los cuales seran alamacenado en un arreglo, al final debe visualizar el promedio de esos numeros.
            double[] numero = new double[10];
            double suma = 0;
            for (int i =0; i< numero.Length; i++)
            {
                Console.WriteLine($"Ingresel el numero {i + 1} ");
                numero[i] = double.Parse(Console.ReadLine());
                suma += numero[i];
                

            }
            double promedio = suma / numero.Length;
            Console.Write($"El promedio de los numeros ingresados es;{promedio}");

        }
    }
}
