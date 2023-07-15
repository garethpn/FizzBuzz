namespace FizzBuzz.Rules;

public class BuzzRule: IRule
{
    public bool Run(int value)
    {
        return value % 5 == 0 && value % 15 > 0;
    }
}