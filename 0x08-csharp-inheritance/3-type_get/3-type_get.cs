using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// Class Obj
/// </summary>
public class Obj
{
    /// <summary>
    /// Print Properties and Methods from an Object
    /// </summary>
    /// <param name="myObj">Object</param>
    public static void Print(object myObj)
    {
        var t = myObj.GetType().GetTypeInfo();
        Console.WriteLine($"{t.Name} Properties:");

        foreach (PropertyInfo p in t.GetProperties())
            Console.WriteLine(p.Name);

        Console.WriteLine($"{t.Name} Methods:");
        foreach (MethodInfo m in t.GetMethods())
            Console.WriteLine(m.Name);
    }
}
