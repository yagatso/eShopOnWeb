using System;
using System.Collections.Generic;
namespace BlazorShared.Models;

public class OrderItemResponse
{
    public List<OrderItem> OrderItems { get; set; } = new();
}
