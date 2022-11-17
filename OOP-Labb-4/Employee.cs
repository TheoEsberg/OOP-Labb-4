using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_4
{
    internal class Employee
    {
        #region Variables
        protected int ID { get; set; }
        protected string Name { get; set; }
        protected string Gender { get; set; }
        protected int Salary { get; set; }
        #endregion

        #region Constructors
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
        #endregion

        #region Get Values
        public int GetId() { return this.ID; }
        public string GetName() { return this.Name; }
        public string GetGender() { return this.Gender; } 
        public int GetSalary() { return this.Salary; }
        #endregion
    }
}
