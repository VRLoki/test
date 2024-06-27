/// <summary>
/// Represents the base to build the classes.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Gets the name of the instance.
    /// </summary>
    string name { get; }

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
/// Represents a test object.
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{

    /// <summary>
    /// Gets and sets the durability.
    /// </summary>
    /// <value>Durability value</value>
    public int durability { get; set; }

    /// <summary>
    /// Gets and sets if the collectable was collected.
    /// </summary>
    /// <value>True or False</value>
    public bool isCollected { get; set; }

    /// <summary>
    /// Gets and sets the name of the instance.
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Interacts with the object.
    /// </summary>
    public void Interact()
    {
    }

    /// <summary>
    /// Breaks the breakable object
    /// </summary>
    public void Break()
    {
    }

    /// <summary>
    /// Collects the collectable.
    /// </summary>
    public void Collect()
    {
    }

    /// <summary>
    /// Returns a string representation of the instance.
    /// </summary>
    /// <returns>The string representation of the instance.</returns>
    public override string ToString()
    {
        return base.ToString();
    }
}
