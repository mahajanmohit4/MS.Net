using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelViewCtnr.Models
{
    public class Friend
    {
        [Key]
        
        public int FriendId { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Name")]
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string FriendName { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Name")]
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string Place { get; set; }
    }
}