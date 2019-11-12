using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using WebAssForUna.pages.model;

namespace WebAssForUna.Pages
{
    public class ConfirmationModel : PageModel
    {
        public ModelPage modelPage { get; set; }

        public IActionResult OnGet()
        {
            var value = HttpContext.Session.GetString("modelpage");

            if (value != null)
            {
                modelPage = JsonConvert.DeserializeObject<ModelPage>(value);
                return Page();
            }
            else
            {

                return RedirectToPage("error");
            }
        }
        
    }
}