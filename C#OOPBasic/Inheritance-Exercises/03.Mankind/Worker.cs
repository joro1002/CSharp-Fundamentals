using System;
using System.Collections.Generic;
using System.Text;

public class Worker : Human
{
    private decimal weekSalary;
    private decimal workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekSalary
    {
        get => this.weekSalary;
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.weekSalary = value;
        }
    }

    public decimal WorkHoursPerDay
    {
        get => this.workHoursPerDay;
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            this.workHoursPerDay = value;
        }
    }

    public decimal SalaryPerHour()
    {
        return this.weekSalary / 5 / this.workHoursPerDay;
    }

    public override string ToString()
    {
        var sb = new StringBuilder()
            .AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Week Salary: {this.WeekSalary:F2}")
            .AppendLine($"Hours per day: {this.workHoursPerDay:F2}")
            .AppendLine($"Salary per hour: {this.SalaryPerHour():F2}");
        return sb.ToString();
    }
}

