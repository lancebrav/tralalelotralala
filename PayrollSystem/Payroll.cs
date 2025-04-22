using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class Payroll
    {
        public int EmployeeId { get; set; }
        public DateTime PayPeriodStart { get; set; }
        public DateTime PayPeriodEnd { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal OvertimePay { get; set; }
        public decimal Deductions { get; set; }
        public decimal NetPay => BaseSalary + OvertimePay - Deductions;

    }
}
