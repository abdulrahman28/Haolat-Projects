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
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }

        private void Circle_Load(object sender, EventArgs e)
        {
            area_lbl.Text = "";
            cir_lbl.Text = "";
        }

        private float radius;
        private double circum, area;

        private void clr() {
            cir_lbl.Text = String.Empty;
            area_lbl.Text = String.Empty;

        }
        private void rad_txt_box_TextChanged(object sender, EventArgs e)
        {

            if (rad_txt_box.Text == String.Empty) clr();

            else
            {
                try
                {

                    radius = float.Parse(rad_txt_box.Text);

                    circum = 2 * Math.PI * radius;

                    area = 2 * Math.PI * Math.Pow(radius, 2);

                    cir_lbl.Text = Math.Round(circum, 2).ToString();

                    area_lbl.Text = Math.Round(area, 2).ToString();

                }
                catch (Exception) { clr(); }
            }
        }

        private void main_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainPage().Show();
        }

        double ar, cir;

        bool srt = false;
        private void rtext_TextChanged(object sender, EventArgs e)
        {
            try {           

                if (rtext.Text != String.Empty && srt == true)
                {
                    cir = 2 * Math.PI * float.Parse(rtext.Text);
                    ar =  Math.PI * (Math.Pow(float.Parse(rtext.Text), 2));
                    cir = Math.Round(cir, 2);
                    ar = Math.Round(ar, 2);

                    ctext.Text = cir.ToString();
                    areatxt.Text = ar.ToString();

                    srt = false;

                }

                else srt = true;
            
            
            }
            
            catch(Exception){
            
            
            
            
            }
        }
    }
}
