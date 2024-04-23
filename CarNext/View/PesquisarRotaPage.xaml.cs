using CarNext.Service;
using System.Windows.Input;

namespace CarNext.View;

public partial class PesquisarRotaPage : ContentPage
{
    public static readonly BindableProperty FocusOriginCommandProperty =
          BindableProperty.Create(nameof(FocusOriginCommand), typeof(ICommand), typeof(PesquisarRotaPage), null, BindingMode.TwoWay);

    public ICommand FocusOriginCommand
    {
        get { return (ICommand)GetValue(FocusOriginCommandProperty); }
        set { SetValue(FocusOriginCommandProperty, value); }
    }

    public PesquisarRotaPage()
	{
		InitializeComponent();
	}

    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();
        if (BindingContext != null)
        {
            FocusOriginCommand = new Command(OnOriginFocus);
        }
    }

    void OnOriginFocus()
    {
        destinationEntry.Focus();
    }
}