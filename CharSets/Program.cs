using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CharSets
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide one or more file names.");
                return;
            }

            var charSetProcessor = new CharSetProcessor();
            var unionCharacters = new HashSet<char>();

            foreach (var fileName in args)
            {
                try
                {
                    var characters = charSetProcessor.ReadCharactersFromFile(fileName);
                    unionCharacters.UnionWith(characters);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error processing file '{fileName}': {ex.Message}");
                    return;
                }
            }

            var sortedCharacters = unionCharacters.OrderBy(c => c);
            Console.WriteLine("Union of characters:");
            Console.WriteLine(string.Join(", ", sortedCharacters));
        }
    }
}