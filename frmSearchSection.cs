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
    public partial class frmSearchSection : Form
    {
        frmEnroll f;

        public frmSearchSection(frmEnroll f)
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
                    using (MySqlCommand cm = new MySqlCommand("SELECT * FROM vwcourse", cn))
                    {
                        MySqlDataReader dr;
                        cn.Open();
                        dr = cm.ExecuteReader();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr["id"], dr["course"], dr["year"], dr["adviserid"], dr["adviser"]);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string _column = dataGridView1.Columns[e.ColumnIndex].Name;
            if (_column == "colSelect")
            {
                
                f.txtYear.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                f._courseId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                f.txtSection.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                f._adviserId = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                f.txtAdviser.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                
                this.Dispose();
            }
        }
    }
}
