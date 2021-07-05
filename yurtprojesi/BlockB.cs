using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using yurtprojesi.Model;
using System.Data.SqlClient;

namespace yurtprojesi
{
    public partial class BlockB : Form
    {
        public BlockB()
        {
            InitializeComponent();
        }

        private void BlockB_Load(object sender, EventArgs e)
        {
            string dbPath = @"data source=C:\database\proje.db";

            SQLiteConnection con = new SQLiteConnection(dbPath);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SQLiteCommand komut = new SQLiteCommand();

            komut.Connection = con;
            komut.CommandText = "select count(RoomNo) as SAYI from StudentsInfo where RoomNo='B11'";

            komut.ExecuteNonQuery();
            using (SQLiteDataReader dr = komut.ExecuteReader())
            {
                if (dr.Read())
                {
                    lblread.Text = dr["SAYI"].ToString();
                }

                //        con.Close();
            }
            int a = Convert.ToInt32(lblread.Text);
            if (a >= 4)
            {

                B1.BackColor = Color.DarkRed;
            }
            lblread.Text = a.ToString();
            lblbos.Text = (4 - a).ToString();

            // string dbpath1 = @"data source=C:\database\proje.db";
            //   SQLiteConnection cons = new SQLiteConnection(dbpath1);
            //     if (cons.State == ConnectionState.Closed)
            //     {
            //        cons.Open();
            //    }
            SQLiteCommand komut2 = new SQLiteCommand();

            komut2.Connection = con;
            komut2.CommandText = "select count(RoomNo) as SAYI2 from StudentsInfo where RoomNo='B12'";

            komut2.ExecuteNonQuery();
            SQLiteDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {
                lblread2.Text = dr2["SAYI2"].ToString();
            }
            //     con.Close();
            int a2 = Convert.ToInt32(lblread2.Text);
            if (a2 >= 4)
            {

                B2.BackColor = Color.DarkRed;
            }
            lblread2.Text = a2.ToString();
            lblbos2.Text = (4 - a2).ToString();

            //3
            SQLiteCommand komut3 = new SQLiteCommand();

            komut3.Connection = con;
            komut3.CommandText = "select count(RoomNo) as SAYI3 from StudentsInfo where RoomNo='B13'";

            komut3.ExecuteNonQuery();
            SQLiteDataReader dr3 = komut3.ExecuteReader();
            if (dr3.Read())
            {
                lblread3.Text = dr3["SAYI3"].ToString();
            }
            // con.Close();
            int a3 = Convert.ToInt32(lblread3.Text);
            if (a3 >= 4)
            {

                B3.BackColor = Color.DarkRed;
            }
            lblread3.Text = a3.ToString();
            lblbos3.Text = (4 - a3).ToString();

            //4
            SQLiteCommand komut4 = new SQLiteCommand();

            komut4.Connection = con;
            komut4.CommandText = "select count(RoomNo) as SAYI4 from StudentsInfo where RoomNo='B21'";

            komut4.ExecuteNonQuery();
            SQLiteDataReader dr4 = komut4.ExecuteReader();
            if (dr4.Read())
            {
                lblread4.Text = dr4["SAYI4"].ToString();
            }
            //con.Close();
            int a4 = Convert.ToInt32(lblread4.Text);
            if (a4 >= 4)
            {

                B21.BackColor = Color.DarkRed;
            }
            lblread4.Text = a4.ToString();
            lblbos4.Text = (4 - a4).ToString();

            //5
            SQLiteCommand komut5 = new SQLiteCommand();

            komut5.Connection = con;
            komut5.CommandText = "select count(RoomNo) as SAYI5 from StudentsInfo where RoomNo='B22'";

            komut5.ExecuteNonQuery();
            SQLiteDataReader dr5 = komut5.ExecuteReader();
            if (dr5.Read())
            {
                lblread5.Text = dr5["SAYI5"].ToString();
            }
            // con.Close();
            int a5 = Convert.ToInt32(lblread5.Text);
            if (a5 >= 4)
            {

                B22.BackColor = Color.DarkRed;
            }
            lblread5.Text = a5.ToString();
            lblbos5.Text = (4 - a5).ToString();

            //6
            SQLiteCommand komut6 = new SQLiteCommand();

            komut6.Connection = con;
            komut6.CommandText = "select count(RoomNo) as SAYI6 from StudentsInfo where RoomNo='B23'";

            komut6.ExecuteNonQuery();
            SQLiteDataReader dr6 = komut6.ExecuteReader();
            if (dr6.Read())
            {
                lblread6.Text = dr6["SAYI6"].ToString();
            }
            con.Close();
            int a6 = Convert.ToInt32(lblread6.Text);
            if (a6 >= 4)
            {

                B23.BackColor = Color.DarkRed;
            }
            lblread6.Text = a6.ToString();
            lblbos6.Text = (4 - a6).ToString();

        }

        //fLOOR 1

        private void B1_Click(object sender, EventArgs e)
        {
            int a2 = Convert.ToInt32(lblread.Text);
            if (a2 >= 4)
            {
                MessageBox.Show("Oda dolu");
            }
            else if (a2 == 0 || a2 == 1 || a2 == 2 || a2 == 3)
            {
                Form5 d = new Form5();
                d.tbGender.selectedIndex = 1;
                d.tbGender.Enabled = false;
                d.tbRoomNo.Text = "B11";
                d.Show();
                this.Hide();
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            int a2 = Convert.ToInt32(lblread2.Text);
            if (a2 >= 4)
            {
                MessageBox.Show("Oda dolu");
            }
            else if (a2 == 0 || a2 == 1 || a2 == 2 || a2 == 3)
            {
                Form5 d = new Form5();
                d.tbGender.selectedIndex = 1;
                d.tbGender.Enabled = false;
                d.tbRoomNo.Text = "B12";
                d.Show();
                this.Hide();
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            int a2 = Convert.ToInt32(lblread3.Text);
            if (a2 >= 4)
            {
                MessageBox.Show("Oda dolu");
            }
            else if (a2 == 0 || a2 == 1 || a2 == 2 || a2 == 3)
            {
                Form5 d = new Form5();
                d.tbGender.selectedIndex = 1;
                d.tbGender.Enabled = false;
                d.tbRoomNo.Text = "B13";
                d.Show();
                this.Hide();
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
          

        }


        //fLOOR 2

        private void B21_Click(object sender, EventArgs e)
        {
            int a2 = Convert.ToInt32(lblread4.Text);
            if (a2 >= 4)
            {
                MessageBox.Show("Oda dolu");
            }
            else if (a2 == 0 || a2 == 1 || a2 == 2 || a2 == 3)
            {
                Form5 d = new Form5();
                d.tbGender.selectedIndex = 1;
                d.tbGender.Enabled = false;
                d.tbRoomNo.Text = "B21";
                d.Show();
                this.Hide();
            }
        }

        private void B22_Click(object sender, EventArgs e)
        {
            int a2 = Convert.ToInt32(lblread5.Text);
            if (a2 >= 4)
            {
                MessageBox.Show("Oda dolu");
            }
            else if (a2 == 0 || a2 == 1 || a2 == 2 || a2 == 3)
            {
                Form5 d = new Form5();
                d.tbGender.selectedIndex = 1;
                d.tbGender.Enabled = false;
                d.tbRoomNo.Text = "B22";
                d.Show();
                this.Hide();
            }
        }

        private void B23_Click(object sender, EventArgs e)
        {
            int a2 = Convert.ToInt32(lblread6.Text);
            if (a2 >= 4)
            {
                MessageBox.Show("Oda dolu");
            }
            else if (a2 == 0 || a2 == 1 || a2 == 2 || a2 == 3)
            {
                Form5 d = new Form5();
                d.tbGender.selectedIndex = 1;
                d.tbGender.Enabled = false;
                d.tbRoomNo.Text = "B23";
                d.Show();
                this.Hide();
            }
        }

        private void panelChildFormB_Paint(object sender, PaintEventArgs e)
        {

        }



        /*   private Form activeForm = null;
       private void openChildFormB(Form childForm)
       {
           if (activeForm != null)
               activeForm.Close();
           activeForm = childForm;
           childForm.TopLevel = false;
           childForm.Dock = DockStyle.Fill;
           panelChildFormB.Controls.Add(childForm);
           panelChildFormB.Tag = childForm;
           childForm.BringToFront();
           childForm.Show();

       }*/
    }
    
}
