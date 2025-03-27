using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace ип111
{
    class Program
    {
        static void ProcessNumber(int number)
        {
            if (number % 2 == 0)
            {
                throw new ArithmeticException("Четное число");
            }
            else
            {
                throw new OverflowException("Нечетное число");
            }
        }

        static void Main()
        {
            while (true)
            {
                Console.Write("Введите число:");
                string input = Console.ReadLine();

                try
                {
                    int number = int.Parse(input);

                    try
                    {
                        ProcessNumber(number);
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Число нечётное");
                    }
                    catch (ArithmeticException)
                    {
                        Console.WriteLine("Число чётное");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Конец");
                    break;
                }
            }
        }
    }
}*/
