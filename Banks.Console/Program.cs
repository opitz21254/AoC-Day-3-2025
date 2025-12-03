
namespace Banks.Console;
using Banks.Logic;  // your real namespace

class Program
{
    static void Main()
    {
        var path = "input.txt";   // put this in your Runner project root
        var banks = InputParser.LoadBanks(path);

        long result = Banks.Logic.CalculateTotal(banks);

        Console.WriteLine($"Answer: {result}");
    }
}
