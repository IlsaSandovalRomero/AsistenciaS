using System;
using System.Collections.Generic;
using Asistencia;

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

            for (int i = 0; i < cantEstudiantes; i++)
            {
                Console.WriteLine($"Por favor, ingrese los datos del estudiante {i + 1}:");

                // Ingresar nombre del estudiante

                Console.WriteLine($"Nombre del estudiante {i + 1}: ");
                string nombre = Console.ReadLine();

                // Ingresar y validar el total de sesiones

                int totalDeSesiones;
                do
                {
                    Console.Write("Ingrese el total de sesiones del curso: ");
                    totalDeSesiones = Convert.ToInt32(Console.ReadLine());

                    if (totalDeSesiones <= 0)
                    {
                        Console.WriteLine("El total de sesiones debe ser un numero mayor que 0. Intentelo de nuevo, por favor.");
                    }
                    else if (totalDeSesiones > 200)
                    {
                        Console.WriteLine("El total de sesiones debe ser un numero menor que 200. Intentelo de nuevo.");

                    }

                } while (totalDeSesiones <= 0);


                // Ingresar y validar las sesiones asistidas

                int totalSesionesAsistidas;
                do
                {
                    Console.Write("Sesiones asistidas: ");
                    totalSesionesAsistidas = Convert.ToInt32(Console.ReadLine());

                    if (totalSesionesAsistidas < 0 || totalSesionesAsistidas > totalDeSesiones)
                    {
                        Console.WriteLine($"El número de sesiones asistidas debe estar entre 0 y {totalDeSesiones}. Inténtelo de nuevo.");
                    }

                } while (totalSesionesAsistidas < 0 || totalSesionesAsistidas > totalDeSesiones);


                estudiantes[i] = new Universidad.Estudiante
                {
                    Nombre = nombre,
                    TotalDeSesiones = totalDeSesiones,
                    totalSesionesAsistidas = totalSesionesAsistidas
                };
            }

            // Calcular y mostrar la información de cada estudiante
            foreach (var estudiante in estudiantes)
            {
                estudiante.MostrarInfo();
            }
        }
    }
}