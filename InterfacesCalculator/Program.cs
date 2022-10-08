using InterfacesCalculator;

internal class Program
{
    public static void Main(string[] args)
    {
        ICalculate calculate = new Calculus();
        calculate.Welcome();
        IResult result = new Calculus();
        result.Result();
    }
}