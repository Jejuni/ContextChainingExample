using System.Security.Claims;

namespace ContextChainingExample.MenuBuilding;

internal class MenuBuilderContext
{
    public Menu Menu { get; } = new();
    public required ProjectInformation ProjectInformation { get; init; }
    public required ClaimsPrincipal User { get; init; }
}