using System;
using System.Text.Json.Serialization;

namespace InventoryLibrary
{
    /// <summary>
    /// Represents the class all the other will inherit from.
    /// </summary>
    public class BaseClass
    {
        /// <summary>
        /// Gets or sets the id of the object.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the date and hour the object was created
        /// </summary>
        [JsonPropertyName("date_created")]
        public DateTime Date_created { get; set; }

        /// <summary>
        /// Gets or sets the modification date and hour of the object.
        /// </summary>
        [JsonPropertyName("date_updated")]
        public DateTime Date_updated { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public BaseClass()
        {
            Id = Guid.NewGuid().ToString();
            Date_created = DateTime.Now;
            Date_updated = Date_created;
        }

        /// <summary>
        /// Updates the date updated of the
        /// </summary>
        /// <param name="_">Unused parameter</param>
        public virtual void UpdateProperties(string[] _) => Date_updated = DateTime.Now;
    }
}
