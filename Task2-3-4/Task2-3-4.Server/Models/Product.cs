using System;
using System.Collections.Generic;

namespace _14_4_24.Server.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? ProductDesc { get; set; }
}
