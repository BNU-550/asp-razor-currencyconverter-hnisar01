using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorCurrencyConverter.Pages
{
    public class ConverterModel : PageModel
    {
        public const double PoundsToDollars = 1.36;

        [BindProperty]
        public string Value { get; set; }

        [BindProperty]
        public decimal Amount { get; set; }

        /// <summary>
        /// This method will be called when the webpage will be displayed
        /// </summary>
        public void OnGet()
        {
            Value = "100.00";
        }

        /// <summary>
        /// Will be used when the submit button will be clicked
        /// </summary>
        public void OnPost()
        {
            Amount = Convert.ToDecimal(Value);
            Amount = Amount * (decimal)PoundsToDollars;
            ViewData["Message"] = Amount;

        }
    }
}
