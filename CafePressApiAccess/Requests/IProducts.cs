namespace CafePressApiAccess.Requests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using CafePressApiAccess.Models.Products;

    public interface IProducts : ICore
    {
        /// <summary>
        /// Searches the by section identifier.
        /// </summary>
        /// <param name="SectionId">The section identifier.</param>
        /// <returns>Task&lt;IList&lt;Product&gt;&gt;.</returns>
        Task<List<Product>> SearchByStoreAndSectionId(string StoreId, int SectionId);
    }
}
