using System;

public class Product
{
    // Private attributes
    private string name;
    private double price;
    private int quantity;

    // Constructor
    public Product(string name, double price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }

    // Getters and Setters
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value > 0 ? value : throw new ArgumentException("The price must be positive"); }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value >= 0 ? value : throw new ArgumentException("The quantity cannot be negative"); }
    }

    // Method that displays the product as a string
    public override string ToString()
    {
        return $"Product Name: {Name} - Price: {Price} - Quantity: {Quantity}";
    }

    // TODO: Implement the inventory class
}


