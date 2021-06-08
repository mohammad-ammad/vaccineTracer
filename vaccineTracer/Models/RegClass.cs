using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
//VaccinationSystemEntities1
namespace vaccineTracer.Models
{
    public class RegClass
    {
        [Required(ErrorMessage ="Please fill the First Name")]
        [Display(Name ="First Name")]
        public string first_name { get; set; }

        [Required(ErrorMessage = "Please fill the Last Name")]
        [Display(Name = "Last Name")]
        public string last_name { get; set; }

        [Required(ErrorMessage = "Please fill the CNIC")]
        [Display(Name = "CNIC")]
        public string cnic { get; set; }

        [Required(ErrorMessage = "Please fill the Age")]
        [Display(Name = "Age")]
        public int age { get; set; }

        [Required(ErrorMessage = "Please fill the City")]
        [Display(Name = "City")]
        public string city { get; set; }

        [Required(ErrorMessage = "Please fill the Registration Date")]
        [Display(Name = "Registration Date")]
        public DateTime reg_date { get; set; }

    }
}