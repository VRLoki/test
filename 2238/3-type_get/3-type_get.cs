using System;
using System.Reflection;

/// <summary>
/// Represents an object checker.
/// </summary>
static class Obj
{
	/// <summary>
	/// Prints the names of the available properties and methods of <paramref name="myObj"/>.
	/// </summary>
	/// <param name="myObj">Object to check the properties and methods</param>
	public static void Print(object myObj)
	{
		Type objectType = myObj.GetType();
		TypeInfo objectTypeInfo = objectType.GetTypeInfo();

		Console.WriteLine($"{objectType.Name} Properties:");
		foreach (PropertyInfo property in objectTypeInfo.GetProperties())
			Console.WriteLine(property.Name);

		Console.WriteLine($"{objectType.Name} Methods:");
		foreach (MethodInfo method in objectTypeInfo.GetMethods())
			Console.WriteLine(method.Name);
	}
}
