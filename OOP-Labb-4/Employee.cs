using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_4
{
    internal class Employee
    {
        private int ID { get; set; }
        private string Name { get; set; }
        private string Gender { get; set; }
        private int Salary { get; set; }

        public Employee(int id, string name, string gender, int salary)
        {
            this.ID = id;
            this.Name = name;
            this.Gender = gender;
            this.Salary = salary;
        }

        public Employee()
        {

        }
    }
}
