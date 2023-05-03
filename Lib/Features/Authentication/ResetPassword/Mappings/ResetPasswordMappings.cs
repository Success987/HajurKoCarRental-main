using HajurKoCarRental.Lib.Core;
using HajurKoCarRental.Lib.Routing;

namespace HajurKoCarRental.Lib.Features.Authentication.ResetPassword.Mappings;

internal class ResetPasswordMappings : BaseMappings
{
    public override void AddMappings(WebApplication app)
    {
        app.MapPost(Routes.ForgotPasswordRoute, () => "Hello World!");
        app.MapPost(Routes.ResetPasswordRoute, () => "Hello World!");
    }
}