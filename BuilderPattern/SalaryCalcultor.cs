using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class SalaryCalcultor
    {
        public SalaryCalcultor(int textPercentage = 0,decimal bounsPercentage = 0,decimal educationPackage = 0,decimal transportation = 0)
        {
            TextPercentage = textPercentage;
            BounsPercentage = bounsPercentage;
            EducationPackage = educationPackage;
            Transportation = transportation;
        }
        public int TextPercentage { get; set; }
        public decimal BounsPercentage { get; set; }
        public decimal EducationPackage { get; set; }
        public decimal Transportation { get; set; }
    }
}
