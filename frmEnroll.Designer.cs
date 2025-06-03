namespace Enrollment_Management_System
{
    partial class frmEnroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnroll));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblAY = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtFname = new TextBox();
            txtMname = new TextBox();
            txtLrn = new TextBox();
            txtLname = new TextBox();
            pictureBox2 = new PictureBox();
            txtSection = new TextBox();
            txtYear = new TextBox();
            txtAdviser = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button3 = new Button();
            btnSave = new Button();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 51);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(480, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblAY
            // 
            lblAY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAY.AutoSize = true;
            lblAY.BackColor = Color.FromArgb(128, 128, 255);
            lblAY.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAY.ForeColor = Color.White;
            lblAY.Location = new Point(385, 59);
            lblAY.Name = "lblAY";
            lblAY.Size = new Size(136, 32);
            lblAY.TabIndex = 5;
            lblAY.Text = "2024-2025";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 161);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 66;
            label4.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 187);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 63;
            label3.Text = "Middlename";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 132);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 65;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 103);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 64;
            label1.Text = "Lrn";
            // 
            // txtFname
            // 
            txtFname.BackColor = Color.White;
            txtFname.Enabled = false;
            txtFname.Location = new Point(118, 158);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(385, 23);
            txtFname.TabIndex = 67;
            // 
            // txtMname
            // 
            txtMname.BackColor = Color.White;
            txtMname.Enabled = false;
            txtMname.Location = new Point(118, 187);
            txtMname.Name = "txtMname";
            txtMname.Size = new Size(385, 23);
            txtMname.TabIndex = 68;
            // 
            // txtLrn
            // 
            txtLrn.BackColor = Color.White;
            txtLrn.Enabled = false;
            txtLrn.Location = new Point(118, 100);
            txtLrn.Name = "txtLrn";
            txtLrn.Size = new Size(358, 23);
            txtLrn.TabIndex = 69;
            // 
            // txtLname
            // 
            txtLname.BackColor = Color.White;
            txtLname.Enabled = false;
            txtLname.Location = new Point(118, 129);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(385, 23);
            txtLname.TabIndex = 70;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(480, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txtSection
            // 
            txtSection.BackColor = Color.White;
            txtSection.Enabled = false;
            txtSection.Location = new Point(118, 248);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(385, 23);
            txtSection.TabIndex = 70;
            // 
            // txtYear
            // 
            txtYear.BackColor = Color.White;
            txtYear.Enabled = false;
            txtYear.Location = new Point(118, 219);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(358, 23);
            txtYear.TabIndex = 69;
            // 
            // txtAdviser
            // 
            txtAdviser.BackColor = Color.White;
            txtAdviser.Enabled = false;
            txtAdviser.Location = new Point(118, 277);
            txtAdviser.Name = "txtAdviser";
            txtAdviser.Size = new Size(385, 23);
            txtAdviser.TabIndex = 68;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 222);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 64;
            label5.Text = "Year";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 251);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 65;
            label6.Text = "Section";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 277);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 63;
            label7.Text = "Adviser";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(417, 351);
            button3.Name = "button3";
            button3.Size = new Size(86, 33);
            button3.TabIndex = 72;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 192, 0);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(304, 351);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 33);
            btnSave.TabIndex = 71;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(480, 219);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(23, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 73;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // frmEnroll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(527, 467);
            ControlBox = false;
            Controls.Add(pictureBox4);
            Controls.Add(button3);
            Controls.Add(btnSave);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(txtFname);
            Controls.Add(txtAdviser);
            Controls.Add(txtMname);
            Controls.Add(txtYear);
            Controls.Add(txtLrn);
            Controls.Add(txtSection);
            Controls.Add(txtLname);
            Controls.Add(panel1);
            Controls.Add(lblAY);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(64, 64, 64);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmEnroll";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        public Label lblAY;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox txtFname;
        public TextBox txtMname;
        public TextBox txtLrn;
        public TextBox txtLname;
        private PictureBox pictureBox2;
        public TextBox txtSection;
        public TextBox txtYear;
        public TextBox txtAdviser;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button3;
        public Button btnSave;
        private PictureBox pictureBox4;
    }
}