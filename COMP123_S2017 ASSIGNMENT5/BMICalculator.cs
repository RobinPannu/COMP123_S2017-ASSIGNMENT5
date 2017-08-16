using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_ASSIGNMENT5
{
/*
* Name: Robin Singh Pannu
* Student ID: 300930741
* Date: August 15th, 2017
* Description: BMI calculator Project.
* Version 0.4:- Fixed the bug of Metric Calculation
*/
    public partial class BMICalculator : Form
    {
        //PRIVATE INSTANCE VARIABLES

        private double _bmiResult;
        private char _bmiScale;

        //PUBLIC PROPERTIES

        public double BMIResult
        {
            get
            {
                return this._bmiResult;
            }
            set
            {
                this._bmiResult = value;
            }
        }

        public char BMIScale
        {
            get
            {
                return this._bmiScale;
            }
            set
            {
                this._bmiScale = value;
            }
        }
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Weight = Convert.ToDouble(WeightTextBox.Text);
            double Height = Convert.ToDouble(HeightTextBox.Text);

            if (ImperialRadioButton.Checked)
            {
               
                this.BMIResult = ( Weight* 703) / (Math.Pow(Height,2));
            }

            else if (MetricsRadioButton.Checked)
            {
               
                this.BMIResult = (Weight) / (Math.Pow(Height, 2));
            }
            BMIResultTextBox.Text = Convert.ToString(BMIResult);

            if (this.BMIResult < 18.5)
            {
                BMIScale = 'U';
            }
            else if (this.BMIResult >= 18.5 && this.BMIResult <= 24.9)
            {
                BMIScale = 'N';
            }
            else if (this.BMIResult >= 25 && this.BMIResult <= 29.9)
            {
                BMIScale = 'O';
            }
            else if (this.BMIResult >= 30)
            {
                BMIScale = 'B';
            }

            switch (BMIScale)
            {
                case 'U':
                    BMITextBox.Text = "Underweight";
                    break;

                case 'N':
                    BMITextBox.Text = "Normal";
                    break;

                case 'O':
                    BMITextBox.Text = "Overweight";
                    break;

                case 'B':
                    BMITextBox.Text = "Obese";
                    break;

            }
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {
            HeightValueLabel.Text = "m";
            WeightValueLabel.Text = "kgs";
        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightValueLabel.Text = "m";
            WeightValueLabel.Text = "kgs";
        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            HeightValueLabel.Text = "In";
            WeightValueLabel.Text = "lbs";
        }
    }
}
