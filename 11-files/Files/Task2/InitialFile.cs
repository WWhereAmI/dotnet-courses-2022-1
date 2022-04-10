using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Task2
{
    static class InitialFile
    {
        public static string FileFilter { get; }
        public static string RepositoryPath { get; }
        public static string BackUpFolderPath { get; }

        static InitialFile()
        {
            FileFilter = ConfigurationManager.AppSettings["FileFilter"];
            RepositoryPath = ConfigurationManager.AppSettings["RepositoryPath"];
            BackUpFolderPath = ConfigurationManager.AppSettings["BackUpFolderPath"];
        }

    }
}
