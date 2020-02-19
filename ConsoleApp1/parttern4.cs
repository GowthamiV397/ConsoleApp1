using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class parttern4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
              
                for (int j = i; j >= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            
        }
    }
}
