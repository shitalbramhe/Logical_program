using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_program
{
    internal class Prime_number
    {
        public void Prime()
        {
            Console.Write("\n Enter the Number to check prime or not");
            int num = Convert.ToInt32(Console.ReadLine());
            int count=0;
            for(int i=1; i <= num; i++)
            {
                if(num%i==0)
                {
                    count++;
                }
            }
            if (count==2)
            {
                Console.WriteLine(num+" Number is a prime number");
            }
            else
            {
                Console.WriteLine(num+" Number is not a prime number");
            }
        }
    }
}
