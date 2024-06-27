using System;

/// <summary>
/// Represents operations on vectors.
/// </summary>
class VectorMath
{
	/// <summary>
	/// Calculates the length of a 2D or 3D vector.
	/// </summary>
	/// <param name="vector">Vector to calculate</param>
	/// <returns>-1 or the value of the magnitude.</returns>
	public static double Magnitude(double[] vector)
	{
		double vectorLength = 0;

		if (vector.Length != 2 && vector.Length != 3)
			return -1;
		foreach (double point in vector)
		{
			vectorLength += point * point;
		}
		vectorLength = Math.Sqrt(vectorLength);
		return Math.Round(vectorLength, 2);
	}
}
