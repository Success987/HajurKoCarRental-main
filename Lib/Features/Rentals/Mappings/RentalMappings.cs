using HajurKoCarRental.Lib.Core;
using HajurKoCarRental.Lib.Routing;

namespace HajurKoCarRental.Lib.Features.Rentals.Mappings;

internal class RentalMappings : BaseMappings
{
    public override void AddMappings(WebApplication app)
    {
        app.MapGet(Routes.RentalsRoute, () => "Hello World!");
        app.MapPost(Routes.RentalsRoute, () => "Hello World!");
        app.MapGet(Routes.RentalRoute, (int id, int page) => $"Hello World! {id} {page}");
        app.MapPut(Routes.RentalRoute, () => "Hello World!");
        app.MapDelete(Routes.RentalRoute, () => "Hello World!");
    }
}