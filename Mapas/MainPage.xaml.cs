using Map = Microsoft.Maui.Controls.Maps.Map;
namespace Mapas;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}
}

public class MapTypesPageCode : ContentPage
{
    public MapTypesPageCode()
    {
        Map map = new Map();
        Content = map;
    }

    Map mapa = new Map
    {
        IsShowingUser = true
    };
}

