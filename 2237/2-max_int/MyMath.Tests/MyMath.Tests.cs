using System;
using System.Collections.Generic;
using MyMath;
using NUnit.Framework;

namespace MyMath.Tests
{
	public class Tests
	{
		/// <summary>
		/// Tests with only positive int.
		/// </summary>
		[Test]
		public void TestWithOnlyPositiveInt()
		{
			List<int> numbers = new List<int>() { 0, 5, 4, 43, 3, 5};
			int result = Operations.Max(numbers);
			Assert.AreEqual(43, result);
		}

		/// <summary>
		/// Tests with an empty list.
		/// </summary>
		[Test]
		public void TestWithEmptyList()
		{
			List<int> numbers = new List<int>();
			int result = Operations.Max(numbers);
			Assert.AreEqual(0, result);
		}

		/// <summary>
		/// Tests with only the same value.
		/// </summary>
		[Test]
		public void TestWithOnlyMaxValue()
		{
			List<int> numbers = new List<int>() { 5, 5, 5};
			int result = Operations.Max(numbers);
			Assert.AreEqual(5, result);
		}

		/// <summary>
		/// Tests with only negative int.
		/// </summary>
		[Test]
		public void TestWithOnlyNegativeInt()
		{
			List<int> numbers = new List<int>() { -5, -4, -43, -3, -5 };
			int result = Operations.Max(numbers);
			Assert.AreEqual(-3, result);
		}

		/// <summary>
		/// Tests with only one int.
		/// </summary>
		[Test]
		public void TestWithOneValue()
		{
			List<int> numbers = new List<int>() { -5 };
			int result = Operations.Max(numbers);
			Assert.AreEqual(-5, result);
		}
	}
}
