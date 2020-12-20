using System;

/// <summary>
/// Class Obj
/// </summary>
public class Obj
{
    /// <summary>
    /// Get if obj is an instance of Array
    /// </summary>
    /// <param name="obj">Object</param>
    /// <returns>True if obj is an instance of Array, otherwise false</returns>
    public static bool IsInstanceOfArray(object obj) => obj is Array;
}
