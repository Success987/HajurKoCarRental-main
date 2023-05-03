using HajurKoCarRental.Lib.Core;
using HajurKoCarRental.Lib.Routing;

namespace HajurKoCarRental.Lib.Features.Authentication.Login.Mappings;

internal class LoginMappings : BaseMappings
{
    public override void AddMappings(WebApplication app)
    {
        app.MapGet(Routes.LoginRoute, () => "Hello World!");
    }
}