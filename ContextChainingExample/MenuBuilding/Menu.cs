namespace ContextChainingExample.MenuBuilding;

internal record Menu
{
    public MenuEntry Home { get; } = new() { Icon = "home", Path = "/home", TrafficLightState = "red" };
    public MenuEntry Project { get; } = new() { Icon = "project", Path = "/project", TrafficLightState = "red" };
    public MenuEntry Approval { get; } = new() { Icon = "approval", Path = "/approval", TrafficLightState = "red" };
    public MenuEntry AdminArea { get; } = new() { Icon = "admin", Path = "/admin", TrafficLightState = "red" };
}

internal record MenuEntry
{
    public bool IsVisible { get; set; } = true;
    public required string Icon { get; set; }
    public required string Path { get; set; }
    public required string TrafficLightState { get; set; }
}