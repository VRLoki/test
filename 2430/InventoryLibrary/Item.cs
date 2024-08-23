using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using InventoryLibrary;

/// <summary>
/// Represents an item.
/// </summary>
public class Item : BaseClass
{
    private float _price;

    /// <summary>
    /// Gets or sets the name of the item.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the description of the item.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the price of the item.
    /// </summary>
    [JsonPropertyName("price")]
    public float Price
    {
        get => _price;
        set => _price = (float)Math.Round(value, 2);
    }

    /// <summary>
    /// Gets or sets the tags of an item.
    /// </summary>
    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// Parameterless constructor used when loading the JSON file.
    /// </summary>
    public Item() { }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="properties">List of properties</param>
    public Item(string[] properties) : base()
    {
        for (int i = 0; i < properties.Length; i += 2)
        {
            string propertyName = properties[i].ToLower();
            string propertyValue = properties[i + 1];

            switch (propertyName)
            {
                case "name":
                    Name = propertyValue.Trim('\"');
                    break;
                case "description":
                    Description = propertyValue.Trim('\"');
                    break;
                case "price":
                    float.TryParse(propertyValue, out float price);
                    Price = price;
                    break;
                case "tags":
                    propertyValue = propertyValue.Trim('[', ']');
                    Tags = propertyValue.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(tag => tag.Trim().Trim('\'', '\"'))
                           .ToList();
                    break;
                default:
                    continue;
            }
        }
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
                case "name":
                    Name = propertyValue.Trim('\"');
                    break;
                case "description":
                    Description = propertyValue.Trim('\"');
                    break;
                case "price":
                    float.TryParse(propertyValue, out float price);
                    Price = price;
                    break;
                case "tags":
                    propertyValue = propertyValue.Trim('[', ']');
                    Tags = propertyValue.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(tag => tag.Trim().Trim('\'', '\"'))
                           .ToList();
                    break;
                default:
                    continue;
            }
        }
        base.UpdateProperties(properties);
    }
}
