using System;

/// <summary>
/// Represents a Queue of a certain type of data.
/// </summary>
/// <typeparam name="T">Type of data stored.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Returns the Queue's type.
    /// </summary>
    /// <returns>The Queue's type</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
