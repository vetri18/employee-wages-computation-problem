using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeePresentAbsent
    {
        public static void EmployeePresentAndAbsent()
        {
            const int IS_FULLTIME = 1;
            const int IS_PARTTIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int Check = random.Next(3);
            if (Check == IS_FULLTIME)
            {
                Console.WriteLine("Full Time Present");
                empHrs = 8;
            }
            else if (Check == IS_PARTTIME)
            {
                Console.WriteLine("Part Time Present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
