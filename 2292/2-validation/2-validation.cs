using System;

/// <summary>
/// Represents the player character.
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="name">Name of the player</param>
    /// <param name="maxHp">Max health of the player</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp < 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }

        this.name = name;
        this.maxHp = maxHp;
        hp = maxHp;
    }

    /// <summary>
    /// Prints the current health of the player
    /// </summary>
    public void PrintHealth() => Console.WriteLine($"{name} has {hp} / {maxHp} health");

    /// <summary>
    /// Calculates the health.
    /// </summary>
    /// <param name="amount">Amount to calculate the health with</param>
    /// <returns>The new health value</returns>
    delegate float CalculateHealth(float amount);

    /// <summary>
    /// Inflicts the player of <paramref name="damage"/> amount.
    /// </summary>
    /// <param name="damage">Damage value</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            damage = 0;
        Console.WriteLine($"{name} takes {damage} damage!");
        CalculateHealth calculateHealth = hit => { return hp - hit; };
        ValidateHP(calculateHealth(damage));
    }

    /// <summary>
    /// Heals the player of <paramref name="heal"/> amount.
    /// </summary>
    /// <param name="heal">Heal value</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;
        Console.WriteLine($"{name} heals {heal} HP!");
        CalculateHealth calculateHealth = life => { return hp + life; };
        ValidateHP(calculateHealth(heal));
    }

    /// <summary>
    /// Checks the new health.
    /// </summary>
    /// <param name="newHp">New health of the player</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            hp = 0;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;
    }
}
