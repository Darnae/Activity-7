using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Calculations
{
    public partial class ApromiatePI : Form
    {
        public ApromiatePI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalcuateButton_Click(object sender, EventArgs e)
        {
            Random terms = new Random();
           
            double PI = System.Math.PI * terms.NextDouble();

            for (int i = 0; i < 10; i++)
            {
                TermsForPi.Text = terms.Next(1000,3000).ToString(); // will change range with each test

                ReferenceForPi.Text = TermsForPi.Text.Trim() + " terms";

                Results.Text = PI.ToString();

            }
        }
    }
}
