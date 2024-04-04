using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShared.Interfaces;
using BlazorShared.Models;
using Microsoft.Extensions.Logging;


namespace BlazorAdmin.Services;

public class OrderService
{
    //private readonly IRepository<Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate.Order> _orderRepository;

    private readonly HttpService _httpService;
    private readonly ILogger<CatalogItemService> _logger;

    public OrderService(HttpService httpService, ILogger<CatalogItemService> logger)
    {
        _httpService = httpService;
        _logger = logger;
    }
    public async Task<List<OrderItem>> List()
    {
        _logger.LogInformation("Fetching orders from API.");

        var itemListTask = _httpService.HttpGet<OrderItemResponse>($"order-items");
        await Task.WhenAll(itemListTask);
        var items = itemListTask.Result.OrderItems;

        return items;
    }
}
