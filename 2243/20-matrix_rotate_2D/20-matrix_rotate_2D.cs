using System;

/// <summary>
/// Represents operations on matrixes.
/// </summary>
class MatrixMath
{
	/// <summary>
	/// Rotate a 2D matrix.
	/// </summary>
	/// <param name="matrix">2D matrix to rotate</param>
	/// <param name="angle">Angle in radian to rotate the </param>
	/// <returns>A matrix containing -1 or the result of the rotation.</returns>
	public static double[,] Rotate2D(double[,] matrix, double angle)
	{
		int rowLength = matrix.GetLength(0), colLength = matrix.GetLength(1);

		if (rowLength != colLength)
			return new double[,] { { -1 } };

		double cosAngle = Math.Cos(angle);
		double sinAngle = Math.Sin(angle);

		double[,] rotationMatrix = new double[,]
		{
			{cosAngle, sinAngle},
			{-sinAngle, cosAngle}
		};

		return Multiply(matrix, rotationMatrix);
	}

	/// <summary>
	/// Multiply 2 matrixes.
	/// </summary>
	/// <param name="matrix1">First matrix</param>
	/// <param name="matrix2">Second matrix</param>
	/// <returns>A matrix with -1 if they can't be multiplied or the result.</returns>
	public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
	{
		int rowMatrix1 = matrix1.GetLength(0);
		int colMatrix1 = matrix1.GetLength(1);
		int rowMatrix2 = matrix2.GetLength(0);
		int colMatrix2 = matrix2.GetLength(1);

		if (colMatrix1 != rowMatrix2)
			return new double[,] { { -1 } };

		double[,] mul = new double[rowMatrix1, colMatrix2];

		for (int i = 0; i < rowMatrix1; i++)
		{
			for (int j = 0; j < colMatrix2; j++)
			{
				double temp = 0;
				for (int k = 0; k < colMatrix1; k++)
					temp += matrix1[i, k] * matrix2[k, j];
				mul[i, j] = Math.Round(temp, 2);
			}
		}
		return mul;
	}
}
