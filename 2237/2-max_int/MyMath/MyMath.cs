using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMath
{
	/// <summary>
	/// Represents possible operations on numbers.
	/// </summary>
	public static class Operations
	{
		/// <summary>
		/// Finds the max value in a list of int.
		/// </summary>
		/// <param name="nums">List of int.</param>
		/// <returns>The max value.</returns>
		public static int Max(List<int> nums)
		{
			if (nums.Count == 0)
				return 0;
			return nums.Max();
		}
	}
}
