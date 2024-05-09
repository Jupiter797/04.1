using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Введіть розмір масиву : ");
            int value = Convert.ToInt32(Console.ReadLine());

            double[] array = new double[value];

            int number = 2;
            array[0] = 1;

            for (int i = 0; i < value; i++)
            {
                array[i] = Math.Pow(number, i);
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
