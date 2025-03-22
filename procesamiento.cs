// Método para calcular el promedio de las calificaciones
static double CalcularPromedio(List<double> calificaciones)
{
    if (calificaciones.Count == 0)
    {
        Console.WriteLine("No se ingresaron calificaciones.");
        return 0;
    }

    double suma = 0;
    foreach (double calificacion in calificaciones)
    {
        suma += calificacion;
    }

    return suma / calificaciones.Count;
}