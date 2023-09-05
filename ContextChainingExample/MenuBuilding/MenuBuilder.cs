using System.Security.Claims;
using ContextChainingExample.MenuBuilderHandlers;

namespace ContextChainingExample.MenuBuilding;

internal class MenuBuilder
{
    private readonly IEnumerable<IMenuBuilderHandler> _handler;

    public MenuBuilder(IEnumerable<IMenuBuilderHandler> handler)
    {
        _handler = handler ?? throw new ArgumentNullException(nameof(handler));
    }

    public async Task Build(CancellationToken cancellationToken)
    {
        var context = await RetrieveContext(cancellationToken);
        foreach (var menuBuilderHandler in _handler)
        {
            await menuBuilderHandler.Handle(context);
        }

        var menu = context.Menu;
    }

    private async Task<MenuBuilderContext> RetrieveContext(CancellationToken cancellationToken)
    {
        // simulate loading stuff from database...
        await Task.Delay(1);
        var projInfo = new ProjectInformation
        {
            HasApproval = false,
            Id = Guid.NewGuid(),
            State = "SomeStateProbablyAsAnEnum"
        };

        var user = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
        {
            new("name", "boosd1"),
            new("http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Admin"),
        }));

        return new MenuBuilderContext
        {
            ProjectInformation = projInfo,
            User = user
        };
    }
}