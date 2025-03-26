using Duende.IdentityServer.Models;

namespace ERCS.IdentityServer.Configurations
{
    public static class Clients
    {
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>()
            {
                new Client
                {
                    ClientId = "test-client",
                    ClientSecrets = { new Secret("secret".Sha256()) },
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "api.read" }
                }
            };
        }
    }
}
