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

            using StreamWriter sw = new StreamWriter(fileName);

            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    break;

                sw.WriteLine(input);
            }
        }
    }
}