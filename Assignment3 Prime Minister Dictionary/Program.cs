using System;
using System.Collections.Generic;

class IndiaLeaders
{
    static void Main(string[] args)
    { 
        //initial dictionary of prime ministers
        var primeMinisters = new Dictionary<string, int>()
        {
            {"Atal Bihari Vajpayee", 1998},
            {"Narendra Modi", 2014},
            {"Manmohan Singh", 2004}
        };

        string pm2004 = GetPMOfYear(primeMinisters, 2004);
        Console.WriteLine($"Prime Minister of 2004: {pm2004}");

        primeMinisters.Add("Narendra Damodardas Modi", 2024);

        var sortedPrimeMinisters = SortPrimeMinistersByYear(primeMinisters);

        // Display the sorted prime ministers
        Console.WriteLine("\nPrime Ministers Year Wise:");
        foreach (var pm in sortedPrimeMinisters)
        {
            Console.WriteLine($"{pm.Key}: {pm.Value}");
        }
    }
    //finding the prime minister of a specific year
    static string GetPMOfYear(Dictionary<string, int> primeMinisters, int year)
    {
        foreach (var pm in primeMinisters)
        {
            if (pm.Value == year)
                return pm.Key;
        }
        return "Prime Minister not found";
    }

    // Method to sort the prime ministers by year
    static Dictionary<string, int> SortPrimeMinistersByYear(Dictionary<string, int> primeMinisters)
    {
        var sortedPMs = new Dictionary<string, int>();

        var years = new List<int>(primeMinisters.Values);
        years.Sort();

        foreach (var year in years)
        {
            foreach (var pm in primeMinisters)
            {
                if (pm.Value == year)
                {
                    sortedPMs.Add(pm.Key, pm.Value);
                    break;
                }
            }
        }

        return sortedPMs;
    }
}
