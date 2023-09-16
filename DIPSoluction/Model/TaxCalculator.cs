using System;

namespace DIPViolation.Model
{
    internal class TaxCalculator
    {
        private readonly ILogger logger;

        public TaxCalculator(ILogger logger)
        {
            this.logger = logger;
        }

        public void CalculateTax(int amount, int rate)
        {
            try
            {
                int tax = amount / rate;
                Console.WriteLine("Tax calculated: " + tax);
            }
            catch (Exception ex)
            {
                logger.Log("Error: " + ex.Message);
            }
        }
    }
}
