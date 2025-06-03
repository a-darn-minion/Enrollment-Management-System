namespace Enrollment_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel2 = new Panel();
            button11 = new Button();
            btnAY = new Button();
            btnCourse = new Button();
            btnFees = new Button();
            btnTeacher = new Button();
            btnStudent = new Button();
            btnPay = new Button();
            btnBill = new Button();
            btnEnroll = new Button();
            lblRole = new Label();
            lblUser = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 44, 84);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1484, 5);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(button11);
            panel2.Controls.Add(btnAY);
            panel2.Controls.Add(btnCourse);
            panel2.Controls.Add(btnFees);
            panel2.Controls.Add(btnTeacher);
            panel2.Controls.Add(btnStudent);
            panel2.Controls.Add(btnPay);
            panel2.Controls.Add(btnBill);
            panel2.Controls.Add(btnEnroll);
            panel2.Controls.Add(lblRole);
            panel2.Controls.Add(lblUser);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 756);
            panel2.TabIndex = 1;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button11.BackColor = Color.Gray;
            button11.Cursor = Cursors.Hand;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.MouseOverBackColor = Color.Red;
            button11.FlatStyle = FlatStyle.Flat;
            button11.ForeColor = Color.White;
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(8, 710);
            button11.Name = "button11";
            button11.Padding = new Padding(10, 0, 0, 0);
            button11.Size = new Size(249, 34);
            button11.TabIndex = 13;
            button11.Text = "Logout";
            button11.TextImageRelation = TextImageRelation.ImageBeforeText;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // btnAY
            // 
            btnAY.BackColor = Color.Transparent;
            btnAY.Cursor = Cursors.Hand;
            btnAY.FlatAppearance.BorderSize = 0;
            btnAY.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 84);
            btnAY.FlatStyle = FlatStyle.Flat;
            btnAY.ForeColor = Color.White;
            btnAY.Image = (Image)resources.GetObject("btnAY.Image");
            btnAY.ImageAlign = ContentAlignment.MiddleLeft;
            btnAY.Location = new Point(8, 520);
            btnAY.Name = "btnAY";
            btnAY.Padding = new Padding(10, 0, 0, 0);
            btnAY.Size = new Size(249, 34);
            btnAY.TabIndex = 10;
            btnAY.Text = "   Academic Year";
            btnAY.TextAlign = ContentAlignment.MiddleLeft;
            btnAY.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAY.UseVisualStyleBackColor = false;
            btnAY.Click += button7_Click;
            // 
            // btnCourse
            // 
            btnCourse.BackColor = Color.Transparent;
            btnCourse.Cursor = Cursors.Hand;
            btnCourse.FlatAppearance.BorderSize = 0;
            btnCourse.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 84);
            btnCourse.FlatStyle = FlatStyle.Flat;
            btnCourse.ForeColor = Color.White;
            btnCourse.Image = (Image)resources.GetObject("btnCourse.Image");
            btnCourse.ImageAlign = ContentAlignment.MiddleLeft;
            btnCourse.Location = new Point(8, 480);
            btnCourse.Name = "btnCourse";
            btnCourse.Padding = new Padding(10, 0, 0, 0);
            btnCourse.Size = new Size(249, 34);
            btnCourse.TabIndex = 9;
            btnCourse.Text = "   Section";
            btnCourse.TextAlign = ContentAlignment.MiddleLeft;
            btnCourse.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCourse.UseVisualStyleBackColor = false;
            btnCourse.Click += btnCourse_Click;
            // 
            // btnFees
            // 
            btnFees.BackColor = Color.Transparent;
            btnFees.Cursor = Cursors.Hand;
            btnFees.FlatAppearance.BorderSize = 0;
            btnFees.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 84);
            btnFees.FlatStyle = FlatStyle.Flat;
            btnFees.ForeColor = Color.White;
            btnFees.Image = (Image)resources.GetObject("btnFees.Image");
            btnFees.ImageAlign = ContentAlignment.MiddleLeft;
            btnFees.Location = new Point(8, 440);
            btnFees.Name = "btnFees";
            btnFees.Padding = new Padding(10, 0, 0, 0);
            btnFees.Size = new Size(249, 34);
            btnFees.TabIndex = 8;
            btnFees.Text = "   Fees";
            btnFees.TextAlign = ContentAlignment.MiddleLeft;
            btnFees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFees.UseVisualStyleBackColor = false;
            btnFees.Click += btnFees_Click;
            // 
            // btnTeacher
            // 
            btnTeacher.BackColor = Color.Transparent;
            btnTeacher.Cursor = Cursors.Hand;
            btnTeacher.FlatAppearance.BorderSize = 0;
            btnTeacher.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 84);
            btnTeacher.FlatStyle = FlatStyle.Flat;
            btnTeacher.ForeColor = Color.White;
            btnTeacher.Image = (Image)resources.GetObject("btnTeacher.Image");
            btnTeacher.ImageAlign = ContentAlignment.MiddleLeft;
            btnTeacher.Location = new Point(8, 400);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Padding = new Padding(10, 0, 0, 0);
            btnTeacher.Size = new Size(249, 34);
            btnTeacher.TabIndex = 7;
            btnTeacher.Text = "   Teacher";
            btnTeacher.TextAlign = ContentAlignment.MiddleLeft;
            btnTeacher.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTeacher.UseVisualStyleBackColor = false;
            btnTeacher.Click += button5_Click;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.Transparent;
            btnStudent.Cursor = Cursors.Hand;
            btnStudent.FlatAppearance.BorderSize = 0;
            btnStudent.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 84);
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.ForeColor = Color.White;
            btnStudent.Image = (Image)resources.GetObject("btnStudent.Image");
            btnStudent.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudent.Location = new Point(8, 360);
            btnStudent.Name = "btnStudent";
            btnStudent.Padding = new Padding(10, 0, 0, 0);
            btnStudent.Size = new Size(249, 34);
            btnStudent.TabIndex = 6;
            btnStudent.Text = "   Student";
            btnStudent.TextAlign = ContentAlignment.MiddleLeft;
            btnStudent.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.Transparent;
            btnPay.Cursor = Cursors.Hand;
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 84);
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.ForeColor = Color.White;
            btnPay.Image = (Image)resources.GetObject("btnPay.Image");
            btnPay.ImageAlign = ContentAlignment.MiddleLeft;
            btnPay.Location = new Point(8, 320);
            btnPay.Name = "btnPay";
            btnPay.Padding = new Padding(10, 0, 0, 0);
            btnPay.Size = new Size(249, 34);
            btnPay.TabIndex = 5;
            btnPay.Text = "   Payment";
            btnPay.TextAlign = ContentAlignment.MiddleLeft;
            btnPay.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnBill
            // 
            btnBill.BackColor = Color.Transparent;
            btnBill.Cursor = Cursors.Hand;
            btnBill.FlatAppearance.BorderSize = 0;
            btnBill.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 84);
            btnBill.FlatStyle = FlatStyle.Flat;
            btnBill.ForeColor = Color.White;
            btnBill.Image = (Image)resources.GetObject("btnBill.Image");
            btnBill.ImageAlign = ContentAlignment.MiddleLeft;
            btnBill.Location = new Point(8, 280);
            btnBill.Name = "btnBill";
            btnBill.Padding = new Padding(10, 0, 0, 0);
            btnBill.Size = new Size(249, 34);
            btnBill.TabIndex = 4;
            btnBill.Text = "   Billing";
            btnBill.TextAlign = ContentAlignment.MiddleLeft;
            btnBill.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBill.UseVisualStyleBackColor = false;
            btnBill.Click += btnBill_Click;
            // 
            // btnEnroll
            // 
            btnEnroll.BackColor = Color.Transparent;
            btnEnroll.Cursor = Cursors.Hand;
            btnEnroll.FlatAppearance.BorderSize = 0;
            btnEnroll.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 84);
            btnEnroll.FlatStyle = FlatStyle.Flat;
            btnEnroll.ForeColor = Color.White;
            btnEnroll.Image = (Image)resources.GetObject("btnEnroll.Image");
            btnEnroll.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnroll.Location = new Point(8, 240);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Padding = new Padding(10, 0, 0, 0);
            btnEnroll.Size = new Size(249, 34);
            btnEnroll.TabIndex = 3;
            btnEnroll.Text = "   Enrollment";
            btnEnroll.TextAlign = ContentAlignment.MiddleLeft;
            btnEnroll.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEnroll.UseVisualStyleBackColor = false;
            btnEnroll.Click += btnEnroll_Click;
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(112, 111, 211);
            lblRole.Location = new Point(9, 166);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(248, 23);
            lblRole.TabIndex = 2;
            lblRole.Text = "Administrator";
            lblRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            lblUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.FromArgb(112, 111, 211);
            lblUser.Location = new Point(9, 143);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(248, 23);
            lblUser.TabIndex = 1;
            lblUser.Text = "Sir Iban";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            lblUser.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(269, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1203, 744);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(481, 316);
            label1.Name = "label1";
            label1.Size = new Size(285, 78);
            label1.TabIndex = 0;
            label1.Text = "WELCOME!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 761);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(64, 64, 64);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label lblUser;
        private Label lblRole;
        private Button btnEnroll;
        private Button btnAY;
        private Button btnCourse;
        private Button btnFees;
        private Button btnTeacher;
        private Button btnStudent;
        private Button btnPay;
        private Button btnBill;
        private Button button11;
        private Label label1;
    }
}
