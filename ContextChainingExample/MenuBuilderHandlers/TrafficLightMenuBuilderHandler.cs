using ContextChainingExample.MenuBuilding;

namespace ContextChainingExample.MenuBuilderHandlers;

internal class TrafficLightMenuBuilderHandler : IMenuBuilderHandler
{
    public ValueTask Handle(MenuBuilderContext context)
    {
        // Some logic to figure out state...
        if (context.ProjectInformation.State == "SomeStateProbablyAsAnEnum")
        {
            context.Menu.Home.TrafficLightState = "green";
            context.Menu.Project.TrafficLightState = "green";
            context.Menu.Approval.TrafficLightState = "yellow";
        }

        return ValueTask.CompletedTask;
    }
}