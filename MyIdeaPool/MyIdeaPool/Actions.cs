using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using MyIdeaPool.Models;

namespace MyIdeaPool
{
    internal class Actions
    {
        internal static string CheckLogin(HttpRequestMessage request)
        {
            var jwt = request.Headers.GetValues("X-Access-Token").First();
            if (!Storage.UserExists(jwt)) throw new AppException(HttpStatusCode.NotFound, "access token is unknown");
            if (Jwt.IsExpired(jwt)) throw new AppException(HttpStatusCode.Unauthorized, "access token is expired");
            return Jwt.DecodeToken(jwt);
        }
        public static Jwt.Token Login(string email, string password)
        {
            var user = Storage.GetUser(email);
            if (user == null) throw new AppException(HttpStatusCode.NotFound, $"user {email} not found");
            if (password != user.password) throw new AppException(HttpStatusCode.Unauthorized, "wrong password");

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
            if (null != Storage.GetUser(user.email)) throw new AppException(HttpStatusCode.Forbidden, $"user {user.email} already registered");
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
        public static bool Logout(string refresh_token)
        {
            return Storage.RemoveToken(refresh_token);
        }

        public static Me GetMe(string email)
        {
            var user = Storage.GetUser(email);

            //gravatar hash calculation
            var md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(email));
            var sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            var hash = sBuilder.ToString();

            return new Me
            {
                email = user.email,
                name = user.name,
                avatar_url = $"http://www.gravatar.com/avatar/{hash}"
            };
        }

        public static Idea CrUpIdea(NewIdea _idea, string email, string id = null)
        {
            if (id == null) id = Guid.NewGuid().ToString();
            else
            if (!Storage.IdeaExists(id, email)) throw new AppException(HttpStatusCode.NotFound, $"idea {id} not found");
            var idea = new Idea(id, _idea);
            Storage.PutIdea(idea, email);
            return idea;

        }
        public static bool DeleteIdea(string id, string email)
        {
            if (!Storage.IdeaExists(id, email)) throw new AppException(HttpStatusCode.NotFound, $"idea {id} not found");
            return Storage.RemoveIdea(id, email);
        }

        internal static List<Idea> GetIdeas(string email)
        {
            return Storage.GetIdeas(email);
        }
    }
    internal class AppException : Exception
    {
        public HttpStatusCode Status { get; set; }
        public AppException(HttpStatusCode status, string message) : base(message)
        {
            Status = status;
        }
        public override string ToString()
        {
            return $"Application Error: {Message}";
        }
    }
}