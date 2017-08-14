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
 * Description: BMI Calculator Application assignment to showcase windows forms and UI Controls
 * Version: 0.3 - Added 2 methods _calculateBmiImperial & _calculateBmiMetrics
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

        private void _calculateButton_Click(object sender, EventArgs e)
        {
            if (ImperialRadioButton.Checked)
            {
                _calculateBmiImperial();
                return;
            }
            else
            {
                _calculateBmiMetrics();
                return;
            }








            double weight, feet;
            bool wasParseSuccessful;

            wasParseSuccessful = double.TryParse(PoundsTextBox.Text, out weight);
            if (wasParseSuccessful == false)
            {
                MessageBox.Show(this, "Invalid weight");
                return;
            }

            wasParseSuccessful = double.TryParse(FeetTextBox.Text, out feet);
            if (wasParseSuccessful == false)
            {
                MessageBox.Show(this, "Invalid feet");
                return;
            }


            double bmi;
            if (ImperialRadioButton.Checked)
            {
                /*
                 * weightInPounds	x	703
heightInInches	x	heightInInches
                 */
                weight = double.Parse(PoundsTextBox.Text);
                feet = double.Parse(FeetTextBox.Text);
                double inches = double.Parse(InchesTextBox.Text);
                inches += feet * 12;

                bmi = (weight * 703) / (inches * inches);
            }
            else if (MetricRadioButton.Checked)
            {
                weight = double.Parse(KilogramsTextBox.Text);
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
                textBox1.Text = "Underweight";
                ResultTextBox.Text = "Less than 18.5";
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

        private void _calculateBmiMetrics()
        {
            double weight, centimeters;
            bool wasParseSuccessful;

            wasParseSuccessful = double.TryParse(KilogramsTextBox.Text, out weight);
            if (wasParseSuccessful == false)
            {
                MessageBox.Show(this, "Invalid weight");
                return;
            }
            wasParseSuccessful = double.TryParse(CentimetersTextBox.Text, out centimeters);
            if (wasParseSuccessful == false)
            {
                MessageBox.Show(this, "Invalid centimemters");
                return;
            }

            double meters = centimeters / 100;

            double bmi = weight / (meters * meters);

            BMITextBox.Text = string.Format("{0:F2}", bmi);

            if (bmi < 18.5)
            {
                textBox1.Text = "Underweight";
                ResultTextBox.Text = "Less than 18.5";
            }
            else if (18.5 <= bmi && bmi < 24.9)
            {
                textBox1.Text = "Normal";
                ResultTextBox.Text = "Between 18.5 and 24.9";
            }
            else if (25 <= bmi && bmi < 29.9)
            {
                textBox1.Text = "OverWeight";
                ResultTextBox.Text = "Between 25 and 29.9";
            }
            else
            {
                textBox1.Text = "Obese";
                ResultTextBox.Text = "30 or greater";
            }
        }

        private void _calculateBmiImperial()
        {
            double weight, feet, inches, bmi;
            bool wasParseSuccessful;

            wasParseSuccessful = double.TryParse(PoundsTextBox.Text, out weight);
            if (wasParseSuccessful == false)
            {
                MessageBox.Show(this, "Invalid weight");
                return;
            }

            wasParseSuccessful = double.TryParse(FeetTextBox.Text, out feet);
            if (wasParseSuccessful == false)
            {
                MessageBox.Show(this, "Invalid feet");
                return;
            }

            wasParseSuccessful = double.TryParse(InchesTextBox.Text, out inches);
            if (wasParseSuccessful == false)
            {
                MessageBox.Show(this, "Invalid inches");
                return;
            }

            /*
             * weightInPounds	x	703
heightInInches	x	heightInInches
             */
            inches += feet * 12;

            bmi = (weight * 703) / (inches * inches);

            BMITextBox.Text = string.Format("{0:F2}", bmi);

            if (bmi < 18.5)
            {
                textBox1.Text = "Underweight";
                ResultTextBox.Text = "Less than 18.5";
            }
            else if (18.5 <= bmi && bmi < 24.9)
            {
                textBox1.Text = "Normal";
                ResultTextBox.Text = "Between 18.5 and 24.9";
            }
            else if (25 <= bmi && bmi < 29.9)
            {
                textBox1.Text = "OverWeight";
                ResultTextBox.Text = "Between 25 and 29.9";
            }
            else
            {
                textBox1.Text = "Obese";
                ResultTextBox.Text = "30 or greater";
            }
        }

        /// <summary>
        /// This is an event handler for the "FormClosing" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
