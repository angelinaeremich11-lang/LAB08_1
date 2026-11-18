using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace LAB08_1
{
    internal class Department
    {
        public string Name { get; set; }
        private List<Employee> employees;
        public Department(string name)
        {
            Name = name;
            employees = new List<Employee>();
        }
        public bool AddEmployee(Employee employee)
        {
            if (employee == null)
            {
                return false;
            }
            if (employee.IsEmployed)
            {
                Console.WriteLine($"Ошибка: {employee.Name} уже работает в другом отделе!");
                return false;
            }
            foreach (Employee emp in employees)
            {
                if (emp.ID == employee.ID)
                {
                    return false;
                }
            }
            employees.Add(employee);
            employee.IsEmployed = true;
            return true;
        }
        public bool RemoveEmployee(int id)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].ID == id)
                {
                    employees[i].IsEmployed = false;
                    employees.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public int CountEmployees()
        {
            int count = 0;

            foreach (Employee emp in employees)
            {
                count++;
            }



            return count;
        }
        public int CountWorkers()
        {
            int count = 0;
            foreach (Employee emp in employees)
            {
                if (emp is Worker)
                {
                    count++;
                }
            }
            return count;
        }
        public int CountProgrammers()
        {
            int count = 0;
            foreach (Employee emp in employees)
            {
                if (emp is Programmer)
                {
                    count++;
                }
            }
            return count;
        }
        public int CountManagers()
        {
            int count = 0;
            foreach (Employee emp in employees)
            {
                if (emp is Manager)
                {
                    count++;
                }
            }
            return count;
        }
        public decimal CalculateTotalSalary()
        {
            decimal total = 0;
            foreach (Employee emp in employees)
            {
                total += emp.TotalSalary();
            }
            return total;
        }
        public decimal CalculateAverageSalary()
        {
            if (employees.Count == 0)
            {
                return 0;
            }
            return CalculateTotalSalary() / employees.Count;
        }

        public Employee? FindHighestPaidEmployee()
        {
            if (employees.Count == 0)
            {
                return null;
            }

            Employee highest = employees[0];

            foreach (Employee emp in employees)
            {
                if (emp.TotalSalary() > highest.TotalSalary())
                {
                    highest = emp;
                }
            }
            return highest;
        }

        public Employee? FindLowestPaidEmployee()
        {
            if (employees.Count == 0)
            {
                return null;
            }

            Employee lowest = employees[0];

            foreach (Employee emp in employees)
            {
                if (emp.TotalSalary() < lowest.TotalSalary())
                {
                    lowest = emp;
                }
            }
            return lowest;
        }

        public decimal CalculateAverageSalaryByType(string type)
        {
            decimal total = 0;
            int count = 0;

            foreach (Employee emp in employees)
            {
                if (emp.GetType().Name == type)
                {
                    total += emp.TotalSalary();
                    count++;
                }
            }

            if (count == 0)
            {
                return 0;
            }

            return total / count;
        }
        public void PrintEmployees()
        {
            Console.WriteLine($"Department: {Name}");
            Console.WriteLine("-------------------------");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
