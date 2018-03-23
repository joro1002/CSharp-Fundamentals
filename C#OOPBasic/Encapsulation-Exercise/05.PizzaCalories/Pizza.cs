﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Pizza
{
    private string name;
    private Dough dough;
    private int numberOfToppings;
    private List<Toppings> toppings;

    public Pizza(string name)
    {
        this.Name = name;
        this.NumberOfToppings = numberOfToppings;
        this.toppings = new List<Toppings>();
    }

    public string Name
    {
        get => this.name;
        private set
        {
            if (value.Length < 1 || value.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            this.name = value;
        }
    }

    public int NumberOfToppings
    {
        get => this.numberOfToppings;
        set
        {
            if (value < 0 || value > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.numberOfToppings = value;
        }
    }

    public Dough Dough
    {
        set => this.dough = value;
    }

    public void AddTopping(Toppings topping)
    {
        this.toppings.Add(topping);
    }

    public double Calories()
    {
        return this.dough.GetCalories() + this.toppings.Sum(t => t.GetCalories());
    }

    public override string ToString()
    {
        return $"{this.Name} - {this.Calories():F2} Calories.";
    }
}

