﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductManagementSystem_JobanSandhu.Buzz;
using ProductManagementSystem_JobanSandhu.Data;

namespace ProductManagementSystem_JobanSandhu.Pages.ProductManagers
{
    public class IndexModel : PageModel
    {
        private readonly ProductManagementSystem_JobanSandhu.Data.ApplicationDbContext _context;

        public IndexModel(ProductManagementSystem_JobanSandhu.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ProductManager> ProductManager { get;set; }

        public async Task OnGetAsync()
        {
            ProductManager = await _context.ProductManagers
                .Include(p => p.Product)
                .Include(p => p.Supplier).ToListAsync();
        }
    }
}
