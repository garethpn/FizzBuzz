// See https://aka.ms/new-console-template for more information

using FizzBuzz.Rules;

namespace FizzBuzz;

public static class Program
{
    static public void Main(String[] args)
    {
        var fizzRule = new FizzRule();
        var buzzRule = new BuzzRule();
        var fizzBuzzRule = new FizzBuzzRule();
        
        for (int i = 1; i < 100; i++)
        {
            if (fizzRule.Run(i))
            {
                Console.WriteLine("Fizz");
            }
            else if (buzzRule.Run(i))
            {
                Console.WriteLine("Buzz");
            }
            else if (fizzBuzzRule.Run(i))
            {
                Console.WriteLine("FizzBuzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}