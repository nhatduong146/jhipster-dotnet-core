using Microsoft.AspNetCore.Components;
using JhipsterExample.Client.Pages.Utils;

namespace JhipsterExample.Client
{
    public partial class App : ComponentBase
    {
        [Inject]
        public INavigationService NavigationService { get; set; } // Permit to initialize navigation service
    }
}
