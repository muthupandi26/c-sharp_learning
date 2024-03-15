using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
    }

    public partial class Employee
    {
        public Employee(int id, string name) { 
        this.EmpId = id;
        this.Name = name;
        }

        public void DisplayEmpInfo()
        {
            Console.WriteLine(this.EmpId + " " + this.Name);
        }
    }


    

}
