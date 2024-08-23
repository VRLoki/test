using System;

/// <summary>
/// Represents the base to build the classes.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Represents the name of the instance.
    /// </summary>
    public string name;

    /// <summary>
    /// Returns a string representation of the instance.
    /// </summary>
    /// <returns>The string representation of the instance.</returns>
    public override string ToString() => $"{name} is a {GetType()}";
}

/// <summary>
/// Represents an interactive object.
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Interacts with the object.
    /// </summary>
    void Interact();
}

/// <summary>
/// Represents a breakable object.
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Gets and sets the durability.
    /// </summary>
    /// <value>Durability value</value>
    int durability { get; set; }

    /// <summary>
    /// Breaks the breakable object
    /// </summary>
    void Break();
}

/// <summary>
/// Represents a collectable object.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Gets and sets if the collectable was collected.
    /// </summary>
    /// <value>True or False</value>
    bool isCollected { get; set; }

    /// <summary>
    /// Collects the collectable.
    /// </summary>
    void Collect();
}

/// <summary>
/// Represents an interactive door.
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Constructor for the Door class.
    /// </summary>
    /// <param name="name">Name of the door.</param>
    public Door(string name = "Door") => this.name = name;

    /// <summary>
    /// Interacts with the object.
    /// </summary>
    public void Interact() => Console.WriteLine($"You try to open the {name}. It's locked.");
}

/// <summary>
/// Represents a decoration object.
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// Defines if the decoration item is useful for the quest.
    /// </summary>
    public bool isQuestItem;

    /// <summary>
    /// Gets and sets the durability.
    /// </summary>
    /// <value>Durability value</value>
    public int durability { get; set; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="name">Name of the decoration</param>
    /// <param name="durability">Durability of the decoration</param>
    /// <param name="isQuestItem">Is the item important for the quest</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        this.name = name;

        if (durability < 0)
            throw new Exception("Durability must be greater than 0");

        this.durability = durability;

        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Interacts with the object.
    /// </summary>
    public void Interact()
    {
        if (durability > 0)
        {
            if (isQuestItem)
                Console.WriteLine($"You look at the {name}. There's a key inside.");
            else
                Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
        else
            Console.WriteLine($"The {name} has been broken.");
    }

    /// <summary>
    /// Breaks the breakable object
    /// </summary>
    public void Break()
    {
        durability--;

        if (durability > 0)
            Console.WriteLine($"You hit the {name}. It cracks.");
        else if (durability == 0)
            Console.WriteLine($"You smash the {name}. What a mess.");
        else
            Console.WriteLine($"The {name} is already broken.");
    }
}
