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
    public partial class Form4 : Form
    {
        Form3 prevPage;
        Form5 myNewPage;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            prevPage = new Form3(); 
            myNewPage = new Form5();
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
    }
}
