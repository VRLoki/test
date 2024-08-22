/// <summary>
/// Represents an object checker.
/// </summary>
static class Obj
{
	/// <summary>
	/// Checks if <paramref name="obj"/> is an integer.
	/// </summary>
	/// <param name="obj">Object to check.</param>
	/// <returns>True if it's an int or false.</returns>
	public static bool IsOfTypeInt(object obj) => obj is int;
}
