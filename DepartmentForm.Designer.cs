namespace DATABASEINFOMAN
{
    partial class DepartmentForm
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
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.datagriddept = new System.Windows.Forms.DataGridView();
            this.txtdeptid = new System.Windows.Forms.TextBox();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnJobRoles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnERD = new System.Windows.Forms.Button();
            this.dataGridAuditLog = new System.Windows.Forms.DataGridView();
            this.btnLocation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagriddept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuditLog)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProjects
            // 
            this.btnProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnProjects.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProjects.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjects.Location = new System.Drawing.Point(280, 272);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(119, 33);
            this.btnProjects.TabIndex = 17;
            this.btnProjects.Text = "Projects";
            this.btnProjects.UseVisualStyleBackColor = false;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployee.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Location = new System.Drawing.Point(139, 272);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(138, 33);
            this.btnEmployee.TabIndex = 15;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // datagriddept
            // 
            this.datagriddept.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.datagriddept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagriddept.Location = new System.Drawing.Point(126, 365);
            this.datagriddept.Name = "datagriddept";
            this.datagriddept.RowTemplate.Height = 24;
            this.datagriddept.Size = new System.Drawing.Size(419, 315);
            this.datagriddept.TabIndex = 18;
            this.datagriddept.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            // 
            // txtdeptid
            // 
            this.txtdeptid.Location = new System.Drawing.Point(150, 120);
            this.txtdeptid.Name = "txtdeptid";
            this.txtdeptid.Size = new System.Drawing.Size(184, 22);
            this.txtdeptid.TabIndex = 19;
            this.txtdeptid.TextChanged += new System.EventHandler(this.txtdeptid_TextChanged);
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(150, 163);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(184, 22);
            this.txtDepartmentName.TabIndex = 20;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ID.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(123, 120);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(24, 18);
            this.ID.TabIndex = 22;
            this.ID.Text = "ID";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(21, 163);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(128, 18);
            this.FirstName.TabIndex = 23;
            this.FirstName.Text = "Department Name";
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisplay.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(235, 207);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(79, 36);
            this.btnDisplay.TabIndex = 27;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(320, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 36);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(150, 207);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 36);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(359, 120);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(71, 34);
            this.Search.TabIndex = 28;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(405, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 33);
            this.button1.TabIndex = 29;
            this.button1.Text = "Query";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnJobRoles
            // 
            this.btnJobRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnJobRoles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJobRoles.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobRoles.Location = new System.Drawing.Point(139, 311);
            this.btnJobRoles.Name = "btnJobRoles";
            this.btnJobRoles.Size = new System.Drawing.Size(138, 33);
            this.btnJobRoles.TabIndex = 30;
            this.btnJobRoles.Text = "Job Roles";
            this.btnJobRoles.UseVisualStyleBackColor = false;
            this.btnJobRoles.Click += new System.EventHandler(this.btnJobRoles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 44);
            this.label1.TabIndex = 32;
            this.label1.Text = "Department";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(405, 207);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(79, 36);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnERD
            // 
            this.btnERD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnERD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnERD.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnERD.Location = new System.Drawing.Point(280, 311);
            this.btnERD.Name = "btnERD";
            this.btnERD.Size = new System.Drawing.Size(119, 33);
            this.btnERD.TabIndex = 40;
            this.btnERD.Text = "ERD";
            this.btnERD.UseVisualStyleBackColor = false;
            this.btnERD.Click += new System.EventHandler(this.btnERD_Click);
            // 
            // dataGridAuditLog
            // 
            this.dataGridAuditLog.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridAuditLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAuditLog.Location = new System.Drawing.Point(126, 667);
            this.dataGridAuditLog.Name = "dataGridAuditLog";
            this.dataGridAuditLog.RowTemplate.Height = 24;
            this.dataGridAuditLog.Size = new System.Drawing.Size(419, 13);
            this.dataGridAuditLog.TabIndex = 41;
            // 
            // btnLocation
            // 
            this.btnLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLocation.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnLocation.Location = new System.Drawing.Point(405, 311);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(109, 33);
            this.btnLocation.TabIndex = 49;
            this.btnLocation.Text = "Location";
            this.btnLocation.UseVisualStyleBackColor = false;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(665, 708);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.dataGridAuditLog);
            this.Controls.Add(this.btnERD);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJobRoles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.txtdeptid);
            this.Controls.Add(this.datagriddept);
            this.Controls.Add(this.btnProjects);
            this.Controls.Add(this.btnEmployee);
            this.Name = "DepartmentForm";
            this.Text = "DepartmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.datagriddept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuditLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.DataGridView datagriddept;
        private System.Windows.Forms.TextBox txtdeptid;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnJobRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnERD;
        private System.Windows.Forms.DataGridView dataGridAuditLog;
        private System.Windows.Forms.Button btnLocation;
    }
}