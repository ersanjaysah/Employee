using System;

namespace UC10_EmpWage_MultipleCompany_UsingInterface
{
    public class Program
    {
       public static void Main(string[] args)
       {
            EmpWageBuilderArray obj = new EmpWageBuilderArray();
            obj.addCompanyEmpWage("DMart", 15, 5, 20);
            obj.addCompanyEmpWage("Reliance", 15, 8, 20);
            obj.empWageForMultiCompanyUsingInterface();
       }
    }
}