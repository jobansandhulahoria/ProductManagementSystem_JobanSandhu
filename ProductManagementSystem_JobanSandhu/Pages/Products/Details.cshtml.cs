using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductManagementSystem_JobanSandhu.Buzz;
using ProductManagementSystem_JobanSandhu.Data;

namespace ProductManagementSystem_JobanSandhu.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly ProductManagementSystem_JobanSandhu.Data.ApplicationDbContext _context;

        public DetailsModel(ProductManagementSystem_JobanSandhu.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Products.FirstOrDefaultAsync(m => m.ID == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
