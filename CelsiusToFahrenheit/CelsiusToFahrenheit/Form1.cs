using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CelsiusToFahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tokaTB_TextChanged(object sender, EventArgs e)
        {
            double tokaTBValue, ekaTBValue;
            errorLB.Visible = false;
            if (String.IsNullOrEmpty(tokaTB.Text))
            {
                ekaTB.Text = null;
                errorLB.Text = "Tarkista kentät!";
                errorLB.Visible = true;
                return;
            }
            tokaTBValue = Convert.ToDouble(tokaTB.Text);
            Math.Round(tokaTBValue, 2);
            ekaTBValue = (tokaTBValue - 32) / 1.8;
            ekaTB.Text = Convert.ToString(ekaTBValue);
        }


        private void ekaTB_TextChanged(object sender, EventArgs e)
        {
            double tokaTBValue, ekaTBValue;
            errorLB.Visible = false;
            if (String.IsNullOrEmpty(ekaTB.Text))
            {
                tokaTB.Text = null;
                errorLB.Text = "Tarkista kentät!";
                errorLB.Visible = true;
                return;
            }
            ekaTBValue = Convert.ToDouble(ekaTB.Text);
            Math.Round(ekaTBValue, 2);
            tokaTBValue = ekaTBValue * 1.8 + 32;
            tokaTB.Text = Convert.ToString(tokaTBValue);
        }
    }
}