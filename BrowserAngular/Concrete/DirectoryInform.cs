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

        //public List<string> GetDirectories(string path)
        //{
        //    List<string> directList = new List<string>();
        //    try
        //    {
        //        DirectoryInfo dir = new DirectoryInfo(path);
        //        foreach (var item in dir.GetDirectories())
        //        {
        //            directList.Add(item.Name);
        //        }   
        //    }
        //    catch (ArgumentNullException ex) { }
        //    catch (ArgumentException ex) { }
        //    catch (System.Security.SecurityException ex) { }
        //    catch (PathTooLongException ex) { }
                                                               

        //    return directList;
        //}

       

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
        /////////////////////////////////////
        public long GetLessCount(string path, long searchValue)
        {
            long folderSize = 0;
            GetFileSize(path, ref folderSize, searchValue, 0, true);
            return folderSize;

        }
        public long GetMoreCount(string path, long searchValue)
        {
            long folderSize = 0;
            GetFileSize(path, ref folderSize, 0, searchValue, false, false, true);
            return folderSize;

        }
        public long GetBetweenCount(string path, long searchValue1, long searchValue2)
        {
            long folderSize = 0;
            GetFileSize(path, ref folderSize, searchValue1, searchValue2, false, true);
            return folderSize;

        }

        public void GetFileSize(string path, ref long size, long searchValue1, long searchValue2 = 0, bool less = false, bool between = false, bool more = false)
        {
            try
            {
                string[] files = System.IO.Directory.GetFiles(path);
                foreach (string file in files)
                {
                    if (less)
                    {
                        System.IO.FileInfo fi = new System.IO.FileInfo(file);
                        if (fi.Length <= searchValue1)
                            size++;
                    }
                    if (between)
                    {
                        System.IO.FileInfo fi = new System.IO.FileInfo(file);
                        if (fi.Length > searchValue1 && fi.Length <= searchValue2)
                            size++;
                    }
                    if (more)
                    {
                        System.IO.FileInfo fi = new System.IO.FileInfo(file);
                        if (fi.Length >= searchValue2)
                            size++;
                    }

                }
                string[] subDirs = System.IO.Directory.GetDirectories(path);
                foreach (string dir in subDirs)
                {
                    if (less)
                        GetFileSize(dir, ref size, searchValue1, 0, true);
                    if (between)
                        GetFileSize(dir, ref size, searchValue1, searchValue2, false, true);
                    if (more)
                        GetFileSize(dir, ref size, 0, searchValue2, false, false, true);
                }

            }
           
            catch (ArgumentNullException ex) { }
            catch (ArgumentException ex) { }
            catch (System.Security.SecurityException ex) { }
            catch (PathTooLongException ex) { }
            catch (UnauthorizedAccessException ex) { }
            catch (NotSupportedException ex) { }
            catch (DirectoryNotFoundException ex) { }
        }










    }
}