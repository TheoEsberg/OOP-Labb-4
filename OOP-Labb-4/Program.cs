using System;
using System.Collections.Generic;

namespace OOP_Labb_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --------------- PART ONE (STACK) ---------------
            #region Create Employees and Stack
            // Create five different Employees
            Employee E1, E2, E3, E4, E5;
            CreateEmployees(out E1, out E2, out E3, out E4, out E5);

            // Stack
            Stack<Employee> EmpStack = new Stack<Employee>();
            AddEmployeesToStack(E1, E2, E3, E4, E5, EmpStack);
            #endregion

            #region Print Employees in EmpStack
            WriteCenteredLabel("All employees in the stack");

            // Write out all of the Employees in EmpStack
            foreach (Employee e in EmpStack)
            {
                WriteEmployeeInfo(e.GetId(), e.GetName(), e.GetGender(), e.GetSalary());
                WriteCenteredLabel("Employees left in stack: " + EmpStack.Count, false);
            }
            #endregion

            #region Pop Employees in EmpStack
            WriteCenteredLabel("Pop all the employees in the stack");

            // Pop all of the Employees in EmpStack
            while (EmpStack.Count > 0)
            {
                Employee e = EmpStack.Pop();
                WriteEmployeeInfo(e.GetId(), e.GetName(), e.GetGender(), e.GetSalary());
                WriteCenteredLabel("Employees left in stack: " + EmpStack.Count, false);
            }
            #endregion

            // Add all of the Emplyees back to the stack
            AddEmployeesToStack(E1, E2, E3, E4, E5, EmpStack);

            #region Peek Employees in EmpStack
            WriteCenteredLabel("Use peek on the employee stack");

            // Get the info about the first employee in EmpStack two times with Peek
            for (int i = 0; i < 2; i++)
            {
                Employee e = EmpStack.Peek();
                WriteEmployeeInfo(e.GetId(), e.GetName(), e.GetGender(), e.GetSalary());
                WriteCenteredLabel("Employees left in stack: " + EmpStack.Count, false);
            }
            #endregion

            #region Contains Employee in EmpStack
            WriteCenteredLabel("Check if the employee 'E3' is in the stack");

            // Check if employee three exists in the stack
            bool ExistsInStack = EmpStack.Contains(E3);
            if (ExistsInStack) 
            { 
                WriteCenteredLabel("Employee E3 exist in EmpStack.", false); 
            }
            else 
            { 
                WriteCenteredLabel("Employee E3 does not exist in EmpStack.", false); 
            }
            #endregion


            // --------------- PART TWO (LIST) ---------------
            #region Create a list of Employees
            // Create a list of Employees called EmpList
            List<Employee> EmpList = new List<Employee>();
            AddEmployeesToList(E1, E2, E3, E4, E5, EmpList);
            #endregion

            #region Contains Employee in EmpList
            WriteCenteredLabel("Check if the employee 'E2' is in the list");

            bool ExistsInList = EmpList.Contains(E2);
            if (!ExistsInList) 
            { 
                WriteCenteredLabel("Employee E2 does not exist in EmpList.", false); 
            }
            else 
            { 
                WriteCenteredLabel("Employee E2 exist in EmpList.", false); 
            }
            #endregion

            #region Find first Male
            WriteCenteredLabel("Find the first Male");
            if (EmpList.Find(x => x.GetGender() == "Male") != null)
            {
                Employee e = EmpList.Find(x => x.GetGender() == "Male");
                WriteEmployeeInfo(e.GetId(), e.GetName(), e.GetGender(), e.GetSalary());
            } 
            else 
            {
                WriteCenteredLabel("There was no Employees with Male gender", false);
            }
            #endregion

            #region Find all Males
            WriteCenteredLabel("Find all Males");
            List<Employee> MaleEmpList = EmpList.FindAll(x => x.GetGender() == "Male");
            if (MaleEmpList.Count > 0)
            {
                foreach (Employee e in MaleEmpList)
                {
                    WriteEmployeeInfo(e.GetId(), e.GetName(), e.GetGender(), e.GetSalary());
                }
            } 
            else
            {
                WriteCenteredLabel("There was no Employees with Male gender", false);
            }

            #endregion


            // Read key to stop program from ending
            Console.ReadKey();
        }

        private static void AddEmployeesToList(Employee E1, Employee E2, Employee E3, Employee E4, Employee E5, List<Employee> EmpList)
        {
            EmpList.Add(E1);
            EmpList.Add(E2);
            EmpList.Add(E3);
            EmpList.Add(E4);
            EmpList.Add(E5);
        }

        private static void WriteEmployeeInfo(int id, string name, string gender, int salary)
        {
            Console.WriteLine(String.Format("\n{0," + ((Console.WindowWidth / 2) - 2) + "} {1, 1} {2, -10}", "Id", ":", id));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) - 2) + "} {1, 1} {2, -10}", "Name", ":", name));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) - 2) + "} {1, 1} {2, -10}", "Gender", ":", gender));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) - 2) + "} {1, 1} {2, -10}", "Salary", ":", salary));
        }

        private static void WriteCenteredLabel(string LabelText)
        {
            Console.WriteLine(String.Format("\n\n{0," + ((Console.WindowWidth / 2) + (LabelText.Length / 2)) + "}", LabelText));
            string divider = "--------------------------------------------------------";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (divider.Length / 2)) + "}", divider));
        }

        private static void WriteCenteredLabel(string LabelText, bool NewLine)
        {
            if (NewLine) { Console.WriteLine(); }
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (LabelText.Length / 2)) + "}", LabelText));
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
