using System;
using System.Collections.Generic;
using System.Text;

public class Box
{
    private double length;

    public double Length
    {
        get { return length; }
        set { length = value; }
    }

    private double width;

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    private double height;

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    public Box(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public double CalculateSurfaceArea(double lenght, double width, double height)
    {
        return (2 * lenght * width) + (2 * lenght * height) + (2 * width * height);
    }

    public double CalculateLateralSurfaceArea(double lenght, double width, double height)
    {
        return (2 * lenght * height) + (2 * width * height);
    }

    public double CalculateVolume(double lenght, double width, double height)
    {
        return lenght * width * height;
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder()
            .AppendLine($"Surface Area - {CalculateSurfaceArea(this.length, this.width, this.height):F2}")
            .AppendLine($"Lateral Surface Area - {CalculateLateralSurfaceArea(this.length, this.width, this.height):F2}")
            .AppendLine($"Volume - {CalculateVolume(this.length, this.width, this.height):F2}");
        return stringBuilder.ToString();
    }
}

