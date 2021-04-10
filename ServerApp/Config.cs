using System.Collections.Generic;
using IdentityServer4.Models;

namespace ServerApp
{
    public class Config
    {
        // clients that are allowed to access resources from the Auth server
        public static IEnumerable<Client> GetClients()
        {
            // client credentials
            return new List<Client>
            {
                new Client
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = { "api1" }
                }
            };
        }

        // API that are allowed to access the Auth server
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new[]
            {
                new ApiResource("api1", "My API")
            };
        }

        // Scopes that are allowed to access the Auth server
        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new[]
            {
                new ApiScope(name: "api1",   displayName: "Access API Backend")
            };
        }
    }
}
