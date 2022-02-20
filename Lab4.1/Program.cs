using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int i = 0;
            int j = 0;
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number > 0)
                {
                    i++;
                }

                if (number < 0)
                {
                    j++;
                }
                if (number == 0)
                    break;


            } while (number != 0);
            Console.WriteLine("Число положительных чисел равно {0},число отрицательных чисел равно {1}", i, j);
        }
    }
}
