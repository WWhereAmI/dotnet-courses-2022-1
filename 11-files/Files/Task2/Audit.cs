using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace Task2
{
    internal class Audit
    {
        
        private string path;

        public Audit(string path)
        {
            this.path = path;
        }

        public void StartWork()
        {
            foreach (var item in GetAllDirectories())
            {
                InitialWatcher(item);
            }
            
        }
        
        private List<string> GetAllDirectories()
        {
            var json = File.ReadAllText("Folders.json");
        
            return JsonSerializer.Deserialize<List<string>>(json);   
        }

        private FileSystemWatcher InitialWatcher(string folder)
        {
            FileSystemWatcher watcher = new FileSystemWatcher(folder);

            watcher.Changed += FileModified;
            watcher.Created += FileModified;

            watcher.Filter = "*.txt";

            watcher.EnableRaisingEvents = true;

            return watcher;
        }

     


        private void FileModified(object sender, FileSystemEventArgs e)
        {
            
            File.Copy(e.FullPath, $"BackUp\\{e.Name}");

            Console.WriteLine($"{e.FullPath} has been changed");
        }
    }
}
