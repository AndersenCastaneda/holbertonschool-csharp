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
}
