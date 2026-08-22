using System;


namespace practica_2V
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int numero1;
            //int numero2;
            // Hola crear un programa donde se  soliciten al usuario 2numeros y se muestre el mayor de los 2numeros
            //Console.WriteLine("Ingrese el primer numero:\n" + "hola usuario  ");
            //numero1 = int.Parse(Console.ReadLine());
            ////  numero2 = int.Parse( Console.ReadLine());

            //if (numero1 > numero2)
            //{
            // Console.WriteLine("El numero mayor es: " + numero1);
            //}
            //else if (numero2 > numero1)
            ////  Console.WriteLine("El numero mayor es: " + numero2);
            //}
            //else
            //{
            //  Console.WriteLine("Los numeros son iguales");
            //}
            // comprobador de 2 numeros par o impar
            // int numero1;
            ////int.TryParse(Console.ReadLine(), out numero1);


            //if (numero1 % 2 == 0)
            //{
            //  Console.WriteLine("El primer numero es par");
            //}
            //else
            //{
            //  Console.WriteLine("El primer numero es impar");
            //}

            Console.WriteLine("Hola jugador este es pepito ");
            Console.WriteLine("\nel solo puede moverse ariba abajo izquierda y derecha \n");
            Console.WriteLine("Ingrese la letra de la direccion que desea moverse: \n" + "a=izquierda, d=derecha, w=arriba, s=abajo");
            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.A)
            {
                Console.WriteLine("El jugador se mueve a la izquierda");
            }
            else if (tecla.Key == ConsoleKey.D)
            {
                Console.WriteLine("El jugador se mueve a la derecha");
            }
            else if (tecla.Key == ConsoleKey.W)
            {
                Console.WriteLine("El jugador se mueve hacia arriba");
            }
            else if (tecla.Key == ConsoleKey.S)
            {
                Console.WriteLine("El jugador se mueve hacia abajo");
            }
            else
            {
                Console.WriteLine("Tecla no valida");


            }


        }
    }
}