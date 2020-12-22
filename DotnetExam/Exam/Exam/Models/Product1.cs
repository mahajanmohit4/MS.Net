using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam.Models
{
    public class Product1
    {
        [Key]
        public int ProductId { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage ="please Enter prodcut Name")]
        [Display(Name = "Product Name")]
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed then {1} characters. ")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "please Enter Rate")]       
        public decimal Rate { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "please Enter Description")]
        [StringLength(200, ErrorMessage = "The {0} value cannot exceed then {1} characters")]
        public string Description { get; set; }

       
        public int CategoryId { get; set; }
        public IEnumerable<SelectListItem> Categories1 { get; set; }
    }
}