using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _12.ciclo_do_wiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Algoritmo que le pida a un grupo de usuarios su nimbre número de cuenta y slado ; oara cada usuarios se debe hacer lo siguiente
            si el salfo es mayor o iugla a 3,000.000 sacar ub mensaje que diga el nombre del usuario el número de cuanta el saldo y "es apto para el crediot 

            si el salfo es menor a 3,000.000 sacar un mensaje que diga el nombre del usuario el número de cuenta el saldo y "no es apto para el credito"
                El algoritmo debe prermintir pregutnat la infromacion de los usuarios hasta que se le indique que ta no se desea preguntar mas 
            ademas, el algortimo debe permitir mostar el número de usuarios a los que se le pregunto la informacion y deme mostar el promedio de los saldos  */
            int usuarios = 0;
           
            int saldo = 0;
            int promedio = 0;
            string nombre;
            bool continuar = true;
            string respuesta;

            do
            {

                Console.WriteLine("Ingrese su nombre del usuario: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su número de cuenta : ");
                int numeroCuenta = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su saldo : ");
                saldo = int.Parse(Console.ReadLine());
                if (saldo >= 3000000)
                {
                    Console.WriteLine($"el usuario{nombre} con el número de cuenta {numeroCuenta} con un saldo de {saldo} es apto para el crédito");
                }
                else
                {
                    Console.WriteLine($"el usuario{nombre} con el número de cuenta {numeroCuenta} con un saldo de {saldo} no es apto para el crédito");
                   
                    usuarios++;
                }
                Console.WriteLine("Desea volver a verificar si credito si/no");
                respuesta = Console.ReadLine();
                if (respuesta == "no")
                {
                    continuar = false;
                    promedio = saldo / usuarios;
                    Console.WriteLine($"El número de usuarios a los que se le pregunto la información es {usuarios} y el promedio de los saldos es {promedio}");
                }
                
             }while (continuar);
        }
    }
}
