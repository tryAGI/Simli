
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

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "x-simli-api-key")
                {
                    Authorizations.RemoveAt(i);
                }
            }

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