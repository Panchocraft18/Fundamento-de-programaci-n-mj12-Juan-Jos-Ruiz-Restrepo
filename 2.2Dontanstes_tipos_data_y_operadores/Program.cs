using System;


namespace _2._2Dontanstes_tipos_data_y_operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hola ke lo que ");
            //hoy vere los tipos de datos y operadores en especial las CONSTANTES 
            const string gravedad = "9.8 m/s^2"; // Constante de gravedad
            string nombre = "Juan José Ruiz Restrepo"; // Variable de tipo string
            nombre = "panchocraft18";
            //gravedad = "10"; ! no puedo cambiar el valor de una constante¡

            //TIPOS DE DATOS 1.1
            byte dato1 = 5; //bite 0 / 255 limites
            int dato2 = -4563; //int entero con signo  -2,147,483,648 / 2,147,483,647 limites
            ulong dato3 = 456789873833; //ulong entero sin signo 0 / 18,446,744,073,709,551,615 limites
            float dato4 = 3.4f; // los represento con F float numero decimal con signo 1.5e-45 / 3.4e38 limites
                                // else se significaria un double sin el el float no pongo f 
            double dato5 = 3.27; // double numero decimal con signo 5.0e-324 / 1.7e308 limites
            decimal dato6 = 123456.445678m; // decimal numero decimal con signo 1.0e-28 / 7.9e28 limites

            //TIPOS DE DATOS PARA CARACTERES  1.2
            char dato7 = 'w'; // char caracter unicode 0 / 65535 limites
            char espacio = ' '; // char caracter unicode 0 / 65535 limites
            string dato8 = "jnsajsañkjfdñkjasfñkjsñfjfsañksfkjfkjss*~¬°"; // string cadena de caracteres unicode 0 / 2,147,483,647 limites
            bool dato9 = true; // bool valor booleano true o false
            object dato10 = new object(); // object objeto base de todos los tipos de datos

            //OPERADORES LOGICOS 1.3
            //Numerirocos + cambio de signo 
            int dato11 = 5;
            int dato12 = -dato11; // cambio de signo
            int dato13 = +dato12; // suma
            int dato14 = -dato13; // cambio de signo
            Console.WriteLine("dato11:{0}, dato12:{1}, dato13:{2}, dato14:{3}", dato11, dato12, dato13, dato14);
            int dato15 = 5 + 3;// suma
            int dato16 = dato15 - 3; // resta
            int dato17 = 25 * 3; // multiplicacionS
           // int dato18 =  5 / 3; // division
            //float int dato18 = (float) 5 / 3; // division
            float dato18 =5f /3f; // division

            Console.WriteLine("suma:{0}, resta:{1}, producto:{2}, division:{3}", dato15, dato16, dato17, dato18);
        }
    }
}