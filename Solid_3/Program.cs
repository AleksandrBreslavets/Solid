using System;

//Liskov Substitution Principle.

interface IShape
{
    int GetArea();
}

class Rectangle : IShape
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public Rectangle(int w, int h)
    {
        Width = w;
        Height = h;
    }

    public int GetArea()
    {
        return Width * Height;
    }
}

class Square : IShape
{
    public virtual int Side { get; set; }

    public Square(int s)
    {
        Side = s;
    }

    public int GetArea()
    {
        return Side*Side;
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            IShape r = new Rectangle(5, 10);
            IShape s = new Square(10);

            Console.WriteLine("Rectangle:");
            Console.WriteLine(r.GetArea());
            Console.WriteLine("Square:");
            Console.WriteLine(s.GetArea());

            Console.ReadKey();
        }
    }
