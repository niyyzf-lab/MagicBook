using System.ComponentModel;

namespace MagicBook.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private readonly IRegionManager _regionManager;

        public MainWindowViewModel(IRegionManager regionManager)
        {
            NavigateViewCommand = new DelegateCommand<string>(NavigateView);
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(HomePage));
            _regionManager = regionManager;
        }

        public DelegateCommand<string> NavigateViewCommand { get; private set; }


        //导航到指定页面传入参数:页面名称
        private void NavigateView(string uri)
        {
            _regionManager.RequestNavigate("ContentRegion", uri);
            SelectedMenuItem = uri;
        }

        private string? _selectedMenuItem = "Home";

        public string? SelectedMenuItem
        {
            get => _selectedMenuItem;
            set
            {
                if (_selectedMenuItem == value)
                    return;

                SetProperty(ref _selectedMenuItem, value);
                RaisePropertyChanged(nameof(SelectedMenuItem));
            }
        }
    }
}
