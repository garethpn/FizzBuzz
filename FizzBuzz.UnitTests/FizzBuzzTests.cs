using FizzBuzz.Rules;

namespace FizzBuzz.UnitTests;

public class Tests
{

    [Test]
    [TestCase(3)]
    [TestCase(6)]
    [TestCase(9)]
    public void Number_Divisible_By_3_Returns_Fizz(int value)
    {
        var fizzRule = new FizzRule();

        var shouldPrintFizz = fizzRule.Run(3);

        Assert.IsTrue(shouldPrintFizz);
    }

    [Test]
    [TestCase(15)]
    [TestCase(30)]
    [TestCase(45)]
    public void Number_Divisible_By_3_And_5_Returns_False(int value)
    {
        var fizzRule = new FizzRule();

        var shouldPrintFizz = fizzRule.Run(3);

        Assert.IsFalse(shouldPrintFizz);
    }
    
}