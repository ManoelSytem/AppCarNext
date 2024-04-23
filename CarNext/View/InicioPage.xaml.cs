using Microsoft.Maui.Maps;
using Map = Microsoft.Maui.Controls.Maps.Map;
namespace CarNext.View;


public partial class InicioPage : ContentPage
{
    public InicioPage()
    {

        Location location = new Location(-3.7399984, -38.5105573);
        MapSpan mapSpan = new MapSpan(location, 0.01, 0.01);

        Map map = new Map();

        Content = new Map(mapSpan);
        InitializeComponent();

        Shell.SetTabBarIsVisible(this, true);
    }
}
