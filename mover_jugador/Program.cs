using System;


namespace mover_jugador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola jugador\n" + "jugemos LOL ");
            Console.WriteLine(" solo te puedes mover a la derecha o izquierda otra accion diferente queda invalidad+");
            Console.WriteLine("ingresa la letra d para moverte a la derecha o la letra a para moverte a la izquierda");
            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.D)
            {
                Console.WriteLine("el personaje se mueve a la derecha");
            }
            else if (tecla.Key == ConsoleKey.A)
            {
                Console.WriteLine("el personaje se mueve a la izquierda");
            }
            else             
            {
                Console.WriteLine("accion invalida");
            }
        }
    }
}
