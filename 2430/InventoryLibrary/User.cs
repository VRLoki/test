using InventoryLibrary;
using System.Text.Json.Serialization;

/// <summary>
/// Represents a user.
/// </summary>
public class User : BaseClass
{
    /// <summary>
    /// Gets or sets the name of the user.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Parameterless constructor used when loading the JSON file.
    /// </summary>
    public User() {}

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="name">Name of the user</param>
    public User(string name) : base() => Name = name.Trim('\"');

    /// <summary>
    /// Update the properties of the instance.
    /// </summary>
    /// <param name="properties">List of properties to update</param>
    public override void UpdateProperties(string[] properties)
    {
        Name = properties[1].Trim('\"');
        base.UpdateProperties(properties);
    }
}
