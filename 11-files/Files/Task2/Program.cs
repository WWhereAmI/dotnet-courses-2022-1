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
     
            StartProgram();

        }

        static void StartProgram()
        {
            Console.WriteLine("Input the path to repository");

            var repositoryPath = Console.ReadLine();
            if (!Directory.Exists(repositoryPath))
            {
                Directory.CreateDirectory(repositoryPath);
            }

            var backUpFolderPath = "BackUp";
            if (!Directory.Exists(backUpFolderPath))
            {
                throw new DirectoryNotFoundException("BackUp directory doesn't exists");
            }

            string workMode;

            do
            {
                Console.WriteLine("Choose mode: 1. AuditMode 2. RollingBackMode");
                workMode = Console.ReadLine().Trim();
               
                switch (workMode)
                {
                    case "AuditMode":
                        AuditModeStart(repositoryPath, backUpFolderPath);                
                        break;

                    case "RollingBackMode":
                        RollingBackModeStart(repositoryPath, backUpFolderPath);
                        break;

                    default:
                        Console.WriteLine("Incorrect WorkMode");
                        break;
                }

            } while (workMode != "0");

            Console.WriteLine("Exiting from application...");
        }

    
        static private void AuditModeStart(string repositoryPath, string backUpFolderPath)
        {
            Console.WriteLine("Current mode: AuditMode");
            Console.WriteLine("Print '0' for exit...");

            Audit audit = new Audit(repositoryPath, backUpFolderPath);
            audit.StartWork();
           
            while (Console.ReadLine() != "0");
            
            audit.Dispose();      
            Console.WriteLine("Exiting from AuditMode...");
        }


        static private void RollingBackModeStart(string repositoryPath, string backUpFolderPath)
        {
            Console.WriteLine("Current mode: RollingBackMode");
            Console.WriteLine("Print '0' for exit...");

            DateTime dateForRollBack;
            RollBack rollBack = new RollBack(repositoryPath, backUpFolderPath);

            do
            {
                Console.WriteLine("Choose one of these RollBacks and print a date");
                rollBack.ShowAvailableRollBacks();

                if (DateTime.TryParse(Console.ReadLine(),out dateForRollBack))
                {
                    if (rollBack.RollBackTo(dateForRollBack))
                    {
                        Console.WriteLine("RollBack is Successful");
                    }
                    else
                    {
                        Console.WriteLine("Some troubles with RollBack");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Incorrect rollback datetime. Try again...");
                }

            } while (dateForRollBack != default);

            Console.WriteLine("Exiting from RollingBackMode...");
        }

     



        
    }
}
