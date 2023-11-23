using System;
//Interface Segregation Principle.

interface IShapeProduct
{
    void SetColor(byte color);
    void SetSize(byte size);
}

interface IDiscountProduct
{
    void ApplyDiscount(string discount);
    void ApplyPromocode(string promocode);
}

interface ISellProduct
{
    void SetPrice(double price);
}

class Book : ISellProduct, IDiscountProduct
{
    private double Price { get; set; }
    private string Discount { get; set; }
    private string Promocode { get; set; }

    public void SetPrice(double price)
    {
        Price = price;
        Console.WriteLine($"Setted price of book: {Price}");
    }

    public void ApplyDiscount(string discount)
    {
        Discount = discount;
        Console.WriteLine($"To book applied discount: {Discount}");
    }

    public void ApplyPromocode(string promocode)
    {
        Promocode = promocode;
        Console.WriteLine($"To book applied promocode: {Promocode}");
    }
}

class Outerwear : IShapeProduct, ISellProduct, IDiscountProduct
{
    private double Price { get; set; }
    private string Discount { get; set; }
    private string Promocode { get; set; }
    private byte Color { get; set; }
    private byte Size { get; set; }

    public void SetPrice(double price)
    {
        Price = price;
        Console.WriteLine($"Setted price of outerwear: {Price}");
    }

    public void ApplyDiscount(string discount)
    {
        Discount = discount;
        Console.WriteLine($"To outerwear applied discount: {Discount}");
    }

    public void ApplyPromocode(string promocode)
    {
        Promocode = promocode;
        Console.WriteLine($"To outerwear applied promocode: {Promocode}");
    }

    public void SetColor(byte color)
    {
        Color = color;
        Console.WriteLine($"The color of outerwear: {Color}");
    }

    public void SetSize(byte size)
    {
        Size = size;
        Console.WriteLine($"The size of outerwear: {Size}");
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Console.ReadKey();
    }
}