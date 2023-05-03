using HajurKoCarRental.Lib.Core;
using HajurKoCarRental.Lib.Routing;

namespace HajurKoCarRental.Lib.Features.Cars.Mappings;

internal class CarMappings : BaseMappings
{
    public override void AddMappings(WebApplication app)
    {
        app.MapGet(Routes.CarsRoute, () => "Hello World!");
        app.MapGet(Routes.CarRoute, () => "Hello World!");
        app.MapPut(Routes.CarRoute, () => "Hello World!");
        app.MapDelete(Routes.CarRoute, () => "Hello World!");
    }
}