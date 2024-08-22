using NUnit.Framework;

namespace MyMath.Tests
{
	/// <summary>
	/// Tests the different cases with the <see cref="Operations"/> class.
	/// </summary>
	[TestFixture]
	public class Tests
	{
		/// <summary>
		/// Tests an addition between two positive integers.
		/// </summary>
		[Test]
		public void TestBetweenPositiveInt()
		{
			const int firstNumber = 1, secondNumber = 2;
			int result = Operations.Add(firstNumber, secondNumber);
			Assert.AreEqual(3, result);
		}

		/// <summary>
		/// Tests an addition between two negative integers.
		/// </summary>
		[Test]
		public void TestBetweenNegativeInt()
		{
			const int firstNumber = -100, secondNumber = -23;
			int result = Operations.Add(firstNumber, secondNumber);
			Assert.AreEqual(-123, result);
		}

		/// <summary>
		/// Test an addition with a negative integer.
		/// </summary>
		[Test]
		public void TestWithNegativeInt()
		{
			const int firstNumber = 1, secondNumber = -23;
			int result = Operations.Add(firstNumber, secondNumber);
			Assert.AreEqual(-22, result);
		}

		/// <summary>
		/// Tests with a string converted into an int.
		/// </summary>
		[Test]
		public void TestWithStringToInt()
		{
			int firstNumber = 0, secondNumber = int.Parse("500");
			int result = Operations.Add(firstNumber, secondNumber);
			Assert.AreEqual(500, result);
		}

		/// <summary>
		/// Tests an addition with intMax.
		/// </summary>
		[Test]
		public void TestWithIntMax()
		{
			const int firstNumber = int.MaxValue, secondNumber = -2313131;
			int result = Operations.Add(firstNumber, secondNumber);
			Assert.AreEqual(2145170516, result);
		}
	}
}
