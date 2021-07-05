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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            string name = tbSearch.Text.Trim();
            Student s = new Student();
            dgStudent.DataSource = s.GetAllStudents(name);
            
        }

        private void tbSearch_TextChange(object sender, EventArgs e)
        {
            string name = tbSearch.Text.Trim();

            Student s = new Student();
            dgStudent.DataSource = s.GetStudentByName(name);
        }

        private void dgStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = dgStudent.CurrentRow.Cells[0].Value.ToString();
            tbFirstName.Text = dgStudent.CurrentRow.Cells[1].Value.ToString();
            tbLastName.Text = dgStudent.CurrentRow.Cells[2].Value.ToString();
            tbEmail.Text = dgStudent.CurrentRow.Cells[3].Value.ToString();
            tbTelephone.Text = dgStudent.CurrentRow.Cells[4].Value.ToString();
              string g=dgStudent.CurrentRow.Cells[5].Value.ToString();
            tbPFirstName.Text = dgStudent.CurrentRow.Cells[6].Value.ToString();
            tbPLastName.Text = dgStudent.CurrentRow.Cells[7].Value.ToString();
            tbPTel.Text = dgStudent.CurrentRow.Cells[8].Value.ToString();
            tbRoomNo.Text = dgStudent.CurrentRow.Cells[9].Value.ToString();
            tbAddress.Text = dgStudent.CurrentRow.Cells[10].Value.ToString();
             string a = dgStudent.CurrentRow.Cells[11].Value.ToString();
           
            int b = 0;
            switch (a)
            {
                case "Bilgisayar Mühendisliği":
                    b += 1;
                    break;
                case "Yazılım Mühendisliği":
                    b += 2;
                    break;
                case "Endüstri Mühendisliği":
                    b += 3;
                    break;
                case "Elektrik Elektronik Mühendisliği":
                    b += 4;
                    break;
                case "Gıda Mühendisliği":
                    b += 5;
                    break;
                case "Mimarlık":
                    b += 6;
                    break;
                case "Tıp":
                    b += 7;
                    break;
                case "İşletme":
                    b += 8;
                    break;
            }
            tbDepartment.selectedIndex = b;

            int gg = 0;
            switch (g)
            {
                case "Male":
                        gg += 1;
                    break;
                case "Female":
                    gg += 2;
                    break;
            }
            tbGender.selectedIndex = gg;
            tbGender.Enabled = false;

        }

        private void btnEdit_MouseClick(object sender, MouseEventArgs e)
        {
          

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            string id = dgStudent.CurrentRow.Cells[0].Value.ToString();
            string first = tbFirstName.Text.Trim();
            string last = tbLastName.Text.Trim();
            string email = tbEmail.Text.Trim();
            string tel = tbTelephone.Text.Trim();
            string pfirst = tbPFirstName.Text.Trim();
            string plast = tbPLastName.Text.Trim();
            string ptel = tbPTel.Text.Trim();
            string room = tbRoomNo.Text.Trim();
            string adres = tbAddress.Text.Trim();
            int a = tbDepartment.selectedIndex;

            Security s1 = new Security();

            if (first.Length == 0 || last.Length == 0 || email.Length == 0 || tel.Length == 0 || pfirst.Length == 0 || plast.Length == 0 || ptel.Length == 0 || room.Length == 0 || adres.Length == 0 || a == 0)
            {
                MessageBox.Show("All information must be filled");

            }
            else if (!s1.IsNumeric(tel) || !s1.IsNumeric(ptel))
            {
                MessageBox.Show("Check cell phone numbers");

            }
            else
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Update Personnel?", "UPDATE", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {


                    Student s = new Student();
                    s.UpdateStudent(id, first, last, email, tel, pfirst, plast, ptel, room, a, adres);
                    dgStudent.DataSource = s.GetAllStudents();
                }
                else
                {
                    MessageBox.Show("Personnel not Update");
                }

            }
            }
        }
}
