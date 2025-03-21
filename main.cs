using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<double> calificaciones = ObtenerCalificaciones();
        double promedio = CalcularPromedio(calificaciones);
        MostrarResultado(promedio);
    }
}