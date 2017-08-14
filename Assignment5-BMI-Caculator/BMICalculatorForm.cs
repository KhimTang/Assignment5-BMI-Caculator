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
 * Date: August 04. 2017
 * Description: BMI Calculator Application assignment to showcase windows forms and UI Controls
 * Version: 0.2 - Added function to the BMI calculator buttons
*/

namespace Assignment5_BMI_Caculator
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double bmi;
            if (ImperialRadioButton.Checked)
            {
                /*
                 * weightInPounds	x	703
heightInInches	x	heightInInches
                 */
                double weight = double.Parse(PoundsTextBox.Text);
                double feet = double.Parse(FeetTextBox.Text);
                double inches = double.Parse(InchesTextBox.Text);
                inches += feet * 12;

                bmi = (weight * 703) / (inches * inches);
            }
            else if (MetricRadioButton.Checked)
            {
                double weight = double.Parse(KilogramsTextBox.Text);
                double centimeters = double.Parse(CentimetersTextBox.Text);
                double meters = centimeters / 100;

                bmi = weight / (meters * meters);
            }
            else
            {
                // ask user to select one
                bmi = 0;
            }
            BMITextBox.Text = string.Format("{0:F2}", bmi);

            if (bmi < 18.5)
            {
                Console.WriteLine();
                textBox1.Text = "Underweight";
                //ResultTextBox
            }
            else if (18.5 <= bmi && bmi < 24.9)
            {
                textBox1.Text = "Normal";
            }
            else if (25 <= bmi && bmi < 29.9)
            {
                textBox1.Text = "OverWeight";
            }
            else
            {
                textBox1.Text = "Obese";
            }
        }
    }
}
