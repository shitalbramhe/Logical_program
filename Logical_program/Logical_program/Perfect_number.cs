using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_program
{
    public class Perfect_number
    {
        int number, sum = 0, n;
        public void Perfect()
        {
            Console.Write("\n Enter the Number to check perfect number");
            number = Convert.ToInt32(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine(number+" Entered number is a perfect number");
            }
            else
            {
                Console.WriteLine(number + " Entered number is not a perfect number");
            }
        }
    }
}
