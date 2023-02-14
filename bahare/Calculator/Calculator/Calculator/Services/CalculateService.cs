using Calculator.Interfaces;

namespace Calculator.Services
{
    public class CalculateService: ICalculatorService
    {
        private ILogger<CalculateService> Logger { get; }
        public CalculateService(ILogger<CalculateService> logger)
            {
                Logger = logger;             
            }
        public int? getSum(int? firstNumber, int? secondNumber)
        {
            if (firstNumber == null || secondNumber == null)
                throw new Exception();

            return firstNumber + secondNumber;
        }
        public int? getMinus(int? firstNumber, int? secondNumber)
        {
            if (firstNumber == null || secondNumber == null)
                throw new Exception();

            return firstNumber - secondNumber;
        }
        public int? getMultiple(int? firstNumber, int? secondNumber)
        {
            if (firstNumber == null || secondNumber == null)
                throw new Exception();

            return firstNumber * secondNumber;
        }
        public decimal? getDivide(int? firstNumber, int? secondNumber)
        {
            if (secondNumber == 0) 
                throw new ArgumentException("Please Enter Valid Number for Division");
            else
                return  (decimal)firstNumber / secondNumber;
        }
    }
}
