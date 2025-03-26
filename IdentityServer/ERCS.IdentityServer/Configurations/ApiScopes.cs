using Duende.IdentityServer.Models;

namespace ERCS.IdentityServer.Configurations
{
    public static class ApiScopes
    {
        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
            {
                new ApiScope("api.read", "Read access to the API"),
                new ApiScope("api.write", "Write access to the API")
            };
        }
    }
}
