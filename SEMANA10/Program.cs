using System;
using System.Collections.Generic;
using System.Linq;

namespace VacunacionCOVID
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1️⃣ Crear conjunto ficticio de 500 ciudadanos
            HashSet<string> ciudadanos = new HashSet<string>();

            for (int i = 1; i <= 500; i++)
            {
                ciudadanos.Add($"Ciudadano {i}");
            }

            // 2️⃣ Crear conjunto ficticio de 75 vacunados con Pfizer
            HashSet<string> pfizer = new HashSet<string>();
            for (int i = 1; i <= 75; i++)
            {
                pfizer.Add($"Ciudadano {i}");
            }

            // 3️⃣ Crear conjunto ficticio de 75 vacunados con AstraZeneca
            HashSet<string> astraZeneca = new HashSet<string>();
            for (int i = 50; i < 125; i++)
            {
                astraZeneca.Add($"Ciudadano {i}");
            }

            // 4️⃣ Operaciones de teoría de conjuntos

            // Unión: ciudadanos vacunados (Pfizer ∪ AstraZeneca)
            HashSet<string> vacunados = new HashSet<string>(pfizer);
            vacunados.UnionWith(astraZeneca);

            // No vacunados: Ciudadanos - Vacunados
            HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
            noVacunados.ExceptWith(vacunados);

            // Ambas dosis: Pfizer ∩ AstraZeneca
            HashSet<string> ambasDosis = new HashSet<string>(pfizer);
            ambasDosis.IntersectWith(astraZeneca);

            // Solo Pfizer: Pfizer - AstraZeneca
            HashSet<string> soloPfizer = new HashSet<string>(pfizer);
            soloPfizer.ExceptWith(astraZeneca);

            // Solo AstraZeneca: AstraZeneca - Pfizer
            HashSet<string> soloAstraZeneca = new HashSet<string>(astraZeneca);
            soloAstraZeneca.ExceptWith(pfizer);

            // 5️⃣ Mostrar resultados
            Console.WriteLine("=== RESULTADOS ===\n");

            Console.WriteLine($"Total ciudadanos: {ciudadanos.Count}");
            Console.WriteLine($"Vacunados con Pfizer: {pfizer.Count}");
            Console.WriteLine($"Vacunados con AstraZeneca: {astraZeneca.Count}");
            Console.WriteLine($"No vacunados: {noVacunados.Count}");
            Console.WriteLine($"Ambas dosis: {ambasDosis.Count}");
            Console.WriteLine($"Solo Pfizer: {soloPfizer.Count}");
            Console.WriteLine($"Solo AstraZeneca: {soloAstraZeneca.Count}");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}