using System;
using System.Collections.Generic;

namespace admin_edoctor.Models;

public partial class Product
{
    public int? ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public string? ImageUrl { get; set; }

    public int? CategoryId { get; set; }

    public int? StockQuantity { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
