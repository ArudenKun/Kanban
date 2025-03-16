using Hydro;

namespace Web.Pages.Components;

public class Content : HydroComponent
{
    public int Count { get; set; }

    public void Add()
    {
        Count++;
        Client.ExecuteJs(
            """
            console.log('Test')
            """
        );
    }
}
