using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private decimal money;
    
    public List<Product> bagOfProducts { get; set; }

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.bagOfProducts = new List<Product>();
    }

    public string Name
    {
        get { return name; }
        set
        {
            Validator.ValidateName(value);
            name = value;
        }
    }

    public decimal Money
    {
        get { return money; }
        set
        {
          Validator.ValidateMoney(value);
            money = value;
        }
    }

    public string BuyProduct(Product product)
    {
        if (this.Money < product.Cost)
        {
           return $"{this.Name} can't afford {product.Name}";
        }

        this.money -= product.Cost;
        this.bagOfProducts.Add(product);

        return $"{this.Name} bought {product.Name}";
    }

    public override string ToString()
    {
        string productOutput = this.bagOfProducts.Count > 0 ? string.Join(", ", this.bagOfProducts) : "Nothing bought";

        string result = $"{this.Name} - {productOutput}";
        return result;
    }
   

}

