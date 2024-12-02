namespace AdventOfCode.Solutions;

public class HistorianHysteria : BaseSolution
{
    private int[] FirstList { get; set; } = [];
    private int[] SecondList { get; set;  } = [];

    public override void ReadInput()
    {
        var contents = File.ReadAllLines($"{InputBasePath}/dec-1.txt");
        FirstList = new int[contents.Length];
        SecondList = new int[contents.Length];
        for (int i = 0; i < contents.Length; i++)
        {
            var numbers = contents[i].Split("   ");
            FirstList[i] = int.Parse(numbers[0]);
            SecondList[i] = int.Parse(numbers[1]);
        }
    }

    public int Solve()
    {
        Array.Sort(FirstList);
        Array.Sort(SecondList);
        var sum = 0;
        for (int i = 0; i < FirstList.Length; i++)
        {
            if (FirstList[i] < SecondList[i])
            {
                sum +=  SecondList[i] - FirstList[i];
            }
            else
            {
                sum +=  FirstList[i] - SecondList[i];
            }
        }
        return sum;
    }
}