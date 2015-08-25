namespace CafePressApiAccess
{
    using System.Net;

    using JetBrains.Annotations;

    /// <summary>
    /// Class RequestResult.
    /// </summary>
    public class RequestResult
    {
        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>The content.</value>
        [NotNull]
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the HTTP status code.
        /// </summary>
        /// <value>The HTTP status code.</value>
        public HttpStatusCode HttpStatusCode { get; set; }
    }
}
