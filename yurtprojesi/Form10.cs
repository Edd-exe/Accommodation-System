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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            string name = tbAtSearch.Text.Trim();
            Student m = new Student();
            dgAt.DataSource = m.GetAllAbsenteeism();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            //gerekszi
        }

        private void dgAt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbAtID.Text = dgAt.CurrentRow.Cells[0].Value.ToString();
            tbAtFirstName.Text = dgAt.CurrentRow.Cells[1].Value.ToString();
            tbAtLastName.Text = dgAt.CurrentRow.Cells[2].Value.ToString();
            tbAtKalan.Text = dgAt.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnAtUpdate_Click(object sender, EventArgs e)
        {
            Security s1 = new Security();

            //SAVE button
            if (tbAt.Text.Length == 0)
            {
                MessageBox.Show("Adding discountinuity field must be filled");
                
            }
            else if (!s1.IsNumeric(tbAt.Text))
            {
                MessageBox.Show("Discountinuty must be number");

            }
           else if (true) {
                int tbat = Convert.ToInt32(tbAt.Text.Trim());
                int tbatkalan = Convert.ToInt32(tbAtKalan.Text.Trim());
                int test = tbatkalan - tbat;
                string id = tbAtID.Text;

                if (test < 0)
                {
                    MessageBox.Show("Absence limit cannot be exceeded", "Discountinuity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbAt.Clear();
                    tbAt.Focus();
                }

                else if (test >= 0)
                {


                    Student s = new Student();
                    s.UpdateAbsenteeism(test, id);
                    MessageBox.Show("Discountinuity Added", "Discountinuity", MessageBoxButtons.OK);
                    dgAt.DataSource = s.GetAllAbsenteeism();
                    tbAt.Clear();
                    tbAtLastName.Clear();
                    tbAtFirstName.Clear();
                    tbAtID.Clear();
                    tbAtKalan.Clear();
                }

                
                //   tbAtSearch();
            }



        }
    }
}
