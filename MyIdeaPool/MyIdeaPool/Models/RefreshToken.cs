using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyIdeaPool.Models
{
    public class RefreshToken
    {
        [Required]
        public string refresh_token { get; set; }
    }
}