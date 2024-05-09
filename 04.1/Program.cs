using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Введіть розмір масиву : ");
            int value = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[value];

            for (int i = 0; i < value; i++)
            {
                array[i] = 2 * i;
            }

            for (int i = 0; i < value; i++)
            {
                Console.Write($"| {array[i]} ");
            }
            Console.WriteLine("|");

            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
