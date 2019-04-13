using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinformsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelWiek_Click(object sender, EventArgs e)
        {
            MessageBox.Show("klik");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            labelKomunikat1.Text = "Witaj," + textBoxImię.Text + " " + textBoxNazwisko.Text;

            if (!string.IsNullOrEmpty(textBoxWiek.Text))
            {
                int wiek = Convert.ToInt32(textBoxWiek.Text);
                if (wiek < 67)
                {
                    labelKomunikat2.Text = string.Format(" do emerytury zostało Ci {0} lat", 67 - wiek);
                }
                else
                {
                    labelKomunikat2.Text = "jesteś emerytem";
                }
            }
            else
            {
                labelKomunikat2.Text = "Proszę, podaj wiek";
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
