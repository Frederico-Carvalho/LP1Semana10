using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("not enough arguments");
                return;
            }

            string fileName = args[0];
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    break;
                queue.Enqueue(input);
            }

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                while (queue.Count > 0)
                {
                    string line = queue.Dequeue();
                    writer.WriteLine(line);
                }
            }
        }
    }
}