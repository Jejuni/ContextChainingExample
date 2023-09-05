using ContextChainingExample.MenuBuilding;

namespace ContextChainingExample.MenuBuilderHandlers;

internal interface IMenuBuilderHandler
{
    ValueTask Handle(MenuBuilderContext context);
}