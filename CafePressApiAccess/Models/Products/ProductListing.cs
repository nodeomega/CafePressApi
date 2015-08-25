namespace CafePressApiAccess.Models.Products
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// Class ProductListing.
    /// </summary>
    public class ProductListing : ListingBase
    {
        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        /// <value>The products.</value>
        [XmlArray("products"), XmlArrayItem(typeof(Product))]
        public List<Product> Products { get; set; }
    }
}
