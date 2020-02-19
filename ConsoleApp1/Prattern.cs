using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Prattern
    {
        static void Main(string[] args)
        {
            /*1
              01
              101
              0101
              10101*/
            Console.WriteLine("enter n  value");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j%2);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}
