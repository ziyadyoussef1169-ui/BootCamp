using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Sphere s1 = new Sphere(3);       
        Sphere s2 = Sphere.FromDiameter(10); 
        Console.WriteLine("=== SPHERE DETAILS ===");
        Console.WriteLine(s1);
        Console.WriteLine(s2);

        Console.WriteLine("\n=== ADDING SPHERES (r1 + r2) ===");
        Sphere s3 = s1 + s2;
        Console.WriteLine(s3);

        Console.WriteLine("\n=== COMPARISONS ===");
        Console.WriteLine($"Is s1 > s2 ? {s1 > s2}");
        Console.WriteLine($"Is s1 < s2 ? {s1 < s2}");
        Console.WriteLine($"Is s1 == s2 ? {s1 == s2}");

        Console.WriteLine("\n=== SORTING SPHERES BY RADIUS ===");
        List<Sphere> spheres = new List<Sphere> { s3, s1, s2 };
        spheres.Sort((a, b) => a.Radius.CompareTo(b.Radius));

        foreach (var sphere in spheres)
            Console.WriteLine(sphere);
    }
}
