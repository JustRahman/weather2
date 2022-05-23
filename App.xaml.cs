using DevExpress.Mvvm;
using DevExpress.Xpf.Core;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.DB.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using weather.Model;

namespace weather
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        #region properties
        public string ServerName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DbName { get; set; }
        #endregion

        public App()
        {
            ReadFile();
            DbConnection();


            var splashScreenViewModel = new DXSplashScreenViewModel() { Title = "Hello" };
            SplashScreenManager.Create(() => new SplashScreens.DXSplashScreen(), splashScreenViewModel).ShowOnStartup();
        }

        private void DbConnection()
        {
            string _connStr = $"XpoProvider=MSSqlServer;Data Source={ServerName};User ID={UserName};Password={Password};Initial Catalog={DbName};Persist Security Info=true";
            try
            {
                XpoDefault.DataLayer = XpoDefault.GetDataLayer(_connStr, AutoCreateOption.DatabaseAndSchema);
                XpoDefault.Session.UpdateSchema();
                XpoDefault.Session = null;
                //  MessageBox.Show("BAza ustunlikli baglandy");
            }
            catch (UnableToOpenDatabaseException)
            {
                try
                {
                    XpoDefault.DataLayer = XpoDefault.GetDataLayer(_connStr, AutoCreateOption.DatabaseAndSchema);
                    XpoDefault.Session.UpdateSchema();
                }
                catch (Exception _ex)
                {
                    MessageBox.Show("Maglumatlar bazasyna baglanylmady. Indiki ýalňyşlylar ýüze çykdy " + _ex.Message);
                    //  Application.Exit();
                }
            }

        }

        private void ReadFile()
        {
            if (System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\config.sys"))
            {
                using (StreamReader Reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\config.sys"))
                {
                    string jsonFile = Reader.ReadToEnd();
                    configFile jsonConfig = JsonConvert.DeserializeObject<configFile>(jsonFile);

                    ServerName = jsonConfig.MSSQLServerName;
                    UserName = jsonConfig.MSSQLServerUserName;
                    Password = jsonConfig.MSSQLServerPassword;
                    DbName = jsonConfig.MSSQLServerDbName;
                }
            }
        }

    }
}
