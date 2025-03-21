// Método para obtener las calificaciones del usuario
static List<double> ObtenerCalificaciones()
{
    List<double> calificaciones = new List<double>();
    Console.WriteLine("Ingrese las calificaciones (ingrese -1 para terminar):");

    while (true)
    {
        string entrada = Console.ReadLine();
        if (double.TryParse(entrada, out double calificacion))
        {
            if (calificacion == -1) // Condición para terminar la entrada
            {
                break;
            }
            calificaciones.Add(calificacion);
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número válido.");
        }
    }

    return calificaciones;
}