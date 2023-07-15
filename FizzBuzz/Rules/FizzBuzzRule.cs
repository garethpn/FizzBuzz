namespace FizzBuzz.Rules;

public class FizzBuzzRule: IRule
{
    public bool Run(int value)
    {
        return value % 15 == 0;
    }
}