namespace Enrollment_Management_System
{
    partial class frmStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            label4 = new Label();
            button3 = new Button();
            btnUpdate = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtLname = new TextBox();
            panel1 = new Panel();
            btnSave = new Button();
            txtLrn = new TextBox();
            txtMname = new TextBox();
            txtFname = new TextBox();
            txtAddress = new TextBox();
            txtAge = new TextBox();
            txtOcc1 = new TextBox();
            txtOcc2 = new TextBox();
            txtFather = new TextBox();
            txtMother = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblOccupation = new Label();
            label10 = new Label();
            label11 = new Label();
            dtBdate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 124);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 59;
            label4.Text = "First Name";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(423, 394);
            button3.Name = "button3";
            button3.Size = new Size(86, 33);
            button3.TabIndex = 58;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 192, 0);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(270, 394);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 33);
            btnUpdate.TabIndex = 57;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 56;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 54;
            label1.Text = "Lrn";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(471, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(124, 92);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(385, 23);
            txtLname.TabIndex = 62;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 51);
            panel1.TabIndex = 53;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 192, 0);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(124, 394);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 33);
            btnSave.TabIndex = 55;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtLrn
            // 
            txtLrn.Location = new Point(124, 63);
            txtLrn.Name = "txtLrn";
            txtLrn.Size = new Size(385, 23);
            txtLrn.TabIndex = 62;
            // 
            // txtMname
            // 
            txtMname.Location = new Point(124, 150);
            txtMname.Name = "txtMname";
            txtMname.Size = new Size(385, 23);
            txtMname.TabIndex = 62;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(124, 121);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(385, 23);
            txtFname.TabIndex = 62;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(124, 179);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(385, 23);
            txtAddress.TabIndex = 62;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(124, 237);
            txtAge.Name = "txtAge";
            txtAge.ReadOnly = true;
            txtAge.Size = new Size(385, 23);
            txtAge.TabIndex = 62;
            // 
            // txtOcc1
            // 
            txtOcc1.Location = new Point(124, 295);
            txtOcc1.Name = "txtOcc1";
            txtOcc1.Size = new Size(385, 23);
            txtOcc1.TabIndex = 62;
            // 
            // txtOcc2
            // 
            txtOcc2.Location = new Point(124, 353);
            txtOcc2.Name = "txtOcc2";
            txtOcc2.Size = new Size(385, 23);
            txtOcc2.TabIndex = 62;
            // 
            // txtFather
            // 
            txtFather.Location = new Point(124, 266);
            txtFather.Name = "txtFather";
            txtFather.Size = new Size(385, 23);
            txtFather.TabIndex = 62;
            // 
            // txtMother
            // 
            txtMother.Location = new Point(124, 324);
            txtMother.Name = "txtMother";
            txtMother.Size = new Size(385, 23);
            txtMother.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 150);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 54;
            label3.Text = "Middlename";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 179);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 56;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 208);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 59;
            label6.Text = "Birthdate";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 237);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 54;
            label7.Text = "Age";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 266);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 56;
            label8.Text = "Father Name";
            label8.Click += label8_Click;
            // 
            // lblOccupation
            // 
            lblOccupation.AutoSize = true;
            lblOccupation.Location = new Point(12, 295);
            lblOccupation.Name = "lblOccupation";
            lblOccupation.Size = new Size(69, 15);
            lblOccupation.TabIndex = 59;
            lblOccupation.Text = "Occupation";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 327);
            label10.Name = "label10";
            label10.Size = new Size(81, 15);
            label10.TabIndex = 56;
            label10.Text = "Mother Name";
            label10.Click += label8_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 356);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 59;
            label11.Text = "Occupation";
            // 
            // dtBdate
            // 
            dtBdate.Format = DateTimePickerFormat.Short;
            dtBdate.Location = new Point(124, 208);
            dtBdate.Name = "dtBdate";
            dtBdate.Size = new Size(385, 23);
            dtBdate.TabIndex = 65;
            dtBdate.ValueChanged += dtBdate_ValueChanged;
            // 
            // frmStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(518, 442);
            ControlBox = false;
            Controls.Add(dtBdate);
            Controls.Add(label11);
            Controls.Add(lblOccupation);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(btnUpdate);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMother);
            Controls.Add(txtAddress);
            Controls.Add(txtFather);
            Controls.Add(txtFname);
            Controls.Add(txtOcc2);
            Controls.Add(txtOcc1);
            Controls.Add(txtMname);
            Controls.Add(txtAge);
            Controls.Add(txtLrn);
            Controls.Add(txtLname);
            Controls.Add(panel1);
            Controls.Add(btnSave);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(64, 64, 64);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmStudent";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button button3;
        public Button btnUpdate;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        public TextBox txtLname;
        private Panel panel1;
        public Button btnSave;
        public TextBox txtLrn;
        public TextBox txtMname;
        public TextBox txtFname;
        public TextBox txtAddress;
        public TextBox txtAge;
        public TextBox txtOcc1;
        public TextBox txtOcc2;
        public TextBox txtFather;
        public TextBox txtMother;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblOccupation;
        private Label label10;
        private Label label11;
        public DateTimePicker dtBdate;
    }
}