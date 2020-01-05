namespace EasyJamCore.API.ControllerHelpers
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    public static class ClientHelper
    {
        public static async Task<string> CallGET(string baseUri, string requestUri, string id = "")
        {
            string responseData;
            HttpClient client = null;
            try
            {
                using (client = new HttpClient(handler: new HttpClientHandler() { UseDefaultCredentials = true }))
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    Uri.TryCreate(new Uri(baseUri), $"{requestUri}{(string.IsNullOrEmpty(id) ? string.Empty : $"/{id}")}", out Uri fullRequestUri);

                    using (var response = await client.GetAsync(fullRequestUri).ConfigureAwait(false))
                    {
                        responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    }

                    return responseData;
                }
            }
            catch
            {
                client.Dispose();
                throw;
            }
            finally
            {
                if (client != null)
                {
                    client.Dispose();
                }
            }
        }
    }
}
