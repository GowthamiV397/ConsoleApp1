using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class partten2
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter n value");
            //int n = Convert.ToInt32(Console.ReadLine());
            int k;
            for (int i = 5; i >= 1; i--)
            {
                if (i % 2 == 1)
                {
                    k = 1;
                }
                else
                {
                    k = i;
                }
              
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k);
                    if (i % 2 == 1)
                    {
                        k++;
                    }
                    else
                    {
                        k--;
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
