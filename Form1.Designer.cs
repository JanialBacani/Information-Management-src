namespace DATABASEINFOMAN
{
    partial class Form1
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
            this.txtidno = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.txthiredates = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.hiredate = new System.Windows.Forms.TextBox();
            this.query = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdeptid = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnJobRoles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnERD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLocation = new System.Windows.Forms.Button();
            this.dataGridAuditLog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuditLog)).BeginInit();
            this.SuspendLayout();
            // 
            // txtidno
            // 
            this.txtidno.BackColor = System.Drawing.SystemColors.Window;
            this.txtidno.Location = new System.Drawing.Point(168, 96);
            this.txtidno.Name = "txtidno";
            this.txtidno.Size = new System.Drawing.Size(184, 22);
            this.txtidno.TabIndex = 0;
            this.txtidno.TextChanged += new System.EventHandler(this.txtidno_TextChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(128, 96);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(24, 18);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(40, 138);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(112, 18);
            this.FirstName.TabIndex = 2;
            this.FirstName.Text = "Employee Name";
            this.FirstName.Click += new System.EventHandler(this.FirstName_Click);
            // 
            // txthiredates
            // 
            this.txthiredates.AutoSize = true;
            this.txthiredates.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthiredates.Location = new System.Drawing.Point(75, 179);
            this.txthiredates.Name = "txthiredates";
            this.txthiredates.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txthiredates.Size = new System.Drawing.Size(80, 18);
            this.txthiredates.TabIndex = 3;
            this.txthiredates.Text = "Hire Date";
            this.txthiredates.Click += new System.EventHandler(this.txthiredate_Click);
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(168, 138);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(184, 22);
            this.txtfirstname.TabIndex = 4;
            this.txtfirstname.TextChanged += new System.EventHandler(this.txtfirstname_TextChanged);
            // 
            // datagrid
            // 
            this.datagrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(43, 377);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.Size = new System.Drawing.Size(607, 259);
            this.datagrid.TabIndex = 6;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(385, 96);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(68, 32);
            this.Search.TabIndex = 11;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDepartment.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartment.Location = new System.Drawing.Point(418, 264);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(142, 33);
            this.btnDepartment.TabIndex = 13;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.UseVisualStyleBackColor = false;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnProjects
            // 
            this.btnProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnProjects.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProjects.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjects.Location = new System.Drawing.Point(150, 264);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(132, 33);
            this.btnProjects.TabIndex = 14;
            this.btnProjects.Text = "Projects";
            this.btnProjects.UseVisualStyleBackColor = false;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisplay.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(385, 200);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(78, 37);
            this.btnDisplay.TabIndex = 18;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(469, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 37);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(385, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 37);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // hiredate
            // 
            this.hiredate.Location = new System.Drawing.Point(168, 179);
            this.hiredate.Name = "hiredate";
            this.hiredate.Size = new System.Drawing.Size(184, 22);
            this.hiredate.TabIndex = 19;
            this.hiredate.TextChanged += new System.EventHandler(this.hiredate_TextChanged);
            // 
            // query
            // 
            this.query.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.query.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.query.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.query.Location = new System.Drawing.Point(150, 303);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(132, 33);
            this.query.TabIndex = 20;
            this.query.Text = "Query";
            this.query.UseVisualStyleBackColor = false;
            this.query.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Department ID";
            // 
            // txtdeptid
            // 
            this.txtdeptid.Location = new System.Drawing.Point(168, 215);
            this.txtdeptid.Name = "txtdeptid";
            this.txtdeptid.Size = new System.Drawing.Size(184, 22);
            this.txtdeptid.TabIndex = 22;
            this.txtdeptid.TextChanged += new System.EventHandler(this.txtdeptid_TextChanged);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(469, 200);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(78, 37);
            this.btnupdate.TabIndex = 23;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnJobRoles
            // 
            this.btnJobRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnJobRoles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJobRoles.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobRoles.Location = new System.Drawing.Point(288, 264);
            this.btnJobRoles.Name = "btnJobRoles";
            this.btnJobRoles.Size = new System.Drawing.Size(124, 33);
            this.btnJobRoles.TabIndex = 24;
            this.btnJobRoles.Text = "Job Roles";
            this.btnJobRoles.UseVisualStyleBackColor = false;
            this.btnJobRoles.Click += new System.EventHandler(this.btnJobRoles_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 44);
            this.label2.TabIndex = 25;
            this.label2.Text = "Employee Information";
            // 
            // btnERD
            // 
            this.btnERD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnERD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnERD.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnERD.Location = new System.Drawing.Point(288, 303);
            this.btnERD.Name = "btnERD";
            this.btnERD.Size = new System.Drawing.Size(124, 33);
            this.btnERD.TabIndex = 44;
            this.btnERD.Text = "ERD";
            this.btnERD.UseVisualStyleBackColor = false;
            this.btnERD.Click += new System.EventHandler(this.btnERD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 45;
            this.label3.Text = "Results";
            // 
            // btnLocation
            // 
            this.btnLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLocation.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnLocation.Location = new System.Drawing.Point(418, 303);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(142, 33);
            this.btnLocation.TabIndex = 47;
            this.btnLocation.Text = "Location";
            this.btnLocation.UseVisualStyleBackColor = false;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // dataGridAuditLog
            // 
            this.dataGridAuditLog.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridAuditLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAuditLog.Location = new System.Drawing.Point(43, 632);
            this.dataGridAuditLog.Name = "dataGridAuditLog";
            this.dataGridAuditLog.RowTemplate.Height = 24;
            this.dataGridAuditLog.Size = new System.Drawing.Size(607, 14);
            this.dataGridAuditLog.TabIndex = 48;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(708, 684);
            this.Controls.Add(this.dataGridAuditLog);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnERD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnJobRoles);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtdeptid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.query);
            this.Controls.Add(this.hiredate);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnProjects);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txthiredates);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtidno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuditLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtidno;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label txthiredates;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox hiredate;
        private System.Windows.Forms.Button query;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdeptid;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnJobRoles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnERD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.DataGridView dataGridAuditLog;
    }
}

