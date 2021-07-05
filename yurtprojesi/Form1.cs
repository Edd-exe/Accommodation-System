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

namespace yurtprojesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            ddList.selectedIndex = 0;
            
        }
        


        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

   

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_2(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();

            int selecteddL = ddList.selectedIndex;

            if (selecteddL == 0)
            {
                Manager m = new Manager();
                if (m.Login(email, password, selecteddL))
                {
                    Form3 f = new Form3();
                    this.Hide();
                    f.ShowDialog();
                    
                }
                else
                {
                    lblMessage.Text = "Hatalı giriş";
                    lblMessage.ForeColor = Color.Red;

                }
            }

            if (selecteddL == 1)
            {

                Security ss = new Security();
                if (ss.LoginS(email, password, selecteddL))
                {
                    Form11 f1 = new Form11();
                    this.Hide();
                    f1.ShowDialog();
                    
                }
                else { lblMessage.Text = "Hatalı giriş";
                    lblMessage.ForeColor = Color.Red;
                }

            }
          
            
                
            

        }

        private void pcbExit_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }

        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                tbPassword.Focus();
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                ddList.Focus();
            }
        }

        private void ddList_onItemSelected(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
