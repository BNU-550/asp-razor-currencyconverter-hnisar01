using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorCurrencyConverter.Pages
{
    [RequireHttps]
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string FullName { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            FullName = "Hassan";
        }

        public void OnPost()
        {
            if (String.IsNullOrWhiteSpace(FullName))
            {
                ViewData["Message"] = "Name is Missing!" ;
                FullName = "Anonymous";
            }
            else
            {
                ViewData["Message"] = "Name is Registered!";
                //Register the User
            }

        }
    }
}
