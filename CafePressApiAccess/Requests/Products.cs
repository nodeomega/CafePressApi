namespace CafePressApiAccess.Requests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using CafePressApiAccess.Models.Products;

    public class Products : Core, IProducts
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Core" /> class.
        /// </summary>
        /// <param name="apiKey">The API token.</param>
        /// <param name="baseUrl">The base URL.</param>
        public Products(string apiKey, string baseUrl)
            : base(apiKey, baseUrl)
        {
        }

        /// <summary>
        /// Searches the by section identifier.
        /// </summary>
        /// <param name="StoreId">The store identifier.</param>
        /// <param name="SectionId">The section identifier.</param>
        /// <returns>Task&lt;IList&lt;Product&gt;&gt;.</returns>
        public async Task<List<Product>> SearchByStoreAndSectionId(string StoreId, int SectionId)
        {
            var res = string.Format(
                "{0}?v=3&appKey={1}&storeId={2}&sectionId={3}",
                "product.listByStoreSection.cp",
                this.ApiKey,
                StoreId,
                SectionId);
            return await this.GenericGetAsync<List<Product>>(res, "products");
        }
    }
}
