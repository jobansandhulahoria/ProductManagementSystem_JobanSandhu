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
    public class IndexModel : PageModel
    {
        private readonly ProductManagementSystem_JobanSandhu.Data.ApplicationDbContext _context;

        public IndexModel(ProductManagementSystem_JobanSandhu.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Supplier> Supplier { get;set; }

        public async Task OnGetAsync()
        {
            Supplier = await _context.Suppliers.ToListAsync();
        }
    }
}
