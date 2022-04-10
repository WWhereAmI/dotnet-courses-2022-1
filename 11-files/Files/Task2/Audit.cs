using System;
using System.Configuration;
using System.IO;

namespace Task2
{
    internal class Audit : IDisposable
    {

        private FileSystemWatcher watcher;

        public void StartWork()
        {
            InitialWatcher();
        }


        private void InitialWatcher()
        {
            watcher = new FileSystemWatcher(InitialFile.RepositoryPath);

            watcher.Changed += FileModified;
            watcher.Created += FileModified;

            watcher.Filter = InitialFile.FileFilter;

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
            string dirPath = Path.Combine(InitialFile.BackUpFolderPath, fileName);

            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }

            string logfilePath = Path.Combine(dirPath, $"{DateTime.Now:dd-MM-yyyy HH-mm}.txt");

            File.Copy(filePath, logfilePath, true);
        }

        public void Dispose()
        {
            watcher.Changed -= FileModified;
            watcher.Created -= FileModified;
            watcher.Dispose();
        }
    }
}
