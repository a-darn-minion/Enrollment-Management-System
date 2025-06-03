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
    public partial class frmTeacherList : Form
    {
        public frmTeacherList()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void loadRecords()
        {
            try
            {
                dataGridView1.Rows.Clear();
                using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
                {
                    using (MySqlCommand cm = new MySqlCommand("SELECT * FROM tblteacher", cn))
                    {
                        MySqlDataReader dr;
                        cn.Open();
                        dr = cm.ExecuteReader();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr["teacherId"], dr["lname"], dr["fname"], dr["mname"], dr["contact"], dr["address"], dr["email"]);
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmTeacher f = new frmTeacher(this);
            f.ShowDialog();
            f.btnUpdate.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string _column = dataGridView1.Columns[e.ColumnIndex].Name;
            if (_column == "Edit")
            {
                frmTeacher f = new frmTeacher(this);
                f.txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                f.txtlname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                f.txtfname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                f.txtmname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                f.txtcontact.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                f.txtaddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                f.txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                f.btnSave.Enabled = false;
                f.btnUpdate.Enabled = true;
                f.txtID.Enabled = false;
                f.ShowDialog();
            }
            else if (_column == "Delete")
            {
                if (MessageBox.Show("Do you want to delete this record?", clsDbConnection._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
                    {
                        using (MySqlCommand cm = new MySqlCommand("DELETE FROM tblteacher WHERE teacherId=@teacherId", cn))
                        {
                            cn.Open();
                            cm.Parameters.AddWithValue("@teacherId", dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                            cm.ExecuteNonQuery();
                            cn.Close();
                        }
                    }
                    loadRecords();
                }
            }
        }
    }
}
