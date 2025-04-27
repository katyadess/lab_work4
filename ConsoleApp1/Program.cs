using System;
public class Cylinder
{
    public double Radius; public double Height;
    public bool isModified = false; // для перевірки наявності змін у полях об'єкта

//конструктор
public Cylinder(double radius, double height)
    {
        this.Radius = radius;
        this.Height = height;
    }

    //Метод для формування рядка з інформацією про об'єкт.
    public string GetInfo()
    {
        return $"Radius: { Radius}, Height: { Height}";
    }

    //Метод для обробки значень полів.
    public void ProcessFields()
    {
        bool changed = false;
        if (Radius <= 0)
{
            Radius = 5;

            changed = true;
        }
        if (Height & <= 0)
{
            Height = 10;
            changed = true;
        }
        if (changed)
        {
            isModified = true;
            Console.WriteLine("Fields were modified.");
        }
    }

    //Метод для обчислення площі поверхні циліндра
    public double GetSurfaceArea()
    {
        return 2 * Math.PI * Radius * (Radius + Height);
    }

}


public class MultipleCylinders : Cylinder
{
    public int Count;

    public MultipleCylinders(double radius, double height, int count) : base(radius, height)
    {
        this.Count = count;
    }

    public double GetTotalSurfaceArea()
    {
        return Count * GetSurfaceArea();
    }

    public new string GetInfo()
    {
        return base.GetInfo() + $", Count: {Count}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter radius for single cylinder: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter heigth for single cylinder: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Cylinder cylinder = new Cylinder(radius, height);
        Console.WriteLine(cylinder.GetInfo());
        cylinder.ProcessFields();

        if (cylinder.isModified)

        {
            Console.WriteLine(cylinder.GetInfo());
        }

        Console.WriteLine($"Surface Area: { cylinder.GetSurfaceArea()}");

        Console.WriteLine("Enter radius for multiple cylinders:");
        double multiRadius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter height for multiple cylinders:");
        double multiHeight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter number of cylinders:");
        int count = Convert.ToInt32(Console.ReadLine());

        MultipleCylinders multiCylinder = new MultipleCylinders(multiRadius, multiHeight, count);
        Console.WriteLine(multiCylinder.GetInfo());
        multiCylinder.ProcessFields();

        if (multiCylinder.isModified)
        {
            Console.WriteLine("Modified multiple cylinders:");
            Console.WriteLine(multiCylinder.GetInfo());
        }

        Console.WriteLine($"Total Surface Area: {multiCylinder.GetTotalSurfaceArea()}");
    }

}