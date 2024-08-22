using System;
using System.Linq;

namespace Text
{
	/// <summary>
	/// Represents a string checker.
	/// </summary>
	public static class Str
	{
		/// <summary>
		/// Checks how many words are in the string.
		/// </summary>
		/// <param name="s">String to check.</param>
		/// <returns>The number of words in the string.</returns>
		public static int CamelCase(string s) => String.IsNullOrEmpty(s) ? 0 : s.AsEnumerable().Where(c => Char.IsUpper(c)).Count() + 1;
	}
}
