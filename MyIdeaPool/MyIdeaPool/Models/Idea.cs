using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyIdeaPool.Models
{
    public class Idea : NewIdea
    {
        public Idea(string _id, NewIdea _idea)
        {
            id = _id;
            content = _idea.content;
            impact = _idea.impact;
            ease = _idea.ease;
            confidence = _idea.confidence;

            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = DateTime.Now.ToUniversalTime() - origin;
            created_at = (uint)Math.Floor(diff.TotalSeconds);
        }

        public string id { get; set; }
        public float average_score { get { return (impact + ease + confidence) / 3.0f; } }
        public uint created_at { get; set; }

    }
}