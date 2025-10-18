using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, };
            Console.WriteLine("Введите индекс:");
            int a = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(array[a]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка: индекс вне диапазона!");
            }
        }
    }
}
