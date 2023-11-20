using System.Configuration;
using System.Data;
using System.Windows;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Sample.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace CommunityToolkit.Mvvm.Sample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public new static App Current => (App)Application.Current;

        public IServiceProvider Services { get; }

        public App()
        {
            Services = ConfigureServices();
        }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton(typeof(MainWindowViewModel), typeof(MainWindowViewModel));
            services.AddSingleton(typeof(AsyncCommandsViewModel), typeof(AsyncCommandsViewModel));
            services.AddSingleton(typeof(CollectionsViewModel), typeof(CollectionsViewModel));
            services.AddSingleton(typeof(INotifyPropertyChangedAttributesViewModel), typeof(INotifyPropertyChangedAttributesViewModel));
            services.AddSingleton(typeof(InversionOfControlViewModel), typeof(InversionOfControlViewModel));
            services.AddSingleton(typeof(ObservableObjectViewModel), typeof(ObservableObjectViewModel));
            services.AddSingleton(typeof(ObservablePropertyAttributeViewModel), typeof(ObservablePropertyAttributeViewModel));
            services.AddSingleton(typeof(ObservableValidatorViewModel), typeof(ObservableValidatorViewModel));
            services.AddSingleton(typeof(RelayCommandAttributeViewModel), typeof(RelayCommandAttributeViewModel));
            services.AddSingleton(typeof(RelayCommandsViewModel), typeof(RelayCommandsViewModel));
            services.AddSingleton(typeof(RequestMessagesViewModel), typeof(RequestMessagesViewModel));
            services.AddSingleton(typeof(SendingMessagesViewModel), typeof(SendingMessagesViewModel));

            return services.BuildServiceProvider();
        }

    }

}
