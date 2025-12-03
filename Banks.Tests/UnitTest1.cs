namespace Banks.Tests;

using Banks.Logic;

public class Tests
{
    // [SetUp]
    // public void Setup()
    // {
        
    // }

    [Test]
    public void Test1()
    {
        var j = new Joltage();
        // A string = ONE LINE from the input file.
        var bankString = "987654321111111";
        int joltage = j.maxBankJoltage(bankString);
        Assert.That(joltage, Is.EqualTo(98));
    }
}
