namespace DisappearingFontIcons.Controls;

public partial class FontImageControl : ContentView
{
    public string Glyph
    {
        get => (string)GetValue(GlyphProperty);
        set => SetValue(GlyphProperty, value);
    }

    public Color IconColor
	{
		get => (Color)GetValue(IconColorProperty);
		set => SetValue(IconColorProperty, value);
	}

    public static readonly BindableProperty GlyphProperty = BindableProperty.Create(nameof(Glyph), typeof(string), typeof(FontImageControl), string.Empty, propertyChanged: (bindable, oldValue, newValue) =>
    {
        ((FontImageControl)bindable).OnGlyphChanged();
    });

    public static readonly BindableProperty IconColorProperty = BindableProperty.Create(nameof(IconColor), typeof(Color), typeof(FontImageControl), Colors.Black, propertyChanged: (bindable, oldValue, newValue) =>
	{
		((FontImageControl)bindable).OnIconColorChanged();
    });

	public FontImageControl()
	{
		InitializeComponent();
	}

    private void OnGlyphChanged()
    {
        if (Glyph == null)
        {
            return;
        }

        FontImageSource.Glyph = Glyph;
    }

    private void OnIconColorChanged()
	{
		if (IconColor == null) 
		{
			return;
		}

		FontImageSource.Color = IconColor;
    }
}