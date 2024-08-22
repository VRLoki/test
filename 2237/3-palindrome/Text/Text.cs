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
		/// Checks if a string is a palindrome.
		/// </summary>
		/// <param name="s">String to check</param>
		/// <returns>True if it's a palindrome or false.</returns>
		public static bool IsPalindrome(string s)
		{
			string trimmedString = String.Concat(s.ToLower().Where(c => IsALetter(c)));
			string reverseString = new string(trimmedString.Reverse().ToArray());
			return reverseString.Equals(trimmedString);
		}

		private static bool IsALetter(char c) => !Char.IsPunctuation(c) && !Char.IsWhiteSpace(c);
	}
}
