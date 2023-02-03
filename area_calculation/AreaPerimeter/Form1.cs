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
    public partial class Form1 : Form
    {
        Homepage homePage;
        private int option;
        Form2 myNewForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            homePage = new Homepage();
            myNewForm = new Form2();
            /*
            label2.Text = "Circumference :";
            label3.Visible = true;
            radiusBox.Visible = true;
            label4.Visible = false;
            lengthBox.Visible = false;
            label5.Visible = false;
            */
        }

        private void radiusBox_TextChanged(object sender, EventArgs e)
        {
            if (radiusBox.Text != "")
            {
                if (comboBox1.Text == "Circle" || comboBox1.Text == "Square")
                {
                    option = 1;
                    calculateButton.Visible = true;
                }
                else if (lengthBox.Text != "" && comboBox1.Text == "Rectangle")
                {
                    option = 1;
                    calculateButton.Visible = true;
                }
                else
                {
                    option = 0;
                    calculateButton.Visible = false;
                }
            }

            if (areaTextBox.Text != "" || PerimeterTextBox.Text != "")
            {
                if (comboBox1.Text == "Rectangle")
                {
                    if ((radiusBox.Text == "" && lengthBox.Text != "") || (radiusBox.Text != "" && lengthBox.Text == ""))
                    {
                        option = 2;
                        calculateButton.Visible = true;
                    }
                }
            }
        }


        private void lengthBox_TextChanged(object sender, EventArgs e)
        {
            if (radiusBox.Text != "" && lengthBox.Text != "" && comboBox1.Text == "Rectangle")
            {
                option = 1;
                calculateButton.Visible = true;
            }
            else
            {
                option = 0;
                calculateButton.Visible = false;
            }

            if (areaTextBox.Text != "" || PerimeterTextBox.Text != "")
            {
                if (comboBox1.Text == "Rectangle")
                {
                    if ((radiusBox.Text == "" && lengthBox.Text != "") || (radiusBox.Text != "" && lengthBox.Text == ""))
                    {
                        option = 2;
                        calculateButton.Visible = true;
                    }
                }
            }
        }

        private void areaTextBox_TextChanged(object sender, EventArgs e)
        {
            option = 0;
            calculateButton.Visible = false;
            if (areaTextBox.Text != "" && PerimeterTextBox.Text == "")
            {
                if (radiusBox.Text == "" && (comboBox1.Text == "Circle" || comboBox1.Text == "Square"))
                {
                    option = 2;
                    calculateButton.Visible = true;

                }
                if (comboBox1.Text == "Rectangle")
                {
                    if ((radiusBox.Text == "" && lengthBox.Text != "") || (radiusBox.Text != "" && lengthBox.Text == ""))
                    {
                        option = 2;
                        calculateButton.Visible = true;
                    }
                }
            }
        }

        private void PerimeterTextBox_TextChanged(object sender, EventArgs e)
        {
            option = 0;
            calculateButton.Visible = false;
            if (PerimeterTextBox.Text != "" && areaTextBox.Text == "")
            {
                if (radiusBox.Text == ""  && (comboBox1.Text == "Circle" || comboBox1.Text == "Square"))
                {
                    option = 2;
                    calculateButton.Visible = true;

                }
                if (comboBox1.Text == "Rectangle")
                {
                    if ((radiusBox.Text == "" && lengthBox.Text != "") || (radiusBox.Text != "" && lengthBox.Text == ""))
                    {
                        option = 2;
                        calculateButton.Visible = true;
                    }
                }
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (option == 1 && radiusBox.Text != "")
                {
                    if (comboBox1.Text == "Circle")
                    {
                        label2.Text = "Circumference :";
                        label3.Text = "Radius :";
                        label3.Visible = true;
                        radiusBox.Visible = true;
                        label4.Visible = false;
                        lengthBox.Visible = false;
                        areaTextBox.Text = ((22f / 7f) * float.Parse(radiusBox.Text) * float.Parse(radiusBox.Text)).ToString("F");
                        PerimeterTextBox.Text = (2f * (22f / 7f) * float.Parse(radiusBox.Text)).ToString("F");
                    }

                    if (lengthBox.Text != "" && comboBox1.Text == "Rectangle")
                    {
                        label2.Text = "       Perimeter :";
                        label3.Text = "Length :";
                        label3.Visible = true;
                        radiusBox.Visible = true;
                        label4.Text = "Width :";
                        label4.Visible = true;
                        lengthBox.Visible = true;
                        areaTextBox.Text = (float.Parse(lengthBox.Text) * float.Parse(radiusBox.Text)).ToString("F");
                        PerimeterTextBox.Text = (2 * (float.Parse(lengthBox.Text) + float.Parse(radiusBox.Text))).ToString("F");
                    }

                    if (comboBox1.Text == "Square")
                    {
                        label2.Text = "       Perimeter :";
                        label3.Text = "Length :";
                        label3.Visible = true;
                        radiusBox.Visible = true;
                        label4.Visible = false;
                        lengthBox.Visible = false;
                        areaTextBox.Text = (float.Parse(radiusBox.Text) * float.Parse(radiusBox.Text)).ToString("F");
                        PerimeterTextBox.Text = (4 * float.Parse(radiusBox.Text)).ToString("F");
                    }
                }
                else if (option == 2)
                {
                    if (areaTextBox.Text != "")
                    {
                        if (comboBox1.Text == "Circle" && radiusBox.Text == "")
                        {
                            label2.Text = "Circumference :";
                            label3.Text = "Radius :";
                            label3.Visible = true;
                            radiusBox.Visible = true;
                            label4.Visible = false;
                            lengthBox.Visible = false;
                            radiusBox.Text = (Math.Sqrt((7f / 22f) * float.Parse(areaTextBox.Text))).ToString("F");
                        }

                        if (comboBox1.Text == "Rectangle")
                        {
                            label2.Text = "       Perimeter :";
                            label3.Text = "Length :";
                            label3.Visible = true;
                            radiusBox.Visible = true;
                            label4.Text = "Width :";
                            label4.Visible = true;
                            lengthBox.Visible = true;
                            if (radiusBox.Text != "" && lengthBox.Text == "")
                                lengthBox.Text = (float.Parse(areaTextBox.Text) / float.Parse(radiusBox.Text)).ToString("F");
                            if (radiusBox.Text == "" && lengthBox.Text != "")
                                radiusBox.Text = (float.Parse(areaTextBox.Text) / float.Parse(lengthBox.Text)).ToString("F");
                        }

                        if (comboBox1.Text == "Square" && radiusBox.Text == "")
                        {
                            label2.Text = "       Perimeter :";
                            label3.Text = "Length :";
                            label3.Visible = true;
                            radiusBox.Visible = true;
                            label4.Visible = false;
                            lengthBox.Visible = false;
                            radiusBox.Text = (Math.Sqrt(float.Parse(areaTextBox.Text))).ToString("F");
                        }
                    } 
                    if (PerimeterTextBox.Text != "")
                    {
                        if (comboBox1.Text == "Circle")
                        {
                            label2.Text = "Circumference :";
                            label3.Text = "Radius :";
                            label3.Visible = true;
                            radiusBox.Visible = true;
                            label4.Visible = false;
                            lengthBox.Visible = false;
                            radiusBox.Text = ((1f / 2f) * (7f / 22f) * float.Parse(PerimeterTextBox.Text)).ToString("F");
                        }

                        if (comboBox1.Text == "Rectangle")
                        {
                            label2.Text = "       Perimeter :";
                            label3.Text = "Length :";
                            label3.Visible = true;
                            radiusBox.Visible = true;
                            label4.Text = "Width :";
                            label4.Visible = true;
                            lengthBox.Visible = true;
                            if (radiusBox.Text != "" && lengthBox.Text == "")
                                lengthBox.Text = ((float.Parse(PerimeterTextBox.Text) / 2) - float.Parse(radiusBox.Text)).ToString("F");
                            if (radiusBox.Text == "" && lengthBox.Text != "")
                                radiusBox.Text = ((float.Parse(PerimeterTextBox.Text) / 2) - float.Parse(lengthBox.Text)).ToString("F");
                        }

                        if (comboBox1.Text == "Square")
                        {
                            label2.Text = "       Perimeter :";
                            label3.Text = "Length :";
                            label3.Visible = true;
                            radiusBox.Visible = true;
                            label4.Visible = false;
                            lengthBox.Visible = false;
                            radiusBox.Text = (float.Parse(PerimeterTextBox.Text) / 4).ToString("F");
                        }
                    }

                }
                else //option is 0 
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            radiusBox.Text = String.Empty;
            lengthBox.Text = String.Empty;
            areaTextBox.Text = String.Empty;
            PerimeterTextBox.Text = String.Empty;
            if ((comboBox1.SelectedItem).ToString() == "Circle")
            {
                label2.Text = "Circumference :";
                label3.Text = "Radius :";
                label3.Visible = true;
                radiusBox.Visible = true;
                label4.Visible = false;
                lengthBox.Visible = false;
            }

            if ((comboBox1.SelectedItem).ToString() == "Rectangle")
            {
                label2.Text = "       Perimeter :";
                label3.Text = "Length :";
                label3.Visible = true;
                radiusBox.Visible = true;
                label4.Text = "Width :";
                label4.Visible = true;
                lengthBox.Visible = true;
            }

            if ((comboBox1.SelectedItem).ToString() == "Square")
            {
                label2.Text = "       Perimeter :";
                label3.Text = "Length :";
                label3.Visible = true;
                radiusBox.Visible = true;
                label4.Visible = false;
                lengthBox.Visible = false;
            }

        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            radiusBox.Text = String.Empty;
            lengthBox.Text = String.Empty;
            areaTextBox.Text = String.Empty;
            PerimeterTextBox.Text = String.Empty;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage.Show();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            myNewForm.Show();
        }
    }
}
