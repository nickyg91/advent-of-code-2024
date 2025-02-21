namespace AdventOfCode.Solutions;

public class HistorianHysteria : BaseSolution<int>
{
    private int[] LeftList { get; set; } = [];
    private int[] RightList { get; set;  } = [];

    protected override void ReadInput()
    {
        var contents = File.ReadAllLines($"{InputBasePath}/dec-1.txt");
        LeftList = new int[contents.Length];
        RightList = new int[contents.Length];
        for (int i = 0; i < contents.Length; i++)
        {
            var numbers = contents[i].Split("   ");
            LeftList[i] = int.Parse(numbers[0]);
            RightList[i] = int.Parse(numbers[1]);
        }
    }

    public override int Solve()
    {
        ReadInput();
        Array.Sort(LeftList);
        Array.Sort(RightList);
        var sum = 0;
        for (int i = 0; i < LeftList.Length; i++)
        {
            if (LeftList[i] < RightList[i])
            {
                sum +=  RightList[i] - LeftList[i];
            }
            else
            {
                sum +=  LeftList[i] - RightList[i];
            }
        }
        return sum;
    }

    public int SolvePartTwo()
    {
        var value = 0;
        for (int i = 0; i < LeftList.Length; i++)
        {
            var count = RightList.Count(x => x == LeftList[i]);
            value += LeftList[i] * count;
        }

        return value;
    }
}