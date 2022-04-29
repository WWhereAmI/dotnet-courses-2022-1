using BLL.Main;
//using DAL.DB;
using System;
using System.Windows.Forms;
using Interfaces;
using DAL.List;
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

            #region Configuration
            //var builder = new ConfigurationBuilder().AddJsonFile("AppConfig.json", optional:false, reloadOnChange: true);
            //var config = builder.Build();

            //var settingsPersonBL = config["BL_Settings:Person_BL"];
            //var settingsPersonDAO = config["DAO_Settings:Person_DAO"];

            //var settingsAwardBL = config["BL_Settings:Award_BL"];
            //var settingsAwardDAO = config["DAO_Settings:Award_DAO"];
            #endregion

            var personDAO = new PersonDAO();
            IPersonBL personBL = new PersonBL(personDAO);

            var awardDAO = new AwardDAO();
            IAwardBL awardBL = new AwardBL(awardDAO);

            Application.Run(new FormDataBase(personBL, awardBL));
        }
    }
}
