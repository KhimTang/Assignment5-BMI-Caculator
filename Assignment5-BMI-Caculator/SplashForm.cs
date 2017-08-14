using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Khim Tang
 * StudentID: 300920672
 * Date: August 14. 2017
 * Description: This is the SplashForm class
 * Version: 0.3 - Created SplashFormTimer
*/

namespace Assignment5_BMI_Caculator
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the "Tick" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplasFormtimer_Tick(object sender, EventArgs e)
        {
            BMICalculatorForm calculatorForm = new BMICalculatorForm();
            calculatorForm.Show();
            this.Hide();
            SplasFormtimer.Enabled = false;//This turns timer off
        }
    }
}
