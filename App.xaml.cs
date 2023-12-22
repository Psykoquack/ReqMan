using Microsoft.Extensions.DependencyInjection;
using ReqManLib;
using System.Configuration;
using System.Data;
using System.Windows;

namespace ReqMan
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider? ServiceProvider { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();
            var mainWindow = ServiceProvider.GetService<MainWindow>();
            mainWindow!.Show();
        }


        private void ConfigureServices(ServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient(typeof(MainWindow));
            serviceCollection.AddTransient(typeof(ReqMgmt));
        }
    }

}
