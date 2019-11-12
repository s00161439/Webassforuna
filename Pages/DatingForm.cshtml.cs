using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using WebAssForUna.pages.model;

namespace WebAssForUna.Pages
{
    public class DatingFormModel : PageModel
    {
        
        [BindProperty]
        public ModelPage modelpage { get; set; } = new ModelPage();
        public void OnGet()
        {
            var value = HttpContext.Session.GetString("modelpage");
            if (value != null)
            {
                modelpage = JsonConvert.DeserializeObject<ModelPage>(value);
                HttpContext.Session.Clear();

            }
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var SerialisedData = JsonConvert.SerializeObject(modelpage);

                HttpContext.Session.SetString("modelpage", SerialisedData);

                return RedirectToPage("Confirmation");
            }
            else
            {
                return Page();
            }


        }
    }
}