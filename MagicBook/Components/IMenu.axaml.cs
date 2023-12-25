namespace MagicBook.Components;

public class IMenu :Button
{
    // logo
    public static readonly StyledProperty<object> LogoProperty = AvaloniaProperty.Register<IMenu, object>(
        nameof(Logo));

    public object Logo
    {
        get => GetValue(LogoProperty);
        set => SetValue(LogoProperty, value);
    }
    // title
    public static readonly StyledProperty<object> TitleProperty = AvaloniaProperty.Register<IMenu, object>(
        nameof(Title));

    public object Title
    {
        get => GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }
    // messageNotify
    public static readonly StyledProperty<string> MessageNotifyProperty = AvaloniaProperty.Register<IMenu, string>(
        nameof(MessageNotify));

    public string MessageNotify
    {
        get => GetValue(MessageNotifyProperty);
        set => SetValue(MessageNotifyProperty, value);
    }

    // SelectedMenu

    public static readonly StyledProperty<string?> SelectedMenuProperty = AvaloniaProperty.Register<IMenu, string?>(
        nameof(SelectedMenu));

    public string? SelectedMenu
    {
        get => GetValue(SelectedMenuProperty);
        set => SetValue(SelectedMenuProperty, value);
    }
}
