using Elsa.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ElsaQuickstarts.ConsoleApp.HelloWorld;

public partial class Program
{
    private static async Task Main()
    {
        var services = new ServiceCollection()
            .AddElsa(options => options
                .AddConsoleActivities() 
                .AddWorkflow<HelloWorld>())
            .BuildServiceProvider();

        var workflowRunner = services.GetRequiredService<IBuildsAndStartsWorkflow>();

        await workflowRunner.BuildAndStartWorkflowAsync<HelloWorld>();
    }
}
