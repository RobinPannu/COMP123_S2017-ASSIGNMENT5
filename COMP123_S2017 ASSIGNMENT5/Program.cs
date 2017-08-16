using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_ASSIGNMENT5
{
 /*
 * Name: Robin Singh Pannu
 * Student ID: 300930741
 * Date: August 15th, 2017
 * Description: BMI calculator Project's driver class.
 * Version 0.1:- Splashform start.
 */
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
            Application.Run(new SplashForm());
        }
    }
}
