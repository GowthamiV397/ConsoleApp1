using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class EmployeeData
    {
        public int EmpId;
        public string EmpName;
        public double Salary;
        //public EmployeeData(int id, string name, double salary)
        //{
        //    this.EmpId = id;
        //    this.EmpName = name;
        //    this.Salary = salary;
        //}
        static void Main(string[] args)
        {
            //List<EmployeeData> employees = new List<EmployeeData>();
            //employees.Add(new EmployeeData(1, "Gowthami", 20000));
            //employees.Add(new EmployeeData(2, "sfndkgf", 35000));
            
            List<EmployeeData> employees = new List<EmployeeData>();
            employees.Add(new EmployeeData() { EmpId = 1, EmpName = "fherkugh", Salary = 20000 });
            employees.Add(new EmployeeData() { EmpId = 2, EmpName = "nmhjn", Salary = 10000 });
            employees.Where(x => x.Salary > 10000).ToList();
            var list = employees;
            foreach (EmployeeData data in employees)
            {
                //if(data.Salary>10000)
                //{ 
                Console.WriteLine(data.EmpId +" " + data.EmpName +" " +data.Salary);
                //}
            }
            Console.ReadLine();
        }

    }

}
