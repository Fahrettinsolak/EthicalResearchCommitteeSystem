using Duende.IdentityServer.Models;

namespace ERCS.IdentityServer.Configurations
{
    public static class IdentityResources
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new Duende.IdentityServer.Models.IdentityResources.OpenId(),
                new Duende.IdentityServer.Models.IdentityResources.Profile()
            };
        }
    }
}