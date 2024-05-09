using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Введіть розмір масиву : ");
            int value = Convert.ToInt32(Console.ReadLine());

            int[] f = new int[value];
            f[0] = 1;
            f[1] = 1;
            Console.Write($"| {f[0]} | {f[1]} ");
            for (int i = 2; i < value; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
                Console.Write($"| {f[i]} ");
            }
            Console.WriteLine("|");

            Console.ReadKey();
        }
    }
}
