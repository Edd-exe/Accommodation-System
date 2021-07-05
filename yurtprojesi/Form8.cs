using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using yurtprojesi.Model;
using System.Data.SQLite;

namespace yurtprojesi
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }


        private void btnBackup_Click(object sender, EventArgs e)
        {


            File.Copy(@"C:\database\proje.db", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\kayit.db");
            MessageBox.Show("KAYITLAR YEDEKLENDİ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

       

        private void btnBackup_Click_2(object sender, EventArgs e)
        {

            File.Copy(@"C:\database\proje.db", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\kayit.db");
            MessageBox.Show("KAYITLAR YEDEKLENDİ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void tbMPassword_TextChanged(object sender, EventArgs e)
        {
            //gereksiz
        }

 
        private void dgM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           //geksiz

        }

        private void dgM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void btnMUpdate_Click(object sender, EventArgs e)
        {
            if (tbNewPassword.Text.Trim() != tbNewPasswordAgain.Text.Trim())
            {
                MessageBox.Show("Passwords are not same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNewPassword.Clear();
                tbNewPasswordAgain.Clear();

            }
            else if (tbNewPassword.Text.Length==0 || tbNewPasswordAgain.Text.Length==0)
            {
                MessageBox.Show("This field cannot be blank", "Info", MessageBoxButtons.OK);
                tbNewPassword.Focus();

            }
            else if (tbNewPassword.Text.Trim() == tbNewPasswordAgain.Text.Trim() && tbNewPassword.Text.Length!=0 || tbNewPasswordAgain.Text.Length!= 0)
            {
                string newp = tbNewPassword.Text.Trim();
                Manager m = new Manager();
                string old = lblread.Text;

              m.UpdateManager(newp, old);
                MessageBox.Show("Your password has been updated", "Info", MessageBoxButtons.OK);
                this.Hide();


            }





        }

        private void tbNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGO_MouseClick(object sender, MouseEventArgs e)
        {

            if (tbOldPassword.Text.Trim() == lblread.Text)
            {
                tbOldPassword.Visible = false;
                panelNewPassword.Visible = true;
                btnGO.Visible = false;
            }
            else MessageBox.Show("This password was not found", "Info", MessageBoxButtons.OK);
            tbOldPassword.Clear();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            panelNewPassword.Visible = false;
            string dbPath = @"data source=C:\database\proje.db";

            SQLiteConnection con = new SQLiteConnection(dbPath);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SQLiteCommand komut = new SQLiteCommand();

            komut.Connection = con;
            komut.CommandText = "select ManagerPassword as SIFRE from ManagersInfo Where Type=0";

            komut.ExecuteNonQuery();
            using (SQLiteDataReader dr = komut.ExecuteReader())
            {

                if (dr.Read())
                {
                    lblread.Text = dr["SIFRE"].ToString();
                }

                con.Close();
            }
        }
    }
}
