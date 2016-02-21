using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using BrowserAngular.Abstract;
using BrowserAngular.Models;

namespace BrowserAngular.Concrete
{
    public class DirectoryInform : IDirectory
    {
        public List<string> GetInitialtDirectories()
        {
            List<string> drivesList = new List<string>();
            try
            {
                DriveInfo[] allDrives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in allDrives)
                {
                    if (drive.DriveType == DriveType.Fixed)
                    {
                        drivesList.Add(drive.Name);
                    }
                }
            }
            catch(IOException ex){}
            catch (UnauthorizedAccessException ex) { }

           
            return drivesList;

            
        }

        public List<string> GetDirectories(string path)
        {
            List<string> directList = new List<string>();
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                foreach (var item in dir.GetDirectories())
                {
                    directList.Add(item.Name);
                }   
            }
            catch (ArgumentNullException ex) { }
            catch (ArgumentException ex) { }
            catch (System.Security.SecurityException ex) { }
            catch (PathTooLongException ex) { }
                                                               

            return directList;
        }

        public long GetMinCountFiles(string path, long number)
        {
            long count = 0;
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                IEnumerable<FileInfo> filesInfo = dir.EnumerateFiles("*", SearchOption.AllDirectories);
                foreach (var info in filesInfo)
                {
                    if (info.Length < number)
                    {
                        count++;
                    }
                }
            }
            catch(ArgumentNullException ex) { }
            catch(ArgumentException ex) { }
            catch(System.Security.SecurityException ex) { }
            catch(PathTooLongException ex) { }
            catch(DirectoryNotFoundException ex) { }
            catch (System.UnauthorizedAccessException ex) { }
            return count;
        }

        public List<string> GetDirectoriesList(string path)
        {
            List<string> dirList = new List<string>();
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                foreach (var dir in dirInfo.GetDirectories())
                {
                    dirList.Add(dir.Name);
                }
            }
            catch (ArgumentNullException ex) { }
            catch (ArgumentException ex) { }
            catch (System.Security.SecurityException ex) { }
            catch (PathTooLongException ex) { }
            
            return dirList;
        }

        public List<string> GetFilesList(string path)
        {
            List<string> dirList = new List<string>();
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                foreach (var dir in dirInfo.GetFiles())
                {
                    dirList.Add(dir.Name);
                }
            }
            catch (ArgumentNullException ex) { }
            catch (ArgumentException ex) { }
            catch (System.Security.SecurityException ex) { }
            catch (PathTooLongException ex) { }

            return dirList;
            
        }
    }
}