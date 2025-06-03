using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Enrollment_Management_System
{

    public partial class frmSearchStudents : Form
    {
        frmEnroll f;
        public frmSearchStudents(frmEnroll f)
        {
            InitializeComponent();
            this.f = f;

        }

        public void loadRecords()
        {
            try
            {
                dataGridView1.Rows.Clear();
                using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
                {
                    using (MySqlCommand cm = new MySqlCommand("SELECT * FROM tblstudent where lname like'" + txtSearch.Text + "%' order by lname, fname, mname", cn))
                    {
                        MySqlDataReader dr;
                        cn.Open();
                        dr = cm.ExecuteReader();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
                        }
                        dr.Close();
                        cn.Close();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadRecords();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string _column = dataGridView1.Columns[e.ColumnIndex].Name;
            if (_column == "colSelect")
            {
                f.txtLrn.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                f.txtLname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                f.txtFname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                f.txtMname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.Dispose();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
