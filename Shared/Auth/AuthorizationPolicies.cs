using System.Security.Claims;
using Microsoft.Extensions.DependencyInjection;

namespace Shared.Auth;

public static class AuthorizationPolicies
{
    public static void AddPolicies(IServiceCollection services)
    {
        services.AddAuthorizationCore(options =>
        {
            options.AddPolicy("MustBeAdmin", a =>
                a.RequireAuthenticatedUser().RequireClaim(ClaimTypes.Role, "Admin"));
            options.AddPolicy("MustBeCustomer", a =>
                a.RequireAuthenticatedUser().RequireClaim(ClaimTypes.Role, "Customer"));
            options.AddPolicy("MustBeUser", a =>
                a.RequireAuthenticatedUser().RequireClaim(ClaimTypes.Role, "User"));
        });
    }
}