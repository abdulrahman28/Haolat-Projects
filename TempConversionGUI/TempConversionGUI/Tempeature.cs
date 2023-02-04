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
    public partial class Tempeature : Form
    {

        private float temp;
        private int opt = 1;

        public Tempeature()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            cvt_btn.Visible = false;
        }

        private void cvt_btn_Click(object sender, EventArgs e)
        {
            if (far_txt_box.Text != "" && opt == 1) cel_txt_box.Text = ((float.Parse(far_txt_box.Text) - 32f) * (5f / 9f)).ToString();

            if (cel_txt_box.Text != "" && opt == 2) far_txt_box.Text = ((float.Parse(cel_txt_box.Text) * (9f / 5f)) + 32f).ToString();

        }

        private void ext_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void far_txt_box_TextChanged(object sender, EventArgs e)
        {
            if (far_txt_box.Text != "") { cvt_btn.Visible = true; opt = 1; }
            else cvt_btn.Visible = false;
        }

        private void cel_txt_box_TextChanged(object sender, EventArgs e)
        {
            /*
            if (cel_txt_box.Text != "") { cvt_btn.Visible = true; opt = 2; }
            else cvt_btn.Visible = false;
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * */
        }

                      private void clr_btn_Click(object sender, EventArgs e)
        {
            far_txt_box.Clear();
            cel_txt_box.Clear();
        }

        private void main_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainPage().Show();
        }




    }
}
