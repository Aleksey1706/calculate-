using System;

namespace ConsoleApp3
{
    class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Sub(int x, int y)
        {
            return x - y;
        }
        static int Mul(int x, int y)
        {
            return x * y;
        }
        static int Div(int x, int y)
        {
            if (y!=0)
            {
                return x / y;
            }
            else
            {
                Console.WriteLine("no-no-no");
                return 0;
            }
           
        }
        static void Main(string[] args)
        {
            try { 
            Console.WriteLine("First num");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second num");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Operation");
            string sign = Console.ReadLine();

                switch (sign)
                {
                    case "+":
                        Console.WriteLine("Сложение {0}", Add(x, y));
                        break;
                    case "-":
                        Console.WriteLine("Вычетание{0}", Sub(x, y));
                        break;
                    case "*":
                        Console.WriteLine("Умножения{0}", Mul(x, y));
                        break;
                    case "/":
                        Console.WriteLine("Деление{0}", Div(x, y));


                        break;
                    default:
                        Console.WriteLine("Вы ввели не арифметическую операцию");
                        break;
                }

            }
            catch(FormatException)
            {
                Console.WriteLine("Format");
            }
           
            Console.ReadKey();
        }
       
    }
}
