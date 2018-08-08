using System;
using System.Windows.Forms;
namespace Call
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtResult.Text = Convert.ToInt32(txtFirstN.Text + txtSecondN.Text).ToString();
         

        }
    }
}
