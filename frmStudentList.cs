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
    public partial class frmStudentList : Form
    {
        public frmStudentList()
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
                    using (MySqlCommand cm = new MySqlCommand("SELECT * FROM tblstudent order by lname, fname, mname", cn))
                    {
                        MySqlDataReader dr;
                        cn.Open();
                        dr = cm.ExecuteReader();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], DateTime.Parse(dr[5].ToString()).ToShortDateString(), dr[6], dr[7], dr[8], dr[9], dr[10], dr[11]);
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
            frmStudent f = new frmStudent(this);
            f.btnUpdate.Enabled = false;
            f.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string _column = dataGridView1.Columns[e.ColumnIndex].Name;
            if (_column == "Edit")
            {
                frmStudent f = new frmStudent(this);
                f.btnSave.Enabled = false;
                f.txtLrn.Enabled = false;
                f.txtLrn.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                f.txtLname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                f.txtFname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                f.txtMname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                f.txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                f.dtBdate.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
             
                f.txtFather.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                f.txtOcc1.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                f.txtMother.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();                
                f.txtOcc2.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                f.ShowDialog();
                
            }
            else if (_column == "Delete")
            {
                if (MessageBox.Show("Do you want to delete this record?", clsDbConnection._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
                    {
                        using (MySqlCommand cm = new MySqlCommand("DELETE FROM tblstudent WHERE lrn=@lrn", cn))
                        {
                            cn.Open();
                            cm.Parameters.AddWithValue("@lrn", dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                            cm.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("Record has been successfully deleted!", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridView1.ClearSelection();
                            loadRecords();
                        }
                    }
                }
            }
        }
    }
}
