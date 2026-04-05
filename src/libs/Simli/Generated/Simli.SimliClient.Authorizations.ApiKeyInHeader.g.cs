
#nullable enable

namespace Simli
{
    public sealed partial class SimliClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Simli.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "x-simli-api-key",
                Value = apiKey,
            });
        }
    }
}