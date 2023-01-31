using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using CarRentalManagement.Client;
using CarRentalManagement.Client.Shared;
using CarRentalManagement.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using CarRentalManagement.Client.Static;

namespace CarRentalManagement.Client.Pages.Colours
{
    public partial class Index
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private List<Colour> colours;
        protected async override Task OnInitializedAsync()
        {
            colours = await _client.GetFromJsonAsync<List<Colour>>($"{Endpoints.ColoursEndpoint}");
        }

        private async Task DeleteAsync(int id)
        {
            var colour = colours.First(q => q.Id == id);
            if (await js.InvokeAsync<bool>("confirm", $"Do you want to delete {colour.Name}?"))
            {
                await _client.DeleteAsync($"{Endpoints.ColoursEndpoint}/{id}");
                await OnInitializedAsync();
            }
        }
    }
}