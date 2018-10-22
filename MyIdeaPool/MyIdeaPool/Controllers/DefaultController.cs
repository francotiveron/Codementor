using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using MyIdeaPool.Models;

namespace MyIdeaPool.Controllers
{
    public class DefaultController : ApiController
    {
        [Route("users")]
        [SwaggerOperation("Signup")]
        [HttpPost]
        public HttpResponseMessage SignUp([FromBody] User user)
        {
            return Request.CreateResponse(HttpStatusCode.Created, Actions.SignUp(user));
        }

        [Route("access-tokens/refresh")]
        [SwaggerOperation("Refresh Jwt")]
        [HttpPost]
        public string RefreshJwt([FromBody] RefreshToken refresh_token)
        {
            return Actions.RefreshToken(refresh_token.refresh_token);
        }

        [Route("access-tokens")]
        [SwaggerOperation("User login")]
        [HttpPost]
        public HttpResponseMessage Login([FromBody] LoginPars login)
        {
            return Request.CreateResponse(HttpStatusCode.Created, Actions.Login(login.email, login.password));
        }

        [Route("access-tokens")]
        [SwaggerOperation("User logout")]
        [HttpDelete]
        public HttpResponseMessage Logout([FromBody] RefreshToken refresh_token)
        {
            Actions.Logout(refresh_token.refresh_token);
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }

        [Route("me")]
        [SwaggerOperation("User info")]
        [HttpGet]
        public Me Me()
        {
            Actions.CheckLogin(Request);
            var jwt = Request.Headers.GetValues("X-Access-Token").First();
            return Actions.GetMe(jwt);
        }

        [Route("ideas")]
        [SwaggerOperation("Create idea")]
        [HttpPost]
        public HttpResponseMessage CreateIdea([FromBody] NewIdea idea)
        {
            Actions.CheckLogin(Request);
            if (ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.Created, Actions.CrUpIdea(idea));
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        [Route("ideas/{id}")]
        [SwaggerOperation("Delete idea")]
        [HttpDelete]
        public HttpResponseMessage DeleteIdea(string id)
        {
            Actions.CheckLogin(Request);
            Actions.DeleteIdea(id);
            return Request.CreateResponse(HttpStatusCode.NoContent);
      }

        [Route("ideas/{id}")]
        [SwaggerOperation("Update idea")]
        [HttpPut]
        public HttpResponseMessage UpdateIdea(string id, [FromBody] NewIdea idea)
        {
            Actions.CheckLogin(Request);
            if (ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.OK, Actions.CrUpIdea(idea, id));
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        [Route("ideas")]
        [SwaggerOperation("Get ideas")]
        [HttpGet]
        public List<Idea> GetIdeas()
        {
            Actions.CheckLogin(Request);
            return Actions.GetIdeas();
        }

    }
}
