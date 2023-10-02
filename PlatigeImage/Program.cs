using log4net;
using System.IO;
using System.Reflection;
using System.Xml;

namespace PlatigeImage.View.WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new ApplicationInitializer().Initialize();
        }
    }


}