using System;
using System.ComponentModel;
using System.IO;
using System.Threading;

namespace Task2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            AuditModeStart();

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
                        AuditModeStart();
                        break;
                    case "RollingBackMode":
                        RollingBackModeStart();
                        break;
                    case "q":
                        Console.WriteLine("Stopping the application...");
                        break;
                    default:
                        Console.WriteLine("Incorrect WorkMode");
                        break;
                }

            } while (workMode != "q");
        }

       
            
       

        static void AuditModeStart()
        {
            Console.WriteLine("Current mode: AuditMode");


            Audit audit = new Audit("github");
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
