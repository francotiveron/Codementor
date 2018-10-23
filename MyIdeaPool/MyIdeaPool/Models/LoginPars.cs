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

        [
            Required
            , RegularExpression(
                "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{8,}"
                , ErrorMessage = "Password must be at least 8 characters, including 1 uppercase letter, 1 lowercase letter, and 1 number"
              )
        ]
        public string password { get; set; }
    }
}