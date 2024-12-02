// See https://aka.ms/new-console-template for more information

using AdventOfCode.Solutions;

Console.WriteLine("Hello, Advent of Code!");
Console.WriteLine("Here is the solution for Day 1");
var historianHysteria = new HistorianHysteria();
historianHysteria.ReadInput();
var result = historianHysteria.Solve();
Console.WriteLine($"Solution: {result}");
Console.ReadLine();