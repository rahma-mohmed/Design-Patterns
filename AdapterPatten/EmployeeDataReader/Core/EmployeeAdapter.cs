using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Core
{
    public class EmployeeAdapter
    {
        private readonly Employee _employee;    
        private readonly IEnumerable<PayitemAdapter> _payItems;

        public EmployeeAdapter(Employee employee)
        {
            _employee = employee;
            _payItems = employee.PayItems.Select(x => new PayitemAdapter(x)).ToList();
        }

        public string FullName => _employee.FullName;
        public IEnumerable<PayitemAdapter> PayItems => _payItems;
    }
}
