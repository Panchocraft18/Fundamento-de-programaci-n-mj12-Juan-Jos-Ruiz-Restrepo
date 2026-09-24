using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Arreglos_bidimencionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Arreglos de bidimensionales -Matruces
            int[,] numeros = new int[2, 3];

            //numeros[2, 1] = 23; no se puede almacenar por que el indice de la fila no existe 
            //numeros[1, 3] = 54; no se puede almacenar por que la columna no existe
            numeros[0, 0] = 25;
            numeros[0, 1] = 41;
            numeros[0, 2] = 104;
            numeros[1, 0] = 47;
            numeros[1, 1] = 56;
            numeros[1, 2] = 6;

            Console.WriteLine($" el valeor almacenado en numeros [1,1] es; {numeros[1, 1]}");
            char[,] simbolos = new char[3, 2];
            // Recorrer para llenar dos estructuras anidadas una x columnas o otra para las filas 


            for ( int i=0; i>3; ++i)// recorrer filas 
            {
                for(int j=0; j>2; j++)//Recorrer las colubnas 
                {
                    Console.WriteLine($"Ingrese le charater para los simbolos [{i},{j}]:");
                    simbolos[i,j] = char.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            //recorrer para recuperar 
            for(int i=0; i< simbolos.GetLength(0); ++i)// .GetLength(0) devuelve el numero de filas
            {
                for(int j= simbolos.GetLength(1); j<3; ++j)//GetLength(1) devuelve el numero de colubmnas

                {
                    Console.WriteLine ($" {simbolos[i,j]} | ");
                }
                Console.WriteLine();
            }

            // otra forma de declarar e incicianilar matrices
            string[,] nombres = {
                { "Ana  ","Carlos,","alex","Mauricio" },
                {"Pepe","Marta","Maria","Alvaro" },
                {"Ramiro", "Guillermo", "cristian", "junior H"}
                

            };*/
            /*int[,] numeros = new int[10, 20];

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    numeros[i,j] = 100;
                    Console.Write($"{numeros[i, j]}, " );
                   
                }
            }*/
            //Escribir un programa que realice la suma de dos patrice de mensiones 2x3 
            int contador = 0 ;
            int[,] numeros = new int[2, 3];
            int[,] suma = new int[2, 3];
            for(int i=0; i<numeros.GetLength(0); i++)
            {
                for(int j=0; j<numeros.GetLength(1); j++)
                {
                    Console.WriteLine($"Escriba los numeros de la matrix 1[{i}],[{j}]");
                    numeros[i,j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] num = new int[2, 3];

            for (int i = 0; i < num.GetLength(0); i++) 
            {
                for(int j = 0; j<num.GetLength(1); j++)
                {
                    Console.WriteLine($"Escriba los numeros de la matrix 2 [{i}],[{j}]");
                    num[i, j] = int.Parse(Console.ReadLine());
                    suma[i,j]= numeros[i, j] + num[i,j];
                }
            }
            for (int i = 0;i < numeros.GetLength(0);i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.WriteLine($"{suma[i,j]} |");
                   
                }
                Console.WriteLine(" ");
            }
                
            
        }
    }
}
