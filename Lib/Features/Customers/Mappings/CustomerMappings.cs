using HajurKoCarRental.Lib.Core;
using HajurKoCarRental.Lib.Routing;

namespace HajurKoCarRental.Lib.Features.Customers.Mappings;

internal class CustomerMappings : BaseMappings
{
    public override void AddMappings(WebApplication app)
    {
        app.MapGet(Routes.CustomersRoute, () => "Hello World!");
        app.MapGet(Routes.CustomerRoute, () => "Hello World!");
        app.MapPut(Routes.CustomerRoute, () => "Hello World!");
        app.MapDelete(Routes.CustomerRoute, () => "Hello World!");
    }
}