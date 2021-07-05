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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string name = tbPaySearch.Text.Trim();
            Student m = new Student();
            dgPayment.DataSource = m.GetAllPayments();
        }

        private void dgPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //gerkesiz
        }

        private void dgPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tbPayID.Text = dgPayment.CurrentRow.Cells[0].Value.ToString();
            tbPayFirstName.Text = dgPayment.CurrentRow.Cells[1].Value.ToString();
            tbPayLastName.Text = dgPayment.CurrentRow.Cells[2].Value.ToString();
            tbPayDebt.Text = dgPayment.CurrentRow.Cells[3].Value.ToString();
            // tbPayTransfer.Text = dgPayment.CurrentRow.Cells[4].Value.ToString();

        }

        private void tbPayFistName_OnValueChanged(object sender, EventArgs e)
        {
            //gereksiz
        }

        private void btnTAdd_Click(object sender, EventArgs e)
        { //Paymnet button
            Security s1 = new Security();

            //SAVE button
            if (tbPayTransfer.Text.Length == 0)
            {
                MessageBox.Show("Adding payment field must be filled");

            }
            else if (!s1.IsNumeric(tbPayTransfer.Text))
            {
                MessageBox.Show("Payment must be number");

            }
            else if (true)
            {
                try
                {
                    int odenen = Convert.ToInt32(tbPayTransfer.Text.Trim());
                    int kalan = Convert.ToInt32(tbPayDebt.Text.Trim());
                    int test = kalan - odenen;
                    string id = tbPayID.Text;
                    if (test < 0)
                    {
                        MessageBox.Show("Absence limit cannot be exceeded", "Discountinuity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbPayTransfer.Clear();
                        tbPayTransfer.Focus();
                    }

                    else if (test >= 0)
                    {


                        Student u = new Student();
                        u.UpdatePayments(test, id);
                        MessageBox.Show("Payment completed", "Payment", MessageBoxButtons.OK);
                        dgPayment.DataSource = u.GetAllPayments();
                        
                        tbPayFirstName.Clear();
                        tbPayID.Clear();
                        tbPayLastName.Clear();
                        tbPayLastName.Clear();
                        tbPaySearch.Clear();
                        tbPayTransfer.Clear();
                        tbPayDebt.Clear();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
               



            }

           
        }
    }
}
