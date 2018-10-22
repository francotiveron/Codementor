using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using MyIdeaPool.Models;

namespace MyIdeaPool
{
    internal class Actions
    {
        internal static void CheckLogin(HttpRequestMessage request)
        {
            var jwt = request.Headers.GetValues("X-Access-Token").First();
            if (!Storage.UserExists(jwt)) throw new Exception("access token is unknown");
            if (Jwt.IsExpired(jwt)) throw new Exception("access token is expired");
        }
        public static Jwt.Token Login(string email, string password)
        {
            var user = Storage.GetUser(email);
            if (user == null) throw new Exception("user not found");
            if (password != user.password) throw new Exception("wrong password");

            var token = new Jwt.Token
            {
                jwt = Jwt.GenerateToken(email),
                refresh_token = Guid.NewGuid().ToString()
            };
            Storage.PutToken(token);
            return token;
        }
        public static Jwt.Token SignUp(User user)
        {
            //Validation.Validate(user);
            if (null != Storage.GetUser(user.email)) throw new Exception("user already registered");
            Storage.PutUser(user);           
            return Login(user.email, user.password);
        }
        public static string RefreshToken(string refresh_token)
        {
            var email = Jwt.DecodeToken(Storage.GetToken(refresh_token).jwt);
            var token = new Jwt.Token
            {
                jwt = Jwt.GenerateToken(email),
                refresh_token = refresh_token
            };
            Storage.PutToken(token);
            return token.jwt;
        }
        public static void Logout(string refresh_token)
        {
            Storage.RemoveToken(refresh_token);
        }

        public static Me GetMe(string jwt)
        {
            var email = Jwt.DecodeToken(jwt);
            var user = Storage.GetUser(email);
            return new Me
            {
                email = user.email,
                name = user.name,
                avatar_url = "TBI"
            };
        }

        public static Idea CrUpIdea(NewIdea _idea, string id = null)
        {
            //Validation.Validate(_idea);
            if (id == null) id = Guid.NewGuid().ToString();
            else
            if (!Storage.IdeaExists(id)) throw new Exception("idea not found");
            var idea = new Idea(id, _idea);
            Storage.PutIdea(idea);
            return idea;

        }
        public static void DeleteIdea(string id)
        {
            Storage.RemoveIdea(id);
        }

        internal static List<Idea> GetIdeas()
        {
            return Storage.GetIdeas();
        }
    }
}