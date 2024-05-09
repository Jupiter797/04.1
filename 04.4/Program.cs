using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Random rnd = new Random();

            Console.Write("Введіть розмір масиву : ");
            int value = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[value];

            for (int i = 0; i < value; i++)
            {
                array[i] = rnd.Next(101);

                Console.Write($"| {array[i]} ");
            }
            Console.WriteLine("|");

            for (int j = value - 1; j >= 0; j--)
            {
                Console.Write($"| {array[j]} ");
            }
            Console.WriteLine("|");

            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
