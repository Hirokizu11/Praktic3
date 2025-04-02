using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ип1111
{
    class CharArrayException : Exception
    {
        public char[] CharArray { get; } 

        
        public CharArrayException(int size)
        {
            CharArray = new char[size];

            for (int i = 0; i < size; i++)
            {
                CharArray[i] = (char)('A' + i);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Введите размер символьного массива: ");
                int size = int.Parse(Console.ReadLine());

                throw new CharArrayException(size);
            }
            catch (CharArrayException ex)
            {
                Console.WriteLine("Содержимое массива из исключения:");
                Console.WriteLine(new string(ex.CharArray));
                
                Console.WriteLine(ex.ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено не число!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}

