using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BrowserAngular.Concrete;
using BrowserAngular.Models;

namespace BrowserAngular.Abstract
{
    public interface IDirectory
    {
        List<string> GetInitialtDirectories();
        List<string> GetDirectories(string path);
        long GetMinCountFiles(string path, long namber);
        List<string> GetFilesList(string path);
        List<string> GetDirectoriesList(string path);
    }
}