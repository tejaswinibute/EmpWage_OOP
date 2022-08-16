﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmpWage.ClassMethod
{
    internal class Class_Method
    {
     public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NO_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        int empHrs = 0, totalEmpHrs = 0, totaldays = 0;
        public void Month()
        {

            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totaldays < NO_OF_WORKING_DAYS)
            {
                totaldays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("DAYS:" + totaldays + "Emp Hrs :" + empHrs);
            }
        }

        public void Condition()
        {


            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("TOTAL EMPLOYEE WAGE: " + totalEmpWage);

        }
    }
}





    

