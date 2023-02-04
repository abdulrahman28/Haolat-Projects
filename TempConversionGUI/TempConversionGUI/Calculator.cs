using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConversionGUI
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            setRes("0");
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            setRes("1");
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            setRes("2");
        }



        private void setRes(String val) {
            if (eqPress == true) { ResBox.Clear(); ResBox.Text = "0"; eqPress = false; }
            if (ResBox.Text == "0") ResBox.Text = val;
            else ResBox.Text += val;
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            setRes("3");
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            setRes("4");
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            setRes("5");
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            setRes("6");
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            setRes("7");
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            setRes("8");
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            setRes("9");
        }

        private void DecBtn_Click(object sender, EventArgs e)
        {
            if (!ResBox.Text.Contains(".")) ResBox.Text += ".";
        }

        private void PlusMinuBtn_Click(object sender, EventArgs e)
        {
            if (!ResBox.Text.Contains("-")) ResBox.Text = "-" + ResBox.Text;
            else ResBox.Text = ResBox.Text.Trim('-');
        }

        private decimal firVal;
        private decimal secVal;
        String op;

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            firVal = decimal.Parse(ResBox.Text);
            op = "+";
            setRes(op);
            ResBox.Clear();
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            firVal = decimal.Parse(ResBox.Text);
            op = "-";
            setRes(op);
            ResBox.Clear();
        }

        private void DivBtn_Click(object sender, EventArgs e)
        {
            firVal = decimal.Parse(ResBox.Text);
            op = "/";
            setRes(op);
            ResBox.Clear();
        }

        private void MultBtn_Click(object sender, EventArgs e)
        {
            firVal = decimal.Parse(ResBox.Text);
            op = "x";
            setRes(op);
            ResBox.Clear();
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            ResBox.Clear();
            ResBox.Text = "0";
        }

        private bool eqPress = false;

        private void EqualBtn_Click(object sender, EventArgs e)
        {

            eqPress = true;

            secVal = decimal.Parse(ResBox.Text);
            switch(op){
                case "+":
                    ResBox.Text = (firVal + secVal).ToString();
                    break;

                case "-":
                    ResBox.Text = (firVal - secVal).ToString();
                    break;

                case "/":
                    ResBox.Text = (firVal / secVal).ToString();
                    break;

                case "x":
                    ResBox.Text = (firVal * secVal).ToString();
                    break;
            }
            
        }



    }
}
