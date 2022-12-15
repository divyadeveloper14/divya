using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using ECAD_eApps_Interview;
using ECAD_eApps_Interview.Services;
using ECAD_eApps_Interview.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace ECAD_eApps_Interview
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost _host;

        public App()
        {
            CreateHostBuilder().Build().Run();
        }

        public static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
            .ConfigureServices((services) =>
            {
                services.AddScoped<IDiagramService, DiagramServices>();
                services.AddSingleton<DiagramViewModel>();
            });       
       
    }
}
