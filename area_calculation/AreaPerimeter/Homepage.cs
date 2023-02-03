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
    public partial class Homepage : Form
    {
        Form1 myNewForm;
        public Homepage()
        {
            InitializeComponent();
            //myNewForm = new Form1();
        }

      
         private void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            myNewForm.Show();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            myNewForm = new Form1();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
