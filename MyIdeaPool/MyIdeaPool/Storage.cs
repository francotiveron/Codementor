using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyIdeaPool.Models;

namespace MyIdeaPool
{
    internal class Storage
    {
        private static readonly int pageSize = 10;
        //email -> user
        private static Dictionary<string, User> users = new Dictionary<string, User>();
        //refresh_token -> token
        private static Dictionary<string, Jwt.Token> tokens = new Dictionary<string, Jwt.Token>();
        //email -> [id -> idea]
        private static Dictionary<string, Dictionary<string, Idea>> ideas = new Dictionary<string, Dictionary<string, Idea>>();

        internal static void PutUser(User user)
        {
            users[user.email] = user;
        }

        internal static User GetUser(string email)
        {
            if (users.TryGetValue(email, out var user)) return user;
            return null;
        }

        internal static void PutToken(Jwt.Token token)
        {
            tokens[token.refresh_token] = token;
        }

        internal static bool UserExists(string jwt)
        {
            return tokens.Any(kvp => kvp.Value.jwt == jwt);
        }

        internal static Jwt.Token GetToken(string refresh_token)
        {
            if (tokens.TryGetValue(refresh_token, out var token)) return token;
            return null;
        }

        internal static bool RemoveToken(string refresh_token)
        {
            return tokens.Remove(refresh_token);
        }

        internal static void PutIdea(Idea idea, string email)
        {
            IdeasOf(email)[idea.id] = idea;
        }

        internal static bool RemoveIdea(string id, string email)
        {
            return IdeasOf(email).Remove(id);
        }

        internal static List<Idea> GetIdeas(string email, int page)
        {
            var ideas = IdeasOf(email).Values;
            List<Idea> ret;

            if (page >= 0)
            {
                ret = ideas
                    .OrderBy(idea => idea.created_at)
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .ToList();
            }
            else
            {
                ret = new List<Idea>();
                var n = ideas.Count;
                if (n > 0)
                {
                    var m = Math.Min(pageSize, n);
                    var r = new Random();
                    var idx = Enumerable.Range(0, n).OrderBy(x => r.Next()).Take(m);
                    foreach (var i in idx) ret.Add(ideas.ElementAt(i));
                }
            }
            return ret;
        }

        internal static bool IdeaExists(string id, string email)
        {
            return IdeasOf(email).ContainsKey(id);
        }

        private static Dictionary<string, Idea> IdeasOf(string email)
        {
            if (!ideas.TryGetValue(email, out var ideasOf))
            {
                ideasOf = new Dictionary<string, Idea>();
                ideas[email] = ideasOf;
            }
            return ideasOf;
        }
    }
}