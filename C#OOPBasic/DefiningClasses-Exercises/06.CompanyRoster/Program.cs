using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        var employees = new List<Employee>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var token = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string name = token[0];
            decimal salary = decimal.Parse(token[1]);
            string position = token[2];
            string department = token[3];
            string imeil = "n/a";
            int age = -1;
            var employee = new Employee(name, salary, position, department);

            if (token.Length > 4)
            {
                var ageOrEmail = token[4];
                if (ageOrEmail.Contains("@"))
                {
                    employee.Imeil = ageOrEmail;
                }
                else
                {
                    employee.Age = int.Parse(ageOrEmail);
                }
            }

          
            if (token.Length > 5)
            {
                employee.Age = int.Parse(token[5]);
            }

            employees.Add(employee);
        }

        var result = employees
            .GroupBy(e => e.Department)
            .Select(d => new
            {
                Department = d.Key,
                AverageSalary = d.Average(e => e.Salary),
                Employees = d.OrderByDescending(emp => emp.Salary).ToList()
            })
            .OrderByDescending(d => d.AverageSalary)
            .FirstOrDefault();


        if (result != null)
        {
            Console.WriteLine($"Highest Average Salary: {result.Department}");

            foreach (var employee in result.Employees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Imeil} {employee.Age}");
            }
        }
    }

}
