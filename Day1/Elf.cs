namespace AdventOfCode2022.Day1;

public class Elf
{
    public int Index { get; set; }
    public List<int> CaloriesOfElf { get; set; }

    public int CalculateCalories()
    {
        int caloriesSum = 0;
        foreach (var calories in CaloriesOfElf)
        {
            caloriesSum += calories;
        }

        return caloriesSum;
    }

    public Elf()
    {
        CaloriesOfElf = new List<int>();
    }
}