using System;

namespace DIPViolation.Model
{
    internal class DBLogger
    {
        public void Log(string Message)
        {
            Console.WriteLine("ERROR WAS CREATED OF " + Message);
        }
    }
}
