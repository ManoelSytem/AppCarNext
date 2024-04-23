using CommunityToolkit.Maui.Behaviors;
using System.Formats.Tar;

namespace CarNext.CustomControl
{
    public sealed class CustomEntry : Entry
    {
        public static BindableProperty CornerRadiusProperty =
            BindableProperty.Create(nameof(CornerRadius), typeof(int), typeof(CustomEntry), 0);

        public static BindableProperty BorderThicknessProperty =
            BindableProperty.Create(nameof(BorderThickness), typeof(int), typeof(CustomEntry), 0);

        public static BindableProperty PaddingProperty =
            BindableProperty.Create(nameof(Padding), typeof(Thickness), typeof(CustomEntry), new Thickness(5));

        public static BindableProperty BorderColorProperty =
            BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(CustomEntry), Colors.Transparent);

        public static BindableProperty CustomHeightProperty =
            BindableProperty.Create(nameof(CustomHeight), typeof(int), typeof(CustomEntry), 0);
       

        public CustomEntry()
        {
            var behavior = new MaskedBehavior
            {
                Mask = "(XX) X XXXX XXXX ",
            };

            this.Behaviors.Add(behavior);

            this.TextChanged += PositionCursor;


        }
        public int CornerRadius
        {
            get => (int)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        public void PositionCursor(object sender, EventArgs args)
        {
            (sender as Entry).CursorPosition = this?.Text?.Length ?? 0;
        }
        public int BorderThickness
        {
            get => (int)GetValue(BorderThicknessProperty);
            set => SetValue(BorderThicknessProperty, value);
        }
        public Color BorderColor
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }
        /// <summary>
        /// Esta propriedade não pode ser alterada em tempo de execução no iOS.
        /// </summary>
        public Thickness Padding
        {
            get => (Thickness)GetValue(PaddingProperty);
            set => SetValue(PaddingProperty, value);
        }

        public int CustomHeight
        {
            get => (int)GetValue(CustomHeightProperty);
            set => SetValue(CustomHeightProperty, value);
        }

    }
}
