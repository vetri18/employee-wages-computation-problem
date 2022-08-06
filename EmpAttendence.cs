using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPresentAbsent
{
    internal class EmpAttendence
    {
        public static void EmpAttd()
        {
            int IS_PRESENT = 1;
            Random random = new Random();
            int Check = random.Next(0, 2);
            Console.WriteLine(Check);
            if (Check == IS_PRESENT)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Absent");
            }
        }
    }
}