using HajurKoCarRental.Lib.Core;
using HajurKoCarRental.Lib.Routing;

namespace HajurKoCarRental.Lib.Features.Authentication.Register.Mappings;

public class RegisterMappings : BaseMappings
{
    public override void AddMappings(WebApplication app)
    {
        app.MapPost(Routes.RegisterRoute, () => "R");
    }
}