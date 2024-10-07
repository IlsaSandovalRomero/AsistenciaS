//C:\Users\MSI\source\repos
using System;
using System.Collections.Generic;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido al sistema de registro y control de asistencia de estudiantes de la Universidad Nacional de Ingenieria!");

            int cantEstudiantes;
            do
            {
                Console.WriteLine("Ingrese la cantidad de estudiantes: ");
                cantEstudiantes = Convert.ToInt32(Console.ReadLine());

                if (cantEstudiantes <= 0)
                {
                    Console.WriteLine("Por favor, ingrese un numero valido de estudiantes: ");
                }
            } while (cantEstudiantes <= 0);

            Universidad.Estudiante[] estudiantes = new Universidad.Estudiante[cantEstudiantes];
        }
    }
}