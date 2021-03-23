using System;

/// <summary>
/// Base abstract class
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Name property
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// String representation
    /// </summary>
    /// <returns>name is a type</returns>
    public override string ToString() => $"{name} is a {GetType()}";
}

/// <summary>
/// Interactive interface
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Interact function
    /// </summary>
    void Interact();
}

/// <summary>
/// Breackable interface
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Durability property
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Break function
    /// </summary>
    void Break();
}

/// <summary>
/// Collectable interface
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// IsCollected Property
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Collect function
    /// </summary>
    void Collect();
}

/// <summary>
/// TestObject class
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// Interact function
    /// </summary>
    public void Interact() { }

    /// <summary>
    /// Durability property
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Break function
    /// </summary>
    public void Break() { }

    /// <summary>
    /// IsCollected Property
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Collect function
    /// </summary>
    public void Collect() { }
}
