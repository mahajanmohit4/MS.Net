using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Miniproject2.Models
{
    public class UserClass
    {

        
        [Required(ErrorMessage = "please enter the login name")]
        public string Loginname { get; set; }

        
        [Required(ErrorMessage = "please enter the Password")]
        [DataType(DataType.Password)]
       public string Password { get; set; }



        
        [Required(ErrorMessage = "please enter the  Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password")]

        public string Confirmpassword { get; set; }

       
        [Required(ErrorMessage = "please enter the login name")]
        public string FullName { get; set; }

       
        [Required(ErrorMessage = "please enter the emailid")]

       public string EmailId { get; set; }

       
        [Required(ErrorMessage = "please enter the city")]
        public string City { get; set; }

       
        [Required(ErrorMessage = "please enter the Phone number")]
        public string Phone { get; set; }



     


    }
}