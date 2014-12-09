// Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

using System;

class SurfaceOfATriangle
{
    static double TriangleSurface1(double side, double h)
    {
        double surface = (side * h) / 2;
        return surface;
    }

    static double TriangleSurface2(double A, double B, double C)
    {
        double p = (A + B + C) / 2;
        double surface = Math.Sqrt(p * ((p - A) * (p - B) * (p - C)));
        return surface;
    }

    static double TriangleSurface3(double sideOne, double sideTwo, double angle)
    {
        double surface = (sideOne * sideTwo * Math.Sin(angle)) / 2;
        return surface;
    }

    static void Main()
    {
        double surface = 0;
        double sideA = 3;
        double sideB = 6;
        double sideC = 7;
        double altitude = 4;
        double angle = 45;

        surface = TriangleSurface1(sideC, altitude);
        Console.WriteLine("Surface of triangle 1 is: {0:F3}", surface);
        surface = TriangleSurface2(sideA, sideB, sideC);
        Console.WriteLine("Surface of triangle 2 is: {0:F3}", surface);
        surface = TriangleSurface3(sideA, sideC, angle);
        Console.WriteLine("Surface of triangle 3 is: {0:F3}", surface);
    }
}
