using System;
using Microsoft.AspNetCore.Mvc;

namespace NewStore.Api.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public string Get()
        {            
            return "Hello World 1";
        }

        [HttpGet]
        [Route("error")]
        public string Error()
        {
            throw new Exception("Algum erro ocoreu.");
            return "Erro";
        }
    }
}