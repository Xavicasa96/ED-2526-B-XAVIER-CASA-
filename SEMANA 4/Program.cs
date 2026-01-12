using System;
using System.Linq;

class Program
{
    static void Main()
    {
        /* ================================
           EJERCICIO 1
           Lista de asignaturas
           ================================ */
        Console.WriteLine("EJERCICIO 1");
        string[] asignaturas = { "Matematicas", "Fisica", "Quimica", "Historia", "Lengua" };

        foreach (string a in asignaturas)
        {
            Console.WriteLine(a);
        }

        /* ================================
           EJERCICIO 2
           Yo estudio <asignatura>
           ================================ */
        Console.WriteLine("\nEJERCICIO 2");
        foreach (string a in asignaturas)
        {
            Console.WriteLine($"Yo estudio {a}");
        }

        /* ================================
           EJERCICIO 5
           Numeros del 1 al 10 en orden inverso
           ================================ */
        Console.WriteLine("\nEJERCICIO 5");
        int[] numeros = Enumerable.Range(1, 10).ToArray();

        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            Console.Write(numeros[i]);
            if (i != 0) Console.Write(", ");
        }
        Console.WriteLine();

        /* ================================
           EJERCICIO 8
           Palindromo (CORREGIDO)
           ================================ */
        Console.WriteLine("\nEJERCICIO 8");
        Console.Write("Ingrese una palabra: ");

        string palabra = Console.ReadLine() ?? "";
        palabra = palabra.ToLower();

        string invertida = new string(palabra.Reverse().ToArray());

        if (palabra == invertida)
            Console.WriteLine("Es un palindromo");
        else
            Console.WriteLine("No es un palindromo");

        /* ================================
           EJERCICIO 10
           Precio menor y mayor
           ================================ */
        Console.WriteLine("\nEJERCICIO 10");
        int[] precios = { 50, 75, 46, 22, 80, 65, 8 };

        Console.WriteLine($"Precio menor: {precios.Min()}");
        Console.WriteLine($"Precio mayor: {precios.Max()}");

        Console.WriteLine("\nPrograma finalizado.");
    }
}
