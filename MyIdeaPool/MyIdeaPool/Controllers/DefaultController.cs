using MyIdeaPool.Models;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Web.Http;

namespace MyIdeaPool.Controllers
{
    public class DefaultController : ApiController
    {
        /*
         * Exception info to client
         * Can be enriched (e.g. ex.Data)
        */
        private string ExceptionInfo(Exception ex)
        {
            return ex.GetType().Name + " - " + ex.Message;
        }
        private HttpResponseMessage Process<T>(Func<string, T> action, HttpStatusCode successCode = HttpStatusCode.OK, bool checkLogin = false)
        {
            try
            {
                var email = checkLogin ? Actions.CheckLogin(Request) : null;

                if (!ModelState.IsValid) return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                try
                {
                    if (successCode == HttpStatusCode.NoContent)
                    {
                        action(email);
                        return Request.CreateResponse(HttpStatusCode.NoContent);
                    }
                    else
                    {
                        return Request.CreateResponse(successCode, action(email));
                    }
                }
                catch (TargetInvocationException ex) //bypass exception layer from dynamic calls
                {
                    throw ex.InnerException;
                }
            }
            catch (AppException ex) //custom
            {
                return Request.CreateErrorResponse(ex.Status, ex.ToString());
            }
            catch (Exception ex) 
            {
                //avoid standard back propagation of uncaught exceptions (e.g. call stack is not propagated)
                //drills down innerexception stack
                var sb = new StringBuilder();
                for (var x = ex; x != null; x = x.InnerException) sb.Append(ExceptionInfo(x) + Environment.NewLine);
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, sb.ToString());
            }
        }

        [Route("users")]
        [SwaggerOperation("Signup")]
        [HttpPost]
        public HttpResponseMessage SignUp([FromBody] User user)
        {
            return Process((dummy) => Actions.SignUp(user), HttpStatusCode.Created);
        }

        [Route("access-tokens/refresh")]
        [SwaggerOperation("Refresh Jwt")]
        [HttpPost]
        public HttpResponseMessage RefreshJwt([FromBody] RefreshToken refresh_token)
        {
            return Process((dummy) => Actions.RefreshToken(refresh_token.refresh_token), HttpStatusCode.OK);
        }

        [Route("access-tokens")]
        [SwaggerOperation("User login")]
        [HttpPost]
        public HttpResponseMessage Login([FromBody] LoginPars login)
        {
            return Process((dummy) => Actions.Login(login.email, login.password), HttpStatusCode.Created);
        }

        [Route("access-tokens")]
        [SwaggerOperation("User logout")]
        [HttpDelete]
        public HttpResponseMessage Logout([FromBody] RefreshToken refresh_token)
        {
            return Process((dummy) => Actions.Logout(refresh_token.refresh_token), HttpStatusCode.NoContent);
        }

        [Route("me")]
        [SwaggerOperation("User info")]
        [HttpGet]
        public HttpResponseMessage Me()
        {
            return Process((email) => Actions.GetMe(email), checkLogin: true);
        }

        [Route("ideas")]
        [SwaggerOperation("Create idea")]
        [HttpPost]
        public HttpResponseMessage CreateIdea([FromBody] NewIdea idea)
        {
            return Process((email) => Actions.CrUpIdea(idea, email), HttpStatusCode.Created, true);
        }

        [Route("ideas/{id}")]
        [SwaggerOperation("Delete idea")]
        [HttpDelete]
        public HttpResponseMessage DeleteIdea(string id)
        {
            return Process((email) => Actions.DeleteIdea(id, email), HttpStatusCode.NoContent, true);
        }

        [Route("ideas/{id}")]
        [SwaggerOperation("Update idea")]
        [HttpPut]
        public HttpResponseMessage UpdateIdea(string id, [FromBody] NewIdea idea)
        {
            return Process((email) => Actions.CrUpIdea(idea, email, id), checkLogin: true);
        }

        [Route("ideas")]
        [SwaggerOperation("Get ideas")]
        [HttpGet]
        public HttpResponseMessage GetIdeas(int page = -1)
        {
            return Process((email) => Actions.GetIdeas(email, page), checkLogin: true);
        }

    }
}
