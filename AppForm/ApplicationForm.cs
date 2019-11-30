using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppForm
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            btnGenerate.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cbAgree.Checked)
            {
                panel1.Visible = true;
                btnGenerate.Visible = true;
                textBoxTermsandConditions.Visible = false;
                btnNext.Visible = false;
                cbAgree.Visible = false;
            }
            else{
                MessageBox.Show("Please Check the Terms and Conditions Aggreement");
            }
            
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }

        private void labelEmailAddr_Click(object sender, EventArgs e)
        {

        }
    }
}
