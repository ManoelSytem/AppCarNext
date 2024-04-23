using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using System.Windows.Input;
using CarNext.Model;

namespace CarNext.View;

public partial class MapPesquisaPage : ContentPage
{
    public static readonly BindableProperty CalculateCommandProperty =
           BindableProperty.Create(nameof(CalculateCommand), typeof(ICommand), typeof(MainPage), null, BindingMode.TwoWay);

    public ICommand CalculateCommand
    {
        get { return (ICommand)GetValue(CalculateCommandProperty); }
        set { SetValue(CalculateCommandProperty, value); }
    }

    public static readonly BindableProperty UpdateCommandProperty =
      BindableProperty.Create(nameof(UpdateCommand), typeof(ICommand), typeof(MainPage), null, BindingMode.TwoWay);

    public ICommand UpdateCommand
    {
        get { return (ICommand)GetValue(UpdateCommandProperty); }
        set { SetValue(UpdateCommandProperty, value); }
    }

    public MapPesquisaPage()
	{
		InitializeComponent();

        double zoomLevel = 0.5;
        double latlongDegrees = 360 / (Math.Pow(2, zoomLevel));
        if (map.VisibleRegion != null)
        {
            map.MoveToRegion(new MapSpan(map.VisibleRegion.Center, latlongDegrees, latlongDegrees));
        }
        

    }

    public async void OnEnterAddressTapped(object sender, EventArgs e)
    {
        await   Navigation.PushAsync(new PesquisarRotaPage() { BindingContext = this.BindingContext }, false);
    }

    public void Handle_Stop_Clicked(object sender, EventArgs e)
    {
        
    }
}