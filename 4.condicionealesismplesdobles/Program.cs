using System;
using System.Diagnostics.Eventing.Reader;


namespace _4.condicionealesismplesdobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estructureas  de control condicionales
            //Simples 
            //1 Crear un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, mostrar un mensaje que diga Bienvenido a mi sitio web ", si no, mostrar un mensaje que diga "Eres menor de edad".

            // byte edad = 0;
            //  Console.WriteLine ("ingerse su edad");
            //edad = Convert.ToByte(Console.ReadLine());
            //if (edad >=18)
            //{
            //si la condicion es verdadera se cumple 
            //  Console.WriteLine ("Bienvenido a mi sitio web");
            //}

            //float sueldo = 1;
            //Console.WriteLine("Ingrese su sueldo");
            //sueldo = Convert.ToSingle(Console.ReadLine());
            //if (sueldo >= 3000) ;
            //{
            //  Console.WriteLine("Debe abonar impuestos");
            //}

             byte edad = 0;
            Console.WriteLine ("ingerse su edad");
            edad = Convert.ToByte(Console.ReadLine());
                if (edad >=18)
                {
                //si la condicion es verdadera se cumple 
                     Console.WriteLine ("Bienvenido a mi sitio web");
                }
            else
            {
                               Console.WriteLine(" No es apto para mi sitio ");
            }
        }

    }


    
}


