using RazorPage1.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace RazorPage1.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly NorthwindContext _context;

        public ProductsModel(NorthwindContext context)
        {
            _context = context;
        }

        public List<Product> Products { get; set; } = new();

        public async Task OnGetAsync()
        {
            Products = await _context.Products
                .OrderBy(p => p.UnitPrice)
                .ToListAsync();
        }
    }
}
