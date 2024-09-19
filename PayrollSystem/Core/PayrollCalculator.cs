using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace PayrollSystem.Core
{
    public class PayrollCalculator
    {
        public decimal Calculate(Employee employee)
        {
            Debug.WriteLine($"Calculating Salary for employee");
            if (employee.PayItems?.Any() == false)
            {
                return 0;
            }
            var total = employee.PayItems.Sum(PayItem => PayItem.Value);
            return Math.Round(total / 30, 2);
        }
    }
}