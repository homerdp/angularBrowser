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
    public class DirController : ApiController
    {
        IDirectory _directory;
        public DirController(IDirectory directory)
        {
            _directory = directory;
        }

        public List<string> Get()
        {
            List<string> initialDir = _directory.GetInitialtDirectories();
            return initialDir;
        }

        public DirectoryInfoModel Get(string path)
        {
            DirectoryInfoModel dirModel = new DirectoryInfoModel();
            dirModel.InitialPath.Add(path);
            dirModel.DirectoriesList = _directory.GetDirectoriesList(path);
            dirModel.FilesList = _directory.GetFilesList(path);
            return dirModel;
        }
        
    }
}
