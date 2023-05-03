using HajurKoCarRental.Lib.Core;
using HajurKoCarRental.Lib.Routing;

namespace HajurKoCarRental.Lib.Features.Damages.Mappings;

internal class DamageMappings : BaseMappings
{
    public override void AddMappings(WebApplication app)
    {
        app.MapPost(Routes.DamagesRoute, () => "Hello World!");
        app.MapGet(Routes.DamagesRoute, () => "Hello World!");
        app.MapGet(Routes.DamagesRoute, () => "Hello World!");
        app.MapPut(Routes.DamagesRoute, () => "Hello World!");
    }
}