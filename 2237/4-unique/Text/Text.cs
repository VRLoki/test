using System;
using System.Collections.Generic;
using System.Linq;

namespace Text
{
	/// <summary>
	/// Represents a string checker.
	/// </summary>
	public static class Str
	{
		/// <summary>
		/// Finds the index of the first non-repeating character.
		/// </summary>
		/// <param name="s">String to check</param>
		/// <returns>The index of the character or -1 if there's none.</returns>
		public static int UniqueChar(string s)
		{
			if (s.Length == 1)
				return 0;

			try
			{
				return s.IndexOf(s.GroupBy(c => c).First(ch => ch.Count() == 1).Key);
			}
			catch (InvalidOperationException)
			{
				return -1;
			}
		}
	}
}
