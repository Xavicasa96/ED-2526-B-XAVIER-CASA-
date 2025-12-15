public class Estudiante
{
    public int ID { get; set; }
    public string? Nombres { get; set; }
    public string? Apellidos { get; set; }
    public string? Direccion { get; set; }
    public string[] Telefonos { get; set; }

    public Estudiante()
    {
        Telefonos = new string[3];
    }

    public void Registrar()
    {
        Console.Write("Ingrese ID: ");
        int.TryParse(Console.ReadLine(), out int id);
        ID = id;

        Console.Write("Ingrese nombres: ");
        Nombres = Console.ReadLine();

        Console.Write("Ingrese apellidos: ");
        Apellidos = Console.ReadLine();

        Console.Write("Ingrese dirección: ");
        Direccion = Console.ReadLine();

        Console.WriteLine("Ingrese 3 números de teléfono:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Teléfono {i + 1}: ");
            Telefonos[i] = Console.ReadLine() ?? "";
        }
    }

    public void Mostrar()
    {
        Console.WriteLine("\n===== DATOS DEL ESTUDIANTE =====");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine("Teléfonos:");
        foreach (var t in Telefonos)
        {
            Console.WriteLine($"- {t}");
        }
    }
}
