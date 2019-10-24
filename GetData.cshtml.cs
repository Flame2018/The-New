using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShinobiRanks1._0.Data;

namespace ShinobiRanks1._0.Pages
{
    public class GetDataModel : PageModel
    {
        public ApplicationDbContext _DB { get; set; }

        public IList<HVGenin> HVGenin { get; set; }

        public GetDataModel(ApplicationDbContext DB)
        {
            _DB = DB;
        }

        public async Task OnGetAsync()
        {
            HVGenin = await _DB.HVGenin.ToListAsync();
        }
    }
}