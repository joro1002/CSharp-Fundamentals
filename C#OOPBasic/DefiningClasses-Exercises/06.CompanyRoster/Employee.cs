using System;
using System.Collections.Generic;
using System.Text;

public class Employee
{
    private string name;
    private decimal salary;
    private string position;
    private string department;
    private string imeil;
    private int age;

    public Employee(string name, decimal salary, string position, string department)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.imeil = "n/a";
        this.age = -1;
    }

    public string Name => this.name;
    public decimal Salary => this.salary;
    public string Department => this.department;
    public string Position => this.position;
    public string Imeil
    {
        get { return imeil; }
        set { imeil = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }







}

