namespace Calculator;

using CalculatorLibrary;

class Program
{
    static void Main(string[] args)
    {
        int a = 2;
        int b = 3;
        int c = CalculatorLibrary.Add(a, b);
        Console.WriteLine($"Result from Add({a}, {b}) is {c}");
    }
}