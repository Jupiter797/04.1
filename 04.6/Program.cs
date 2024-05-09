using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть розмір 2 мірного масиву");

            Console.Write("Розмір по осі Y : ");
            int valueY = Convert.ToInt32(Console.ReadLine());

            Console.Write("Розмір по осі X : ");
            int valueX = Convert.ToInt32(Console.ReadLine());

            int value = 1;

            int[,] array = new int[valueY, valueX];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = value;
                    value += 2;
                }
            }

            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < valueX; j++)
                {
                    Console.Write($"|  {array[i, j]}  \t");
                }
                Console.WriteLine("|");
            }

            Console.ReadKey();
        }
    }
}
