using System;
public class Program
    {
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;

        private string company;
        private int empRatePerHr;
        private int numOfWorkingDays;
        private int maxHrsInMonth;
        private int totalEmpWage;

        public Program(string companyName, int empRatePerHr, int numOfWorkingDays, int maxHrsInMonth)
        {
            this.company = companyName;
            this.empRatePerHr = empRatePerHr;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsInMonth = maxHrsInMonth;
        }

        public void saveEmployeeWages()
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Days=" + totalWorkingDays + " empHrs=" + empHrs);

            }
            int totalSalary = totalEmpHrs * this.empRatePerHr;
            Console.WriteLine("Total Employees wage for company " + company + " is =" + totalSalary);

        }
        public string myMethod()
        {
            return "Total employee wage for company is " + this.company + " is =" + this.totalEmpWage;
        }

        public static void Main(string[] args)
        {
            Program Dmart = new Program("Dmart",5,20,10);
            Program Reliance = new Program("Reliance", 20, 5, 20);
            Dmart.saveEmployeeWages();
            Console.WriteLine(Dmart.ToString());
            Reliance.saveEmployeeWages();
            Console.WriteLine(Reliance.ToString());
        }
    }

