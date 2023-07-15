namespace FizzBuzz.UnitTests;

public class Tests
{

    [Test]
    [TestCase(3)]
    [TestCase(6)]
    [TestCase(9)]
    public void Number_Divisible_By_Three_Returns_Fizz(int value)
    {
        var fizzRule = new FizzRule();

        var shouldPrintFizz = fizzRule.Run(3);

        Assert.IsTrue(shouldPrintFizz);
    }
}