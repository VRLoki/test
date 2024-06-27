using System;
using System.Linq;
using System.Text.Json.Serialization;
using InventoryLibrary;

/// <summary>
/// Represents the inventory.
/// </summary>
public class Inventory : BaseClass
{
    /// <summary>
    /// Gets or sets the id of the user inputing the item.
    /// </summary>
    [JsonPropertyName("user_id")]
    public string User_id { get; set; }

    /// <summary>
    /// Gets or sets the id of item inputed.
    /// </summary>
    [JsonPropertyName("item_id")]
    public string Item_id { get; set; }

    /// <summary>
    /// Gets or sets the quantity of the item.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }

    /// <summary>
    /// Parameterless constructor used when loading the JSON file.
    /// </summary>
    public Inventory() { }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="properties">List of properties</param>
    public Inventory(string[] properties)
    {
        for (int i = 0; i < properties.Length; i += 2)
        {
            string propertyName = properties[i].ToLower();
            string propertyValue = properties[i + 1];

            switch (propertyName)
            {
                case "user_id":
                    User_id = propertyValue;
                    break;
                case "item_id":
                    Item_id = propertyValue;
                    break;
                case "quantity":
                    if (int.TryParse(propertyValue, out int quantity) && quantity > 0)
                        Quantity = quantity;
                    else
                        Quantity = 1;
                    break;
                default:
                    continue;
            }
        }
        if (!properties.Any(prop => prop.Equals("quantity", StringComparison.OrdinalIgnoreCase)))
            Quantity = 1;
    }

    /// <summary>
    /// Update the properties of the instance.
    /// </summary>
    /// <param name="properties">List of properties to update</param>
    public override void UpdateProperties(string[] properties)
    {
        for (int i = 0; i < properties.Length; i += 2)
        {
            string propertyName = properties[i].ToLower();
            string propertyValue = properties[i + 1];

            switch (propertyName)
            {
                case "user_id":
                    User_id = propertyValue;
                    break;
                case "item_id":
                    Item_id = propertyValue;
                    break;
                case "quantity":
                    if (int.TryParse(propertyValue, out int quantity) && quantity > 0)
                        Quantity = quantity;
                    else
                        Quantity = 1;
                    break;
                default:
                    continue;
            }
        }
        base.UpdateProperties(properties);
    }
}
