using System;

namespace Bulk.Models.ViewModels;

public class HomeVm
{
    public IEnumerable<Category> Categories { get; set; }
    public IEnumerable<Product> Products { get; set; }
}
