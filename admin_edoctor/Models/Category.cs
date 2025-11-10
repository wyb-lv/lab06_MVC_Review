using System;
using System.Collections.Generic;

namespace admin_edoctor.Models;

public partial class Category
{
    public int? CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }
}
