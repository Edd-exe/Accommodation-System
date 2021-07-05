using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yurtprojesi
{
    public partial class Form11 : Form
    {
        Form1 f = null;
        public Form11()
        {
            InitializeComponent();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            openChildForm(new Form6());

        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            openChildForm(new Form12());
        }


        private void btnSetting_Click(object sender, EventArgs e)
        {
            //
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (f ==null)
            {
                f = new Form1();
            }

            this.Hide();
            f.Show();
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            openChildForm(new Form10());
        }
    }
}
