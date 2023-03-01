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

        var hanaLoc = new Location(19.8286306, -98.8960667);
        var eder = new Location(19.6344033, -98.982768);
        var bryan = new Location(19.5692168, -99.0266124);
        var freddy = new Location(19.6478955, -98.9882992);

        MapSpan mapSpan = MapSpan.FromCenterAndRadius(eder, Distance.FromKilometers(5));
        map.MoveToRegion(mapSpan);
        map.Pins.Add(new Pin
        {
            Label = "Casa del eder",
            Location = eder,
        });
        MapSpan mapSpant = MapSpan.FromCenterAndRadius(freddy, Distance.FromKilometers(5));
        map.MoveToRegion(mapSpan);
        map.Pins.Add(new Pin
        {
            Label = "Casa del fredy",
            Location = freddy,
        });
        MapSpan mapSpand = MapSpan.FromCenterAndRadius(bryan, Distance.FromKilometers(-1));
        map.MoveToRegion(mapSpan);
        map.Pins.Add(new Pin
        {
            Label = "Casa del bryan",
            Location = bryan,
        });

        MapSpan mapSpann = MapSpan.FromCenterAndRadius(hanaLoc, Distance.FromKilometers(-1));
        map.MoveToRegion(mapSpan);
        map.Pins.Add(new Pin
        {
            Label = "Casa del roi",
            Location = hanaLoc,
        });


    }

}

public class MapTypesPageCode : ContentPage
{
    public MapTypesPageCode()
    {
        Map map = new();
        Content = map;
    }

}

