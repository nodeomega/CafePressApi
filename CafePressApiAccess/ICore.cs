namespace CafePressApiAccess
{
    using System.Threading.Tasks;

    /// <summary>
    /// Interface ICore
    /// </summary>
    public interface ICore
    {
        /// <summary>
        /// Runs the request asynchronous.
        /// </summary>
        /// <typeparam name="T">The entity Type</typeparam>
        /// <param name="resource">The resource.</param>
        /// <param name="requestMethod">The request method.</param>
        /// <param name="body">The body.</param>
        /// <param name="xmlRootAttribute">The XML root attribute.</param>
        /// <returns>A Task&lt;T&gt;.</returns>
        Task<T> RunRequestAsync<T>(string resource, string requestMethod, object body = null, string xmlRootAttribute = null);

        /// <summary>
        /// Runs the request asynchronous.
        /// </summary>
        /// <param name="resource">The resource.</param>
        /// <param name="requestMethod">The request method.</param>
        /// <param name="body">The body.</param>
        /// <param name="xmlRootAttribute">The XML root attribute.</param>
        /// <returns>A Task&lt;RequestResult&gt;.</returns>
        Task<RequestResult> RunRequestAsync(string resource, string requestMethod, object body = null, string xmlRootAttribute = null);
    }
}
