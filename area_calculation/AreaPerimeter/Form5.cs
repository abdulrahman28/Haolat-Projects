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
    public partial class Form5 : Form
    {
        Form4 prevPage;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            prevPage = new Form4();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            aTextBox.Text = String.Empty;
            bTextBox.Text = String.Empty;
            answerTextBox.Text = String.Empty;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (aTextBox.Text != "" && bTextBox.Text != "")
                {
                    if (comboBox1.Text == "+")
                    {
                        answerTextBox.Text = (float.Parse(aTextBox.Text) + float.Parse(bTextBox.Text)).ToString("F");
                    }
                    if (comboBox1.Text == "-")
                    {
                        answerTextBox.Text = (float.Parse(aTextBox.Text) - float.Parse(bTextBox.Text)).ToString("F");
                    }
                    if (comboBox1.Text == "*")
                    {
                        answerTextBox.Text = (float.Parse(aTextBox.Text) * float.Parse(bTextBox.Text)).ToString("F");
                    }
                    if (comboBox1.Text == "/")
                    {
                        answerTextBox.Text = (float.Parse(aTextBox.Text) / float.Parse(bTextBox.Text)).ToString("F");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevPage.Show();
        }

        private void aTextBox_TextChanged(object sender, EventArgs e)
        {
            if (aTextBox.Text != "" && bTextBox.Text != "")
            {
                calculateButton.Visible = true;
            }
            else
                calculateButton.Visible = false;

        }

        private void bTextBox_TextChanged(object sender, EventArgs e)
        {
            if (aTextBox.Text != "" && bTextBox.Text != "")
            {
                calculateButton.Visible = true;
            }
            else
                calculateButton.Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            aTextBox.Text = String.Empty;
            bTextBox.Text = String.Empty;
            answerTextBox.Text = String.Empty;
            */
        }

        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
