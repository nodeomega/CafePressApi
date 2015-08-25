namespace CafePressApiAccess.Models.Products
{
    using System.Xml.Serialization;

    /// <summary>
    /// Class ProductColor.
    /// </summary>
    [XmlType("size")]
    public class ProductSize
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [XmlAttribute("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <value>The full name.</value>
        [XmlAttribute("fullName")]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the short name.
        /// </summary>
        /// <value>The short name.</value>
        [XmlAttribute("shortName")]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is default.
        /// </summary>
        /// <value><c>true</c> if this instance is default; otherwise, <c>false</c>.</value>
        [XmlAttribute("default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or sets the sell price.
        /// </summary>
        /// <value>The sell price.</value>
        [XmlAttribute("displaySellPrice")]
        public string SellPrice { get; set; }
    }
}
