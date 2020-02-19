using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Session
    {
        public MyTest name { get; set; }
        public Session()
        {
            name  = new MyTest();
        }
        static void Main(string[] args)
        {
            //MyTest myobj = new MyTest();
            //myobj.id = 100;
            Session obj = new Session();
           var s= obj.name.Name("hdgfskjg");
            Console.WriteLine(s);
        }
        

    }
   public class MyTest
    {
        public int id = 10;

        public string Name(string name)
        {
            return name;
        }
    }
}
