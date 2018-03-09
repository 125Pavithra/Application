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
        public string post()
        {
            return "This is the final demo for Git";
        }

        //Put Method to tset the in the git 
        public string Put()
        {
            return "This is the put method";
        }
        public string delete()
        {
            return "This is the delete method";
        }
    }
}
