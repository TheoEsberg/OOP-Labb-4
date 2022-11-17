using System;
using System.Collections.Generic;

namespace OOP_Labb_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create five different Employees
            Employee erik = new Employee(1, "Erik", "Male", 12500);
            Employee kalle = new Employee(2, "Kalle", "Male", 21000);
            Employee zoe = new Employee(3, "Zoe", "Female", 6400);
            Employee alma = new Employee(4, "Alma", "Female", 52500);
            Employee gustaf = new Employee(5, "Gustaf", "Male", 4900);

            // Stack
            Stack<Employee> EmpStack = new Stack<Employee>();
            EmpStack.Push(erik);
            EmpStack.Push(kalle);
            EmpStack.Push(zoe);
            EmpStack.Push(alma);
            EmpStack.Push(gustaf);

            // Write out all of the Employees in EmpStack
            int ItemsInStack = EmpStack.Count;
            foreach(Employee e in EmpStack)
            {
                ItemsInStack--;
                Console.WriteLine("ID: {0}, Name: {1}, Gender: {2}, Salary: {3}kr", e.GetId(), e.GetName(), e.GetGender(), e.GetSalary());
                Console.WriteLine("Items left in stack is {0}", ItemsInStack);
            }


        }
    }
}
