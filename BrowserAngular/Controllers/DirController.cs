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
        const long MinValue = 10485760;  //10Mb
        const long BetweenValue = 52428800; //50Mb
        const long MaxValue = 104857600; //100Mb
        public DirController(IDirectory directory)
        {
            _directory = directory;
        }

        // GET: api/Dir
        public DirectoryInfoModel Get()
        {
            DirectoryInfoModel dirModel = new DirectoryInfoModel();
            dirModel.InitialPath = _directory.GetInitialtDirectories();
            //dirModel.CountLessFiles = _directory.GetLessCount(@"C:\IIS", MinValue);
            //dirModel.CountBetweenFiles = _directory.GetBetweenCount(@"C:\IIS", MinValue, BetweenValue);
            //dirModel.CountMoreFiles = _directory.GetMoreCount(@"C:\IIS", MaxValue);
            //dirModel.DirectoriesList = _directory.GetDirectoriesList(_directory.GetInitialtDirectories()[0]);
            //dirModel.FilesList = _directory.GetFilesList(_directory.GetInitialtDirectories()[0]);


            return dirModel;

        }

        // GET: api/Dir/5
        public DirectoryInfoModel Get(string path)
        {
            DirectoryInfoModel dirModel = new DirectoryInfoModel();
            dirModel.InitialPath.Add(path);
            dirModel.CountLessFiles = _directory.GetLessCount(@"C:\IIS\Admin", MinValue);
            dirModel.CountBetweenFiles = _directory.GetBetweenCount(@"C:\IIS\Admin", MinValue, BetweenValue);
            dirModel.CountMoreFiles = _directory.GetMoreCount(@"C:\IIS\Admin", MaxValue);
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
