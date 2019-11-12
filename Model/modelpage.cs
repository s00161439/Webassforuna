using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;


namespace WebAssForUna.pages.model
{
    public class ModelPage
    {

        public string ErrorMessage { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "**First name is required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "**Last Name is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "**PPSN is required")]
        [Display(Name = "PPSN")]
        [RegularExpression(@"\d{7}[a-zA-Z]{1,2}", ErrorMessage ="**PPSN must be seven numbers followed by one or two letters")]
        public string Ppsn { get; set; }
        [BindProperty]
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "**Gender is required")]
        public string Gender { get; set; }
        [BindProperty]
        [Display(Name = "Height")]
        [Range(110, 200)]
        public decimal Height { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "**Email address is required")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [BindProperty]
        [Display(Name = "Phone")]
        [Phone]
        [RegularExpression(@"[00353,+00353,353,+353,0]+8[35679]\d{7}", ErrorMessage ="**Must be an Irish phone number")]
        public string Phone { get; set; }
        [BindProperty]
        public string Rstatus { get; set; }
        
        public string[] Interests = {"Outdoor sports", "Food", "Pubs", "Theatre", "Music", "Reading", "Gaming", "Watching Sport", "Board Games" };
        [BindProperty]
        public bool[] InterestsChoosen { get; set; } = new bool[10];

    }

}