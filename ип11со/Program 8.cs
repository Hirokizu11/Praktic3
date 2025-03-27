using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ип1111
{
    // Пользовательский класс исключения
    class CharArrayException : Exception
    {
        public char[] CharArray { get; } // Символьный массив

        // Конструктор, принимающий размер массива
        public CharArrayException(int size)
        {
            CharArray = new char[size];

            // Заполняем массив последовательностью букв (начиная с 'A')
            for (int i = 0; i < size; i++)
            {
                CharArray[i] = (char)('A' + i);
            }
        }

        // Переопределяем ToString() для удобного вывода информации
        public override string ToString()
        {
            return "Пользовательское исключение. Массив: " + new string(CharArray);
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

                // Создаем исключение с нужным размером массива
                throw new CharArrayException(size);
            }
            catch (CharArrayException ex)
            {
                // Обработка нашего исключения - вывод массива
                Console.WriteLine("Содержимое массива из исключения:");
                Console.WriteLine(new string(ex.CharArray));

                // Альтернативный вариант вывода через переопределенный ToString()
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

