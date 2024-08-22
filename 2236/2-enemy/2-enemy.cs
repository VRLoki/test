using System;

namespace Enemies
{
	/// <summary>
	/// Represents a zombie enemy
	/// </summary>
	class Zombie
	{
		/// <summary>
		/// Represents the zombie's life.
		/// </summary>
		public int health;

		/// <summary>
		/// Initializes a new instance of the <see cref="Zombie"/>class.
		/// </summary>
		public Zombie() => health = 0;

		/// <summary>
		/// Initializes a new instance of the <see cref="Zombie"/>class. Value must be greater or equal to 0 or an ArgumentException is thrown.
		/// </summary>
		/// <param name="value">Health value to set the zombie to.</param>
		/// <exception cref="ArgumentException"><paramref name="value"/> is negative</exception>
		public Zombie(int value)
		{
			health = value >= 0 ? value : throw new ArgumentException("Health must be greater than or equal to 0");
		}
	}
}
