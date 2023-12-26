using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace MagicBook.Components;

public class ICard : Button
{
    //Image
    public static readonly StyledProperty<object?> ImageProperty = AvaloniaProperty.Register<ICard, object?>(
        nameof(Image),null);

    public object? Image
    {
        get => GetValue(ImageProperty);
        set => SetValue(ImageProperty, value);
    }
    //Avatar
    public static readonly StyledProperty<object?> AvatarProperty = AvaloniaProperty.Register<ICard, object?>(
        nameof(Avatar),null);

    public object? Avatar
    {
        get => GetValue(AvatarProperty);
        set => SetValue(AvatarProperty, value);
    }
    //Title
    public static readonly StyledProperty<object> TitleProperty = AvaloniaProperty.Register<ICard, object>(
        nameof(Title),"Name");

    public object Title
    {
        get => GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }
    //LikeNumber
    public static readonly StyledProperty<string?> LikeNumberProperty = AvaloniaProperty.Register<ICard, string?>(
        "LikeNumber","0");

    public string? LikeNumber
    {
        get => GetValue(LikeNumberProperty);
        set => SetValue(LikeNumberProperty, value);
    }
    //BrowseNumber
    public static readonly StyledProperty<string?> BrowseNumberProperty = AvaloniaProperty.Register<ICard, string?>(
        nameof(BrowseNumber),"0");

    public string? BrowseNumber
    {
        get => GetValue(BrowseNumberProperty);
        set => SetValue(BrowseNumberProperty, value);
    }
}
