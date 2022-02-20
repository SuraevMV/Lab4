using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            int k, n, i;
            k = n = i = 0;
            while (A >= C)
            {
                A -= C;
                k++; //Колличсетво квадратов по стороне A
            }
            while (B >= C)
            {
                B -= C;
                n++; //Колличсетво квадратов по стороне B
            }
            int number = 0;
            while (i < k)
            {
                number += n;
                i++;
            }
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}

