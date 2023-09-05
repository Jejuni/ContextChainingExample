using ContextChainingExample.MenuBuilding;

namespace ContextChainingExample;

internal class Worker : BackgroundService
{
    private readonly MenuBuilder _menuBuilder;

    public Worker(MenuBuilder menuBuilder)
    {
        _menuBuilder = menuBuilder ?? throw new ArgumentNullException(nameof(menuBuilder));
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await _menuBuilder.Build(stoppingToken);
        Environment.Exit(0);
    }
}