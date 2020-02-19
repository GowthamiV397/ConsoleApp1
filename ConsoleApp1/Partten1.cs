using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Partten1
    {
        static void Main(string[] args)
        {
           /*123456789
             1234567
             12345
             123
             1*/
            for (int i = 9; i >= 1; i=i-2)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
                
            }
            Console.ReadLine();
        }

    }
}
