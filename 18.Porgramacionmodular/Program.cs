using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Porgramacionmodular
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            Console.WriteLine("Ingrese su nombre");
            string nombre   = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido");
            string apellido = Console.ReadLine();
            MostrarMensaje(nombre, apellido);
            Console.WriteLine($"Su {nombre},{apellido} edad es: {CalcularEdad(2026,1988)} ");
            Console.ReadKey();
            borrarpantalla();

        }
        // procdiemiento sin parametros 
        static void borrarpantalla()
        {
            Console.Clear();
        }

        // procedimiento con parametros

         static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvendio,{nombre} al curso de prograrmacionn");
        }
        static void MostrarMensaje(string nombre, string apellido )
        {
            Console.WriteLine($"Bienvendio, {nombre} {apellido}  al curso de prograrmacionn");
        }

        //fuciones sin parametros 

         static int CalcularEdad()
        {

            int anñoNacimiento = 1992;
            int añoActual = 2026;
           int edad = añoActual - anñoNacimiento; 
            return edad ;
        }
        //Funciones con parametros
        static int CalcularEdad( int añoActual, int anñoNacimiento)
        {
            return añoActual - anñoNacimiento;
        }

    }
}