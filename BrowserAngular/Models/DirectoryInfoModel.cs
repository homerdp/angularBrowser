using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrowserAngular.Models
{
    public class DirectoryInfoModel

    {
        public List<string> InitialPath = new List<string>();
        public long CountMinFiles { get; set; }
        public List<string> FilesList = new List<string>();
        public List<string> DirectoriesList = new List<string>();
 
    }
}