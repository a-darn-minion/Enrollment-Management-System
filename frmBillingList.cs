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
    public partial class frmBillingList : Form
    {
        

        public frmBillingList()
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
                MySqlDataReader dr;
                dataGridView1.Rows.Clear();
                using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
                {
                    using (MySqlCommand cm = new MySqlCommand("select * from vwbilling where AYcode like '" + clsDbConnection._aycode + "'", cn))
                    {
                        cn.Open();
                        dr = cm.ExecuteReader();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
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
        public void getAY()
        {
            using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
            {
                using (MySqlCommand cm = new MySqlCommand("SELECT AYcode from tblay where status = 'Open'", cn))
                {
                    MySqlDataReader dr;
                    cn.Open();
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        clsDbConnection._aycode = dr["AYcode"].ToString();
                    }
                    dr.Close();
                    cn.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string _colname = dataGridView1.Columns[e.ColumnIndex].Name;
            if (_colname == "View")
            {
                frmBilling f = new frmBilling(this);
                f.loadFees();
                f.lblEID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                f.txtLrn.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                f.txtStudentName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                f.txtSection.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                f.txtYear.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                f.txtAY.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                f.loadRecords();
                f.ShowDialog();
            }
        }
    }
}
