using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_program
{
    public class Fibonacci_series
    {
        int first = 0, second = 1, third = 0;
        public void Fibo(int n)
        {
            Console.WriteLine("Fibonacci series is\n");
            if (n == 0)
            {
                Console.WriteLine(first);
                return;
            }
             for(int i=0; i<n; i++)
            {
                if(i==0)
                {
                    Console.WriteLine(first);
                }
                if(i== 1)
                {
                    Console.WriteLine(second);
                }
                if( i>1)
                {
                    third = first + second;
                    first = second;
                    second = third;
                    Console.WriteLine(third);
                }
            }
        }
    }
}
