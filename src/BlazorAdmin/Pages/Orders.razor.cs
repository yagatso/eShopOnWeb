using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorAdmin.Helpers;
using BlazorAdmin.Services;
using BlazorShared.Models;

namespace BlazorAdmin.Pages.OrderItemPage;

public partial class Orders : BlazorComponent
{
    public OrderService oService { get; set; }

    private List<OrderItem> oItems = new List<OrderItem>();

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            oItems = await oService.List();

            CallRequestRefresh();
        }

        await base.OnAfterRenderAsync(firstRender);
    }

    private async Task ReloadCatalogItems()
    {
        oItems = await oService.List();
        StateHasChanged();
    }
}
