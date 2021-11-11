using System;

namespace Logical_program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Progran number to get excuted \n1. Fibonacci series \n 2. Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            while (flag)
            {
                switch (option)
                {
                    case 1:
                        Fibonacci_series Fibonacci = new Fibonacci_series();
                        int number = Convert.ToInt32(Console.ReadLine());
                        Fibonacci.Fibo(number);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}
