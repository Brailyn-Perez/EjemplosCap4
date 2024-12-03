using EjemplosCap4;

internal class Program
{
    private static void Main(string[] args)
    {
        LibroCalificaciones libroCalificaciones = new LibroCalificaciones("Curso Francis");
        Console.WriteLine("El nombre inicial del curso es: '{0}'\n", libroCalificaciones.NombreCurso);


        // pide el nombre del curso y lo recibe como entrada
        Console.WriteLine("Por favor escriba el nombre del curso:");
        string nombreDelCurso = Console.ReadLine();
        libroCalificaciones.NombreCurso = nombreDelCurso;

        libroCalificaciones.MostrarMensaje();

    }
}