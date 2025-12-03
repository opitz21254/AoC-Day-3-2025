namespace Banks.Tests;

using Banks.Logic;

public class Tests
{
    private Joltage j = new Joltage();

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1() {
        // A string = ONE LINE from the input file.
        var bankString = "987654321111111";
        int jolt = j.maxBankJoltage(bankString);
        Assert.That(jolt, Is.EqualTo(98));
    }

/*
    [Test]
    public void Test2() {
        var bankString = "811111111111119";
        int joltage = j.maxBankJoltage(bankString);
        Assert.That(joltage, Is.EqualTo(89));
    }
    
    [Test]
    public void Test3()
    {
        var bankString = "818181911112111";
        int joltage = j.maxBankJoltage(bankString);
        Assert.That(joltage, Is.EqualTo(92));
    } */
}
