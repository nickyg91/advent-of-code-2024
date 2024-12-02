namespace AdventOfCode.Solutions;

public abstract class BaseSolution<T>
{
    protected const string InputBasePath = "InputData";
    protected abstract void ReadInput();
    public abstract T Solve();
}