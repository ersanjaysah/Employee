using System;

namespace UC8_EmpWageMultiCompany
{
    internal class Program
    {
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;
        public static int companies(string companyName, int empRatePerHr, int numOfWorkingDays,int maxHrsInMonth)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= maxHrsInMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random obj = new Random();
                int randomCheck = obj.Next(0, 3);
                switch (randomCheck)
                {
                    case 1:
                        empHrs = 8;
                        break;
                    case 2:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs =(totalEmpHrs+ empHrs);
                Console.WriteLine("Days=" + totalWorkingDays + " empHrs=" + empHrs);

            }
            int totalSalary = totalEmpHrs * empRatePerHr;
            Console.WriteLine("Total salary= " + totalSalary);
            return totalSalary;
        }
        public static void Main(string[] args)
        {
            companies("GAIL", 20, 4, 10);
            companies("NTPC", 15, 10, 10);
            companies("Reliance", 18, 8, 10);
        }

    }
}
