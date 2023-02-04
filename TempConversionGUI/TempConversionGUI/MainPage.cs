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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ext_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void temp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Tempeature().Show();
        }

        private void circle_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Circle().Show();
        }


    }
}
