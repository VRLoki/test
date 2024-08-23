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

    /// <summary>
    /// Apply a <paramref name="modifier"/> to the <paramref name="baseValue"/>.
    /// </summary>
    /// <param name="baseValue">Damage taken or healed</param>
    /// <param name="modifier">Modifier value to apply</param>
    /// <returns>The value multiplied by a multiplier.</returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue * 0.5f;
            case Modifier.Base:
                return baseValue;
            case Modifier.Strong:
                return baseValue * 1.5f;
            default:
                return 0.0f;
        }
    }
}

/// <summary>
/// Calculates the new value.
/// </summary>
/// <param name="baseValue">Value without the modifier</param>
/// <param name="modifier">Modifier to apply.</param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Represents the "power" of the value taken or healed.
/// </summary>
public enum Modifier
{
    ///<summary>Weakens the value</summary>
    Weak,
    ///<summary>Applies no change to the value</summary>
    Base,
    ///<summary>Strengthens the value</summary>
    Strong
}
