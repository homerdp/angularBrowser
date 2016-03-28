using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BrowserAngular.Abstract;
namespace BrowserAngular.Controllers
{
    public class DataController : ApiController
    {
        private IData _data;
        public DataController(IData data)
        {
            _data = data;
        }
    }
}
