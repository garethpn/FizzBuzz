using FizzBuzz.Rules;

namespace FizzBuzz.UnitTests;

public class FizzBuzzRuleTests
{
    
    [Test]
    [TestCase(3)]
    [TestCase(6)]
    [TestCase(9)]
    public void Number_Divisible_By_3_Returns_False_For_FizzBuzz(int value)
    {
        var fizzBuzzRule = new FizzBuzzRule();

        var shouldPrintFizzBuzz = fizzBuzzRule.Run(value);

        Assert.IsFalse(shouldPrintFizzBuzz);
    }
    
    [Test]
    [TestCase(5)]
    [TestCase(10)]
    [TestCase(20)]
    public void Number_Divisible_By_5_Returns_False_For_FizzBuzz(int value)
    {
        var fizzBuzzRule = new FizzBuzzRule();

        var shouldPrintFizzBuzz = fizzBuzzRule.Run(value);

        Assert.IsFalse(shouldPrintFizzBuzz);
    }

    [Test]
    [TestCase(15)]
    [TestCase(30)]
    [TestCase(45)]
    public void Number_Divisible_By_3_And_5_Returns_True_For_FizzBuzz(int value)
    {
        var fizzBuzzRule = new FizzBuzzRule();

        var shouldPrintFizzBuzz = fizzBuzzRule.Run(value);

        Assert.IsTrue(shouldPrintFizzBuzz);
    }
}