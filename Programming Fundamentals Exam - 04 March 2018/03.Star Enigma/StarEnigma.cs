using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

class StarEnigma
{
    static void Main()
    {
        string pattern = @"(s|t|a|r)";
        RegexOptions options = RegexOptions.Multiline | RegexOptions.IgnoreCase;
        
        int numberOfMessage = int.Parse(Console.ReadLine());

        string patternPlanet = @"(@[A-Za-z]+)";
        string patternPopulation = @":\d+";
        string patternAttackType = @"(A|D)\b";
        string patternSolderCout = @"->\d+";

        List<string> attacked = new List<string>();
        List<string> destroyed = new List<string>();
        for (int i = 0; i < numberOfMessage; i++)
        {
            string message = Console.ReadLine();
            var matches = Regex
                .Matches(message, pattern, options);
            int countMatches = matches.Count;
            string currentMessage = string.Empty;
            foreach (var symbol in message)
            {
                int assciValue = symbol;
                char dectyptMessage =(char)(assciValue - countMatches);
                currentMessage += dectyptMessage;
            }
            var planet = Regex.Match(currentMessage, patternPlanet);
            var population = Regex.Match(currentMessage, patternPopulation);
            var attackType = Regex.Match(currentMessage, patternAttackType);
            var solderCount = Regex.Match(currentMessage, patternSolderCout);

            if (planet.Success && population.Success && attackType.Success && solderCount.Success)
            {
                if (attackType.Value == "A")
                {
                    attacked.Add(planet.Value);
                }
                else
                {
                    destroyed.Add(planet.Value);
                }
            }
        }
        attacked = attacked.OrderBy(a => a).ToList();
        Console.WriteLine($"Attacked planets: {attacked.Count}");
        foreach (var item in attacked)
        {
            var element = 
                string.Join("", item.Skip(1).Take(item.Length - 1)
                .ToList());
            Console.WriteLine($"-> {element.Trim()}");
        }
        Console.WriteLine($"Destroyed planets: {destroyed.Count}");
        destroyed = destroyed.OrderBy(a => a).ToList();
        foreach (var item in destroyed)
        {
            var element =
                string.Join("", item.Skip(1).Take(item.Length - 1)
                .ToList());
            Console.WriteLine($"-> {element}");
        }
    }
}

