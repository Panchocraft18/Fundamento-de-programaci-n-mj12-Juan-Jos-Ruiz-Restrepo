using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2TESTEPARCIAL_ciclos
{
    internal class Program
    {

        static void Main(string[] args)
        {



            /* double nota;
             double acomulador = 0;
             double promedio;
             int contador = 0;
             bool continuar = true;
             char repuesta = ' ';
             //algritmo de calsisifaciones sacar promedio 
             do
             {
                 Console.WriteLine("ingrese la clasificacion / nota : ");
                 nota = double.Parse(Console.ReadLine());


                 acomulador = acomulador + nota;
                 contador++;


                 Console.WriteLine("Desea ingresar otra nota? (s/n): ");
                 repuesta = char.Parse(Console.ReadLine());
                 if (repuesta == 'n')
                 {
                     continuar = false;
                 }
             }while (continuar);

             promedio = acomulador / contador;

             Console.WriteLine("El promedio de las calificaciones es: " + promedio);
                  */

            /*Se requiere un algoritmo para mostrar por pantalla los divisores de un
             número ingresado por teclado. 
             Tener en cuenta que dados dos números enteros a y b, se dice que b es
            divisor de a si se cumple que al efectuar una división entera a/ b el
            residuo es 0, en C# utilizar el operador Mod para obtener el residuo de 
            una división de dos números.*/


            /*int numero = 0;
            Console.WriteLine("Ingrese un número para calcular su divisoresS ");
            numero = int.Parse(Console.ReadLine());
            for (int contador = numero; contador >= 1; contador--)
            {
                if (numero % contador == 0)
                {
                    Console.WriteLine(contador);
                }
             }*/



            /*Dados dos números enteros ingresados por teclado: b que es la base y 
            e que es el exponente, se requiere calcular el resultado de la 
            potenciación. 
            Ejemplo: b=2, e=5  25=2*2*2*2*2= 32 
            Mostrar por pantalla el resultado de la potenciación. 
            Seguir pidiendo por teclado la base y el exponente y realizar la 
            potenciación correspondiente, hasta que el usuario ingrese por teclado 
            el carácter de escape ‘n’*/
            /*int bas = 1;
            int expo = 0;
            char respuesta = ' ';
            bool continuar = true;
           
            int contador = 0;
            int potencia = 1;
            do
            {
                Console.WriteLine("Ingrese la base: ");
                bas = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la exponete: ");
                expo = int.Parse(Console.ReadLine());
                do
                {
                    contador++;
                    potencia *= bas;
                 
                }  while (expo > contador);
            Console.WriteLine("El resultado de la potenciación es: " + potencia);
            Console.WriteLine("Desea ingresar otra base y exponente? (s/n): ");

             respuesta = char.Parse(Console.ReadLine());
             if (respuesta == 'n')
             {
                 continuar = false;
             }


            } while (continuar);*/
            

            

        }



    }
}
