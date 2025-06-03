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
    public partial class frmStudent : Form
    {
        frmStudentList f;
        public frmStudent(frmStudentList f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public void GetAge()
        {
            try
            {
                DateTime dob = dtBdate.Value;

                DateTime py = DateTime.Now;
                TimeSpan ts = py - dob;
                DateTime age = DateTime.MinValue.AddDays(ts.Days);

                txtAge.Text = age.Year.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtBdate_ValueChanged(object sender, EventArgs e)
        {
            GetAge();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtLrn.Text == String.Empty)
            {
                MessageBox.Show("Please enter LRN", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLrn.Focus();
                return;
            }

            if (MessageBox.Show("Do you want to save this record?", clsDbConnection._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
                {
                    using (MySqlCommand cm = new MySqlCommand("insert into tblstudent (lrn, lname, fname, mname, address, bdate, age, father, father_occupation, mother, mother_occupation) values (@lrn, @lname, @fname, @mname, @address, @bdate, @age, @father, @father_occupation, @mother, @mother_occupation)", cn))
                    {
                        cn.Open();
                        cm.Parameters.AddWithValue("@lrn", txtLrn.Text);
                        cm.Parameters.AddWithValue("@lname", txtLname.Text);
                        cm.Parameters.AddWithValue("@fname", txtFname.Text);
                        cm.Parameters.AddWithValue("@mname", txtMname.Text);
                        cm.Parameters.AddWithValue("@address", txtAddress.Text);
                        cm.Parameters.AddWithValue("@bdate", dtBdate.Value.ToString("yyyy-MM-dd"));
                        cm.Parameters.AddWithValue("@age", int.Parse(txtAge.Text));
                        cm.Parameters.AddWithValue("@father", txtFather.Text);
                        cm.Parameters.AddWithValue("@father_occupation", txtOcc1.Text);
                        cm.Parameters.AddWithValue("@mother", txtMother.Text);
                        cm.Parameters.AddWithValue("@mother_occupation", txtOcc2.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Record has been successfully saved!", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button3_Click(sender, e);
                        f.loadRecords();
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtLrn.Clear();
            txtLname.Clear();
            txtFname.Clear();
            txtMname.Clear();
            txtAddress.Clear();
            txtAge.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtOcc1.Clear();
            txtOcc2.Clear();
            dtBdate.Value = DateTime.Now;
            txtLrn.Focus();
            txtLrn.Enabled = true;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Update this record?", clsDbConnection._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
                {
                    using (MySqlCommand cm = new MySqlCommand("update tblstudent set lname=@lname, fname=@fname, mname=@mname, address=@address, bdate=@bdate, age=@age, father=@father, father_occupation=@father_occupation, mother=@mother, mother_occupation=@mother_occupation where lrn = @lrn", cn))
                    {
                        cn.Open();
                        cm.Parameters.AddWithValue("@lrn", txtLrn.Text);
                        cm.Parameters.AddWithValue("@lname", txtLname.Text);
                        cm.Parameters.AddWithValue("@fname", txtFname.Text);
                        cm.Parameters.AddWithValue("@mname", txtMname.Text);
                        cm.Parameters.AddWithValue("@address", txtAddress.Text);
                        cm.Parameters.AddWithValue("@bdate", dtBdate.Value.ToString("yyyy-MM-dd"));
                        cm.Parameters.AddWithValue("@age", int.Parse(txtAge.Text));
                        cm.Parameters.AddWithValue("@father", txtFather.Text);
                        cm.Parameters.AddWithValue("@father_occupation", txtOcc1.Text);
                        cm.Parameters.AddWithValue("@mother", txtMother.Text);
                        cm.Parameters.AddWithValue("@mother_occupation", txtOcc2.Text);
                        
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Record has been successfully Updated!", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button3_Click(sender, e);
                        f.loadRecords();
                        this.Dispose();
                    }                   
                }

            }
        }
    }
}
