using System;
using System.IO;
using System.Threading;

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
            if (!Directory.Exists(InitialFile.RepositoryPath))
            {
                throw new DirectoryNotFoundException("Repository directory doesn't exists");
            }

            if (!Directory.Exists(InitialFile.BackUpFolderPath))
            {
                throw new DirectoryNotFoundException("BackUp directory doesn't exists");
            }

            string workmode;

            do
            {
                Console.WriteLine("Choose mode: 1. AuditMode 2. RollingBackMode");

                workmode = Console.ReadLine().Trim();

                switch (workmode)
                {
                    case "1":
                    case "AuditMode":
                        AuditModeStart();
                        break;

                    case "2":
                    case "RollingBackMode":
                        RollingBackModeStart();
                        break;

                    default:
                        Console.WriteLine("Incorrect WorkMode");
                        break;

                }
            } while (workmode.ToUpper() != "Q");
           

            Console.WriteLine("Exiting from application...");
        }


        static private void AuditModeStart()
        {
            Console.WriteLine("Current mode: AuditMode");
            Console.WriteLine("Print 'Q' for exit...");

            using (Audit audit = new Audit())
            {
                audit.StartWork();

                while (Console.ReadKey().Key != ConsoleKey.Q) ;
            }

            Console.WriteLine("Exiting from AuditMode...");
        }


        static private void RollingBackModeStart()
        {
            Console.WriteLine("Current mode: RollingBackMode");

            DateTime dateForRollBack;
            RollBack rollBack = new RollBack();

            do
            {
                Console.WriteLine("Choose one of these RollBacks and print a date");
                rollBack.ShowAvailableRollBacks();

                if (DateTime.TryParse(Console.ReadLine(), out dateForRollBack))
                {
                    if (rollBack.RollBackTo(dateForRollBack))
                    {
                        Console.WriteLine("RollBack is Successful");
                    }
                    else
                    {
                        Console.WriteLine("Some troubles with a RollBack. Continue (Y/N)?");
                    }

                }
                else
                {
                    Console.WriteLine("Incorrect rollback datetime. Continue (Y/N)?");
                }
               
            } while (Console.ReadKey().Key != ConsoleKey.N);

            Console.WriteLine("Exiting from RollingBackMode...");
        }






    }
}
