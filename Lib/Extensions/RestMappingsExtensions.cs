using HajurKoCarRental.Lib.Core;

namespace HajurKoCarRental.Lib.Extensions;

internal static class RestMappingsExtensions
{
    public static void AddAppMappings(this WebApplication app)
    {
        app.MapGet("/", () => "Hello World!");

        _addMappings(app);

        app.MapFallback(() => "Not found");
    }

    public static void AddDevHelperPages(this WebApplication app)
    {
        if (!app.Environment.IsDevelopment()) return;

        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "HajurKoCarRental API V1"); });
    }

    private static void _addMappings(WebApplication app)
    {
        // Get the assembly that contains the BaseMappings class
        var baseMappingsType = typeof(BaseMappings);
        var assembly = baseMappingsType.Assembly;

        // Find all children of BaseMappings
        var derivedTypes = assembly.GetTypes().Where(t => t.IsSubclassOf(baseMappingsType));

        // Call AddMappings in each
        foreach (var derivedType in derivedTypes)
        {
            var instance = Activator.CreateInstance(derivedType);
            var method = derivedType.GetMethod("AddMappings");
            // ReSharper disable once CoVariantArrayConversion
            method?.Invoke(instance, new[] { app });
        }
    }
}