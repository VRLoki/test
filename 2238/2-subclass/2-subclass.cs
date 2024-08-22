using System;

/// <summary>
/// Represents an object checker.
/// </summary>
static class Obj
{
	/// <summary>
	/// Checks if <paramref name="derivedType"/> is a subclass of <paramref name="baseType"/>.
	/// </summary>
	/// <param name="derivedType">Class to check</param>
	/// <param name="baseType">Reference class</param>
	/// <returns>True if <paramref name="derivedType"/> inherits from <paramref name="baseType"/></returns>
	public static bool IsOnlyASubclass(Type derivedType, Type baseType) => derivedType.IsSubclassOf(baseType);
}
