namespace Enrollment_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmAYList f = new frmAYList();
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.BringToFront();
            f.loadRecords();
            f.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFees_Click(object sender, EventArgs e)
        {
            frmFeesList f = new frmFeesList();
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.BringToFront();
            f.loadRecords();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmTeacherList f = new frmTeacherList();
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.BringToFront();
            f.loadRecords();
            f.Show();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            frmCourseList f = new frmCourseList();
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.BringToFront();
            f.loadRecords();
            f.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            frmStudentList f = new frmStudentList();
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.BringToFront();
            f.loadRecords();
            f.Show();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            frmEnrollmentList f = new frmEnrollmentList();
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.BringToFront();
            f.getAY();
            f.loadRecords();
            f.Show();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            frmBillingList f = new frmBillingList();
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.BringToFront();
            f.getAY();
            f.Show();
            f.loadRecords();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            frmPayment f = new frmPayment(this);
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.BringToFront();
            f.getAY();
            f.Show();
            f.loadRecords();
        }

       
    }
}
