/**
* osu-cleaner
* Version: 1.0
* Author: henntix
* License: The MIT License (MIT)
*/

using System;
using System.Windows.Forms;

namespace osu_cleaner
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainApp());
        }
    }
}