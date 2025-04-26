using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NajibN.Sprint6.Task1.V14.Lib;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.NajibN.Sprint6.Task1.V14
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            object value = Application.EnableVisualStyles();
            object value1 = Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain_LMV());
        }
      
        }
    }

