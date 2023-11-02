Console.WriteLine("Labb nummer 7!\n");




Cirkel cirkelEtt = new Cirkel();
cirkelEtt.radius = 6;
Console.WriteLine("Cirkelns area: " + cirkelEtt.RoundDecimals(cirkelEtt.Area()) + "cm\u00B2");

Rektangel rektangelEtt = new Rektangel();
rektangelEtt.length = 6;
rektangelEtt.width = 12;
Console.WriteLine("Rektangelns area: " + rektangelEtt.Area() + "cm\u00B2");

Kvadrat kvadratEtt = new Kvadrat(); 
kvadratEtt.sideLength = 6; 
Console.WriteLine("Kvadratens area: "+ kvadratEtt.Area() + "cm\u00B2");

Parallellogram parallellogramEtt = new Parallellogram();
/*parallellogramEtt.baseLength = 10;
*/parallellogramEtt.height = 13;
Console.WriteLine("Parallellogrammets area: "+ parallellogramEtt.Area() + "cm\u00B2");

Ellips ellipsEtt = new Ellips();    
ellipsEtt.minorAxis = 3;
ellipsEtt.majorAxis = 7;
Console.WriteLine("Ellipsens area: "+ ellipsEtt.RoundDecimals(ellipsEtt.Area()) + "cm\u00B2");



public class Geometri
{
    public double RoundDecimals(double number)
    {
        double roundedNumber = Math.Round(number, 4);
        return roundedNumber;
    }

    public virtual double Area()
    {
        return 0.0;
    }
}

public class Cirkel : Geometri
{
    public double radius { get; set; }

    public Cirkel()
    {
        radius = 4;
    }

    public override double Area()
    {
        return 3.14159265 * radius * radius;
    }
}

public class Rektangel : Geometri
{
    public double length { get; set; }
    public double width { get; set; }

    public Rektangel()
    {
        length = 5;
        width = 10;
    }

    public override double Area()
    {
        return length * width;
    }
}
public class Kvadrat : Geometri
{
    public double sideLength { get; set; }

    public Kvadrat()
    {
        sideLength = 8;
    }

    public override double Area()
    {
        return sideLength * sideLength;
    }
}

public class Parallellogram : Geometri
{
    public double baseLength { get; set; }
    public double height { get; set; }

    public Parallellogram()
    {
        baseLength = 15;
        height = 10;
    }

    public override double Area()
    {
        return baseLength * height;
    }
}
public class Ellips : Geometri
{
    public double majorAxis { get; set; } 
    public double minorAxis { get; set; } 

    public Ellips()
    {
        majorAxis = 14;
        minorAxis = 10;
    }

    public override double Area()
    {
        return 3.141592654 * majorAxis * minorAxis;
    }
}

