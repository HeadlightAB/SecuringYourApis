using IdentityServer4.Models;

namespace IdSrv
{
    public class IdStore
    {
        public static Client[] Clients { get; } = {
            new Client
            {
                AllowedScopes = new[] {"public.api.read"},
                ClientId = "weatherTV",
                ClientSecrets = new[] {new Secret("secret.password.for.weathertv".Sha256())},
                AllowedGrantTypes = GrantTypes.ClientCredentials
            },
            new Client
            {
                AllowedScopes = new[] {"public.api.write"},
                ClientId = "observerX",
                ClientSecrets = new[] {new Secret("secret.password.for.observer".Sha256())},
                AllowedGrantTypes = GrantTypes.ClientCredentials
            }
        };

        public static ApiResource[] ApiResources { get; } =
        {
            new ApiResource("public.api")
            {
                Scopes = new[]
                {
                    new Scope("public.api.read"),
                    new Scope("public.api.write"),
                }
            }
        };
    }
}