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
    public partial class Form3 : Form
    {
        
        Form1 f = null;
        public Form3()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelStudentSubmenu.Visible = false;
            panelBlockSubmenu.Visible = false;
            //panelPermissionSubmenu.Visible = false;
           // panelPaymentSubmenu.Visible = false;
            panelSettingSubmenu.Visible = false;
            //...

        }

        private void hideSubMenu()
        {
            if (panelStudentSubmenu.Visible == true)
                panelStudentSubmenu.Visible = false;

            if (panelBlockSubmenu.Visible == true)
                panelBlockSubmenu.Visible = false;

           // if (panelPermissionSubmenu.Visible == true)
            //    panelPermissionSubmenu.Visible = false;

           // if (panelPaymentSubmenu.Visible == true)
           //     panelPaymentSubmenu.Visible = false;

            if (panelSettingSubmenu.Visible == true)
                panelSettingSubmenu.Visible = false;
            //...
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }



        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void studentUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStudentSubmenu);
        }
        //show student
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form6());
            
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBlockSubmenu);
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelPermissionSubmenu);
            openChildForm(new Form10());
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
         //   showSubMenu(panelPaymentSubmenu);
            openChildForm(new Form4());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSettingSubmenu);
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (f == null)
            {
                f = new Form1();
            }

            this.Hide();
            f.Show();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        { // burası edit student sayfasıdır
            openChildForm(new Form13());
        }

        private void btnOccupancy_Click(object sender, EventArgs e)
        {
            openChildForm(new Form7());
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
           
           
            
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            openChildForm(new Form8());
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPersonnel_Click_1(object sender, EventArgs e)
        {
           openChildForm(new Form9());
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            //gerekszi
        }
    }
}
