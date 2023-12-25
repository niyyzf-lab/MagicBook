using MagicBook.Views;

namespace MagicBook
{
    public partial class App : PrismApplication
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<HomePage>("Home");
            containerRegistry.RegisterForNavigation<CollectionPage>("Collection");
            containerRegistry.RegisterForNavigation<DownloadsPage>("Downloads");
            containerRegistry.RegisterForNavigation<ChatPage>("Chat");
            containerRegistry.RegisterForNavigation<HistoryPage>("History");
            containerRegistry.RegisterForNavigation<SettingsPage>("Settings");
        }

        protected override AvaloniaObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
    }
}
