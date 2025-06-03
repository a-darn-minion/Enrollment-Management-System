namespace Enrollment_Management_System
{
    partial class frmBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBilling));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblEID = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            txtLrn = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtStudentName = new TextBox();
            label3 = new Label();
            txtSection = new TextBox();
            label4 = new Label();
            txtYear = new TextBox();
            label5 = new Label();
            txtAY = new TextBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            cboDesc = new ComboBox();
            label7 = new Label();
            txtAmount = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(lblEID);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1089, 51);
            panel1.TabIndex = 4;
            // 
            // lblEID
            // 
            lblEID.AutoSize = true;
            lblEID.Location = new Point(915, 29);
            lblEID.Name = "lblEID";
            lblEID.Size = new Size(24, 15);
            lblEID.TabIndex = 41;
            lblEID.Text = "Lrn";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1042, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(388, 297);
            button1.Name = "button1";
            button1.Size = new Size(86, 33);
            button1.TabIndex = 7;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtLrn
            // 
            txtLrn.Enabled = false;
            txtLrn.Location = new Point(124, 69);
            txtLrn.Name = "txtLrn";
            txtLrn.Size = new Size(350, 23);
            txtLrn.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 72);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 5;
            label1.Text = "Lrn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 101);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 5;
            label2.Text = "Student Name";
            // 
            // txtStudentName
            // 
            txtStudentName.Enabled = false;
            txtStudentName.Location = new Point(124, 98);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(350, 23);
            txtStudentName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 130);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 5;
            label3.Text = "Section";
            // 
            // txtSection
            // 
            txtSection.Enabled = false;
            txtSection.Location = new Point(124, 127);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(350, 23);
            txtSection.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 159);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 5;
            label4.Text = "Year";
            // 
            // txtYear
            // 
            txtYear.Enabled = false;
            txtYear.Location = new Point(124, 156);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(350, 23);
            txtYear.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 188);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 5;
            label5.Text = "Academic Year";
            // 
            // txtAY
            // 
            txtAY.Enabled = false;
            txtAY.Location = new Point(124, 185);
            txtAY.Name = "txtAY";
            txtAY.Size = new Size(350, 23);
            txtAY.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(13, 214);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 13);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 239);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 5;
            label6.Text = "Description";
            // 
            // cboDesc
            // 
            cboDesc.FormattingEnabled = true;
            cboDesc.Location = new Point(124, 239);
            cboDesc.Name = "cboDesc";
            cboDesc.Size = new Size(350, 23);
            cboDesc.TabIndex = 9;
            cboDesc.SelectedIndexChanged += cboDesc_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 268);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 5;
            label7.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Enabled = false;
            txtAmount.Location = new Point(124, 268);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(350, 23);
            txtAmount.TabIndex = 10;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(480, 50);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(609, 310);
            tabControl1.TabIndex = 40;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(601, 282);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Student Billing";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column3, Column2, Column8, Delete });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(595, 276);
            dataGridView1.TabIndex = 2;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "id";
            Column3.Name = "Column3";
            Column3.Visible = false;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Description";
            Column2.Name = "Column2";
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column8.DefaultCellStyle = dataGridViewCellStyle2;
            Column8.HeaderText = "Amount";
            Column8.Name = "Column8";
            Column8.Width = 74;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.Name = "Delete";
            Delete.ToolTipText = "Drop Student";
            Delete.Width = 5;
            // 
            // frmBilling
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1089, 358);
            ControlBox = false;
            Controls.Add(tabControl1);
            Controls.Add(txtAmount);
            Controls.Add(cboDesc);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(txtAY);
            Controls.Add(label5);
            Controls.Add(txtYear);
            Controls.Add(label4);
            Controls.Add(txtSection);
            Controls.Add(label3);
            Controls.Add(txtStudentName);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(txtLrn);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(64, 64, 64);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmBilling";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewImageColumn Delete;
        public Label lblEID;
        public TextBox txtLrn;
        public TextBox txtStudentName;
        public TextBox txtSection;
        public TextBox txtYear;
        public TextBox txtAY;
        public GroupBox groupBox1;
        public ComboBox cboDesc;
        public TextBox txtAmount;
    }
}