using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yurtprojesi
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
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


        private void bunifuCircleProgressbar1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void bunifuCircleProgressbar1_MouseClick_1(object sender, MouseEventArgs e)
        {
            
        }

        private void bunifuCircleProgressbar1_MouseClick_2(object sender, MouseEventArgs e)
        {

        }

        private void BlockB_MouseClick(object sender, MouseEventArgs e)
        {
            openChildForm(new BlockB());
        }

        private void BlockA_MouseClick(object sender, MouseEventArgs e)
        {   
          
            openChildForm(new BlockA());
            
        }

        private void BlockC_MouseClick(object sender, MouseEventArgs e)
        { 
            openChildForm(new BlockC());
        }

        private void BlockD_MouseClick(object sender, MouseEventArgs e)
        {
             openChildForm(new BlockD());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //gereksiz
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //gereksiz
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //gereksiz
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            string dbPath = @"data source=C:\database\proje.db";

            SQLiteConnection con = new SQLiteConnection(dbPath);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SQLiteCommand komut = new SQLiteCommand();

            komut.Connection = con;
            komut.CommandText = "select count(RoomNo) as SAYI from StudentsInfo where RoomNo like 'A%'";

            komut.ExecuteNonQuery();
            using (SQLiteDataReader dr = komut.ExecuteReader())
            {
                if (dr.Read())
                {
                    aaktif.Text = dr["SAYI"].ToString();
                }
                int aktif = Convert.ToInt32(aaktif.Text);
                {
                    if (aktif <= 8)
                    {

                        BlockA.ForeColor = Color.Green;

                    }
                    if (aktif > 8 && aktif <= 16)
                    {
                        BlockA.ForeColor = Color.DarkOrange;

                    }
                    if (aktif > 16 && aktif <= 24)
                    {
                        BlockA.ForeColor = Color.Red;

                    }
                }

                BlockA.Value = aktif;

            }

            //B
            SQLiteCommand komut2 = new SQLiteCommand();

            komut2.Connection = con;
            komut2.CommandText = "select count(RoomNo) as SAYI2 from StudentsInfo where RoomNo like 'B%'";

            komut2.ExecuteNonQuery();
            using (SQLiteDataReader dr2 = komut2.ExecuteReader())
            {
                if (dr2.Read())
                {
                    baktif.Text = dr2["SAYI2"].ToString();
                }
                int aktif2 = Convert.ToInt32(baktif.Text);
                {
                    if (aktif2 <= 8)
                    {

                        BlockB.ForeColor = Color.Green;

                    }
                    if (aktif2 > 8 && aktif2 <= 16)
                    {
                        BlockB.ForeColor = Color.DarkOrange;

                    }
                    if (aktif2 > 16 && aktif2<= 24)
                    {
                        BlockB.ForeColor = Color.Red;

                    }
                }

                BlockB.Value = aktif2;

            }
            //C
            SQLiteCommand komut3 = new SQLiteCommand();

            komut3.Connection = con;
            komut3.CommandText = "select count(RoomNo) as SAYI3 from StudentsInfo where RoomNo like 'C%'";

            komut3.ExecuteNonQuery();
            using (SQLiteDataReader dr3 = komut3.ExecuteReader())
            {
                if (dr3.Read())
                {
                    caktif.Text = dr3["SAYI3"].ToString();
                }
                int aktif3 = Convert.ToInt32(caktif.Text);
                {
                    if (aktif3 <= 8)
                    {

                        BlockC.ForeColor = Color.Green;

                    }
                    if (aktif3 > 8 && aktif3 <= 16)
                    {
                        BlockC.ForeColor = Color.DarkOrange;

                    }
                    if (aktif3 > 16 && aktif3 <= 24)
                    {
                        BlockC.ForeColor = Color.Red;

                    }
                }

                BlockC.Value = aktif3;

            }

            //D
            SQLiteCommand komut4 = new SQLiteCommand();

            komut4.Connection = con;
            komut4.CommandText = "select count(RoomNo) as SAYI4 from StudentsInfo where RoomNo like 'D%'";

            komut4.ExecuteNonQuery();
            using (SQLiteDataReader dr4= komut4.ExecuteReader())
            {
                if (dr4.Read())
                {
                    daktif.Text = dr4["SAYI4"].ToString();
                }
                int aktif4 = Convert.ToInt32(daktif.Text);
                {
                    if (aktif4 <= 8)
                    {

                        BlockD.ForeColor = Color.Green;

                    }
                    if (aktif4 > 8 && aktif4 <= 16)
                    {
                        BlockD.ForeColor = Color.DarkOrange;

                    }
                    if (aktif4 > 16 && aktif4 <= 24)
                    {
                        BlockD.ForeColor = Color.Red;

                    }
                }

                BlockD.Value = aktif4;

            }


        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
