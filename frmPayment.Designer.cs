namespace Enrollment_Management_System
{
    partial class frmPayment
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            View = new DataGridViewImageColumn();
            panel3 = new Panel();
            txtSearch = new MetroSet_UI.Controls.MetroSetTextBox();
            tabPage2 = new TabPage();
            btnSave = new Button();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewImageColumn();
            txtCurBalance = new TextBox();
            label8 = new Label();
            txtRunBalance = new TextBox();
            label10 = new Label();
            txtPayment = new TextBox();
            label7 = new Label();
            txtCash = new TextBox();
            label9 = new Label();
            txtTuition = new TextBox();
            label6 = new Label();
            txtAY = new TextBox();
            label5 = new Label();
            txtYear = new TextBox();
            label4 = new Label();
            txtSection = new TextBox();
            label3 = new Label();
            txtStudentName = new TextBox();
            label2 = new Label();
            txtLrn = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ItemSize = new Size(60, 25);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(919, 594);
            tabControl1.TabIndex = 42;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(panel3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(911, 561);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "List of Enrollees";
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column3, Column1, Column4, Column7, Column5, Column9, View });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(3, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(905, 517);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Enrollment ID";
            Column3.Name = "Column3";
            Column3.Visible = false;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "lrn";
            Column1.Name = "Column1";
            Column1.Width = 44;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Student Name";
            Column4.Name = "Column4";
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "Section";
            Column7.Name = "Column7";
            Column7.Width = 70;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Year";
            Column5.Name = "Column5";
            Column5.Width = 52;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.HeaderText = "Status";
            Column9.Name = "Column9";
            Column9.Width = 63;
            // 
            // View
            // 
            View.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            View.HeaderText = "";
            View.Image = (Image)resources.GetObject("View.Image");
            View.Name = "View";
            View.ToolTipText = "Drop Student";
            View.Width = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtSearch);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(905, 38);
            panel3.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.AutoCompleteCustomSource = null;
            txtSearch.AutoCompleteMode = AutoCompleteMode.None;
            txtSearch.AutoCompleteSource = AutoCompleteSource.None;
            txtSearch.BorderColor = Color.FromArgb(155, 155, 155);
            txtSearch.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtSearch.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtSearch.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtSearch.Font = new Font("Microsoft Sans Serif", 10F);
            txtSearch.HoverColor = Color.FromArgb(102, 102, 102);
            txtSearch.Image = (Image)resources.GetObject("txtSearch.Image");
            txtSearch.IsDerivedStyle = true;
            txtSearch.Lines = null;
            txtSearch.Location = new Point(593, 4);
            txtSearch.MaxLength = 32767;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.ReadOnly = false;
            txtSearch.Size = new Size(307, 30);
            txtSearch.Style = MetroSet_UI.Enums.Style.Light;
            txtSearch.StyleManager = null;
            txtSearch.TabIndex = 0;
            txtSearch.TextAlign = HorizontalAlignment.Left;
            txtSearch.ThemeAuthor = "Narwin";
            txtSearch.ThemeName = "MetroLite";
            txtSearch.UseSystemPasswordChar = false;
            txtSearch.WatermarkText = "Search";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnSave);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(txtCurBalance);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txtRunBalance);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(txtPayment);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txtCash);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(txtTuition);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txtAY);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtYear);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtSection);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txtStudentName);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txtLrn);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(911, 561);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Payment Transaction";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 192, 0);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(821, 167);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 33);
            btnSave.TabIndex = 72;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.ColumnHeadersHeight = 30;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn8, Column2, Delete });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.Dock = DockStyle.Bottom;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = SystemColors.Control;
            dataGridView2.Location = new Point(3, 218);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 27;
            dataGridView2.Size = new Size(905, 340);
            dataGridView2.TabIndex = 20;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.HeaderText = "id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.HeaderText = "lrn";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 44;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Student Name";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn5.HeaderText = "Year";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 52;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn4.HeaderText = "Section";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn8.HeaderText = "Amount";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 74;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Date";
            Column2.Name = "Column2";
            Column2.Width = 55;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.Name = "Delete";
            Delete.ToolTipText = "Delete Payment";
            Delete.Width = 5;
            // 
            // txtCurBalance
            // 
            txtCurBalance.BackColor = Color.White;
            txtCurBalance.Enabled = false;
            txtCurBalance.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtCurBalance.Location = new Point(600, 71);
            txtCurBalance.Name = "txtCurBalance";
            txtCurBalance.Size = new Size(307, 25);
            txtCurBalance.TabIndex = 19;
            txtCurBalance.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(489, 74);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 18;
            label8.Text = "Current Balance";
            // 
            // txtRunBalance
            // 
            txtRunBalance.BackColor = Color.White;
            txtRunBalance.Enabled = false;
            txtRunBalance.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtRunBalance.Location = new Point(600, 129);
            txtRunBalance.Name = "txtRunBalance";
            txtRunBalance.Size = new Size(307, 25);
            txtRunBalance.TabIndex = 19;
            txtRunBalance.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(489, 132);
            label10.Name = "label10";
            label10.Size = new Size(96, 15);
            label10.TabIndex = 18;
            label10.Text = "Running Balance";
            // 
            // txtPayment
            // 
            txtPayment.BackColor = Color.White;
            txtPayment.Enabled = false;
            txtPayment.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtPayment.Location = new Point(600, 42);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(307, 25);
            txtPayment.TabIndex = 19;
            txtPayment.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(489, 45);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 18;
            label7.Text = "Total Payment";
            // 
            // txtCash
            // 
            txtCash.BackColor = Color.White;
            txtCash.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtCash.Location = new Point(600, 100);
            txtCash.Name = "txtCash";
            txtCash.Size = new Size(307, 25);
            txtCash.TabIndex = 12;
            txtCash.TextAlign = HorizontalAlignment.Center;
            txtCash.TextChanged += txtCash_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(489, 103);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 7;
            label9.Text = "Cash Payment";
            // 
            // txtTuition
            // 
            txtTuition.BackColor = Color.White;
            txtTuition.Enabled = false;
            txtTuition.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtTuition.Location = new Point(600, 13);
            txtTuition.Name = "txtTuition";
            txtTuition.Size = new Size(307, 25);
            txtTuition.TabIndex = 12;
            txtTuition.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(489, 16);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 7;
            label6.Text = "Total Tuition";
            // 
            // txtAY
            // 
            txtAY.BackColor = Color.White;
            txtAY.Enabled = false;
            txtAY.Location = new Point(121, 129);
            txtAY.Name = "txtAY";
            txtAY.Size = new Size(350, 23);
            txtAY.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 132);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 7;
            label5.Text = "Academic Year";
            // 
            // txtYear
            // 
            txtYear.BackColor = Color.White;
            txtYear.Enabled = false;
            txtYear.Location = new Point(121, 100);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(350, 23);
            txtYear.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 103);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 8;
            label4.Text = "Year";
            // 
            // txtSection
            // 
            txtSection.BackColor = Color.White;
            txtSection.Enabled = false;
            txtSection.Location = new Point(121, 71);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(350, 23);
            txtSection.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 74);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 9;
            label3.Text = "Section";
            // 
            // txtStudentName
            // 
            txtStudentName.BackColor = Color.White;
            txtStudentName.Enabled = false;
            txtStudentName.Location = new Point(121, 42);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(350, 23);
            txtStudentName.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 45);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 10;
            label2.Text = "Student Name";
            // 
            // txtLrn
            // 
            txtLrn.BackColor = Color.White;
            txtLrn.Enabled = false;
            txtLrn.Location = new Point(121, 13);
            txtLrn.Name = "txtLrn";
            txtLrn.Size = new Size(350, 23);
            txtLrn.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 16);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 11;
            label1.Text = "Lrn";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(670, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.ItemSize = new Size(67, 25);
            tabControl2.Location = new Point(0, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(933, 633);
            tabControl2.TabIndex = 44;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Controls.Add(panel1);
            tabPage3.Controls.Add(tabControl1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(925, 600);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Payment";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(225, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 26);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1246, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // frmPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(933, 633);
            ControlBox = false;
            Controls.Add(tabControl2);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(64, 64, 64);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmPayment";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel3;
        private DataGridView dataGridView1;
        private MetroSet_UI.Controls.MetroSetTextBox txtSearch;
        public TextBox txtAY;
        private Label label5;
        public TextBox txtYear;
        private Label label4;
        public TextBox txtSection;
        private Label label3;
        public TextBox txtStudentName;
        private Label label2;
        public TextBox txtLrn;
        private Label label1;
        public GroupBox groupBox1;
        public TextBox textBox2;
        private Label label8;
        public TextBox textBox1;
        private Label label7;
        public TextBox txtTuition;
        private Label label6;
        public TextBox textBox4;
        private Label label10;
        public TextBox txtCash;
        private Label label9;
        private DataGridView dataGridView2;
        public Button btnSave;
        public TextBox txtCurBalance;
        public TextBox txtPayment;
        public TextBox txtRunBalance;
        private PictureBox pictureBox1;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private Panel panel1;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewImageColumn Delete;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewImageColumn View;
    }
}