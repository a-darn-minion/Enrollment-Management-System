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


    public partial class frmCourse : Form
    {
        frmCourseList f;
        public string _adviserId;
        public string _id;
        public frmCourse(frmCourseList f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save this record?", clsDbConnection._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtSection.Text == string.Empty) { return; }
                if (cboYear.Text == string.Empty) { return; }
                if (cboDephead.Text == string.Empty) { return; }
                using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
                {
                    using (MySqlCommand cm = new MySqlCommand("INSERT INTO tblcourse (course, year, adviserid)VALUES(@course, @year, @adviserid)", cn))
                    {
                        cn.Open();
                        cm.Parameters.AddWithValue("@course", txtSection.Text);
                        cm.Parameters.AddWithValue("@year", cboYear.Text);
                        cm.Parameters.AddWithValue("@adviserid", _adviserId);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("New Section has been successfully saved!", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button3_Click(sender, e);
                        f.loadRecords();
                    }
                }
            }
        }

        public void getDephead()
        {
            cboDephead.Items.Clear();
            using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
            {
                using (MySqlCommand cm = new MySqlCommand("SELECT concat(lname, ', ', fname, ' ' , mname )as adviser from tblteacher", cn))
                {
                    MySqlDataReader dr;
                    cn.Open();
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        cboDephead.Items.Add(dr["adviser"]);
                    }
                    dr.Close();
                    cn.Close();
                }
            }
        }

        private void cboDephead_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
            {
                MySqlDataReader dr;
                using (MySqlCommand cm = new MySqlCommand("SELECT teacherId FROM tblteacher WHERE concat(lname, ', ', fname, ' ' , mname)  = @adviser", cn))
                {
                    cn.Open();
                    cm.Parameters.AddWithValue("@adviser", cboDephead.Text);
                    dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        _adviserId = dr["teacherId"].ToString();
                    }
                    cn.Close();
                    dr.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cboDephead.Text = string.Empty;
            txtSection.Text = string.Empty;
            cboYear.Text = string.Empty;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            cboYear.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update this record?", clsDbConnection._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtSection.Text == string.Empty) { return; }
                if (cboYear.Text == string.Empty) { return; }
                if (cboDephead.Text == string.Empty) { return; }
                using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
                {
                    using (MySqlCommand cm = new MySqlCommand("update tblcourse set course = @course, year=@year, adviserid=@adviserid where id = @id", cn))
                    {
                        cn.Open();
                        cm.Parameters.AddWithValue("@course", txtSection.Text);
                        cm.Parameters.AddWithValue("@year", cboYear.Text);
                        cm.Parameters.AddWithValue("@adviserid", _adviserId);
                        cm.Parameters.AddWithValue("@id", _id);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Section has been successfully updated!", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button3_Click(sender, e);
                        f.loadRecords();
                        this.Dispose();
                    }
                }
            }
        }
    }
}

