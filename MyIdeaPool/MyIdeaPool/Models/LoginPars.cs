using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyIdeaPool.Models
{
    public class LoginPars
    {
        [Required, EmailAddress]
        public string email { get; set; }
        [Required, RegularExpression("(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{8,}")]
        public string password { get; set; }
    }
}