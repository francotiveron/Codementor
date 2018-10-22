using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Idea
    {
        public string id { get; set; }
        public string content { get; set; }
        public int impact { get; set; }
        public int ease { get; set; }
        public int confidence { get; set; }
        public float average_score { get; set; }
        public long created_at { get; set; }
    }
}
