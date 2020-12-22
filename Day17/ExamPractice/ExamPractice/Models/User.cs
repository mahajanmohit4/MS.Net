using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamPractice.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }
       
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Login Name")]
        [StringLength(20, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string LoginName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter Password")]
        [StringLength(20, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string Password { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Full Name")]
        [StringLength(20, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please enter EmailId")]
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string Email { get; set; }
        public int CityId { get; set; }

        [Required(ErrorMessage = "Please enter Phone")]
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string Phone { get; set; }

        public IEnumerable<SelectListItem> Cities { get; set; }
        
    }
}