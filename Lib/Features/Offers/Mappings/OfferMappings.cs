using HajurKoCarRental.Lib.Core;
using HajurKoCarRental.Lib.Routing;

namespace HajurKoCarRental.Lib.Features.Offers.Mappings;

internal class OfferMappings : BaseMappings
{
    public override void AddMappings(WebApplication app)
    {
        app.MapGet(Routes.OffersRoute, () => "Hello World!");
        app.MapPost(Routes.OffersRoute, () => "Hello World!");
        app.MapGet(Routes.OfferRoute, () => "Hello World!");
    }
}