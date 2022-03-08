using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class class1
    {
        int Is_Full_Time = 1;
        int Is_Part_Time = 2;
        int Emp_Rate_Per_Hr = 20;
        int empHrs = 0;
        int empWage = 0;

        Random obj = new Random();
        

    public void Employee()
        {
            int empCheck = obj.Next(0, 2);
            if (empCheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        
    public void EmpDailyWages()
        {
            int empCheck = obj.Next(0, 2);
            if (empCheck == Is_Full_Time)
            {
                empHrs = 8;
                Console.WriteLine("He worked full day");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("He is Absent");
            }
            empWage = empHrs * Emp_Rate_Per_Hr;
            Console.WriteLine("Employee salary is= " + empWage);
        }

    public void EmpPartTime()
        {
            int randomCheck = obj.Next(0, 3);
            if (randomCheck == Is_Full_Time)
            {
                empHrs = 8;
                Console.WriteLine("He Worked Full Day");
            }
            else if (randomCheck == Is_Part_Time)
            {
                empHrs = 4;
                Console.WriteLine("He Worked Half Day");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("He Is Absent");
            }
                empWage = empHrs * Emp_Rate_Per_Hr;
                Console.WriteLine("His Salary is= " + empWage);
        }

    }

