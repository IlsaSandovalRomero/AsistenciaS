using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asistencia
{

    // Clase para el método de extensión....
    public static class Extension
    {
        // Método de extensión para mostrar la información del estudiante
        public static void MostrarInfo(this Universidad.Estudiante estudiante)
        {
            double porcentajeDeAsistencia = Universidad.Estudiante.Asistencia.Porcentaje(estudiante.totalSesionesAsistidas, estudiante.TotalDeSesiones);
            bool minimoAsis = Universidad.Estudiante.Asistencia.MinimoDeAsistencia(porcentajeDeAsistencia);

            Console.WriteLine();
            Console.WriteLine($"Estudiante: {estudiante.Nombre}");
            Console.WriteLine($"Asistencia: {porcentajeDeAsistencia:F2}%");
            Console.WriteLine($"Asistio a {estudiante.totalSesionesAsistidas} de {estudiante.TotalDeSesiones} sesiones programadas.");
            Console.WriteLine($"Estado: {(minimoAsis ? "Aprobado por asistencia" : "Reprobado por inasistencia")}");
            Console.WriteLine();
        }


    }
}