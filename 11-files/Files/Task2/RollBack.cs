using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Task2
{
    internal class RollBack
    {
        private HashSet<DateTime> availableRollBacks;
        private List<string> pathMathes = new List<string>();
        private string[] filesList;

        private string reposytoryPath;

        public RollBack(string reposytoryPath, string backUpFolderPath)
        {
            GetAvailableRollBacks(backUpFolderPath);

            this.reposytoryPath = reposytoryPath;
        }
      
        public void ShowAvailableRollBacks()
        {           
            Console.WriteLine(string.Join(" | ",availableRollBacks));
        }

        public bool RollBackTo(DateTime dateForRollBack)
        {
            if (availableRollBacks.Contains(dateForRollBack))
            {
                StartRollBack(dateForRollBack);

                return true;
            }

            return false;

        }

        /// <summary>
        /// Gets RollBack list without repetitions
        /// </summary>
        private void GetAvailableRollBacks(string backUpFolderPath)
        {
            filesList = Directory.GetFiles(backUpFolderPath, "*.txt", SearchOption.AllDirectories);

            availableRollBacks = new HashSet<DateTime>();

            foreach (var file in filesList)
            {
                availableRollBacks.Add(DateTimeParser(Path.GetFileNameWithoutExtension(file)));
            }

        }

        private DateTime DateTimeParser(string dateTime)
        {       
            return DateTime.ParseExact(dateTime, "dd-MM-yyyy HH-mm",
                                      System.Globalization.CultureInfo.InvariantCulture);
        }
      
           

        private void StartRollBack(DateTime dateForRollBack)
        {
            GetAllRollBackPaths(dateForRollBack);

            string fileToRollBack;

            foreach (var path in pathMathes)
            {
                fileToRollBack = $"{Directory.GetParent(path).Name}.txt";

                foreach (var filePath in Directory.GetFiles(reposytoryPath, "*.txt", SearchOption.AllDirectories))
                {
                    if (Path.GetFileName(filePath) == fileToRollBack)
                    {
                        File.Copy(path, filePath, true);
                        break;
                    }
                }

            }

        }

        /// <summary>
        /// Check all filles and tries to find matches by date
        /// </summary>
        /// <param name="dateForRollBack"></param>
        /// <returns>List of RollBack paths that satisfy the condion of the date</returns>
        private void GetAllRollBackPaths(DateTime dateForRollBack)
        {
            foreach (var file in filesList)
            {
                if (dateForRollBack.ToString("dd-MM-yyyy HH-mm") == Path.GetFileNameWithoutExtension(file))
                {
                    pathMathes.Add(file);
                }            
            }         
        }

    }
}
