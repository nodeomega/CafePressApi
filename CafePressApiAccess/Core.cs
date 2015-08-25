namespace CafePressApiAccess
{
    using System;
    using System.IO;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Serialization;

    using CafePressApiAccess.Models.Products;

    using JetBrains.Annotations;

    using Newtonsoft.Json;

    using Formatting = Newtonsoft.Json.Formatting;

    /// <summary>
    /// Class Core.
    /// </summary>
    public class Core
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Core" /> class.
        /// </summary>
        /// <param name="apiKey">The API token.</param>
        /// <param name="baseUrl">The base URL.</param>
        /// <exception cref="System.ArgumentNullException">
        /// apiToken
        /// or
        /// accept
        /// or
        /// baseUrl
        /// </exception>
        public Core([NotNull] string apiKey, [NotNull] string baseUrl)
        {
            if (apiKey == null)
            {
                throw new ArgumentNullException("apiKey");
            }

            if (baseUrl == null)
            {
                throw new ArgumentNullException("baseUrl");
            }

            this.ApiKey = apiKey;
            this.BaseUrl = baseUrl;
        }

        /// <summary>
        /// Gets or sets the API token.
        /// </summary>
        /// <value>The API token.</value>
        [NotNull]
        protected string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the base URL.
        /// </summary>
        /// <value>The base URL.</value>
        [NotNull]
        protected string BaseUrl { get; set; }

        /////// <summary>
        /////// Gets the authentication header.
        /////// </summary>
        /////// <returns>The Authorization Token line for the request.</returns>
        ////protected string GetAuthHeader()
        ////{
        ////    return string.Format("Token token={0}", this.ApiKey);
        ////}

        /// <summary>
        /// run request as an asynchronous operation.
        /// </summary>
        /// <param name="resource">The resource.</param>
        /// <param name="requestMethod">The request method.</param>
        /// <param name="body">The body.</param>
        /// <param name="xmlRootAttribute">The XML root attribute.</param>
        /// <returns>Task&lt;RequestResult&gt;.</returns>
        public async Task<RequestResult> RunRequestAsync(string resource, string requestMethod, object body = null, string xmlRootAttribute = null)
        {
            var requestUrl = this.BaseUrl;
            if (!requestUrl.EndsWith("/"))
            {
                requestUrl += "/";
            }

            requestUrl += resource;

            var req = WebRequest.Create(requestUrl) as HttpWebRequest;

            // GET POST PUT DELETE
            req.Method = requestMethod;

            if (body != null)
            {
                var json = JsonConvert.SerializeObject(
                    body,
                    new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                byte[] formData = Encoding.UTF8.GetBytes(json);

                var requestStream = Task.Factory.FromAsync(
                    req.BeginGetRequestStream,
                    asyncResult => req.EndGetRequestStream(asyncResult),
                    null);

                var dataStream =
                    await requestStream.ContinueWith(t => t.Result.WriteAsync(formData, 0, formData.Length));
                Task.WaitAll(dataStream);
            }

            var task = Task.Factory.FromAsync(
                req.BeginGetResponse,
                asyncResult => req.EndGetResponse(asyncResult),
                null);

            return await task.ContinueWith(
                t =>
                    {
                        var httpWebResponse = t.Result as HttpWebResponse;

                        return new RequestResult
                                   {
                                       Content = ReadStreamFromResponse(httpWebResponse),
                                       HttpStatusCode = httpWebResponse.StatusCode
                                   };
                    });
        }

        /// <summary>
        /// Reads the stream from response.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <returns>A System.String.</returns>
        private static string ReadStreamFromResponse(WebResponse response)
        {
            using (var responseStream = response.GetResponseStream())
            using (var sr = new StreamReader(responseStream))
            {
                // Need to return this response 
                var strContent = sr.ReadToEnd();
                return strContent;
            }
        }

        /// <summary>
        /// run request as an asynchronous operation.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="resource">The resource.</param>
        /// <param name="requestMethod">The request method.</param>
        /// <param name="body">The body.</param>
        /// <param name="xmlRootAttribute">The XML root attribute.</param>
        /// <returns>A Task&lt;T&gt;.</returns>
        public async Task<T> RunRequestAsync<T>(string resource, string requestMethod, object body = null, string xmlRootAttribute = null)
        {
            var response = await this.RunRequestAsync(resource, requestMethod, body, xmlRootAttribute);
            var obj = Task.Factory.StartNew(() => (T)new XmlSerializer(typeof(T), new XmlRootAttribute(xmlRootAttribute)).Deserialize(new StringReader(response.Content)));    // JsonConvert.DeserializeObject<T>(JsonConvert.SerializeXNode(XDocument.Parse(response.Content).Root, Formatting.None, true)));
            return await obj;
        }

        /// <summary>
        /// generic post as an asynchronous operation.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="resource">The resource.</param>
        /// <param name="body">The body.</param>
        /// <param name="xmlRootAttribute">The XML root attribute.</param>
        /// <returns>A Task&lt;T&gt;.</returns>
        protected async Task<T> GenericPostAsync<T>(string resource, object body = null, string xmlRootAttribute = null)
        {
            var res = this.RunRequestAsync<T>(resource, "POST", body);
            return await res;
        }

        /// <summary>
        /// generic get as an asynchronous operation.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="resource">The resource.</param>
        /// <param name="xmlRootAttribute">The XML root attribute.</param>
        /// <returns>A Task&lt;T&gt;.</returns>
        protected async Task<T> GenericGetAsync<T>(string resource, string xmlRootAttribute = null)
        {
            var res = this.RunRequestAsync<T>(resource, "GET", null, xmlRootAttribute);
            return await res;
        }
    }
}
 