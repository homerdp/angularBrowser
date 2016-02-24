using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BrowserAngular.Abstract;
using BrowserAngular.Models;

namespace BrowserAngular.Controllers
{
    public class CountController : ApiController
    {
        IDirectory _directory;
        const long MinValue = 10485760;  //10Mb
        const long BetweenValue = 52428800; //50Mb
        const long MaxValue = 104857600; //100Mb
        public CountController(IDirectory directory)
        {
            _directory = directory;
        }
        public bool Get()
        {
            return true;
        }

        
        public CountModel Get(string path)
        {
            CountModel count = new CountModel();
            count.CountLessFiles = _directory.GetLessCount(path, MinValue);
            count.CountBetweenFiles = _directory.GetBetweenCount(path, MinValue, BetweenValue);
            count.CountMoreFiles = _directory.GetMoreCount(path, MaxValue);
            return count;

        }

       
    }
}
