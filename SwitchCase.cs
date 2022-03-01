using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class SwitchCase
    {
        public static void CalculateEmpWage()
        {
            int Emp_Rate_Per_Hour = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(2);

            //Console.WriteLine("Enter an alphabet");
            //ch = Convert.ToChar(Console.ReadLine());

            switch (empCheck)
            {
                case 0:
                    Console.WriteLine("Employee is Present");
                    empHrs = 8;
                    empWage = empHrs * Emp_Rate_Per_Hour;
                    Console.WriteLine("Emp Wage :" + empWage);
                    break;
                
                case 1:
                    Console.WriteLine("Employee is Working Part Time");
                    empHrs = 4;
                    empWage = empHrs * Emp_Rate_Per_Hour;
                    Console.WriteLine("Emp Wage :" + empWage);
                    break;

                default:
                    Console.WriteLine("Employee is Absent");
                    empHrs = 0;
                    empWage = empHrs * Emp_Rate_Per_Hour;
                    Console.WriteLine("Emp Wage :" + empWage);
                    break;
            }
        }
    }
}
