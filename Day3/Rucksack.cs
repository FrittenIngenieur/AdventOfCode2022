namespace AdventOfCode2022.Day3;

public class Rucksack
{
    public string RucksackItems { get; set; }
    public string Compartment1 { get; set; }
    public string Compartment2 { get; set; }
    public string Letter { get; set; }

    public Rucksack(string rucksackItems)
    {
        RucksackItems = rucksackItems;
        
        Compartment1 = rucksackItems.Substring(0, (int)(rucksackItems.Length/2));
        Compartment2 = rucksackItems.Substring((int)(rucksackItems.Length/2), (int)(rucksackItems.Length/2));

        var _compartment1Array = Compartment1.ToCharArray();
        var _compartment2Array = Compartment2.ToCharArray();

        var sameLetterArray = _compartment1Array.Intersect(_compartment2Array);

        foreach (var rucksackItem in sameLetterArray)
        {
            Letter = rucksackItem.ToString();
        }
    }
    
    
}