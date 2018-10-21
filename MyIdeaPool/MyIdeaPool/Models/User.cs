using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MyIdeaPool.Models
{
    public class User
    {
        [Required, MinLength(1)]
        public string name { get; set; }
        [Required, EmailAddress]
        public string email { get; set; }
        //[Required, RegularExpression("")]
        [Required]
        public string password { get; set; }
    }
}