using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AC_Test.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AC_Test.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        
        [BindProperty]
        public string MaterialName { get; set; }
        [BindProperty]
        public int Amount { get; set; }
        [BindProperty]
        public int MaterialID { get; set; }

        public List<Materials> MaterialsList { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            MaterialsList = new List<Materials>();

            Director dir = new Director();
            MaterialsList = dir.FindMaterialsList();
        }

        public void OnPost()
        {

        }
    }
}
