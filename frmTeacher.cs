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
    public partial class frmTeacher : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        frmTeacherList f;
        public frmTeacher(frmTeacherList f)
        {

            InitializeComponent();
            cn = new MySqlConnection(clsDbConnection._connection);
            this.f = f;
        }

        private void txtContact_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtaddress.Clear();
            txtemail.Clear();
            txtfname.Clear();
            txtlname.Clear();
            txtmname.Clear();
            txtcontact.Clear();
            txtID.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtID.Enabled = true;
            txtID.Focus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save this record?", clsDbConnection._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtID.Text == string.Empty) { return; }
                if (txtlname.Text == string.Empty) { return; }
                if (txtfname.Text == string.Empty) { return; }
                using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
                {
                    using (MySqlCommand cm = new MySqlCommand("INSERT INTO tblteacher (teacherId, lname, fname, mname, contact, address, email)VALUES(@teacherId, @lname, @fname, @mname, @contact, @address, @email)", cn))
                        {
                        cn.Open();
                        cm.Parameters.AddWithValue("@teacherId", txtID.Text);
                        cm.Parameters.AddWithValue("@lname", txtlname.Text);
                        cm.Parameters.AddWithValue("@fname", txtfname.Text);
                        cm.Parameters.AddWithValue("@mname", txtmname.Text);
                        cm.Parameters.AddWithValue("@contact", txtcontact.Text);
                        cm.Parameters.AddWithValue("@address", txtaddress.Text);
                        cm.Parameters.AddWithValue("@email", txtemail.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("New Teacher has been successfully updated!", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button3_Click(sender, e);
                        f.loadRecords();
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update this record?", clsDbConnection._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtID.Text == string.Empty) { return; }
                if (txtlname.Text == string.Empty) { return; }
                if (txtfname.Text == string.Empty) { return; }
                using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
                {
                    using (MySqlCommand cm = new MySqlCommand("update  tblteacher set  lname=@lname, fname=@fname, mname=@mname, contact=@contact, address=@address, email=@email  where teacherId = @teacherId", cn))
                    {
                        cn.Open();   
                        cm.Parameters.AddWithValue("@lname", txtlname.Text);
                        cm.Parameters.AddWithValue("@fname", txtfname.Text);
                        cm.Parameters.AddWithValue("@mname", txtmname.Text);
                        cm.Parameters.AddWithValue("@contact", txtcontact.Text);
                        cm.Parameters.AddWithValue("@address", txtaddress.Text);
                        cm.Parameters.AddWithValue("@email", txtemail.Text);
                        cm.Parameters.AddWithValue("@teacherId", txtID.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("New Teacher has been successfully saved!", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button3_Click(sender, e);
                        f.loadRecords();
                        this.Dispose();
                    }
                }
            }
        }
    }
}
