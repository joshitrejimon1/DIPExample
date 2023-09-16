using DIPViolation.Model;

namespace DIPViolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\acer\\Documents\\.NET_TRAINING\\V STUDIO\\OOPS\\OOPS4\\dotNetCore\\Advanced\\SOLID PRINCIPLE\\SRP\\DIPExample\\data\\error_log.txt";

            ILogger logger = new FileLogger(filePath);

           
            TaxCalculator taxCalculator = new TaxCalculator(logger);

            taxCalculator.CalculateTax(100, 10);
        }
    }
}
