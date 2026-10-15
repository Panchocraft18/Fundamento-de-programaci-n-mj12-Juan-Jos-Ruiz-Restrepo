using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _21.Taller_programacion_modular
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*. Desarrolla un programa que permita: 
             Ingresar una palabra 
                LLevar la palabra ingresada a un vector de caracteres 
            Contar la cantidad de vocales y consonantes en la palabra proporcionada por el 
                usuario.*/
            palabra();
            palabraVector(palabra());
            

             static string palabra()
            {
            string palabra;
            Console.WriteLine("Ingrese una palabra: ");
            palabra = Console.ReadLine();
            return palabra;
              }
             static char[] palabraVector(string palabra)
            {
            char[] vector = palabra.ToCharArray();
             return vector;
             }
            static void contarVocalesConsonantes(char[] vector)
             {
                 int Vocales = 0;
                 int consonantes = 0;
            
                for(int i =0;i< vector.Length;i++)
                 {
                 for (int j = 0; j < vector.Length; j++)
                    {
                     if (vector[j] == 'a' || vector[j] == 'e' || vector[j] == 'i' || vector[j] == 'o' || vector[j] == 'u')
                     {
                        Vocales++;
                     }
                     else
                     {
                        consonantes++;
                     }

                  }

                 }
                
             }
            static void mostrar(int Vocales,int consonantes)
            {
           
            Console.WriteLine($"Cantidad de vocales: {Vocales}");
            Console.WriteLine($"Cantidad de consonantes: {consonantes}");
             }
        }

    }
 }