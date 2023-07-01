using MudBlazor;
using MudBlazor.Utilities;

namespace MarketingCopilot.Components.Index;

public partial class Index : MudComponentBase
{
    //Impression _currentImpression = new Impression();

    private string Classname =>
        new CssBuilder()
            .AddClass(Class)
            .Build();

    private void FetchThemes()
    {
        // set local instance of MEssage 

    }
}