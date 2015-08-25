namespace CafePressApiAccess.Models.Products
{
    using System.Xml.Serialization;

    /// <summary>
    /// Class ProductImage.
    /// </summary>
    [XmlType("productImage")]
    public class ProductImage
    {
        /// <summary>
        /// Gets or sets the color identifier.
        /// </summary>
        /// <value>The color identifier.</value>
        [XmlAttribute("colorId")]
        public int ColorId { get; set; }

        /// <summary>
        /// Gets or sets the name of the perspective.
        /// </summary>
        /// <value>The name of the perspective.</value>
        [XmlAttribute("perspectiveName")]
        public string PerspectiveName { get; set; }

        /// <summary>
        /// Gets or sets the size of the image.
        /// </summary>
        /// <value>The size of the image.</value>
        [XmlAttribute("imageSize")]
        public int ImageSize { get; set; }

        /// <summary>
        /// Gets or sets the product URL.
        /// </summary>
        /// <value>The product URL.</value>
        [XmlAttribute("productUrl")]
        public string ProductUrl { get; set; }
    }
}
