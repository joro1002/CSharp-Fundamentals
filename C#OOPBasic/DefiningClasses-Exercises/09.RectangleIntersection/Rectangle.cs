using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle
{
    private string id;
    private double width;
    private double height;
    private double coordinatesTopLeftX;
    private double coordinatesTopLeftY;

    public Rectangle(string id, double width, double height, double coordinatesTopLeftX, double coordinatesTopLeftY)
    {
        this.id = id;
        this.width = width;
        this.height = height;
        this.coordinatesTopLeftX = coordinatesTopLeftX;
        this.coordinatesTopLeftY = coordinatesTopLeftY;
    }
    
    public string ID
    {
        get { return id; }
        set { id = value; }
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    public double CoordinatesTopLeftX
    {
        get { return coordinatesTopLeftX; }
        set { coordinatesTopLeftX = value; }
    }

    public double CoordinatesTopLeftY
    {
        get { return coordinatesTopLeftY; }
        set { coordinatesTopLeftY = value; }
    }

    public bool IntersectsRectangle(Rectangle r)
    {
        return this.ContainsRectangleCorner(r) || r.ContainsRectangleCorner(this);
    }
    private bool ContainsRectangleCorner(Rectangle r)
    {
        return this.ContainsPoint(r.coordinatesTopLeftX, r.coordinatesTopLeftY) ||
               this.ContainsPoint(r.coordinatesTopLeftX, r.coordinatesTopLeftY + height) ||
               this.ContainsPoint(r.coordinatesTopLeftX + width, r.coordinatesTopLeftY) ||
               this.ContainsPoint(r.coordinatesTopLeftX + width, r.coordinatesTopLeftY + height);
    }

    private bool ContainsPoint(double x, double y)
    {
        return x >= this.coordinatesTopLeftX && x <= this.coordinatesTopLeftX + width &&
               y >= this.coordinatesTopLeftY && y <= this.coordinatesTopLeftY + height;
    }
}

