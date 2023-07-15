namespace FizzBuzz.Rules;

public class BuzzRule: IRule
{
    public bool Run(int value)
    {
        return value % 3 == 0 && value % 15 > 0;
    }
}