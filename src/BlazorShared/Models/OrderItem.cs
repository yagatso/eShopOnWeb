﻿using System;
namespace BlazorShared.Models;

public class OrderItem
{
    public int buyerId { get; set; }
    public DateTime date { get; set; }
    public decimal total { get; set; }
    public string status { get; set; }
}

public class OrderItemDetail
{
    public int buyerId { get; set; }
    public int unit { get; set; }
    public decimal price { get; set; }
    public string name { get; set; }
}


