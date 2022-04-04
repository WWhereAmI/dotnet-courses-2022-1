using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Task2
{
    internal class Audit
    {
        private FileSystemWatcher watcher;
        private string path;

        public Audit(string path)
        {
            this.path = path;
        }

        public void StartWork()
        {
            watcher = new FileSystemWatcher(path);

            watcher.Changed += FileModified;
            watcher.Created += FileModified;
            watcher.Deleted += FileModified;
            watcher.Renamed += FileModified;

            watcher.Filter = "*.txt";

            watcher.EnableRaisingEvents = true;
        }

        private void FileModified(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"{e.FullPath} has been changed");
        }
    }
}
