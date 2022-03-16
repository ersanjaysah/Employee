using System;

namespace UC7_EmpWageClassMethod
{
    public class Program
    {
        public static void EmpWage()
        {

            int Is_Full_Time = 1;
            int Is_Part_Time = 2;
            int maxRateInMonth = 100;
            int empRatePerHr = 20;
            int numOfWorkingDays = 20;
            int empHrs = 0;
            int totalEmpHr = 0;
            int totalWorkingDays = 0;

            while (totalEmpHr < maxRateInMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random obj = new Random();
                int randomCheck = obj.Next(3);
                switch (randomCheck)
                {
                    case 1:
                        {
                            empHrs = 8;
                            break;
                        }
                    case 2:
                        {
                            empHrs = 4;
                            break;
                        }
                    case 0:
                        {
                            empHrs = 0;
                            break;
                        }

                }
                totalEmpHr = (totalEmpHr + empHrs);
                Console.WriteLine("Days=" + totalWorkingDays + " empHrs=" + empHrs);

            }
            int totaSalary = (totalEmpHr * empRatePerHr);
            Console.WriteLine("Total salary is = "+totaSalary);
            Console.WriteLine("Total Employee Hours is = "+totalEmpHr);
            Console.WriteLine("Total Working Days is = "+totalWorkingDays);
        }
        public static void Main()
        {
            Program.EmpWage();
        }
    }
    
}
