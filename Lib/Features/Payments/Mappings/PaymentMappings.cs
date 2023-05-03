using HajurKoCarRental.Lib.Core;
using HajurKoCarRental.Lib.Routing;

namespace HajurKoCarRental.Lib.Features.Payments.Mappings;

internal class PaymentMappings : BaseMappings
{
    public override void AddMappings(WebApplication app)
    {
        app.MapPost(Routes.PaymentsRoute, () => "Hello World!");
        app.MapGet(Routes.PaymentsRoute, () => "Hello World!");
        app.MapGet(Routes.PaymentRoute, () => "Hello World!");
    }
}