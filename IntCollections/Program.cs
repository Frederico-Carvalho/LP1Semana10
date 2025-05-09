﻿using System;
using System.Collections.Generic;

namespace IntCollections
{
    class Program
    {
        static void Main()
        {
            int[] valores = { 1, 10, -30, 10, -5 };

            List<int> lista = new List<int>();
            foreach (int valor in valores)
                lista.Add(valor);
            Console.WriteLine("List: " + string.Join(", ", lista));

            Stack<int> pilha = new Stack<int>();
            foreach (int valor in valores)
                pilha.Push(valor);
            Console.WriteLine("Stack: " + string.Join(", ", pilha));

            Queue<int> fila = new Queue<int>();
            foreach (int valor in valores)
                fila.Enqueue(valor);
            Console.WriteLine("Queue: " + string.Join(", ", fila));

            HashSet<int> conjunto = new HashSet<int>();
            foreach (int valor in valores)
                conjunto.Add(valor);
            Console.WriteLine("HashSet: " + string.Join(", ", conjunto));
        }
    }
}