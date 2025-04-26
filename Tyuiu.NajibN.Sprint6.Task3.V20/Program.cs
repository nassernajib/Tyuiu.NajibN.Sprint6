using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NajibN.Sprint6.Task3.V20.Lib;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.NajibN.Sprint6.Task3.V20
{
    internal static class Program
    {
        public static object ApplicationConfiguration { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
            {
            }
        }
    }
}
