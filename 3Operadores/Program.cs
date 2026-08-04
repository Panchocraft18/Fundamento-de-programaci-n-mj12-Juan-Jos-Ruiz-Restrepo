using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _3Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operadores numericos 
            //Incremento decremento
            int dato1 = 0;
            dato1++; //dato1 = dato1 +1; Incremento de 1 unidad 

            dato1--; // dato1 = dato1 -1; Decrecieminto de 1 unidad

            dato1 += 15; // dato1= dato1 + 15 unidades 
            dato1 -= 14; // dato1= dato1 - 14 unidades 
            dato1 *= 3; // dato1 = dato1*3
            dato1 /= 2;// dato1 = dato1/2
            dato1 *= dato1;

            //Operadores numericos de izquierda a derecha 
            // prioridad de evaluacion 1()  2*,/ 3 +,-
            int dato2 = 4 * 3 / 2;
            int dato3 = 5 / 2 * 4;
            int dato4 = 4 * (5 / 2);
            int dato5 = 3 - 1 * (4 / 2);

            Console.WriteLine(dato2);

            // Operadores LÓGICOS 
            // CONJUCCION AND -Y- &&
            Console.WriteLine("Tabla de la conjución");
            Console.WriteLine(" V && V" + (true && true));
            Console.WriteLine(" v && F" + (true && false));
            Console.WriteLine(" F && v" + (false && true));
            Console.WriteLine(" F && F" + (false && false));

            // Disyunción -OR - O- ||
            Console.WriteLine("TABLA DE LA DISYUNCIÓN");
            Console.WriteLine("V || V=" + (true || true));
            Console.WriteLine("v || F=" + (true || false));
            Console.WriteLine("F || V=" + (false || true));
            Console.WriteLine("F || F=" + (false || false));

            //Negacion 
            bool dato6 = true;
            bool dato7 = !dato6; // cambio de signo 

            //Operadores de comparación 0

            bool dato8 = 5 > 4;
            bool dato9 = 1002 == 102;
            bool dato10 = 10 >= 9;
            bool dato11 = 0  != 1; // diferente de 1 
            bool dato12 = 4 < 5 && 3 ==0;
            bool dato13 = 0 != 2 && dato8 || dato9;




        }
    }
}
