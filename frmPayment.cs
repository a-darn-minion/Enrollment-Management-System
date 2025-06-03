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
    public partial class frmPayment : Form
    {
        string _eid;
        Form1 f;
        public frmPayment(Form1 f)
        {
            InitializeComponent();
            this.f = f;
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
                    using (MySqlCommand cm = new MySqlCommand("SELECT * FROM vwenrollment where AYcode like'" + clsDbConnection._aycode + "' and student like '" + txtSearch.Text + "%'", cn))
                    {
                        MySqlDataReader dr;
                        cn.Open();
                        dr = cm.ExecuteReader();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[9]);
                        }
                        dr.Close();
                        cn.Close();
                        dataGridView1.ClearSelection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void loadPayment()
        {
            try
            {
                dataGridView2.Rows.Clear();
                using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
                {
                    using (MySqlCommand cm = new MySqlCommand("SELECT * FROM vwpayment where lrn like'" + txtLrn.Text + "%'", cn))
                    {
                        MySqlDataReader dr;
                        cn.Open();
                        dr = cm.ExecuteReader();
                        while (dr.Read())
                        {
                            dataGridView2.Rows.Add(dr["id"], dr["lrn"], dr["student"], dr["year"], dr["course"], dr["amount"], DateTime.Parse(dr["pdate"].ToString()).ToShortDateString());
                        }
                        dr.Close();
                        cn.Close();
                        dataGridView2.ClearSelection();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadRecords();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string _column = dataGridView1.Columns[e.ColumnIndex].Name;
            if (_column == "View")
            {
                double _tuition = 0;
                double _payment = 0;
                _eid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtLrn.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtStudentName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSection.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtYear.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtAY.Text = clsDbConnection._aycode;
                tabControl1.SelectedIndex = 1;
                txtTuition.Text = getBilling().ToString("N2");
                txtPayment.Text = getPayment().ToString("N2");
                _tuition = double.Parse(txtTuition.Text);
                _payment = double.Parse(txtPayment.Text);
                txtCurBalance.Text = (_tuition - _payment).ToString("N2");
                loadPayment();
            }
        }

        public double getBilling()
        {
            MySqlDataReader dr;
            double _billing = 0;
            using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
            {
                using (MySqlCommand cm = new MySqlCommand("SELECT amount FROM vwbilling where enrollmentid = '" + _eid + "'", cn))
                {
                    cn.Open();
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        _billing = Double.Parse(dr[0].ToString());
                    }
                    dr.Close();
                    cn.Close();
                }
            }
            return _billing;
        }

        public double getPayment()
        {
            MySqlDataReader dr;
            double _payment = 0;
            using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
            {
                using (MySqlCommand cm = new MySqlCommand("SELECT total FROM vwtotalpayment where enrollmentid = '" + _eid + "'", cn))
                {
                    cn.Open();
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        _payment = Double.Parse(dr[0].ToString());
                    }
                    dr.Close();
                    cn.Close();
                }
            }
            return _payment;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtRunBalance.Text = (double.Parse(txtCurBalance.Text) - double.Parse(txtCash.Text)).ToString("N2");

            }
            catch (Exception ex)
            {
                txtRunBalance.Text = txtCurBalance.Text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((txtLrn.Text == String.Empty) || (txtCash.Text == String.Empty))
            {
                MessageBox.Show("Empty field Required!", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double _payment = 0;
            using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
            {
                using (MySqlCommand cm = new MySqlCommand("insert into tblpayment (pdate,enrollmentid,amount) values (@pdate,@enrollmentid,@amount) ", cn))
                {
                    cn.Open();
                    cm.Parameters.AddWithValue("@pdate", DateTime.Now.ToString("yyyy-MM-dd"));
                    cm.Parameters.AddWithValue("@enrollmentid", _eid);
                    cm.Parameters.AddWithValue("@amount", double.Parse(txtCash.Text));
                    cm.ExecuteReader();
                    cn.Close();
                    MessageBox.Show("Payment Saved!", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabControl1.SelectedIndex = 0;
                    Clear();
                }
            }

        }
        public void Clear()
        {
            txtLrn.Clear();
            txtStudentName.Clear();
            txtSection.Clear();
            txtYear.Clear();
            txtAY.Clear();
            txtTuition.Clear();
            txtPayment.Clear();
            txtCurBalance.Clear();
            txtCash.Clear();
            txtRunBalance.Clear();
            _eid = string.Empty;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string _column = dataGridView2.Columns[e.ColumnIndex].Name;
            if (_column == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this payment?", clsDbConnection._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
                    {
                        using (MySqlCommand cm = new MySqlCommand("DELETE FROM tblpayment where id = @id", cn))
                        {
                            cn.Open();
                            cm.Parameters.AddWithValue("@id", dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                            cm.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("Payment Deleted!", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadPayment();
                            Clear();
                        }
                    }
                }
            }
        }
    }
}
