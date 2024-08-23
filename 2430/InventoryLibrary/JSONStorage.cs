using System;
using System.Collections.Generic;
using System.Linq;
using InventoryLibrary;
using JSONStorageHelper;

/// <summary>
/// Represents the storage in a JSON file.
/// </summary>
public class JSONStorage
{
    private const string FILEPATH = "../storage/inventory_manager.json";
    private readonly Dictionary<string, BaseClass> Objects;

    /// <summary>
    /// Constructor.
    /// </summary>
    public JSONStorage() => Objects = new Dictionary<string, BaseClass>();

    /// <summary>
    /// Returns all the objects.
    /// </summary>
    /// <returns>The dictionary containing all the objects.</returns>
    public Dictionary<string, BaseClass> All(Type type = null)
    {
        if (type == null)
            return Objects;
        return Objects.Where(kvp => kvp.Value.GetType().Equals(type)).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    }

    /// <summary>
    /// Adds an object to the dictionary.
    /// </summary>
    /// <param name="obj">Object to add.</param>
    public void New(BaseClass obj) => Objects.Add(obj.GetType().Name + "." + obj.Id, obj);

    /// <summary>
    /// Saves all the objects in the JSON file.
    /// </summary>
    public void Save() => JSONStorageUtils.Save(Objects, FILEPATH);

    /// <summary>
    /// Loads all the objects from the JSON file.
    /// </summary>
    public void Load() => JSONStorageUtils.Load(Objects, FILEPATH);
}
