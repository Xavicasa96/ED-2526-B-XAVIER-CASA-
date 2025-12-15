using System;

class Program
{
    static void Main(string[] args)
    {
        Estudiante est = new Estudiante();

        Console.WriteLine("=== REGISTRO DE ESTUDIANTE ===");
        est.Registrar();

        Console.WriteLine();
        est.Mostrar();
    }
}
