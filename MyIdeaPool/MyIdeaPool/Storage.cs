using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyIdeaPool.Models;

namespace MyIdeaPool
{
    internal class Storage
    {
        private static Dictionary<string, User> users = new Dictionary<string, User>();
        private static Dictionary<string, Jwt.Token> tokens = new Dictionary<string, Jwt.Token>();
        private static Dictionary<string, Idea> ideas = new Dictionary<string, Idea>();

        public static void PutUser(User user)
        {
            users[user.email] = user;
        }
        public static User GetUser(string email)
        {
            User user;
            if (users.TryGetValue(email, out user)) return user;

            return null;
        }
        //public static void PutToken(string email, Jwt.Token token)
        //{
        //    tokens[email] = token;
        //}
        public static void PutToken(Jwt.Token token)
        {
            tokens[token.refresh_token] = token;
        }
        //public static KeyValuePair<string, Jwt.Token> GetTokenByRefresh(string refresh_token)
        //{
        //    return tokens.First(kvp => kvp.Value.refresh_token == refresh_token);
        //}
        //public static void RemoveTokenByRefresh(string refresh_token)
        //{
        //    var email = tokens.First(kvp => kvp.Value.refresh_token == refresh_token).Key;
        //    tokens.Remove(email);
        //}
        public static bool Exists(string jwt)
        {
            return tokens.Any(kvp => kvp.Value.jwt == jwt);
        }
        public static Jwt.Token GetToken(string refresh_token)
        {
            return tokens[refresh_token];
        }
        public static void RemoveToken(string refresh_token)
        {
            tokens.Remove(refresh_token);
        }
        public static void PutIdea(Idea idea)
        {
            ideas[idea.id] = idea;
        }
        public static void RemoveIdea(string id)
        {
            ideas.Remove(id);
        }

        public static List<Idea> GetIdeas()
        {
            return ideas.Values.Take(10).ToList();
        }

    }
}