using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NajibN.Sprint6.Task2.V30.Lib;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.NajibN.Sprint6.Task2.V30
{

         static class Program
        {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
            object value = Application.Run(new FormMain());
            }
        }
    }

