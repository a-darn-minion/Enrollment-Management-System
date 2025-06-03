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
    public partial class frmAY : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        frmAYList f;
        public frmAY(frmAYList f)
        {
            InitializeComponent();
            cn = new MySqlConnection(clsDbConnection._connection);
            this.f = f;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               if (MessageBox.Show("Are you sure you want to add this Academic Year?", clsDbConnection._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                        cn.Open();
                        cm = new MySqlCommand("update tblAY set status = 'Close'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        cn.Open();
                        cm = new MySqlCommand("INSERT into tblAY(AYcode)values(@AYcode)", cn);     
                        cm.Parameters.AddWithValue("@AYcode", txtAY.Text);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("New Academic year has been successfully saved!", clsDbConnection._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAY.Clear();
                        txtAY.Focus();
                        
                        cn.Close();

                        f.loadRecords();

                    MessageBox.Show("Academic Year added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, clsDbConnection._title, MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }


    } 
}
