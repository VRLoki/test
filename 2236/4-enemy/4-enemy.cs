using System;

namespace Enemies
{
	/// <summary>
	/// Represents a zombie enemy
	/// </summary>
	class Zombie
	{
		private int health;
		private string name = "(No name)";

		/// <summary>
		/// Gets or sets the name of the zombie.
		/// </summary>
		/// <value>Name of the zombie</value>
		public string Name { get => name; set => name = value; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Zombie"/>class.
		/// </summary>
		public Zombie() => health = 0;

		/// <summary>
		/// Initializes a new instance of the <see cref="Zombie"/>class with a health value.
		/// </summary>
		/// <param name="value">Health value to give to the zombie.</param>
		/// <exception cref="ArgumentException"><paramref name="value"/> is negative.</exception>
		public Zombie(int value)
		{
			health = value >= 0 ? value : throw new ArgumentException("Health must be greater than or equal to 0");
		}

		/// <summary>
		/// Get the health of the zombie instance.
		/// </summary>
		/// <returns>The health value.</returns>
		public int GetHealth() => health;
	}
}
