using System;
using System.Collections.Generic;

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
/// Door class
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="value">name value</param>
    public Door(string value = "Door") => name = value;

    /// <summary>
    /// Interact function
    /// </summary>
    public void Interact() => Console.WriteLine($"You try to open the {name}. It's locked.");
}

/// <summary>
/// Decoration class
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// IsQuestItem variable
    /// </summary>
    public bool isQuestItem;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name">Name value</param>
    /// <param name="durability">Durability value</param>
    /// <param name="isQuestItem">IsQuestItem value</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        else
        {
            this.name = name;
            this.durability = durability;
            this.isQuestItem = isQuestItem;
        }
    }

    /// <summary>
    /// Durability property
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Break function
    /// </summary>
    public void Break()
    {
        --durability;
        if (durability > 0)
            Console.WriteLine($"You hit the {name}. It cracks.");
        else if (durability == 0)
            Console.WriteLine($"You smash the {name}. What a mess.");
        else
            Console.WriteLine($"The {name} is already broken.");
    }

    /// <summary>
    /// Interact function
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem)
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        else
            Console.WriteLine($"You look at the {name}. Not much to see here.");
    }
}

/// <summary>
/// Key class
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name">Name value</param>
    /// <param name="isCollected">IsCollected value</param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// IsCollected Property
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Collect function
    /// </summary>
    public void Collect()
    {
        if (isCollected)
            Console.WriteLine($"You have already picked up the {name}.");
        else
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
    }
}

/// <summary>
/// RoomObjects class
/// </summary>
public class RoomObjects
{
    /// <summary>
    /// IterateAction function
    /// </summary>
    /// <param name="roomObjects">List of base objects</param>
    /// <param name="type">Base type of the objects</param>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        for (int i = 0, length = roomObjects.Count; i < length; ++i)
        {
            if (roomObjects[i] is IInteractive && type == typeof(IInteractive))
            {
                IInteractive obj = (IInteractive)roomObjects[i];
                obj.Interact();
            }
            else if (roomObjects[i] is IBreakable && type == typeof(IBreakable))
            {
                IBreakable obj = (IBreakable)roomObjects[i];
                obj.Break();
            }
            else if (roomObjects[i] is ICollectable && type == typeof(ICollectable))
            {
                ICollectable obj = (ICollectable)roomObjects[i];
                obj.Collect();
            }
        }
    }
}
