using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo.Model
{
    class Staff
    {
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hoursWorked;
        public int HoursWorked
        {
            get
            {
                return hoursWorked;
            }

            set
            {
                if (value > 0)
                    hoursWorked = value;
                else
                    hoursWorked = 0;

            }
        }
        public void PrintMessage()
        {
            Console.WriteLine("Calculating pay..");
        }
        public int CalculatePay()
        {
            PrintMessage();


            if (hoursWorked > 0)
                return hoursWorked * hourlyRate;
            else
                return 0;
        }


        public int CalculatePay(int bonus, int allowance)

        {
            PrintMessage();

            if (hoursWorked > 0)
            {
                return hoursWorked * hourlyRate + bonus + allowance;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            
            return $"Name of Staff = {nameOfStaff}, hourlyRate = {hourlyRate}, hourlyWorked = {hoursWorked}";
            
        }
        public Staff(string name)
        {
            nameOfStaff = name;
            Console.WriteLine("\n"+ nameOfStaff);
            Console.WriteLine("---------------------");

        }
    }
  
}
