using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NajibN.Sprint6.Task0.V18.Lib;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.NajibN.Sprint6.Task0.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                /// <summary>
                /// The main entry point for the application.
                /// </summary>
                [STAThread]
                static void Main()
                {
                    object value = Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new FormMain());
                }
            }
        }
    }
}
