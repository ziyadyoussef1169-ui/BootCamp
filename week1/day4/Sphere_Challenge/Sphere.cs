using System;

public class Sphere
{
    private double _radius;

    public double Radius
    {
        get => _radius;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Radius must be positive.");
            _radius = value;
        }
    }

    public double Diameter
    {
        get => _radius * 2;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Diameter must be positive.");
            _radius = value / 2;
        }
    }

    public Sphere(double radius)
    {
        Radius = radius;
    }

    public static Sphere FromDiameter(double diameter)
    {
        return new Sphere(diameter / 2);
    }

    public double Volume => (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);

    public double SurfaceArea => 4 * Math.PI * Math.Pow(Radius, 2);

    
    public static Sphere operator +(Sphere s1, Sphere s2)
    {
        return new Sphere(s1.Radius + s2.Radius);
    }

    
    public static bool operator >(Sphere s1, Sphere s2)
    {
        return s1.Volume > s2.Volume;
    }

    public static bool operator <(Sphere s1, Sphere s2)
    {
        return s1.Volume < s2.Volume;
    }

    public static bool operator ==(Sphere s1, Sphere s2)
    {
        return s1.Radius == s2.Radius;
    }

    public static bool operator !=(Sphere s1, Sphere s2)
    {
        return s1.Radius != s2.Radius;
    }

    public override bool Equals(object obj)
    {
        if (obj is Sphere s)
            return s.Radius == this.Radius;
        return false;
    }

    public override int GetHashCode()
    {
        return Radius.GetHashCode();
    }


    public override string ToString()
    {
        return $"Sphere → Radius: {Radius:F2}, Diameter: {Diameter:F2}, Volume: {Volume:F2}, Surface Area: {SurfaceArea:F2}";
    }
}
