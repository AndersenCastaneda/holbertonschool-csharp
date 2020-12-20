using System;

/// <summary>
/// Class Obj
/// </summary>
public class Obj
{
    /// <summary>
    /// Get if a class is a subtype from another class
    /// </summary>
    /// <param name="derivedType">Class that inheritance from the base class</param>
    /// <param name="baseType">Base class</param>
    /// <returns>True if derivedType inheritance from baseType</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
