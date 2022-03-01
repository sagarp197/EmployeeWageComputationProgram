using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class WagesForMonth
    {
        public static void EmpMonthlyWage()
        {
            int Emp_Rate_Per_Hour = 20;
            int TotalWorkingHrs = 0;
            int TotalWorkingDays = 0;
            int empHrs = 0;
            int empWage = 0;

            int Total_Working_Hrs = 100;
            int Total_Working_Days = 20;

            while (TotalWorkingHrs < Total_Working_Hrs || TotalWorkingDays < Total_Working_Days)
            //while (TotalWorkingDays < Total_Working_Days)
            {

                TotalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(3);

                if (empCheck == 0)
                {
                    Console.WriteLine("Employee is Present");
                    empHrs = 8;
                }
                else if (empCheck == 1)
                {
                    Console.WriteLine("Employee is Working Part Time");
                    empHrs = 4;
                }
                else
                {
                    Console.WriteLine("Employee is Absent");
                    empHrs = 0;
                }

                TotalWorkingHrs = TotalWorkingHrs + empHrs;
                
            }

            empWage = TotalWorkingHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Emp Monthly Wage :" + empWage);

        }


    }
}
