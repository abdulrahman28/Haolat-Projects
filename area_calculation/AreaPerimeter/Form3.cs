using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaPerimeter
{
    public partial class Form3 : Form
    {
        Form2 prevPage;
        Form4 myNewPage;
        private double temp1;
        private double temp2;

        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            prevPage = new Form2();
            myNewPage = new Form4();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            myNewPage.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevPage.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aTextBox_TextChanged(object sender, EventArgs e)
        {
            if (aTextBox.Text != "" && bTextBox.Text != "" && cTextBox.Text != "")
            {
                calculateButton.Visible = true;
            } 
            else 
                calculateButton.Visible = false;

        }

        private void bTextBox_TextChanged(object sender, EventArgs e)
        {
            if (aTextBox.Text != "" && bTextBox.Text != "" && cTextBox.Text != "")
            {
                calculateButton.Visible = true;
            }
            else
                calculateButton.Visible = false;
        }

        private void cTextBox_TextChanged(object sender, EventArgs e)
        {
            if (aTextBox.Text != "" && bTextBox.Text != "" && cTextBox.Text != "")
            {
                calculateButton.Visible = true;
            }
            else
                calculateButton.Visible = false;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (aTextBox.Text != "" && bTextBox.Text != "" && cTextBox.Text != "")
                {
                    temp1 = Math.Pow(double.Parse(bTextBox.Text), 2) - (4 * double.Parse(aTextBox.Text) * double.Parse(cTextBox.Text));
                    if (temp1 >= 0)
                    {
                        temp2 = Math.Sqrt(temp1);
                        x1TextBox.Text = ((-double.Parse(bTextBox.Text) + temp2) / (2 * double.Parse(aTextBox.Text))).ToString("F");
                        x2TextBox.Text = ((-double.Parse(bTextBox.Text) - temp2) / (2 * double.Parse(aTextBox.Text))).ToString("F");
                    } 
                    else
                    {
                        temp1 = temp1 * -1;
                        temp2 = Math.Sqrt(temp1) / (2 * double.Parse(aTextBox.Text));
                        x1TextBox.Text = ((-double.Parse(bTextBox.Text)) / (2 * double.Parse(aTextBox.Text))).ToString("F") + " + " + temp2.ToString("F") + " i";
                        x2TextBox.Text = ((-double.Parse(bTextBox.Text)) / (2 * double.Parse(aTextBox.Text))).ToString("F") + " - " + temp2.ToString("F") + " i";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            aTextBox.Text = String.Empty;
            bTextBox.Text = String.Empty;
            cTextBox.Text = String.Empty;
            x1TextBox.Text = String.Empty;
            x2TextBox.Text = String.Empty;
        }
    }
}
