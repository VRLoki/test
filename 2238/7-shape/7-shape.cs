using System;

/// <summary>Represents a shape.</summary>
class Shape
{
	/// <summary>Calculates the area of the shape.</summary>
	/// <returns>An int value.</returns>
	public virtual int Area()
	{
		throw new NotImplementedException("Area() is not implemented");
	}
}

/// <summary>Represents the shape of a rectangle.</summary>
class Rectangle : Shape
{
	private int width;
	private int height;

	/// <summary>Gets or sets the width of the rectangle.</summary>
	/// <value>Width value.</value>
	public int Width
	{
		get => width;
		set
		{
			if (value < 0)
				throw new ArgumentException("Width must be greater than or equal to 0");
			width = value;
		}
	}

	/// <summary>Gets or sets the height of the rectangle.</summary>
	/// <value>Height value.</value>
	public int Height
	{
		get => height;
		set
		{
			if (value < 0)
				throw new ArgumentException("Height must be greater than or equal to 0");
			height = value;
		}
	}

	/// <summary>Calculates the area of the rectangle.</summary>
	/// <returns>The area value.</returns>
	public new int Area() => width * height;

	/// <summary>Represents the informations of the object as a string.</summary>
	/// <returns>The string containing the informations of the object.</returns>
	public override string ToString() => $"[Rectangle] {width} / {height}";
}
