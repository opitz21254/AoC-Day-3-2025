
namespace Banks.Console;

public static class InputParser
{
    // Reads a file and returns each line as a bank string
    public static List<string> LoadBanks(string path)
    {
        return File.ReadAllLines(path)
                   .Where(l => !string.IsNullOrWhiteSpace(l))
                   .ToList();
    }
}
