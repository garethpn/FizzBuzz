namespace FizzBuzz.Rules;

public class FizzRule: IRule
{
    public bool Run(int value)
    {
        return value % 3 == 0;
    }
}