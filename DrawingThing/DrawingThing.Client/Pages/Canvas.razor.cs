using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace DrawingThing.Client.Pages
{
    public partial class Canvas
    {
        [Inject]
        public IJSRuntime JS { get; set; }

        protected override async void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                await JS.InvokeVoidAsync("Init");
            }
        }

        public async Task ClearCanvas()
        {
            await JS.InvokeVoidAsync("ClearCanvas");
        }
    }
}