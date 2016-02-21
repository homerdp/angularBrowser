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
        const long MinSize = 10737418240;  //10Mb
        public DirController(IDirectory directory)
        {
            _directory = directory;
        }

        // GET: api/Dir
        public DirectoryInfoModel Get()
        {
            DirectoryInfoModel dirModel = new DirectoryInfoModel();
            dirModel.InitialPath = _directory.GetInitialtDirectories();
            dirModel.CountMinFiles = _directory.GetMinCountFiles(_directory.GetInitialtDirectories()[0], MinSize);
            dirModel.DirectoriesList = _directory.GetDirectoriesList(_directory.GetInitialtDirectories()[0]);
            dirModel.FilesList = _directory.GetFilesList(_directory.GetInitialtDirectories()[0]);


            return dirModel;

        }

        // GET: api/Dir/5
        public DirectoryInfoModel Get(string path)
        {
            DirectoryInfoModel dirModel = new DirectoryInfoModel();
            dirModel.InitialPath.Add(path);
            dirModel.CountMinFiles = _directory.GetMinCountFiles(path, MinSize);
            dirModel.DirectoriesList = _directory.GetDirectoriesList(path);
            dirModel.FilesList = _directory.GetFilesList(path);
            return dirModel;
            
        }

        // POST: api/Dir
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Dir/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Dir/5
        public void Delete(int id)
        {
        }
    }
}
