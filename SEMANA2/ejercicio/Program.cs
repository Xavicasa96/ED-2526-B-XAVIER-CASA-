using System;

public class Program
{
    public static void Main(string[] args)
    {
        Circulo c = new Circulo(5);
        Console.WriteLine("CIRCULO");
        Console.WriteLine("Área: " + c.CalcularArea());
        Console.WriteLine("Perímetro: " + c.CalcularPerimetro());

        Rectangulo r = new Rectangulo(4, 6);
        Console.WriteLine("\nRECTANGULO");
        Console.WriteLine("Área: " + r.CalcularArea());
        Console.WriteLine("Perímetro: " + r.CalcularPerimetro());
    }
}
