using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class MethodParameters
    {
        static void Main(string[] args)
        {
            int i = 0;
            MethodParameters obj = new MethodParameters();
            obj.SimpleMethod( ref i);
            Console.WriteLine(i);
            Console.ReadLine();
        }

        public  void SimpleMethod( ref int j)
        {
            j = 10;
        }
    }
}