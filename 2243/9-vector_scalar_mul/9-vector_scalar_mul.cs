using System;

/// <summary>
/// Represents operations on vectors.
/// </summary>
class VectorMath
{
	/// <summary>
	/// Multiply a 2D or 3D vector by a scalar.
	/// </summary>
	/// <param name="vector">2D/3D vector to multiply</param>
	/// <param name="scalar">Number to multiply the vector to</param>
	/// <returns>A vector containing -1 or the result of the multiplication.</returns>
	public static double[] Multiply(double[] vector, double scalar)
	{
		if (vector.Length != 2 && vector.Length != 3)
			return new double[] { -1 };

		for (int i = 0; i < vector.Length; i++)
			vector[i] *= scalar;

		return vector;
	}
}
