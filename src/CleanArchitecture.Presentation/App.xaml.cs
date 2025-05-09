using System.Configuration;
using System.Data;
using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.external;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;

namespace CleanArchitecture.Presentation;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : System.Windows.Application
{
    private IServiceProvider _serviceProvider;

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        var services = new ServiceCollection();
        ConfigureServices(services);
        _serviceProvider = services.BuildServiceProvider();

        var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
        mainWindow.Show();
    }

    private void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IDatabase, Database>();
        services.AddSingleton<IBusinessLogicService, BusinessLogicService>();
        services.AddSingleton<MainWindow>();
    }
}

