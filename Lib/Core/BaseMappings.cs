namespace HajurKoCarRental.Lib.Core;

public abstract class BaseMappings
{
    // creating a separate method instead of letting children add mappings to customer
    // since someone who hasnt worked with the codebase may not know what exactly happening
    // and not add mappings to the constructor. a separate method with this name would help
    public abstract void AddMappings(WebApplication app);
}