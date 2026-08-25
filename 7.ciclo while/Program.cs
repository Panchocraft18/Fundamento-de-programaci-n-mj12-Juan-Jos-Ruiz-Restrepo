using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ciclo_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  int contador = 1;
           // int acomulador = 1;

            //while (contador < 5)
            //{
              //  contador        ++;
                //acomulador  = acomulador + contador;
            //}
            //Console.WriteLine($"La suma de los 5 primeros números es :  { acomulador}");
            int contador = 1;
            int acomulador = 1;
            int numero = 1;
            ;
            Console.WriteLine("Ingrese un número: ");
            numero= int.Parse(Console.ReadLine());
            while (contador < numero )
            {
                contador++;
             acomulador = acomulador * contador;
            }
            Console.WriteLine($"El resultado de la multiplicación es:" + acomulador );
        }
    }
}
