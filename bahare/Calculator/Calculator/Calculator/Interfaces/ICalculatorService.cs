namespace Calculator.Interfaces
{
    public interface ICalculatorService
    {
        decimal? getDivide(int? firstNumber, int? secondNumber);
        int? getMinus(int? firstNumber, int? secondNumber);
        int? getMultiple(int? firstNumber, int? secondNumber);
        int? getSum(int? firstNumber, int? secondNumber);
    }
}
