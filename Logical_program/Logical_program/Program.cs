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
                Console.WriteLine("Enter Progran number to get excuted \n1. Fibonacci series \n2. Perfect Number \n3. Prime Number \n4. Reverse Number \n5. Temperatureconversion \n6. Monthly payment \n7. Vending machine \n8. Stopwatch program \n9. Day of week \n.10 Exit");
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
                        Temperature_conv temperature = new Temperature_conv();
                        Console.WriteLine("Enter value of temperature ");
                        int temp = Convert.ToInt32(Console.ReadLine());
                        temperature.temperatureconversion(temp);
                        break;
                    case 6:
                        Monthly_payment month = new Monthly_payment();
                        Console.WriteLine("Enter the value of principal");
                        double p = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the year");
                        double y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the rate : ");
                        double R = Convert.ToDouble(Console.ReadLine());
                        month.monthlypayment(p,y,R);
                        break;
                    case 7:
                        Console.WriteLine("Enter Amount to get Change");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        Vendingmachine vending = new Vendingmachine();
                        vending.Getchange(amount);
                        break;
                    case 8:
                        Programstopwatch measuretime = new Programstopwatch();
                        measuretime.Elapsetime();
                        break;
                    case 9:
                        dayofweek weekday = new dayofweek();
                        Console.WriteLine("Enter day");
                        int day = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter month");
                        int Month = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter year");
                        int year = Convert.ToInt32(Console.ReadLine());
                        weekday.Day(day, Month, year);
                        break;

                    case 10:
                        flag = false;
                        break;
                }
            }
        }
    }
}
