using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Application.Controllers
{
    public class DefaultController : ApiController
    {
        //Post Method To test in the git 
        public string post()
        {
            return "This is the final demo for Git";
        }
        public string Put()
        {
            return "This is the put method";
        }
    }
}
