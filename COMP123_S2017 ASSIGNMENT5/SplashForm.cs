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
 * Description: This is the SplashForm class.
 * Version 0.1:- Added Splashform tick event handler to stop the form and start the calculator
 */
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the SplashForm Tick event Handler.
        /// This hides the SplashForm after an interval and starts the Calculator form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormPictureBox_Click(object sender, EventArgs e)
        {
            BMICalculator bmiCalculator = new BMICalculator();
            bmiCalculator.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;
        }
    }
}
