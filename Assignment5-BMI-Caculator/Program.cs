using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Khim Tang
 * StudentID: 300920672
 * Date: August 04. 2017
 * Description: BMI Calculator Application assignment to showcase windows forms and UI Controls
 * Version: 0.2 - Started SplashForm first
*/

namespace Assignment5_BMI_Caculator
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
            Application.Run(new SplashForm());
        }
    }
}
