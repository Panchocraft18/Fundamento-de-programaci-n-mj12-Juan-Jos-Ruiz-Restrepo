using System;


namespace cosa_promedioscole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double finalProm;
            string state = "Error";

            Console.Write("Ingrese el promedio final del alumno: ");
            finalProm = double.Parse(Console.ReadLine());

            if (finalProm >= 0)
            {
                if (finalProm <= 5)
                {
                    state = "Desaprobado";
                }
                else
                {
                    if (finalProm <= 10)
                    {
                        state = "Vacacional";
                    }
                    else
                    {
                        if (finalProm <= 15)
                        {
                            state = "Requiere mejorar";
                        }
                        else
                        {
                            if (finalProm <= 20)
                            {
                                state = "Supera las expectativas";
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un promedio correcto.");
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Ingrese un promedio correcto.");
            }

            Console.WriteLine("El estado del alumno es: " + state);
        }
    }
}