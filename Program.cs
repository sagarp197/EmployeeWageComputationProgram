namespace EmployeeWageProgram
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Program");
            EmployeeCheck.CheckEmployeePresence();
            EmpWage.CalculateEmpWage();
            PartTimeWage.CalculateEmpWage();
            WagesForMonth.CalculateEmpWage();

        }

    }
}
