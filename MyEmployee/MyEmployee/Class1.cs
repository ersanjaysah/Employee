using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class class1
    {
        public void Employee()
        {
            int Is_Full_Time = 1;
            Random obj = new Random();
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
           
    }

