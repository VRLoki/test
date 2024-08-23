/// <summary>
/// Represents operations on vectors.
/// </summary>
class VectorMath
{
	/// <summary>
	/// Calculates the dot product of 2 vectors.
	/// </summary>
	/// <param name="vector1">2D or 3D vectors</param>
	/// <param name="vector2">2D or 3D vectors</param>
	/// <returns>-1 or the dot product.</returns>
	public static double DotProduct(double[] vector1, double[] vector2)
	{
		if ((vector1.Length != 2 && vector1.Length != 3) || (vector2.Length != 2 && vector2.Length != 3) || (vector1.Length != vector2.Length))
			return -1;

		double dotProduct = 0;

		for (int i = 0; i < vector1.Length; i++)
			dotProduct += vector1[i] * vector2[i];

		return dotProduct;
	}
}
