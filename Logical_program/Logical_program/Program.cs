using System;

namespace Logical_program
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Progran number to get excuted \n1. Fibonacci series \n2. Perfect Number \n3. Prime Number \n4. Reverse Number \n5. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Fibonacci_series Fibonacci = new Fibonacci_series();
                        int number = Convert.ToInt32(Console.ReadLine());
                        Fibonacci.Fibo(number);
                        break;
                    case 2:
                        Perfect_number perfectnum = new Perfect_number();
                        perfectnum.Perfect();
                        break;
                    case 3:
                        Prime_number primenum = new Prime_number();
                        primenum.Prime();
                        break;
                    case 4:
                        ReverseNumber reversenum = new ReverseNumber();
                        reversenum.Reverse();
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
