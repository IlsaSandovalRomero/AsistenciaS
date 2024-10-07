using System;
using System.Collections.Generic;

// Clase Universidad
public static class Universidad
{
    // Clase anidada Estudiante
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int TotalDeSesiones { get; set; }
        public int totalSesionesAsistidas { get; set; }

        // Clase interna Asistencia para calcular el porcentaje y si aprueba
        public class Asistencia
        {
            // Método estático para calcular el porcentaje de asistencia
            public static double Porcentaje(int totalsesionesAsistidas, int totalDeSesiones)
            {
                if (totalDeSesiones == 0) return 0;
                return (totalsesionesAsistidas / (double)totalDeSesiones) * 100;
            }

            // Método estático para verificar si cumple con el mínimo de asistencia
            public static bool MinimoDeAsistencia(double porcentaje)
            {
                return porcentaje >= 75; // Requiere al menos 75% de asistencia
            }




        }
    }


}