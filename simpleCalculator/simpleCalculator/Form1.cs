using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try catch for exception handling
            try
            {
                //variables - easiest to just declare everything as decimal
                decimal usraAddTog;
                decimal addTog2;
                decimal addVar;
                decimal divVar;
                decimal subtVar;
                decimal multVar;

                //What to do with user input
                usraAddTog = decimal.Parse(firstNumtxtBox.Text);
                // recognized as decimal, user input = string, so need parse.
                addTog2 = decimal.Parse(secNumTxtBox.Text);
                
                //Calculations based on user input below.
                if (addRdBtn.Checked)
                {
                    addVar = usraAddTog + addTog2;
                    //calculation
                    ansTxtBox.Text = addVar.ToString(); 
                    //writes calculation to textbox
                }
                else if (subtRdBtn.Checked)
                {
                    subtVar = usraAddTog - addTog2;
                    //calculation
                    ansTxtBox.Text = subtVar.ToString();
                    //writes calculation to  answer textbox
                }
                else if (divRdBtn.Checked)
                {
                    divVar = usraAddTog / addTog2;
                    //calculation
                    ansTxtBox.Text = divVar.ToString();
                    //writes calculation to textbox
                }
                else if (multRdBtn.Checked)
                {
                    multVar = usraAddTog * addTog2;
                    //calculation
                    ansTxtBox.Text = multVar.ToString();
                    //writes calculation to textbox
                };
            } 
            catch 
            {   /* exception handling results below. 
                Also clears everything once exception message pops up */
                MessageBox.Show("Please try re-entering a number.");
                //user sees this first. then stuff below is cleared.
                firstNumtxtBox.Text = string.Empty;
                secNumTxtBox.Text = string.Empty;
                ansTxtBox.Text = string.Empty;
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            //Clear everything
            addRdBtn.Checked = false;
            subtRdBtn.Checked = false;
            divRdBtn.Checked = false;
            multRdBtn.Checked = false;
            firstNumtxtBox.Text = string.Empty;
            secNumTxtBox.Text = string.Empty;
            ansTxtBox.Text = string.Empty;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ansTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
