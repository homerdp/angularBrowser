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
        //List<string> GetDirectories(string path);
        List<string> GetFilesList(string path);
        List<string> GetDirectoriesList(string path);
        long GetLessCount(string path, long searchValue);
        long GetMoreCount(string path, long searchValue);
        long GetBetweenCount(string path, long searchValue1, long searchValue2);
    }
}