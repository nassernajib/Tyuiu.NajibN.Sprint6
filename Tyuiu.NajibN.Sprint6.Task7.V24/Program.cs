﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NajibN.Sprint6.Task7.V24.Lib;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.NajibN.Sprint6.Task7.V24
{
    internal class Program
        {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
            }
        
        }
    }
}
