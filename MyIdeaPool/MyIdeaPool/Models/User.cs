using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MyIdeaPool.Models
{
    public class User : LoginPars
    {
        [Required]
        public string name { get; set; }
    }
}