using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PlatigeImage.View.WinForms
{
    public class ApplicationInitializer
    {
        private static readonly ILog Log = log4net.LogManager.GetLogger(typeof(ApplicationInitializer));

        public void Initialize()
        {
            ApplicationConfiguration.Initialize();
            ConfigureLog4Net();
            Application.ThreadException += ApplicationOnThreadException;
            Application.Run(new MainView());
        }

        private void ConfigureLog4Net()
        {
            XmlDocument log4NetConfig = new XmlDocument();

            log4NetConfig.Load(File.OpenRead("log4net.config"));
            var repo = LogManager.CreateRepository(Assembly.GetEntryAssembly(), typeof(log4net.Repository.Hierarchy.Hierarchy));
            log4net.Config.XmlConfigurator.Configure(repo, log4NetConfig["log4net"]);
        }

        private static void ApplicationOnThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Log.Error(e.Exception.ToString(), e.Exception);
            MessageBox.Show("An error has occurred. Please restart application and try again.");
        }
    }
}
