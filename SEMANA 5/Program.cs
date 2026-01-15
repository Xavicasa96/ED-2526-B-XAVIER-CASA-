using System;

namespace EjerciciosListas
{
    // Nodo de la lista enlazada
    public class Nodo
    {
        public int Dato;
        public Nodo? Siguiente;

        public Nodo(int valor)
        {
            Dato = valor;
            Siguiente = null;
        }
    }

    public class ListaEnlazada
    {
        public Nodo? Cabeza;

        // Método para agregar un nodo al inicio
        public void Agregar(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            nuevo.Siguiente = Cabeza;
            Cabeza = nuevo;
        }

        // EJERCICIO 1: CONTAR NODOS
        public int ContarNodos()
        {
            int contador = 0;
            Nodo? actual = Cabeza;

            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }

            return contador;
        }

        // EJERCICIO 3: BUSCAR DATO
        public int BuscarDato(int valorBuscado)
        {
            int veces = 0;
            Nodo? actual = Cabeza;

            while (actual != null)
            {
                if (actual.Dato == valorBuscado)
                {
                    veces++;
                }
                actual = actual.Siguiente;
            }

            if (veces == 0)
            {
                Console.WriteLine("Dato no encontrado: " + valorBuscado);
            }

            return veces;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada miLista = new ListaEnlazada();

            miLista.Agregar(10);
            miLista.Agregar(20);
            miLista.Agregar(10);

            Console.WriteLine("--- EJERCICIO 1 ---");
            Console.WriteLine("Total de nodos: " + miLista.ContarNodos());

            Console.WriteLine("\n--- EJERCICIO 3 ---");
            Console.WriteLine("Buscando el 10...");
            int resultado = miLista.BuscarDato(10);
            Console.WriteLine("Aparece: " + resultado + " veces.");
        }
    }
}
