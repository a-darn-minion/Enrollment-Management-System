namespace Enrollment_Management_System
{
    partial class frmCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourse));
            label4 = new Label();
            button3 = new Button();
            btnUpdate = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnSave = new Button();
            cboYear = new ComboBox();
            cboDephead = new ComboBox();
            txtSection = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 121);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 39;
            label4.Text = "Adviser";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(498, 160);
            button3.Name = "button3";
            button3.Size = new Size(86, 33);
            button3.TabIndex = 38;
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
            btnUpdate.Location = new Point(338, 160);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 33);
            btnUpdate.TabIndex = 37;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 92);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 35;
            label2.Text = "Section";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 61);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 32;
            label1.Text = "Year";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(600, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(647, 51);
            panel1.TabIndex = 31;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 192, 0);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(167, 160);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 33);
            btnSave.TabIndex = 34;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cboYear
            // 
            cboYear.FormattingEnabled = true;
            cboYear.Items.AddRange(new object[] { "7th Grade", "8th Grade", "9th Grade", "10th Grade", "11th Grade", "12th Grade" });
            cboYear.Location = new Point(119, 61);
            cboYear.Name = "cboYear";
            cboYear.Size = new Size(517, 23);
            cboYear.TabIndex = 49;
            cboYear.KeyPress += comboBox1_KeyPress;
            // 
            // cboDephead
            // 
            cboDephead.FormattingEnabled = true;
            cboDephead.Location = new Point(118, 121);
            cboDephead.Name = "cboDephead";
            cboDephead.Size = new Size(517, 23);
            cboDephead.TabIndex = 51;
            cboDephead.SelectedIndexChanged += cboDephead_SelectedIndexChanged;
            cboDephead.KeyPress += comboBox1_KeyPress;
            // 
            // txtSection
            // 
            txtSection.Location = new Point(119, 92);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(517, 23);
            txtSection.TabIndex = 52;
            // 
            // frmCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(647, 213);
            ControlBox = false;
            Controls.Add(txtSection);
            Controls.Add(cboDephead);
            Controls.Add(cboYear);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(btnUpdate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnSave);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(64, 64, 64);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmCourse";
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
        private Panel panel1;
        public Button btnSave;
        public ComboBox cboYear;
        public ComboBox cboDephead;
        public TextBox txtSection;
    }
}