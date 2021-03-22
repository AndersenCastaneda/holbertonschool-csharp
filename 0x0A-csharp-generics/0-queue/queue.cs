using System;

/// <summary>
/// Generic Queue class
/// </summary>
/// <typeparam name="T">Generic Type</typeparam>
class Queue<T>
{
    /// <summary>
    /// Retuns the type of queue value
    /// </summary>
    /// <returns>Queue value type</returns>
    public Type CheckType() => typeof(T);
}
