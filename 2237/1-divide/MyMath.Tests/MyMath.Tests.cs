using NUnit.Framework;

namespace MyMath.Tests
{
	public class Tests
	{
		[Test]
		public void TestWithNormalDivide()
		{
			int[,] matrix = new int[,]
			{
				{1, 2, 3},
				{4, 5, 6},
				{7, 8, 9}
			};
			int[,] result = Matrix.Divide(matrix, 2);
			int[,] expectedResult = new int[,]
			{
				{0, 1, 1},
				{2, 2, 3},
				{3, 4, 4}
			};
			Assert.AreEqual(expectedResult, result);
		}

		[Test]
		public void TestWithDivideByZero()
		{
			int[,] matrix = new int[,]
			{
				{1, 2, 3},
				{4, 5, 6},
				{7, 8, 9}
			};
			int[,] result = Matrix.Divide(matrix, 0);
			Assert.AreEqual(null, result);
		}

		[Test]
		public void TestWithMatrixNull()
		{
			int[,] result = Matrix.Divide(null, 9);
			Assert.AreEqual(null, result);
		}

		[Test]
		public void TestWithNegativeNum()
		{
			int[,] matrix = new int[,]
			{
				{1, 2, 3},
				{4, 5, 6},
				{7, 8, 9}
			};
			int[,] result = Matrix.Divide(matrix, -2);
			int[,] expectedResult = new int[,]
			{
				{0, -1, -1},
				{-2, -2, -3},
				{-3, -4, -4}
			};
			Assert.AreEqual(expectedResult, result);
		}
	}
}
