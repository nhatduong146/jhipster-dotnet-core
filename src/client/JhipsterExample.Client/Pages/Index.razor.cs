using System.Threading.Tasks;
using Blazored.Modal.Services;
using JhipsterExample.Client.Models;
using JhipsterExample.Client.Pages.Utils;
using JhipsterExample.Client.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace JhipsterExample.Client.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        private AuthenticationStateProvider AuthenticationService { get; set; }

        [CascadingParameter]
        private IModalService ModalService { get; set; }

        private UserModel CurrentUser => (AuthenticationService as IAuthenticationService)?.CurrentUser;

        private Task SignIn()
        {
            ModalService.Show<Login>("Sign In");
            return Task.CompletedTask;
        }

    }
}
