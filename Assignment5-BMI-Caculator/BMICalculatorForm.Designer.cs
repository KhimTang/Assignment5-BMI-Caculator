namespace Assignment5_BMI_Caculator
{
    partial class BMICalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.FeetTextBox = new System.Windows.Forms.TextBox();
            this.InchesTextBox = new System.Windows.Forms.TextBox();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.PoundsTextBox = new System.Windows.Forms.TextBox();
            this.MyHeightCentimetersLabel = new System.Windows.Forms.Label();
            this.MyWeightKilogramsLabel = new System.Windows.Forms.Label();
            this.CentimetersTextBox = new System.Windows.Forms.TextBox();
            this.KilogramsTextBox = new System.Windows.Forms.TextBox();
            this.BMIIndexLabel = new System.Windows.Forms.Label();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResultTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ResultLable = new System.Windows.Forms.Label();
            this.BMIScaleTextBox = new System.Windows.Forms.TextBox();
            this.BMIScaleLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ResultTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.Location = new System.Drawing.Point(12, 12);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(91, 24);
            this.ImperialRadioButton.TabIndex = 0;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.Location = new System.Drawing.Point(12, 118);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(76, 24);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.AutoSize = true;
            this.MyHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyHeightLabel.Location = new System.Drawing.Point(13, 43);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(155, 16);
            this.MyHeightLabel.TabIndex = 2;
            this.MyHeightLabel.Text = "My Height (Feet - Inches)";
            // 
            // FeetTextBox
            // 
            this.FeetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeetTextBox.Location = new System.Drawing.Point(183, 42);
            this.FeetTextBox.Name = "FeetTextBox";
            this.FeetTextBox.Size = new System.Drawing.Size(69, 22);
            this.FeetTextBox.TabIndex = 3;
            // 
            // InchesTextBox
            // 
            this.InchesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InchesTextBox.Location = new System.Drawing.Point(258, 42);
            this.InchesTextBox.Name = "InchesTextBox";
            this.InchesTextBox.Size = new System.Drawing.Size(43, 22);
            this.InchesTextBox.TabIndex = 4;
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.AutoSize = true;
            this.MyWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeightLabel.Location = new System.Drawing.Point(16, 81);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(128, 16);
            this.MyWeightLabel.TabIndex = 5;
            this.MyWeightLabel.Text = "My Weight (Pounds)";
            // 
            // PoundsTextBox
            // 
            this.PoundsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoundsTextBox.Location = new System.Drawing.Point(183, 81);
            this.PoundsTextBox.Name = "PoundsTextBox";
            this.PoundsTextBox.Size = new System.Drawing.Size(70, 22);
            this.PoundsTextBox.TabIndex = 6;
            // 
            // MyHeightCentimetersLabel
            // 
            this.MyHeightCentimetersLabel.AutoSize = true;
            this.MyHeightCentimetersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyHeightCentimetersLabel.Location = new System.Drawing.Point(12, 149);
            this.MyHeightCentimetersLabel.Name = "MyHeightCentimetersLabel";
            this.MyHeightCentimetersLabel.Size = new System.Drawing.Size(150, 16);
            this.MyHeightCentimetersLabel.TabIndex = 7;
            this.MyHeightCentimetersLabel.Text = "My Height (Centimeters)";
            // 
            // MyWeightKilogramsLabel
            // 
            this.MyWeightKilogramsLabel.AutoSize = true;
            this.MyWeightKilogramsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeightKilogramsLabel.Location = new System.Drawing.Point(13, 183);
            this.MyWeightKilogramsLabel.Name = "MyWeightKilogramsLabel";
            this.MyWeightKilogramsLabel.Size = new System.Drawing.Size(142, 16);
            this.MyWeightKilogramsLabel.TabIndex = 8;
            this.MyWeightKilogramsLabel.Text = "My Weight (Kilograms)";
            // 
            // CentimetersTextBox
            // 
            this.CentimetersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CentimetersTextBox.Location = new System.Drawing.Point(183, 149);
            this.CentimetersTextBox.Name = "CentimetersTextBox";
            this.CentimetersTextBox.Size = new System.Drawing.Size(70, 22);
            this.CentimetersTextBox.TabIndex = 9;
            // 
            // KilogramsTextBox
            // 
            this.KilogramsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KilogramsTextBox.Location = new System.Drawing.Point(183, 183);
            this.KilogramsTextBox.Name = "KilogramsTextBox";
            this.KilogramsTextBox.Size = new System.Drawing.Size(70, 22);
            this.KilogramsTextBox.TabIndex = 10;
            // 
            // BMIIndexLabel
            // 
            this.BMIIndexLabel.AutoSize = true;
            this.BMIIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIIndexLabel.Location = new System.Drawing.Point(4, 305);
            this.BMIIndexLabel.Margin = new System.Windows.Forms.Padding(2, 16, 2, 2);
            this.BMIIndexLabel.Name = "BMIIndexLabel";
            this.BMIIndexLabel.Size = new System.Drawing.Size(173, 20);
            this.BMIIndexLabel.TabIndex = 11;
            this.BMIIndexLabel.Text = "BMI (Body Mass Index)";
            this.BMIIndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BMITextBox
            // 
            this.BMITextBox.Enabled = false;
            this.BMITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMITextBox.Location = new System.Drawing.Point(183, 303);
            this.BMITextBox.Margin = new System.Windows.Forms.Padding(3, 16, 3, 3);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.ReadOnly = true;
            this.BMITextBox.Size = new System.Drawing.Size(115, 22);
            this.BMITextBox.TabIndex = 12;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(27, 238);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(128, 32);
            this.CalculateButton.TabIndex = 15;
            this.CalculateButton.Text = "Calculate BMI";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this._calculateButton_Click);
            // 
            // ResultTableLayoutPanel
            // 
            this.ResultTableLayoutPanel.ColumnCount = 2;
            this.ResultTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.66667F));
            this.ResultTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.33333F));
            this.ResultTableLayoutPanel.Controls.Add(this.ResultTextBox, 1, 1);
            this.ResultTableLayoutPanel.Controls.Add(this.ResultLable, 1, 0);
            this.ResultTableLayoutPanel.Controls.Add(this.BMIScaleTextBox, 0, 1);
            this.ResultTableLayoutPanel.Controls.Add(this.BMIScaleLabel, 0, 0);
            this.ResultTableLayoutPanel.Location = new System.Drawing.Point(1, 330);
            this.ResultTableLayoutPanel.Name = "ResultTableLayoutPanel";
            this.ResultTableLayoutPanel.RowCount = 2;
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ResultTableLayoutPanel.Size = new System.Drawing.Size(300, 99);
            this.ResultTableLayoutPanel.TabIndex = 16;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.Location = new System.Drawing.Point(137, 64);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(154, 24);
            this.ResultTextBox.TabIndex = 14;
            // 
            // ResultLable
            // 
            this.ResultLable.AutoSize = true;
            this.ResultLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLable.Location = new System.Drawing.Point(138, 28);
            this.ResultLable.Margin = new System.Windows.Forms.Padding(4, 28, 3, 0);
            this.ResultLable.Name = "ResultLable";
            this.ResultLable.Size = new System.Drawing.Size(55, 20);
            this.ResultLable.TabIndex = 15;
            this.ResultLable.Text = "Result";
            // 
            // BMIScaleTextBox
            // 
            this.BMIScaleTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BMIScaleTextBox.Enabled = false;
            this.BMIScaleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIScaleTextBox.Location = new System.Drawing.Point(3, 64);
            this.BMIScaleTextBox.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.BMIScaleTextBox.Name = "BMIScaleTextBox";
            this.BMIScaleTextBox.ReadOnly = true;
            this.BMIScaleTextBox.Size = new System.Drawing.Size(128, 26);
            this.BMIScaleTextBox.TabIndex = 16;
            // 
            // BMIScaleLabel
            // 
            this.BMIScaleLabel.AutoSize = true;
            this.BMIScaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIScaleLabel.Location = new System.Drawing.Point(3, 28);
            this.BMIScaleLabel.Margin = new System.Windows.Forms.Padding(3, 28, 0, 0);
            this.BMIScaleLabel.Name = "BMIScaleLabel";
            this.BMIScaleLabel.Size = new System.Drawing.Size(78, 20);
            this.BMIScaleLabel.TabIndex = 17;
            this.BMIScaleLabel.Text = "BMIScale";
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(186, 238);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(115, 32);
            this.ResetButton.TabIndex = 17;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ResultTableLayoutPanel);
            this.Controls.Add(this.BMITextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.BMIIndexLabel);
            this.Controls.Add(this.KilogramsTextBox);
            this.Controls.Add(this.CentimetersTextBox);
            this.Controls.Add(this.MyWeightKilogramsLabel);
            this.Controls.Add(this.MyHeightCentimetersLabel);
            this.Controls.Add(this.PoundsTextBox);
            this.Controls.Add(this.MyWeightLabel);
            this.Controls.Add(this.InchesTextBox);
            this.Controls.Add(this.FeetTextBox);
            this.Controls.Add(this.MyHeightLabel);
            this.Controls.Add(this.MetricRadioButton);
            this.Controls.Add(this.ImperialRadioButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculatorForm_FormClosing);
            this.ResultTableLayoutPanel.ResumeLayout(false);
            this.ResultTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.TextBox FeetTextBox;
        private System.Windows.Forms.TextBox InchesTextBox;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.TextBox PoundsTextBox;
        private System.Windows.Forms.Label MyHeightCentimetersLabel;
        private System.Windows.Forms.Label MyWeightKilogramsLabel;
        private System.Windows.Forms.TextBox CentimetersTextBox;
        private System.Windows.Forms.TextBox KilogramsTextBox;
        private System.Windows.Forms.Label BMIIndexLabel;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TableLayoutPanel ResultTableLayoutPanel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label ResultLable;
        private System.Windows.Forms.TextBox BMIScaleTextBox;
        private System.Windows.Forms.Label BMIScaleLabel;
        private System.Windows.Forms.Button ResetButton;
    }
}

