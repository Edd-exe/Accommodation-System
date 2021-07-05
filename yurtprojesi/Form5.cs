using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yurtprojesi.Model;
using System.IO;
namespace yurtprojesi
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            bunifuDropdown1.selectedIndex = 0;
            tbGender.selectedIndex = 0;
        }

        /*  private void btnRegister_Click(object sender, EventArgs e)
          {
              string fname = tbFirstName.Text.Trim();
              string lname = tbLastName.Text.Trim();
              string email = tbEmail.Text.Trim();
              string tel = tbTelephone.Text.Trim();
              string gender = tbGender.Text.Trim();
              string don = tbRoomNo.Text;
              string rooom = tbRoomNo.Text.Trim();
              string pname = tbPFirstName.Text.Trim();
              string plname = tbPLastName.Text.Trim();
              string address = tbAddress.Text.Trim();
              //  int id = StudentID.Text.Trim();
              string pptell = tbPTel.Text.Trim();
              int departmentid = bunifuDropdown1.selectedIndex;

              Student s = new Student();
              s.AddStudent(fname, lname, email, tel, gender, departmentid, pname, plname, pptell, rooom);
              MessageBox.Show("kayıt eklenmiştir İNş");

          }
          */
      
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            

                string fname = tbFirstName.Text.Trim();
                string lname = tbLastName.Text.Trim();
                string email = tbEmail.Text.Trim();
                string tel = tbTelephone.Text.Trim();
                string gender = tbGender.selectedValue; 
               string rooom = tbRoomNo.Text.Trim();
               string pname = tbPFirstName.Text.Trim();
                string plname = tbPLastName.Text.Trim();
                string address = tbAddress.Text.Trim();   
               string pptell = tbPTel.Text.Trim();
                int departmentid = bunifuDropdown1.selectedIndex;

            int disc = 75;
            int perm = 0;
            int debt = 3000;
            Security s1 = new Security();
            if (fname.Length == 0 || lname.Length == 0 || email.Length == 0 || tel.Length == 0 || gender.Length == 0 || rooom.Length == 0 || pname.Length == 0 || plname.Length == 0 || address.Length == 0 || pptell.Length==0 || departmentid ==0 )
            {
                MessageBox.Show("All information must be filled");

            }
          else  if (!s1.IsNumeric(tel) || !s1.IsNumeric(pptell))
            {
                MessageBox.Show("Check your cell phone numbers");

            }
            else
            {
                Student s = new Student();
                s.AddStudent(fname, lname, email, tel, gender, departmentid, pname, plname, pptell, address, disc, perm, debt, rooom);
                MessageBox.Show("Registered");

                this.Hide();
            }

        }

        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
