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
using System.Data.SQLite;
namespace yurtprojesi
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string name = tbSearch.Text.Trim();

            Student s = new Student();
            dgStudent.DataSource = s.GetStudentByName(name);

        }

        private void btnByStudentID_Click(object sender, EventArgs e)
        {
            string tbsearch = tbSearch.Text.Trim();
            Security s1 = new Security();
              if (tbsearch.Length == 0 )
            {
                MessageBox.Show("ID must be written","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                tbSearch.Focus();
            }
            else if (!s1.IsNumeric(tbsearch))
            {

                MessageBox.Show("ID must be number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSearch.Focus();
            }
            else
            {
                int itbsearch = Convert.ToInt32(tbsearch);
                Student s = new Student();
                dgStudent.DataSource = s.GetStudentByID(itbsearch);
                
            }


            
        }

        private void btnByFirstName_Click(object sender, EventArgs e)
        {
            string tbsearch = tbSearch.Text.Trim();
            Student s = new Student();
            dgStudent.DataSource = s.GetStudentByName(tbsearch);
        }

        private void btnByLastName_Click(object sender, EventArgs e)
        {
            string tbsearch = tbSearch.Text.Trim();
            Student s = new Student();
            dgStudent.DataSource = s.GetStudentByLastName(tbsearch);
        }

        private void btnByDepartment_Click(object sender, EventArgs e)
        {

            string tbsearch = tbSearch.Text.Trim();
            Student s = new Student();
            dgStudent.DataSource = s.GetStudentByDepartment(tbsearch);
        }

        private void btnByRoomNo_Click(object sender, EventArgs e)
        {
            string tbsearch = tbSearch.Text.Trim();
            
            Student s = new Student();
            dgStudent.DataSource = s.GetStudentByRoomNo(tbsearch);
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            //delete komutu

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Delete Student?", "DELETE", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                lbl.Text = dgStudent.CurrentRow.Cells[0].Value.ToString();
                string id = lbl.Text;
                Student s = new Student();
                s.DeleteStudent(id);
                //MessageBox.Show("Registered", "Information Message", MessageBoxButtons.OK);
                dgStudent.DataSource = s.GetAllStudents();
            }
            else
            {
                MessageBox.Show("Student not deleted");
            }


            
            //string name = tbPSearch.Text.Trim();

           

        }

       

        private void dgStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ///cell content click yanlış oldu düzezlt!!!!

            /* tbYeniFirst = dgStudent.CurrentRow.Cells[1].Value.ToString();
            tbYeniFirst = dgStudent.CurrentRow.Cells[2].Value.ToString();
            tbYeniFirst = dgStudent.CurrentRow.Cells[3].Value.ToString();
            tbYeniFirst = dgStudent.CurrentRow.Cells[4].Value.ToString();
            tbYeniFirst = dgStudent.CurrentRow.Cells[5].Value.ToString();
            tbYeniFirst = dgStudent.CurrentRow.Cells[6].Value.ToString();
            tbYeniFirst = dgStudent.CurrentRow.Cells[7].Value.ToString();
            tbYeniFirst = dgStudent.CurrentRow.Cells[8].Value.ToString();
            tbYeniFirst = dgStudent.CurrentRow.Cells[9].Value.ToString();
            tbYeniFirst = dgStudent.CurrentRow.Cells[10].Value.ToString();
            */
        }

        private void Form6_Load_1(object sender, EventArgs e)
        {
            string name = tbSearch.Text.Trim();
            Student s = new Student();
            dgStudent.DataSource = s.GetAllStudents(name);

        }

        private void btnStudentPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(dgStudent.Width, dgStudent.Height);
            dgStudent.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dgStudent.Width, this.dgStudent.Height));

            e.Graphics.DrawImage(bitmap, 25, 25);
        }
    }
}
 