using System;
using System.Collections.Generic;
using System.IO;

public class CharSetProcessor
{
    public HashSet<char> ReadCharactersFromFiles(string[] fileNames)
    {
        HashSet<char> characterSet = new HashSet<char>();

        foreach (var fileName in fileNames)
        {
            var lines = System.IO.File.ReadAllLines(fileName);
            ValidateFileContent(lines);

            foreach (var line in lines)
            {
                characterSet.Add(line[0]);
            }
        }

        return characterSet;
    }

    public HashSet<char> ReadCharactersFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            throw new FileNotFoundException($"The file '{fileName}' does not exist.");
        }

        var characterSet = new HashSet<char>();
        var lines = File.ReadAllLines(fileName);

        foreach (var line in lines)
        {
            if (line.Length != 1)
            {
                throw new ArgumentException($"File '{fileName}' contains a line with more than one character: '{line}'");
            }

            characterSet.Add(line[0]);
        }

        return characterSet;
    }

    private void ValidateFileContent(string[] lines)
    {
        foreach (var line in lines)
        {
            if (line.Length != 1)
            {
                throw new ArgumentException($"File contains a line with more than one character: '{line}'");
            }
        }
    }
}