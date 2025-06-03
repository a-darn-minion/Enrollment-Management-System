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
    public partial class frmFee : Form
    {
        frmFeesList f;
        public string _id;
        public frmFee(frmFeesList f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            txtDescription.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtDescription.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to save this fees?", clsDbConnection._connection, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
                    {

                        using (MySqlCommand cm = new MySqlCommand("INSERT INTO tblfees (fees, amount)VALUES(@fees, @amount)", cn))
                        {
                            cn.Open();
                            cm.Parameters.AddWithValue("@fees", txtDescription.Text);
                            cm.Parameters.AddWithValue("@amount", double.Parse(txtAmount.Text));
                            cm.ExecuteNonQuery();
                            cn.Close();

                            MessageBox.Show("New Fee has been successfully saved!", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button3_Click(sender, e);
                            f.loadRecords();
                        }
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

        private void frmFee_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to update this fee?", clsDbConnection._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection cn = new MySqlConnection(clsDbConnection._connection))
                    {

                        using (MySqlCommand cm = new MySqlCommand("UPDATE  tblfees set fees =@fees, amount = @amount where id = @id", cn))
                        {
                            cn.Open();
                            cm.Parameters.AddWithValue("@fees", txtDescription.Text);
                            cm.Parameters.AddWithValue("@amount", double.Parse(txtAmount.Text));
                            cm.Parameters.AddWithValue("@id", lblId.Text);
                            cm.ExecuteNonQuery();
                            cn.Close();

                            MessageBox.Show("New Fee has been successfully updated!", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            f.loadRecords();
                            this.Dispose();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
