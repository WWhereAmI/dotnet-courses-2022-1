using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Task2
{
    internal class Audit : IDisposable
    {
        private string repositoryPath;
        private string backUpFolderpath;

        private FileSystemWatcher watcher;

        public Audit(string repositoryPath, string backUpFolderpath)
        {
            this.repositoryPath = repositoryPath;
            this.backUpFolderpath = backUpFolderpath;
        }

        public void StartWork()
        {
            InitialWatcher(repositoryPath);
        }


        private void InitialWatcher(string folder)
        {
            watcher = new FileSystemWatcher(folder);

            watcher.Changed += FileModified;
            watcher.Created += FileModified;

            watcher.Filter = "*.txt";

            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
        }


        private void FileModified(object sender, FileSystemEventArgs e)
        {
            LogFile(e.FullPath, Path.GetFileNameWithoutExtension(e.FullPath));

            Console.WriteLine($"{e.Name} has been changed");
        }

        private void LogFile(string filePath, string fileName)
        {
            string content;

            using (StreamReader sr = new StreamReader(filePath))
            {
                content = sr.ReadToEnd();
            }

            if (!Directory.Exists($"{backUpFolderpath}\\{fileName}"))
            {
                Directory.CreateDirectory($"{backUpFolderpath}\\{fileName}");
            }

            using (StreamWriter sw = new StreamWriter($"{backUpFolderpath}\\{fileName}\\{DateTime.Now.ToString("dd-MM-yyyy HH-mm")}.txt"))
            {
                sw.WriteLine(content);
            }
        }

        public void Dispose()
        {
            watcher.Changed -= FileModified;
            watcher.Created -= FileModified;
            watcher.Dispose();
        }
    }
}
