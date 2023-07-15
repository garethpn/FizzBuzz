using FizzBuzz.Rules;

namespace FizzBuzz.UnitTests;

public class BuzzRuleTests
{
    [Test]
    [TestCase(5)]
    [TestCase(10)]
    [TestCase(20)]
    public void Number_Divisible_By_5_Returns_True_For_Buzz(int value)
    {
        var fizzRule = new BuzzRule();

        var shouldPrintFizz = fizzRule.Run(value);

        Assert.IsTrue(shouldPrintFizz);
    }

    [Test]
    [TestCase(15)]
    [TestCase(30)]
    [TestCase(45)]
    public void Number_Divisible_By_3_And_5_Returns_False_For_Buzz(int value)
    {
        var fizzRule = new BuzzRule();

        var shouldPrintFizz = fizzRule.Run(value);

        Assert.IsFalse(shouldPrintFizz);
    }
}