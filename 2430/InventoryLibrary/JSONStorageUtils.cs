using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using InventoryLibrary;

namespace JSONStorageHelper
{
    /// <summary>
    /// Utils to save and load from the JSON file
    /// </summary>
    public static class JSONStorageUtils
    {
        private static readonly Dictionary<string, Type> _typeMappings = new Dictionary<string, Type>
        {
            {"BaseClass", typeof(BaseClass)},
            { "Item", typeof(Item) },
            { "User", typeof(User) },
            { "Inventory", typeof(Inventory) }
        };

        /// <summary>
        /// Saves all the objects in the JSON file.
        /// </summary>
        /// <param name="objects">All the objects to save</param>
        /// <param name="filePath">Path to the JSON file</param>
        public static void Save(Dictionary<string, BaseClass> objects, string filePath)
        {
            if (!File.Exists(filePath))
                File.Create(filePath).Close();

            File.WriteAllText(filePath, JsonSerializer.Serialize(objects.ToDictionary(kvp => kvp.Key, kvp => MapToJsonObject(kvp.Value)), new JsonSerializerOptions { WriteIndented = true }));
        }

        /// <summary>
        /// Loads all the objects from the JSON file.
        /// </summary>
        /// <param name="objects">Dictionary where the objects are put</param>
        /// <param name="filePath">Path to the JSON file</param>
        public static void Load(Dictionary<string, BaseClass> objects, string filePath)
        {
            if (!File.Exists(filePath))
                return;

            string jsonString = File.ReadAllText(filePath);

            if (String.IsNullOrEmpty(jsonString))
                return;

            foreach (var jsonObject in JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(jsonString))
            {
                if (JsonSerializer.Deserialize(jsonObject.Value.GetRawText(), GetObjectTypeFromKey(jsonObject.Key)) is BaseClass baseObject)
                    objects[jsonObject.Key] = baseObject;
            }
        }

        /* Transforms the instance into a JSON string. */
        private static object MapToJsonObject(BaseClass obj)
        {
            Dictionary<string, object> jsonObject = new Dictionary<string, object>();

            foreach (var property in JsonSerializer.Deserialize<Dictionary<string, object>>(JsonSerializer.Serialize(obj, obj.GetType(), new JsonSerializerOptions { WriteIndented = true })))
                    jsonObject[property.Key] = property.Value;

            return jsonObject;
        }

        /* Returns the type of an instance based on its key. */
        private static Type GetObjectTypeFromKey(string key) => _typeMappings[key.Split('.')[0]];
    }
}
