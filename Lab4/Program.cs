using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; ; i++)
            {
                if (i > number)
                    break;
                Console.WriteLine("Квадрат числа {0} равен {1}", i, sum = sum + (2 * i - 1));
            }
            Console.ReadKey();
        }
    }
}
