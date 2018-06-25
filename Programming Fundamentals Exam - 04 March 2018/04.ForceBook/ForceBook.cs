using System;
using System.Collections.Generic;
using System.Linq;

class ForceBook
{
    static void Main()
    {
        string line = Console.ReadLine();
        var storeData = new Dictionary<string, SortedSet<string>>();
        List<string> allUsers = new List<string>();
        
        while (line != "Lumpawaroo")
        {
            var isForceSide = line.Contains("|");
            string[] elements = null;
            if (isForceSide)
            {
                elements = line.Split('|');
                string forceSide = elements[0].Trim();
                string forceUser = elements[1].Trim();

                if (!storeData.ContainsKey(forceSide))
                {
                    storeData.Add(forceSide, new SortedSet<string>());
                }

                if (!storeData[forceSide].Contains(forceUser))
                {
                    storeData[forceSide].Add(forceUser);
                }
            }
            else
            {
                elements = line.Split(new[] { " -> "}, StringSplitOptions.RemoveEmptyEntries);
                string forceUser = elements[0];
                string forceSide = elements[1].Trim();

                if (storeData.ContainsKey(forceSide))
                {
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    if (!storeData[forceSide].Contains(forceUser))
                    {
                        storeData[forceSide].Add(forceUser);
                    }
                }
                
            }
            line = Console.ReadLine();
        }
        var sorted = storeData.OrderByDescending(x => x.Value.Count)
             .ThenBy(n => n.Key)
             .ToDictionary(k => k.Key, v => v.Value);


        foreach (var item in sorted)
        {
            Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
            foreach (var list in item.Value)
            {
                Console.WriteLine($"! {list}");
            }
        }
    }
}

