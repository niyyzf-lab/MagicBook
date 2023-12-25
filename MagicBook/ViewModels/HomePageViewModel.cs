namespace MagicBook.ViewModels;

public class HomePageViewModel: ViewModelBase,INavigationAware
{
    /// <summary>
    /// 导航前
    /// </summary>
    /// <param name="navigationContext"></param>
    /// <exception cref="NotImplementedException"></exception>
    public void OnNavigatedTo(NavigationContext navigationContext)
    {
    }
    /// <summary>
    /// 是否创建新的对象
    /// </summary>
    /// <param name="navigationContext"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public bool IsNavigationTarget(NavigationContext navigationContext)
    {
        return false;
    }
    /// <summary>
    /// 导航离开当前页面触发
    /// </summary>
    /// <param name="navigationContext"></param>
    /// <exception cref="NotImplementedException"></exception>
    public void OnNavigatedFrom(NavigationContext navigationContext)
    {

    }
}
