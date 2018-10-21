using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyIdeaPool.Models
{
    public class Idea
    {
        public Idea(string _id, NewIdea _idea)
        {
            id = _id;
            content = _idea.content;
            impact = _idea.impact;
            ease = _idea.ease;
            confidence = _idea.confidence;
            created_at = DateTime.Now.ToBinary();

        }

        public string id { get; set; }
        public string content { get; set; }
        public int impact { get; set; }
        public int ease { get; set; }
        public int confidence { get; set; }
        public float average_score { get { return (impact + ease + confidence) / 3.0f; }  }
        public long created_at { get; set; }

    }
}