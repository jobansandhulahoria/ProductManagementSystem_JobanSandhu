using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductManagementSystem_JobanSandhu.Buzz;
using ProductManagementSystem_JobanSandhu.Data;

namespace ProductManagementSystem_JobanSandhu.Pages.Suppliers
{
    public class DeleteModel : PageModel
    {
        private readonly ProductManagementSystem_JobanSandhu.Data.ApplicationDbContext _context;

        public DeleteModel(ProductManagementSystem_JobanSandhu.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Supplier Supplier { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Supplier = await _context.Suppliers.FirstOrDefaultAsync(m => m.ID == id);

            if (Supplier == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Supplier = await _context.Suppliers.FindAsync(id);

            if (Supplier != null)
            {
                _context.Suppliers.Remove(Supplier);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
