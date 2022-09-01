using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Employee_Linq
    {


        public Employee_Linq()
        {

        }

        public Employee_Linq(int id, string name, string dept)
        {
            this.ID = id;
            this.Name = name;
            this.Dept = dept;

        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }



        private static List<Employee_Linq> GetListofEmployees()
        {
            List<Employee_Linq> emps = new List<Employee_Linq>();
            emps.Add(new Employee_Linq(1, "John", "Training"));
            emps.Add(new Employee_Linq(2, "Mark", "Finance"));
            emps.Add(new Employee_Linq(3, "Peter", "Technical"));
            emps.Add(new Employee_Linq(4, "Bob", "Technical"));
            emps.Add(new Employee_Linq(5, "Robert", "Finance"));
            emps.Add(new Employee_Linq(6, "Jason", "Training"));

            return emps;
        }
    }
}

