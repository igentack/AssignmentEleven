using Microsoft.AspNetCore.Mvc.Rendering;

namespace Storage.Models;

public class ProductViewModel
{
    //public IEnumerable<Product> Products { get; set; } = new List<Product>();
    //public IEnumerable<SelectListItem> Categories { get; set; } = new List<SelectListItem>();
    public int Id { get; set; }
    public string Name { get; set; }
    public Category Category { get; set; }
    public int Price { get; set; } = 0;
    public int Count { get; set; }
    public int InventoryValue { get; set; } = 0;
}

