using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using Map = Microsoft.Maui.Controls.Maps.Map;
namespace Mapas;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}
    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        var eder = new Location(19.7129283, -98.9719797);
      
        var freddy = new Location(19.7134838, -98.9717866);

        MapSpan mapSpan = MapSpan.FromCenterAndRadius(eder, Distance.FromKilometers(-1));
        map.MoveToRegion(mapSpan);
        map.Pins.Add(new Pin
        {
            Label = "Casa del eder",
            Location = eder,
        });
        MapSpan mapSpant = MapSpan.FromCenterAndRadius(freddy, Distance.FromKilometers(-1));
        map.MoveToRegion(mapSpan);
        map.Pins.Add(new Pin
        {
            Label = "Casa del fredy",
            Location = freddy,
        });
 
       


    }

}

public class MapTypesPageCode : ContentPage
{
    public MapTypesPageCode()
    {
        Map map = new Map
        {
            MapType = MapType.Street
        };
    }

}

