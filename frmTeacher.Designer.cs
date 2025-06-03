namespace Enrollment_Management_System
{
    partial class frmTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacher));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            btnUpdate = new Button();
            txtlname = new TextBox();
            label2 = new Label();
            btnSave = new Button();
            txtID = new TextBox();
            label1 = new Label();
            txtmname = new TextBox();
            label3 = new Label();
            txtfname = new TextBox();
            label4 = new Label();
            txtaddress = new TextBox();
            label5 = new Label();
            txtcontact = new TextBox();
            label6 = new Label();
            txtemail = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 51);
            panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(607, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(507, 296);
            button3.Name = "button3";
            button3.Size = new Size(86, 33);
            button3.TabIndex = 20;
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
            btnUpdate.Location = new Point(347, 296);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 33);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtlname
            // 
            txtlname.Location = new Point(125, 96);
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(515, 23);
            txtlname.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 96);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 17;
            label2.Text = "Last Name";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 192, 0);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(176, 296);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 33);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(125, 65);
            txtID.Name = "txtID";
            txtID.Size = new Size(515, 23);
            txtID.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 14;
            label1.Text = "Teacher ID";
            // 
            // txtmname
            // 
            txtmname.Location = new Point(125, 156);
            txtmname.Name = "txtmname";
            txtmname.Size = new Size(515, 23);
            txtmname.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 156);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 23;
            label3.Text = "Middlename";
            // 
            // txtfname
            // 
            txtfname.Location = new Point(125, 125);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(515, 23);
            txtfname.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 125);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 21;
            label4.Text = "First Name";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(125, 216);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(515, 23);
            txtaddress.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 216);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 27;
            label5.Text = "Address";
            // 
            // txtcontact
            // 
            txtcontact.Location = new Point(125, 185);
            txtcontact.Name = "txtcontact";
            txtcontact.Size = new Size(515, 23);
            txtcontact.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 185);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 25;
            label6.Text = "Contact";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(125, 245);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(515, 23);
            txtemail.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 245);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 29;
            label8.Text = "Email";
            // 
            // frmTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(653, 358);
            ControlBox = false;
            Controls.Add(txtemail);
            Controls.Add(label8);
            Controls.Add(txtaddress);
            Controls.Add(label5);
            Controls.Add(txtcontact);
            Controls.Add(label6);
            Controls.Add(txtmname);
            Controls.Add(label3);
            Controls.Add(txtfname);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(btnUpdate);
            Controls.Add(txtlname);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(txtID);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(64, 64, 64);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmTeacher";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button3;
        public Button btnUpdate;
        public TextBox txtlname;
        private Label label2;
        public Button btnSave;
        public TextBox txtID;
        private Label label1;
        public TextBox txtmname;
        private Label label3;
        public TextBox txtfname;
        private Label label4;
        public TextBox txtaddress;
        private Label label5;
        public TextBox txtcontact;
        private Label label6;
        public TextBox txtemail;
        private Label label8;
    }
}