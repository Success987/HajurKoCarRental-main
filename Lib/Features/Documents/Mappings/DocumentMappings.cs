using HajurKoCarRental.Lib.Core;
using HajurKoCarRental.Lib.Routing;

namespace HajurKoCarRental.Lib.Features.Documents.Mappings;

internal class DocumentMappings : BaseMappings
{
    public override void AddMappings(WebApplication app)
    {
        app.MapPost(Routes.DocumentsUploadRoute, () => "Hello World!");
        app.MapGet(Routes.DocumentsDownloadRoute, () => "Hello World!");
    }
}