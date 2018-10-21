using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyIdeaPool.Models
{
    public class LoginPars
    {
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
    }
}