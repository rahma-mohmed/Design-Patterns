using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Core
{
    internal class EmployeeDataReader
    {
        public IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee
                {
                    FullName = "Rahma Abo Shaheen",
                    PayItems = new List<PayItem>
                    {
                        new PayItem{Name = "Basic Salary" , Value = 1000},
                        new PayItem{Name = "Transportation" , Value = 250},
                        new PayItem{Name = "Medical Insurance" , Value = 150 , IsDeduction = true}
                    }
                },
                new Employee
                {
                    FullName = "Eman Mohmed Kewan",
                    PayItems = new List<PayItem>
                    {
                        new PayItem{Name = "Basic Salary" , Value = 1000},
                        new PayItem{Name = "Transportation" , Value = 250},
                        new PayItem{Name = "Medical Insurance" , Value = 150 , IsDeduction = true}
                    }
                }
            };
        }
    }
}
