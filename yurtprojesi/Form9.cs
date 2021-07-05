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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }



        private void Form9_Load(object sender, EventArgs e)
        {
           string name = tbPSearch.Text.Trim();
            Security s = new Security();
            dgManager.DataSource = s.GetAllSecurity();

    
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //delete
            // ID yi ekranda yazdırmak istemediğimiz için silmek için emaili parametre olarak belirledik.

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Delete Personnel?", "DELETE", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                lbl.Text = dgManager.CurrentRow.Cells[0].Value.ToString();
                string id = lbl.Text;
                Security d = new Security();
                d.DeleteSecurity(id);
               // MessageBox.Show("Registered", "Information Message", MessageBoxButtons.OK);
                //    string name = tbPSearch.Text.Trim();

                dgManager.DataSource = d.GetAllSecurity();
            }
            else
            {
                MessageBox.Show("Personnel not deleted");
            }

            


        }

        private void btnPUpdate_Click(object sender, EventArgs e)
        {
            

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Update Personnel?", "UPDATE", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

                string firstname = tbPFirstName.Text.Trim();
                string lastname = tbPLastName.Text.Trim();
                string email = tbPEmail.Text.Trim();
                string password = tbPPassword.Text.Trim();
                lbl.Text = dgManager.CurrentRow.Cells[0].Value.ToString();
                string id = lbl.Text;
                Security s = new Security();
                s.UpdateSecurity(firstname, lastname, email, password, id);
                //MessageBox.Show("Updated", "Information Message", MessageBoxButtons.OK);

                dgManager.DataSource = s.GetAllSecurity();
            }
            else
            {
                MessageBox.Show("Personnel not Update");
            }




           
        }

        private void btnPAdd_Click(object sender, EventArgs e)
        {
            string firstname = tbPFirstName.Text.Trim();
            string lastname = tbPLastName.Text.Trim();
            string email = tbPEmail.Text.Trim();
            string password = tbPPassword.Text.Trim();

            int typer = 1;
            Security s = new Security();
            s.AddSecurity(firstname, lastname, email, password, typer);
            MessageBox.Show("Registered", "Information Message", MessageBoxButtons.OK);
            string name = tbPSearch.Text.Trim();
            dgManager.DataSource = s.GetAllSecurity();



        }



        private void tbPFirstName_TextChanged(object sender, EventArgs e)
        {
            //gereksiz
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            //string query = "SELECT * FROM ManagersInfo ";
          //  DataAccess.ExecuteNonQuery(query);
        }

        private void dgManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        //gereksiz
        }

        private void tbPSearch_TextChanged(object sender, EventArgs e)
        {
            //gereksiz
        }

        private void dgManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            lbl.Text = dgManager.CurrentRow.Cells[0].Value.ToString();
            tbPFirstName.Text = dgManager.CurrentRow.Cells[1].Value.ToString();
            tbPLastName.Text = dgManager.CurrentRow.Cells[2].Value.ToString();
            tbPEmail.Text = dgManager.CurrentRow.Cells[3].Value.ToString();
            tbPPassword.Text = dgManager.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnSPrint_Click(object sender, EventArgs e)
        {
            /*  if(dgManager.DataSource == null)
              {
                  return;
              }
  */
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            
        
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(dgManager.Width, dgManager.Height);
            dgManager.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dgManager.Width, this.dgManager.Height));

            e.Graphics.DrawImage(bitmap, 25, 25);
        }
    }
}
