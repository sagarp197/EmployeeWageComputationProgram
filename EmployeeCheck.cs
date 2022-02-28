using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProgram
{
    public class EmployeeCheck
    {
        public static void CheckEmployeePresence()
        {
            int Is_Full_Time = 1;

            Random random = new Random();
            int empCheck = random.Next(2);

            if(empCheck==Is_Full_Time)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
