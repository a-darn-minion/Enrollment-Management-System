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
    public partial class frmBilling : Form
    {
        string _feeid;
        frmBillingList f;
        public frmBilling(frmBillingList f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void loadFees()
        {
            MySqlDataReader dr;
            cboDesc.Items.Clear();
            using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
            {
                using (MySqlCommand cm = new MySqlCommand("select concat  (fees, ' - ', amount) as fees from tblfees", cn))
                {
                    cn.Open();
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        cboDesc.Items.Add(dr[0]);
                    }
                    dr.Close();
                    cn.Close();

                }
            }
        }
        public void loadRecords()
        {
            try
            {
                MySqlDataReader dr;
                dataGridView1.Rows.Clear();
                using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
                {
                    using (MySqlCommand cm = new MySqlCommand("SELECT * FROM vwtuition where enrollmentid like '" + lblEID.Text + "'", cn))
                    {
                        
                        cn.Open();
                        dr = cm.ExecuteReader();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr["id"], dr["fees"], dr["amount"]);
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

        private void cboDesc_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlDataReader dr;
            using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
            {
                using (MySqlCommand cm = new MySqlCommand("select * from tblfees where concat  (fees, ' - ', amount) =@fees", cn))
                {
                    cn.Open();
                    cm.Parameters.AddWithValue("@fees", cboDesc.Text);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        _feeid = dr["id"].ToString();
                        txtAmount.Text = dr["amount"].ToString();
                    }
                    dr.Close();
                    cn.Close();

                }
            }
        }

        public bool duplicateEntry()
        {
            bool _exists = false;
            using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
            {
                using (MySqlCommand cm = new MySqlCommand("SELECT * FROM vwtuition where enrollmentid = @enrollmentid and  feesid = @feesid", cn))
                {
                    cn.Open();
                    cm.Parameters.AddWithValue("@enrollmentid", lblEID.Text);

                    cm.Parameters.AddWithValue("@feesid", _feeid);
                    MySqlDataReader dr = cm.ExecuteReader();
                    if (dr.HasRows)
                    {
                        _exists = true;
                    }
                    else
                    {
                        _exists = false;
                    }
                    dr.Close();
                    cn.Close();
                    return _exists;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save this record?", clsDbConnection._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (duplicateEntry() == true)
                {
                    MessageBox.Show("This student already has this Fee!", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
                {
                    using (MySqlCommand cm = new MySqlCommand("INSERT INTO tblbilling (enrollmentid,feesid)VALUES(@enrollmentid, @feesid)", cn))
                    {
                        cn.Open();
                        cm.Parameters.AddWithValue("@enrollmentid", lblEID.Text);
                        cm.Parameters.AddWithValue("@feesid", _feeid);


                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Billing has been successfully Saved!", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        f.loadRecords();
                        loadRecords();
                    }
                }
            }
        }

        
    }
}
