namespace CafePressApiAccess.Models.Products
{
    using System.Xml.Serialization;

    /// <summary>
    /// Class ProductColor.
    /// </summary>
    [XmlType("color")]
    public class ProductColor
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
        /// Gets or sets a value indicating whether this instance is default.
        /// </summary>
        /// <value><c>true</c> if this instance is default; otherwise, <c>false</c>.</value>
        [XmlAttribute("default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is allowed.
        /// </summary>
        /// <value><c>true</c> if this instance is allowed; otherwise, <c>false</c>.</value>
        [XmlAttribute("allowed")]
        public bool IsAllowed { get; set; }

        /// <summary>
        /// Gets or sets the color swatch URL.
        /// </summary>
        /// <value>The color swatch URL.</value>
        [XmlAttribute("colorSwatchUrl")]
        public string ColorSwatchUrl { get; set; }
    }
}
