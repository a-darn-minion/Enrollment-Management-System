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
    public partial class frmEnroll : Form
    {
        public string _courseId = "";
        public string _adviserId = "";
        frmEnrollmentList f;
        public frmEnroll(frmEnrollmentList f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmSearchStudents f = new frmSearchStudents(this);
            f.loadRecords();
            f.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmSearchSection f = new frmSearchSection(this);
            f.loadRecords();
            f.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save this record?", clsDbConnection._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (duplicateEntry() == true)
                {
                    MessageBox.Show("This student is already enrolled for this school year!", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtLrn.Text == string.Empty) { return; }
                if (txtLname.Text == string.Empty) { return; }
                if (txtFname.Text == string.Empty) { return; }
                if (txtMname.Text == string.Empty) { return; }
                if (_courseId == string.Empty) { return; }
                using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
                {
                    using (MySqlCommand cm = new MySqlCommand("INSERT INTO tblenrollment (lrn,courseid, AYcode, enrolldate)VALUES(@lrn,@courseid, @AYcode, @enrolldate)", cn))
                    {
                        cn.Open();
                        cm.Parameters.AddWithValue("@lrn", txtLrn.Text);
                        cm.Parameters.AddWithValue("@courseid", _courseId);
                        cm.Parameters.AddWithValue("@AYcode", lblAY.Text);
                        cm.Parameters.AddWithValue("@enrolldate", DateTime.Now);

                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("New Student has been successfully enrolled!", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        f.loadRecords();
                        button3_Click(sender, e);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtAdviser.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtLrn.Clear();
            txtMname.Clear();
            txtYear.Clear();
            txtSection.Clear();

        }
        public bool duplicateEntry()
        {
            bool _exists = false;
            using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
            {
                using (MySqlCommand cm = new MySqlCommand("SELECT * FROM tblenrollment where lrn = @lrn and  AYcode = @AYcode", cn))
                {
                    cn.Open();
                    cm.Parameters.AddWithValue("@lrn", txtLrn.Text);
                    
                    cm.Parameters.AddWithValue("@AYcode", lblAY.Text);
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
    }
}
