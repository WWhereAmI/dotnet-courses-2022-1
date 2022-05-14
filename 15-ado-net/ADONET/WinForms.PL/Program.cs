using BLL.Main;
using Interfaces;
using System;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace Task1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IPersonDAO personDAO;
            IAwardDAO awardDAO;

            SetUpConfiguration(out personDAO,out awardDAO);

            IPersonBL personBL = new PersonBL(personDAO);
            IAwardBL awardBL = new AwardBL(awardDAO);

            Application.Run(new FormDataBase(personBL, awardBL));
        }

        static private void SetUpConfiguration(out IPersonDAO personDAO, out IAwardDAO awardDAO)
        {
            var daoConfiguration = new ConfigurationBuilder().AddJsonFile("AppConfig.json", optional: true).Build();

            switch (daoConfiguration["CurrentDAO"])
            {
                case "DataBase":
                    personDAO = new DAL.DB.PersonDAO();
                    awardDAO = new DAL.DB.AwardDAO();
                    break;
                case "List":
                    personDAO = new DAL.List.PersonDAO();
                    awardDAO = new DAL.List.AwardDAO();
                    break;
                default:
                    throw new ArgumentException("DAO was not found");
            }
        }
    }
}
