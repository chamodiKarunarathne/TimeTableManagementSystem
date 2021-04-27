
namespace TimeTable
{
    partial class AddStudent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGenerateId = new System.Windows.Forms.Button();
            this.txtBoxSubGroupId = new System.Windows.Forms.TextBox();
            this.txtBoxGroupId = new System.Windows.Forms.TextBox();
            this.txtBoxProgramme = new System.Windows.Forms.ComboBox();
            this.SubGroupNumber = new System.Windows.Forms.NumericUpDown();
            this.GroupNumber = new System.Windows.Forms.NumericUpDown();
            this.txtBoxAcedemicYearAndSemester = new System.Windows.Forms.TextBox();
            this.lblSubGroupId = new System.Windows.Forms.Label();
            this.lblGroupId = new System.Windows.Forms.Label();
            this.lblSubGroupNumber = new System.Windows.Forms.Label();
            this.lblGroupNumber = new System.Windows.Forms.Label();
            this.lblProgramme = new System.Windows.Forms.Label();
            this.lblAcademicYearAndSemester = new System.Windows.Forms.Label();
            this.txtBoxStudentId = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubGroupNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblSearch.Location = new System.Drawing.Point(970, 317);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(89, 29);
            this.lblSearch.TabIndex = 47;
            this.lblSearch.Text = "Search";
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.AllowUserToResizeRows = false;
            this.dgvStudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStudentList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvStudentList.Location = new System.Drawing.Point(950, 406);
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.RowHeadersWidth = 51;
            this.dgvStudentList.RowTemplate.Height = 24;
            this.dgvStudentList.Size = new System.Drawing.Size(1000, 438);
            this.dgvStudentList.TabIndex = 45;
            this.dgvStudentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentList_CellContentClick);
            this.dgvStudentList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStudentList_RowHeaderMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(740, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(511, 51);
            this.label7.TabIndex = 43;
            this.label7.Text = "Manage Student Groups";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtBoxSearch.Location = new System.Drawing.Point(1076, 314);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(596, 34);
            this.txtBoxSearch.TabIndex = 46;
            this.toolTip6.SetToolTip(this.txtBoxSearch, "Search Here");
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(32)))));
            this.panel1.Location = new System.Drawing.Point(0, 1045);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2050, 20);
            this.panel1.TabIndex = 41;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1190, 920);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 50);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.toolTip5.SetToolTip(this.btnDelete, "Delete from the Database");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(990, 920);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 50);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.toolTip4.SetToolTip(this.btnUpdate, "Update the New Fields to the Database");
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(123)))), ((int)(((byte)(202)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(790, 920);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 50);
            this.btnClear.TabIndex = 38;
            this.btnClear.Text = "Clear";
            this.toolTip2.SetToolTip(this.btnClear, "Clear all the Fields");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(151)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(590, 920);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 50);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.toolTip1.SetToolTip(this.btnSave, "Click to Save Records");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // btnGenerateId
            // 
            this.btnGenerateId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.btnGenerateId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnGenerateId.ForeColor = System.Drawing.Color.White;
            this.btnGenerateId.Location = new System.Drawing.Point(321, 920);
            this.btnGenerateId.Name = "btnGenerateId";
            this.btnGenerateId.Size = new System.Drawing.Size(220, 50);
            this.btnGenerateId.TabIndex = 36;
            this.btnGenerateId.Text = "Generate ID\'s";
            this.toolTip3.SetToolTip(this.btnGenerateId, "Generate the Group ID\'s of the Student");
            this.btnGenerateId.UseVisualStyleBackColor = false;
            this.btnGenerateId.Click += new System.EventHandler(this.btnGenerateId_Click);
            // 
            // txtBoxSubGroupId
            // 
            this.txtBoxSubGroupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtBoxSubGroupId.Location = new System.Drawing.Point(490, 806);
            this.txtBoxSubGroupId.Name = "txtBoxSubGroupId";
            this.txtBoxSubGroupId.Size = new System.Drawing.Size(300, 34);
            this.txtBoxSubGroupId.TabIndex = 35;
            // 
            // txtBoxGroupId
            // 
            this.txtBoxGroupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtBoxGroupId.Location = new System.Drawing.Point(490, 706);
            this.txtBoxGroupId.Name = "txtBoxGroupId";
            this.txtBoxGroupId.Size = new System.Drawing.Size(300, 34);
            this.txtBoxGroupId.TabIndex = 34;
            // 
            // txtBoxProgramme
            // 
            this.txtBoxProgramme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtBoxProgramme.FormattingEnabled = true;
            this.txtBoxProgramme.Items.AddRange(new object[] {
            "Information Technology",
            "Cyber Security",
            "Software Engineering",
            "Data Science",
            "Interactive Media",
            "Information System Engineering"});
            this.txtBoxProgramme.Location = new System.Drawing.Point(490, 406);
            this.txtBoxProgramme.Name = "txtBoxProgramme";
            this.txtBoxProgramme.Size = new System.Drawing.Size(300, 37);
            this.txtBoxProgramme.TabIndex = 33;
            this.txtBoxProgramme.SelectedIndexChanged += new System.EventHandler(this.txtBoxProgramme_SelectedIndexChanged);
            // 
            // SubGroupNumber
            // 
            this.SubGroupNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.SubGroupNumber.Location = new System.Drawing.Point(490, 606);
            this.SubGroupNumber.Name = "SubGroupNumber";
            this.SubGroupNumber.Size = new System.Drawing.Size(300, 34);
            this.SubGroupNumber.TabIndex = 32;
            // 
            // GroupNumber
            // 
            this.GroupNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.GroupNumber.Location = new System.Drawing.Point(490, 506);
            this.GroupNumber.Name = "GroupNumber";
            this.GroupNumber.Size = new System.Drawing.Size(300, 34);
            this.GroupNumber.TabIndex = 31;
            this.GroupNumber.ValueChanged += new System.EventHandler(this.GroupNumber_ValueChanged);
            // 
            // txtBoxAcedemicYearAndSemester
            // 
            this.txtBoxAcedemicYearAndSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtBoxAcedemicYearAndSemester.Location = new System.Drawing.Point(490, 306);
            this.txtBoxAcedemicYearAndSemester.Name = "txtBoxAcedemicYearAndSemester";
            this.txtBoxAcedemicYearAndSemester.Size = new System.Drawing.Size(300, 34);
            this.txtBoxAcedemicYearAndSemester.TabIndex = 30;
            // 
            // lblSubGroupId
            // 
            this.lblSubGroupId.AutoSize = true;
            this.lblSubGroupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblSubGroupId.Location = new System.Drawing.Point(50, 806);
            this.lblSubGroupId.Name = "lblSubGroupId";
            this.lblSubGroupId.Size = new System.Drawing.Size(172, 29);
            this.lblSubGroupId.TabIndex = 29;
            this.lblSubGroupId.Text = "Sub - Group ID";
            // 
            // lblGroupId
            // 
            this.lblGroupId.AutoSize = true;
            this.lblGroupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblGroupId.Location = new System.Drawing.Point(50, 706);
            this.lblGroupId.Name = "lblGroupId";
            this.lblGroupId.Size = new System.Drawing.Size(109, 29);
            this.lblGroupId.TabIndex = 28;
            this.lblGroupId.Text = "Group ID";
            // 
            // lblSubGroupNumber
            // 
            this.lblSubGroupNumber.AutoSize = true;
            this.lblSubGroupNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblSubGroupNumber.Location = new System.Drawing.Point(50, 606);
            this.lblSubGroupNumber.Name = "lblSubGroupNumber";
            this.lblSubGroupNumber.Size = new System.Drawing.Size(236, 29);
            this.lblSubGroupNumber.TabIndex = 27;
            this.lblSubGroupNumber.Text = "Sub - Group Number";
            this.lblSubGroupNumber.Click += new System.EventHandler(this.lblSubGroupNumber_Click);
            // 
            // lblGroupNumber
            // 
            this.lblGroupNumber.AutoSize = true;
            this.lblGroupNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblGroupNumber.Location = new System.Drawing.Point(50, 506);
            this.lblGroupNumber.Name = "lblGroupNumber";
            this.lblGroupNumber.Size = new System.Drawing.Size(173, 29);
            this.lblGroupNumber.TabIndex = 26;
            this.lblGroupNumber.Text = "Group Number";
            // 
            // lblProgramme
            // 
            this.lblProgramme.AutoSize = true;
            this.lblProgramme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblProgramme.Location = new System.Drawing.Point(50, 406);
            this.lblProgramme.Name = "lblProgramme";
            this.lblProgramme.Size = new System.Drawing.Size(140, 29);
            this.lblProgramme.TabIndex = 25;
            this.lblProgramme.Text = "Programme";
            // 
            // lblAcademicYearAndSemester
            // 
            this.lblAcademicYearAndSemester.AutoSize = true;
            this.lblAcademicYearAndSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicYearAndSemester.Location = new System.Drawing.Point(50, 306);
            this.lblAcademicYearAndSemester.Name = "lblAcademicYearAndSemester";
            this.lblAcademicYearAndSemester.Size = new System.Drawing.Size(331, 29);
            this.lblAcademicYearAndSemester.TabIndex = 24;
            this.lblAcademicYearAndSemester.Text = "Acadamic Year and Semester";
            // 
            // txtBoxStudentId
            // 
            this.txtBoxStudentId.Location = new System.Drawing.Point(491, 228);
            this.txtBoxStudentId.Name = "txtBoxStudentId";
            this.txtBoxStudentId.Size = new System.Drawing.Size(300, 22);
            this.txtBoxStudentId.TabIndex = 48;
            this.txtBoxStudentId.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1990, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2050, 40);
            this.panel2.TabIndex = 42;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.txtBoxStudentId);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvStudentList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGenerateId);
            this.Controls.Add(this.txtBoxSubGroupId);
            this.Controls.Add(this.txtBoxGroupId);
            this.Controls.Add(this.txtBoxProgramme);
            this.Controls.Add(this.SubGroupNumber);
            this.Controls.Add(this.GroupNumber);
            this.Controls.Add(this.txtBoxAcedemicYearAndSemester);
            this.Controls.Add(this.lblSubGroupId);
            this.Controls.Add(this.lblGroupId);
            this.Controls.Add(this.lblSubGroupNumber);
            this.Controls.Add(this.lblGroupNumber);
            this.Controls.Add(this.lblProgramme);
            this.Controls.Add(this.lblAcademicYearAndSemester);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubGroupNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvStudentList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGenerateId;
        private System.Windows.Forms.TextBox txtBoxSubGroupId;
        private System.Windows.Forms.TextBox txtBoxGroupId;
        private System.Windows.Forms.ComboBox txtBoxProgramme;
        private System.Windows.Forms.NumericUpDown SubGroupNumber;
        private System.Windows.Forms.NumericUpDown GroupNumber;
        private System.Windows.Forms.TextBox txtBoxAcedemicYearAndSemester;
        private System.Windows.Forms.Label lblSubGroupId;
        private System.Windows.Forms.Label lblGroupId;
        private System.Windows.Forms.Label lblSubGroupNumber;
        private System.Windows.Forms.Label lblGroupNumber;
        private System.Windows.Forms.Label lblProgramme;
        private System.Windows.Forms.Label lblAcademicYearAndSemester;
        private System.Windows.Forms.TextBox txtBoxStudentId;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip6;
    }
}

