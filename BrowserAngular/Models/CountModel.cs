using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrowserAngular.Models
{
    public class CountModel
    {
        public long CountLessFiles { get; set; }
        public long CountBetweenFiles { get; set; }
        public long CountMoreFiles { get; set; }
    }
}