using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClientRolodex.Data;
using ClientRolodex.Models;

namespace ClientRolodex.Pages.Clients
{
    public class IndexModel : PageModel
    {
        private readonly ClientRolodex.Data.ClientContext _context;

        public IndexModel(ClientRolodex.Data.ClientContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Clients != null)
            {
                Client = await _context.Clients.ToListAsync();
            }
        }
    }
}
