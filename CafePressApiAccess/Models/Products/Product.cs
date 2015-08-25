namespace CafePressApiAccess.Models.Products
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// Class Product.
    /// </summary>
    [XmlType("product")]
    public class Product
    {
        /// <summary>
        /// Gets or sets the base price.
        /// </summary>
        /// <value>The base price.</value>
        [XmlAttribute("basePrice")]
        public string BasePrice { get; set; }

        /// <summary>
        /// Gets or sets the category caption.
        /// </summary>
        /// <value>The category caption.</value>
        [XmlAttribute("categoryCaption")]
        public string CategoryCaption { get; set; }

        /// <summary>
        /// Gets or sets the category identifier.
        /// </summary>
        /// <value>The category identifier.</value>
        [XmlAttribute("categoryId")]
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the currency code.
        /// </summary>
        /// <value>The currency code.</value>
        [XmlAttribute("currencyCode")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets the currency symbol.
        /// </summary>
        /// <value>The currency symbol.</value>
        [XmlAttribute("currencySymbol")]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Gets or sets the default product URI.
        /// </summary>
        /// <value>The default product URI.</value>
        [XmlAttribute("defaultProductUri")]
        public string DefaultProductUri { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [XmlAttribute("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [XmlAttribute("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is audio cd.
        /// </summary>
        /// <value><c>true</c> if this instance is audio cd; otherwise, <c>false</c>.</value>
        [XmlAttribute("isAudioCD")]
        public bool IsAudioCd { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is book.
        /// </summary>
        /// <value><c>true</c> if this instance is book; otherwise, <c>false</c>.</value>
        [XmlAttribute("isBook")]
        public bool IsBook { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is calendar.
        /// </summary>
        /// <value><c>true</c> if this instance is calendar; otherwise, <c>false</c>.</value>
        [XmlAttribute("isCalendar")]
        public bool IsCalendar { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is cd.
        /// </summary>
        /// <value><c>true</c> if this instance is cd; otherwise, <c>false</c>.</value>
        [XmlAttribute("isCD")]
        public bool IsCd { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is poster.
        /// </summary>
        /// <value><c>true</c> if this instance is poster; otherwise, <c>false</c>.</value>
        [XmlAttribute("isPoster")]
        public bool IsPoster { get; set; }

        /// <summary>
        /// Gets or sets the marketplace price.
        /// </summary>
        /// <value>The marketplace price.</value>
        [XmlAttribute("marketplacePrice")]
        public string MarketplacePrice { get; set; }

        /// <summary>
        /// Gets or sets the merchandise availability.
        /// </summary>
        /// <value>The merchandise availability.</value>
        [XmlAttribute("merchandiseAvailability")]
        public string MerchandiseAvailability { get; set; }

        /// <summary>
        /// Gets or sets the merchandise identifier.
        /// </summary>
        /// <value>The merchandise identifier.</value>
        [XmlAttribute("merchandiseId")]
        public int MerchandiseId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the section identifier.
        /// </summary>
        /// <value>The section identifier.</value>
        [XmlAttribute("sectionId")]
        public int SectionId { get; set; }

        /// <summary>
        /// Gets or sets the sell price.
        /// </summary>
        /// <value>The sell price.</value>
        [XmlAttribute("sellPrice")]
        public string SellPrice { get; set; }

        /// <summary>
        /// Gets or sets the short caption.
        /// </summary>
        /// <value>The short caption.</value>
        [XmlAttribute("shortCaption")]
        public string ShortCaption { get; set; }

        /// <summary>
        /// Gets or sets the stock availability.
        /// </summary>
        /// <value>The stock availability.</value>
        [XmlAttribute("stockAvailability")]
        public string StockAvailability { get; set; }

        /// <summary>
        /// Gets or sets the store identifier.
        /// </summary>
        /// <value>The store identifier.</value>
        [XmlAttribute("storeId")]
        public string StoreId { get; set; }

        /// <summary>
        /// Gets or sets the store URI.
        /// </summary>
        /// <value>The store URI.</value>
        [XmlAttribute("storeUri")]
        public string StoreUri { get; set; }

        /// <summary>
        /// Gets or sets the colors.
        /// </summary>
        /// <value>The colors.</value>
        [XmlElement("color")]
        public List<ProductColor> Colors { get; set; }

        /// <summary>
        /// Gets or sets the sizes.
        /// </summary>
        /// <value>The sizes.</value>
        [XmlElement("size")]
        public List<ProductSize> Sizes { get; set; }

        /// <summary>
        /// Gets or sets the product images.
        /// </summary>
        /// <value>The product images.</value>
        [XmlElement("productImage")]
        public List<ProductImage> ProductImages { get; set; }
    }
}
