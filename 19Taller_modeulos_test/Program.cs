using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._1Taller_modeulos_test
{
    internal class Program
    {
        //Algortimo que muestre un menu con operaciones con *-*/ y permita realizar la operacion que le ususario ingrese por teclado. si es suma o multiplicacion permite al ususario realizar estas operaciones con la cantidad de numero que el desee ingresar. si es dividion o restas solo deja realizar la operacion con dos numeros .4
        //https://stackoverflow.com/questions/2743260/is-it-possible-to-write-to-the-console-in-colour-in-net


        static void Main(string[] args)
        {
            menu();
            Console.WriteLine("Ingrese la operacion que desea realizar");
            RealizarOperaciones(capturarOpcion());


        }
        static void borrarpantalla()
        {
            Console.Clear();
        }
        static void menu()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Bienvenido al programa de operaciones matemáticas");
            Console.WriteLine("Que operacion desea realizar suma(+) Resta(-) Mutipicacion (*) O division (/)");
            Console.WriteLine("1 Suma            2 Resta            3 Multiplicacion            4 Division");
            Console.WriteLine("0, Salir ");
            Console.WriteLine("///////////////////////////////////////////////////////");
        }

        static int capturarOpcion()
        {
            return int.Parse(Console.ReadLine());
        }


        static void RealizarOperaciones(int opcion)
        {
            while(opcion != 0)
            {
                switch (opcion)
                {

                    case 1:
                        Console.WriteLine($"La suma de los numero ingresado es: {suma()}");
                        break;
                    case 2:
                        Console.WriteLine($"El resultado de la resta es: {Resta()}");
                        break;
                    case 3:
                        Console.WriteLine($"El resultado de la multiplicacion es: {Multiplicacion()}");
                        break;
                    case 4:
                        Console.WriteLine($"El resultado de la  DIVISION es: {Division()}");
                        break;
                   
                }
                Console.ReadKey();
                borrarpantalla();
                menu();
                opcion = capturarOpcion();
            }
           
        }
        static float suma()
        {

            float numero = 0;
            float suma = 0;
            char respuesta = ' ';
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A selecionado SUMA");
            Console.ResetColor();

            do
            {

                Console.WriteLine("Ingrese el primer numero");

                Console.ForegroundColor = ConsoleColor.Red; numero = float.Parse(Console.ReadLine());
                suma += numero;
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Desea sumar mas numeros? (s/n)");
                respuesta = char.Parse(Console.ReadLine());
                Console.ResetColor();


            } while (respuesta == 's' || respuesta == 'S');
            return suma;
        }
        static float Multiplicacion()
        {

            float numero = 0;
            float multiplicacion = 1;
            char respuesta = ' ';
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A selecionado multiplicacion");
            Console.ResetColor();

            do
            {

                Console.WriteLine("Ingrese el primer numero");

                Console.ForegroundColor = ConsoleColor.Red; numero = float.Parse(Console.ReadLine());
                multiplicacion *= numero;
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Desea multiplicar mas numeros? (s/n)");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                respuesta = char.Parse(Console.ReadLine());
                Console.ResetColor();


            } while (respuesta == 's' || respuesta == 'S');
            return multiplicacion;
        }
        static float Resta()
        {
          
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A selecionado RESTA");
            Console.ResetColor();
            Console.WriteLine("Ingrese el primer numero");
            Console.ForegroundColor = ConsoleColor.Red; float numero1 = float.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("Ingrese el segundo numero");
            Console.ForegroundColor = ConsoleColor.Red; float numero2 = float.Parse(Console.ReadLine());//delcaro y inicializo de una cuando el modulo termina de ejecutarse se borran todos los datos de la memoria y se libera el espacio de memoria que ocupaba el modulo
            Console.ResetColor();
            return numero1 - numero2;
        }
        static float Division()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A selecionado DIVISION");
            Console.ResetColor();
            Console.WriteLine("Ingrese el primer numero");
            Console.ForegroundColor = ConsoleColor.Red; float numero1 = float.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("Ingrese el segundo numero");
            Console.ForegroundColor = ConsoleColor.Red; float numero2 = float.Parse(Console.ReadLine());
            Console.ResetColor();
            return numero1 / numero2;
        }
    }

}
