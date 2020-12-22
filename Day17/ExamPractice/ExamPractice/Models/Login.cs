using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamPractice.Models
{
    public class Login
    {
        public string LoginName { get; set; }
        public string Password { get; set; }

       public bool RememberMe { get; set; }
    }
}