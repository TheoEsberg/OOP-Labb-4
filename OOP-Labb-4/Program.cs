using System;
using System.Collections.Generic;

namespace OOP_Labb_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create five different Employees
            Employee E1, E2, E3, E4, E5;
            CreateEmployees(out E1, out E2, out E3, out E4, out E5);

            // Stack
            Stack<Employee> EmpStack = new Stack<Employee>();
            AddEmployeesToStack(E1, E2, E3, E4, E5, EmpStack);

            // Write out all of the Employees in EmpStack
            foreach (Employee e in EmpStack)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Gender: {2}, Salary: {3}kr", e.GetId(), e.GetName(), e.GetGender(), e.GetSalary());
                Console.WriteLine("Items left in stack is {0}", EmpStack.Count);
            }

            Console.WriteLine();

            // Pop all of the Employees in EmpStack
            while (EmpStack.Count > 0)
            {
                Employee e = EmpStack.Pop();
                Console.WriteLine("ID: {0}, Name: {1}, Gender: {2}, Salary: {3}kr", e.GetId(), e.GetName(), e.GetGender(), e.GetSalary());
                Console.WriteLine("Employees left in stack: {0}", EmpStack.Count);
            }

            // Add all of the Emplyees back to the stack
            AddEmployeesToStack(E1, E2, E3, E4, E5, EmpStack);
        }

        private static void AddEmployeesToStack(Employee E1, Employee E2, Employee E3, Employee E4, Employee E5, Stack<Employee> EmpStack)
        {
            EmpStack.Push(E1);
            EmpStack.Push(E2);
            EmpStack.Push(E3);
            EmpStack.Push(E4);
            EmpStack.Push(E5);
        }

        private static void CreateEmployees(out Employee E1, out Employee E2, out Employee E3, out Employee E4, out Employee E5)
        {
            E1 = new Employee(1, "Erik", "Male", 12500);
            E2 = new Employee(2, "Kalle", "Male", 21000);
            E3 = new Employee(3, "Zoe", "Female", 6400);
            E4 = new Employee(4, "Alma", "Female", 52500);
            E5 = new Employee(5, "Gustaf", "Male", 4900);
        }
    }
}
