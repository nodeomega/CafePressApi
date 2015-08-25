namespace CafePressApiAccess
{
    using System;

    using CafePressApiAccess.Requests;

    /// <summary>
    /// Class CafePressApi.
    /// </summary>
    public class CafePressApi : ICafePressApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CafePressApi"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="baseUrl">The base URL.</param>
        public CafePressApi(string apiKey, string baseUrl)
        {
            var formattedUrl = this.GetFormattedCafePressUrl(baseUrl).AbsoluteUri;

            this.Products = new Products(apiKey, baseUrl);

            this.CafePressUrl = formattedUrl;
        }

        /// <summary>
        /// Gets or sets the CafePress URL.
        /// </summary>
        /// <value>The CafePress URL.</value>
        public string CafePressUrl { get; set; }

        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        /// <value>The products.</value>
        public Products Products { get; set; }

        /// <summary>
        /// Gets the formatted CafePress URL.
        /// </summary>
        /// <param name="yourCafePressUrl">Your CafePress URL.</param>
        /// <returns>A Uri.</returns>
        protected Uri GetFormattedCafePressUrl(string yourCafePressUrl)
        {
            yourCafePressUrl = yourCafePressUrl.ToLower();

            if (!yourCafePressUrl.StartsWith("http://"))
            {
                yourCafePressUrl = "http://" + yourCafePressUrl;
            }

            return new Uri(yourCafePressUrl);
        }
    }
}
