using ContextChainingExample.MenuBuilding;

namespace ContextChainingExample.MenuBuilderHandlers;

internal class AdminAreaMenuBuilderHandler : IMenuBuilderHandler
{
    public ValueTask Handle(MenuBuilderContext context)
    {
        if (!context.User.IsInRole("Admin"))
            context.Menu.AdminArea.IsVisible = false;

        return ValueTask.CompletedTask;
    }
}