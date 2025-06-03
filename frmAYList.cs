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
using Mysqlx.Cursor;

namespace Enrollment_Management_System
{
    public partial class frmAYList : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        public frmAYList()
        {
            InitializeComponent();
            cn = new MySqlConnection(clsDbConnection._connection);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAY f = new frmAY(this);
            f.ShowDialog();
        }

        public void loadRecords()
        {
            try
            {
                int i = 0;
                dataGridView1.Rows.Clear();
                cn.Open();
                cm = new MySqlCommand("SELECT * FROM tblAY", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString());
                }
                dr.Close();
                cn.Close();
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string _column = dataGridView1.Columns[e.ColumnIndex].Name;
                if (_column == "colOpen")
                {
                    if (MessageBox.Show("Do you want to open academic year " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "?", clsDbConnection._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new MySqlCommand("update tblAY set status = 'Close'",cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        cn.Open();
                        cm = new MySqlCommand("update tblAY set status = 'Open' where AYcode = @AYcode", cn);
                        cm.Parameters.AddWithValue("@AYcode", dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                        cm.ExecuteNonQuery();
                        cn.Close() ;
                        MessageBox.Show("Academic year " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + " has been successfully opened!", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadRecords();
                    }
                }else if (_column == "colClose")
                {
                    if (MessageBox.Show("Do you want to close academic year " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "?", clsDbConnection._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new MySqlCommand("update tblAY set status = 'Close'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        MessageBox.Show("Academic year " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + " has been successfully closed!", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadRecords();
                    }
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
