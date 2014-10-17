using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Portfolio.Models
{
    public class ContactForm
    {
        [Required(ErrorMessage="Enter Your Name"), Display(Name="First Name")] 
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [Required, EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Required, DataType(DataType.MultilineText)]
        public string Comment { get; set; }
    }
}