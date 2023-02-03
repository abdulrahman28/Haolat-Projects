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
    public partial class Form2 : Form
    {
        Form1 prevPage;
        Form3 myNewForm;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            prevPage = new Form1();
            myNewForm = new Form3();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            myNewForm.Show();
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
