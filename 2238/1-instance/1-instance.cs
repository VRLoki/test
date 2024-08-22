using System;

/// <summary>
/// Represents an object checker.
/// </summary>
static class Obj
{
	/// <summary>
	/// Checks if <paramref name="obj"/> is an instance of an array.
	/// </summary>
	/// <param name="obj">Object to check.</param>
	/// <returns>True if it's an instance of an array or false.</returns>
	public static bool IsInstanceOfArray(object obj) => obj is Array;
}
