using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyIdeaPool.Models
{
    public class NewIdea
    {
        [Required, StringLength(100)]
        public string content { get; set; }
        [Required, Range(1, 10)]
        public int impact { get; set; }
        [Required, Range(1, 10)]
        public int ease { get; set; }
        [Required, Range(1, 10)]
        public int confidence { get; set; }
    }
}