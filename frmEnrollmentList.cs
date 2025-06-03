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

    public partial class frmEnrollmentList : Form
    {
        //public string _aycode;
        public frmEnrollmentList()
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
                    using (MySqlCommand cm = new MySqlCommand("SELECT * FROM vwenrollment where AYcode = @AYcode", cn))
                    {
                        MySqlDataReader dr;
                        cn.Open();
                        cm.Parameters.AddWithValue("@AYcode", clsDbConnection._aycode);
                        dr = cm.ExecuteReader();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], DateTime.Parse(dr[8].ToString()).ToShortDateString(), dr[9]);
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmEnroll f = new frmEnroll(this);
            f.lblAY.Text = clsDbConnection._aycode;
            f.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string _column = dataGridView1.Columns[e.ColumnIndex].Name;
            if (_column == "Drop")
            {
                if (MessageBox.Show("Do you want to drop this student?", clsDbConnection._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
                    {
                        using (MySqlCommand cm = new MySqlCommand("update tblenrollment set status = 'Dropped' where enrollmentid like '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn))
                        {
                            cn.Open();
                            cm.ExecuteNonQuery();
                            cn.Close();                   
                            MessageBox.Show("Student has been dropped!", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadRecords();
                        }
                    }
                    
                }
            }
        }
    }
}
