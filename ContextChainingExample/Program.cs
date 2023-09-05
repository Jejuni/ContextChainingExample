using ContextChainingExample;
using ContextChainingExample.MenuBuilderHandlers;
using ContextChainingExample.MenuBuilding;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<IMenuBuilderHandler, AdminAreaMenuBuilderHandler>();
        services.AddSingleton<IMenuBuilderHandler, TrafficLightMenuBuilderHandler>();
        services.AddSingleton<MenuBuilder>();
        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();