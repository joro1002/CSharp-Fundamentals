using System;
using System.Collections.Generic;
using System.Text;

public class Animal : ISoundProducable
{
    private string name;
    private int age;
    private string gender;


    public Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public string Name
    {
        get => this.name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            name = value;
        }
    }

    public int Age
    {
        get => this.age;
        set
        {

            if (string.IsNullOrWhiteSpace(value.ToString()) ||
                value < 0)
            {
                throw new ArgumentException("Invalid input!");
            }
            age = value;
        }
    }

    public virtual string Gender
    {
        get => this.gender;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            gender = value;
        }
    }

    public virtual string ProduceSound()
    {
        return "NOISE!!!!!!!!!";
    }

    public override string ToString()
    {
        var sb = new StringBuilder()
            .AppendLine(this.GetType().Name)
            .AppendLine($"{this.Name} {this.Age} {this.Gender}")
            .AppendLine(this.ProduceSound());

        return sb.ToString().TrimEnd();
    }
}

