using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // EJERCICIO 1
        VerificarParentesis();

        Console.WriteLine("\n--------------------\n");

        // EJERCICIO 2
        TorresDeHanoi();
    }

    // ===== EJERCICIO 1 =====
    static void VerificarParentesis()
    {
        string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            if (c == '(' || c == '{' || c == '[')
                pila.Push(c);
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0)
                {
                    Console.WriteLine("Fórmula NO balanceada");
                    return;
                }

                char ultimo = pila.Pop();
                if (!Coinciden(ultimo, c))
                {
                    Console.WriteLine("Fórmula NO balanceada");
                    return;
                }
            }
        }

        Console.WriteLine(pila.Count == 0
            ? "Fórmula balanceada"
            : "Fórmula NO balanceada");
    }

    static bool Coinciden(char a, char c)
    {
        return (a == '(' && c == ')') ||
               (a == '{' && c == '}') ||
               (a == '[' && c == ']');
    }

    // ===== EJERCICIO 2 =====
    static void TorresDeHanoi()
    {
        int discos = 3;

        Stack<int> origen = new Stack<int>();
        Stack<int> auxiliar = new Stack<int>();
        Stack<int> destino = new Stack<int>();

        for (int i = discos; i >= 1; i--)
            origen.Push(i);

        ResolverHanoi(discos, origen, destino, auxiliar);
    }

    static void ResolverHanoi(
        int n,
        Stack<int> origen,
        Stack<int> destino,
        Stack<int> auxiliar)
    {
        if (n == 1)
        {
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de Origen a Destino");
            return;
        }

        ResolverHanoi(n - 1, origen, auxiliar, destino);

        int actual = origen.Pop();
        destino.Push(actual);
        Console.WriteLine($"Mover disco {actual} de Origen a Destino");

        ResolverHanoi(n - 1, auxiliar, destino, origen);
    }
}
