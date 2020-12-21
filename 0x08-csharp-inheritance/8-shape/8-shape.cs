using System;

/// <summary>
/// Class Shape
/// </summary>
public class Shape
{
    /// <summary>
    /// Get Area from a shape
    /// </summary>
    /// <returns>A new Exception</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Class Rectangle
/// </summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Get and Set the width value
    /// </summary>
    /// <value>Width</value>
    public int Width
    {
        get => width;
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }

    /// <summary>
    /// Get and Set height value
    /// </summary>
    /// <value>Height</value>
    public int Height
    {
        get => height;
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }

    /// <summary>
    /// Get Rectangle Area
    /// </summary>
    /// <returns>Area</returns>
    public new int Area() => width * height;

    /// <summary>
    /// String Representation of Rectangle
    /// </summary>
    public override string ToString() => $"[{this.GetType()}] {width} / {height}";
}

/// <summary>
/// Class Square
/// </summary>
public class Square : Rectangle
{
    private int size;

    /// <summary>
    /// Get and Set Squere size
    /// </summary>
    /// <value>Size</value>
    public int Size
    {
        get => size;
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            else
            {
                size = value;
                Height = value;
                Width = value;
            }
        }
    }
}
