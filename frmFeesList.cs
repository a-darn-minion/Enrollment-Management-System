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
    public partial class frmFeesList : Form
    {
        public frmFeesList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFee f = new frmFee(this);
            f.btnUpdate.Enabled = false;
            f.ShowDialog();
        }

        public void loadRecords()
        {
            try
            {
                dataGridView1.Rows.Clear();
                using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
                {
                    using (MySqlCommand cm = new MySqlCommand("SELECT * FROM tblfees", cn))
                    {
                        MySqlDataReader dr;
                        cn.Open();
                        dr = cm.ExecuteReader();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string _column = dataGridView1.Columns[e.ColumnIndex].Name;
            if (_column == "colEdit")
            {
                frmFee f = new frmFee(this);
                f.btnSave.Enabled = false;
                f.lblId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                f.txtDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                f.txtAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                f.btnUpdate.Enabled = true;
                f.txtDescription.Focus();
                f.ShowDialog();
            }
            else if (_column == "colDelete")
            {
                if (MessageBox.Show("Do you want to delete this record?", clsDbConnection._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
                    { 
                        using (MySqlCommand cm = new MySqlCommand("DELETE from tblfees where id = @id",cn))
                        {
                            cn.Open();
                            cm.Parameters.AddWithValue("@id", dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                            cm.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("Record has been successfully deleted!", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadRecords();
                        }
                    }

                }
            }
        }
    }
}
