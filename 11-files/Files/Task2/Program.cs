using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Text.Json;

namespace Task2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            UpdateFoldersInformation();

            AuditModeStart("github");

            //StartProgram();
           
        }

        static void StartProgram()
        {

            Console.WriteLine("Choose mode: 1. AuditMode 2. RollingBackMode");

            string workMode;
            do
            {
                workMode = Console.ReadLine().Trim();

                

                switch (workMode)
                {
                    case "AuditMode":

                        Console.WriteLine("Input a path for watching");

                        var path = Console.ReadLine();

                        UpdateFoldersInformation();

                        AuditModeStart(path);                
                        break;

                    case "RollingBackMode":
                        RollingBackModeStart();
                        break;

                    default:
                        Console.WriteLine("Incorrect WorkMode");
                        break;
                }

            } while (workMode != "q");
        }

       
            
        static async void UpdateFoldersInformation()
        {
            var foldersPaths = Directory.GetDirectories(Directory.GetCurrentDirectory(), "", SearchOption.AllDirectories);

            using(FileStream fs = new FileStream("Folders.json", FileMode.Create))
            {
                await JsonSerializer.SerializeAsync(fs, foldersPaths);
            }
            
        }

        static void AuditModeStart(string path)
        {
            Console.WriteLine("Current mode: AuditMode");


            Audit audit = new Audit(path);
            audit.StartWork();
           


            while (Console.ReadLine() != "q") ;
        

        }

        static void RollingBackModeStart()
        {
            Console.WriteLine("Current mode: RollingBackMode");

            string dateToRecover;

            do
            {
                dateToRecover = Console.ReadLine().Trim();

                if (DateTime.TryParse(dateToRecover,out DateTime dateTime))
                {

                }
                else
                {
                    Console.WriteLine("Incorrect DateTime");
                }



            } while (dateToRecover != "q");
        }
    }
}
