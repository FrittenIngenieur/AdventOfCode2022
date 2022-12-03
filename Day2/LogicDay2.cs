namespace AdventOfCode2022.Day2;

// A for Rock
// B for Paper
// C for Scissors.

// X for Rock
// Y for Paper
// Z for Scissors

// 1 for Rock
// 2 for Paper
// 3 for Scissors

public class LogicDay2
{
    private List<Move> Moves = new();
    private List<string> Inputs;
    
    public LogicDay2()
    {
        ReadInputList(@"C:\dev\AdventOfCode2022\Day2\inputs.txt");
        CreateMoves();
    }
    
    private void ReadInputList(string path)
    {
        Inputs = File.ReadAllLines(path).ToList();
    }

    private void CreateMoves()
    {
        foreach (string input in Inputs)
        {
            List<string> splitMove = input.Split(" ").ToList();
            
            Moves.Add(new Move(splitMove.First(), splitMove.Last()));
        }
    }

    public int CalculateWinScore()
    {
        int winScore = 0;
        foreach (Move move in Moves)
        {
            winScore += move.GetPointsOfMove();
        }

        return winScore;
    }
    
    public int CalculateWinScorePart2()
    {
        int winScore = 0;
        foreach (Move move in Moves)
        {
            winScore += move.GetPointsOfMoveTheRightWay();
        }

        return winScore;
    }
}