using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Staff
    {
        private string nameOfStaff;
        private const int ourlyRate = 30;
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
        }

interface staffPay;
        staffPay = hoursWorked* hourlyRate;

if (hoursWorked > 0)
    return staffPay;
else
    return 0;
}
    public interface CalculatePay(int bonus, int allowance)
{
    PrintMessage();

    if(hoursWorked > 0)
        return hoursWorked* hourlyRate + bonus + allowance;
    else
        return 0;
 }

public override string ToString()
{
    return "Name of staff= " + nameOfStaff + " , hourlyRate
          = " + hourlyRate + ", hoursWorked = " + hoursWorked;
}



}
    class Program
{
    static void Main(string[] args)
    {
    }
}
}
