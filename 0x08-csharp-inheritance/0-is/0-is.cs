using System;

/// <summary>
/// Class Obj
/// </summary>
public class Obj
{
    /// <summary>
    /// Gets if obj is an integer
    /// </summary>
    /// <param name="obj">Object</param>
    /// <returns>True if is an integer,otherwise false</returns>
    public static bool IsOfTypeInt(object obj) => obj is int;
}
