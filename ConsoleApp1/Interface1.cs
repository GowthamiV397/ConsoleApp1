using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public interface Interface1
    {

         void Test();
       
            
        
    }
    public class show : Interface1
    {
        public void Test()
        {
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            show obj = new show();
            obj.Test();
        }

    }
            
        }
    

    

