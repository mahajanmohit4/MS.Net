using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompareAttribute = System.ComponentModel.DataAnnotations.CompareAttribute;

namespace LogReg.Models
{
    public class Reg
    {
        [Key]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Login Name")]
        [StringLength(20, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string LoginName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter Password")]
        [StringLength(20, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password")]
        [Required(ErrorMessage = "Please enter ConfirmPassword")]
        [StringLength(20, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Full Name")]
        [StringLength(20, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string FullName { get; set; }

        
        [Required(ErrorMessage = "Please enter EmailId")]
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string EmailId { get; set; }

        
        [Required(ErrorMessage = "Please enter EmailId")]
        [StringLength(20, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]

       
        public IEnumerable<SelectListItem> Citys { get; set; }


        [Required(ErrorMessage = "Please enter Phone")]
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string Phone { get; set; }

        public int CityId { get; set; }
    }
}