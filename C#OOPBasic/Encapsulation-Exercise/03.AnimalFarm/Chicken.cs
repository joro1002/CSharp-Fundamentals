﻿using System;
using System.Collections.Generic;
using System.Text;

public class Chicken
{
    private string name;
    private int age;

    public const int MinAge = 0;
    public const int MaxAge = 15;

    public Chicken(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(Name)} cannot be empty.");
            }
            name = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value > MaxAge || value < MinAge)
            {

                throw new ArgumentException($"{nameof(Age)} should be between {MinAge} and {MaxAge}.");
            }
            age = value;
        }
    }

    public double GetProductPerDay()
    {
        return this.CalculateProductPerDay();
    }

    private double CalculateProductPerDay()
    {
        switch (this.Age)
        {
            case 0:
            case 1:
            case 2:
            case 3:
                return 1.5;
            case 4:
            case 5:
            case 6:
            case 7:
                return 2;
            case 8:
            case 9:
            case 10:
            case 11:
                return 1;
            default:
                return 0.75;
        }
    }
}

