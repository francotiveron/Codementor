using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyIdeaPool.Models
{
    public class Me
    {
        public string email { get; set; }
        public string name { get; set; }
        public string avatar_url { get; set; }
    }
}