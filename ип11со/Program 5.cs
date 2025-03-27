using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace ип111
{
    public class GenArray<T> //обобщённый класс для хранения T элементов в массиве
    {
        private T[] array;
        public GenArray()
        {
            array = new T[0];
        }
        public void Add(T item) //добавляем новый элемент в конец массива, создавая новый массив из старого
        {
            T[] newArray = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[array.Length] = item;
            array = newArray;
        }
        public void RemoveAt(int index) //удаление элементов по индексу
        {
            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException("индекс выходит за пределы массива.");
            }
            T[] newArray = new T[array.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index + 1; i < array.Length; i++)
            {
                newArray[i - 1] = array[i];
            }
            array = newArray;
        }
        public T Get(int index) //возвращаем элемент по индексу
        {
            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException("индекс выходит за пределы массива.");
            }

            return array[index];
        }
        public int Length() //возвращаем длину массива
        {
            return array.Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenArray<int> intArray = new GenArray<int>();
            intArray.Add(10);
            intArray.Add(20);
            intArray.Add(30);
            Console.WriteLine("Длина массива:" + intArray.Length());
            Console.WriteLine("Элемент с индексом 1:" + intArray.Get(1));
            intArray.RemoveAt(1);
            Console.WriteLine("Длина массива после удаления:" + intArray.Length());
            GenArray<string> stringArray = new GenArray<string>();
            stringArray.Add("apple");
            stringArray.Add("pinapple");
            Console.WriteLine("Элемент с индексом 0:" + stringArray.Get(0)); //работа с типами данных
        }
    }
}*/
