namespace WindowsFormsBD
{
    partial class FormEmployee
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
            this.labFirst_Name = new System.Windows.Forms.Label();
            this.textBoxFirst_name = new System.Windows.Forms.TextBox();
            this.labLast_name = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.labPhone_number = new System.Windows.Forms.Label();
            this.labHire_date = new System.Windows.Forms.Label();
            this.labSalary = new System.Windows.Forms.Label();
            this.labManager_id = new System.Windows.Forms.Label();
            this.labJob_id = new System.Windows.Forms.Label();
            this.labDepartment_id = new System.Windows.Forms.Label();
            this.textBoxLast_name = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone_number = new System.Windows.Forms.TextBox();
            this.dateTimeHire_date = new System.Windows.Forms.DateTimePicker();
            this.listBoxEmployee = new System.Windows.Forms.ListBox();
            this.butGuardar = new System.Windows.Forms.Button();
            this.numericUpDownSalary = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownManager_id = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDepartment_id = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownJob_id = new System.Windows.Forms.NumericUpDown();
            this.butSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownManager_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepartment_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJob_id)).BeginInit();
            this.SuspendLayout();
            // 
            // labFirst_Name
            // 
            this.labFirst_Name.AutoSize = true;
            this.labFirst_Name.Location = new System.Drawing.Point(33, 31);
            this.labFirst_Name.Name = "labFirst_Name";
            this.labFirst_Name.Size = new System.Drawing.Size(72, 16);
            this.labFirst_Name.TabIndex = 0;
            this.labFirst_Name.Text = "First Name";
            // 
            // textBoxFirst_name
            // 
            this.textBoxFirst_name.Location = new System.Drawing.Point(152, 31);
            this.textBoxFirst_name.Name = "textBoxFirst_name";
            this.textBoxFirst_name.Size = new System.Drawing.Size(244, 22);
            this.textBoxFirst_name.TabIndex = 1;
            // 
            // labLast_name
            // 
            this.labLast_name.AutoSize = true;
            this.labLast_name.Location = new System.Drawing.Point(33, 61);
            this.labLast_name.Name = "labLast_name";
            this.labLast_name.Size = new System.Drawing.Size(72, 16);
            this.labLast_name.TabIndex = 2;
            this.labLast_name.Text = "Last Name";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(33, 91);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(41, 16);
            this.labEmail.TabIndex = 3;
            this.labEmail.Text = "Email";
            // 
            // labPhone_number
            // 
            this.labPhone_number.AutoSize = true;
            this.labPhone_number.Location = new System.Drawing.Point(33, 119);
            this.labPhone_number.Name = "labPhone_number";
            this.labPhone_number.Size = new System.Drawing.Size(94, 16);
            this.labPhone_number.TabIndex = 4;
            this.labPhone_number.Text = "Phone number";
            // 
            // labHire_date
            // 
            this.labHire_date.AutoSize = true;
            this.labHire_date.Location = new System.Drawing.Point(33, 146);
            this.labHire_date.Name = "labHire_date";
            this.labHire_date.Size = new System.Drawing.Size(62, 16);
            this.labHire_date.TabIndex = 5;
            this.labHire_date.Text = "Hire date";
            // 
            // labSalary
            // 
            this.labSalary.AutoSize = true;
            this.labSalary.Location = new System.Drawing.Point(33, 175);
            this.labSalary.Name = "labSalary";
            this.labSalary.Size = new System.Drawing.Size(46, 16);
            this.labSalary.TabIndex = 6;
            this.labSalary.Text = "Salary";
            // 
            // labManager_id
            // 
            this.labManager_id.AutoSize = true;
            this.labManager_id.Location = new System.Drawing.Point(33, 206);
            this.labManager_id.Name = "labManager_id";
            this.labManager_id.Size = new System.Drawing.Size(77, 16);
            this.labManager_id.TabIndex = 7;
            this.labManager_id.Text = "Manager ID";
            // 
            // labJob_id
            // 
            this.labJob_id.AutoSize = true;
            this.labJob_id.Location = new System.Drawing.Point(33, 262);
            this.labJob_id.Name = "labJob_id";
            this.labJob_id.Size = new System.Drawing.Size(46, 16);
            this.labJob_id.TabIndex = 8;
            this.labJob_id.Text = "Job ID";
            // 
            // labDepartment_id
            // 
            this.labDepartment_id.AutoSize = true;
            this.labDepartment_id.Location = new System.Drawing.Point(33, 234);
            this.labDepartment_id.Name = "labDepartment_id";
            this.labDepartment_id.Size = new System.Drawing.Size(93, 16);
            this.labDepartment_id.TabIndex = 9;
            this.labDepartment_id.Text = "Department ID";
            // 
            // textBoxLast_name
            // 
            this.textBoxLast_name.Location = new System.Drawing.Point(151, 58);
            this.textBoxLast_name.Name = "textBoxLast_name";
            this.textBoxLast_name.Size = new System.Drawing.Size(245, 22);
            this.textBoxLast_name.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(152, 88);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(244, 22);
            this.textBoxEmail.TabIndex = 11;
            // 
            // textBoxPhone_number
            // 
            this.textBoxPhone_number.Location = new System.Drawing.Point(151, 116);
            this.textBoxPhone_number.Name = "textBoxPhone_number";
            this.textBoxPhone_number.Size = new System.Drawing.Size(245, 22);
            this.textBoxPhone_number.TabIndex = 12;
            // 
            // dateTimeHire_date
            // 
            this.dateTimeHire_date.Location = new System.Drawing.Point(152, 146);
            this.dateTimeHire_date.Name = "dateTimeHire_date";
            this.dateTimeHire_date.Size = new System.Drawing.Size(244, 22);
            this.dateTimeHire_date.TabIndex = 18;
            // 
            // listBoxEmployee
            // 
            this.listBoxEmployee.FormattingEnabled = true;
            this.listBoxEmployee.ItemHeight = 16;
            this.listBoxEmployee.Location = new System.Drawing.Point(442, 41);
            this.listBoxEmployee.Name = "listBoxEmployee";
            this.listBoxEmployee.Size = new System.Drawing.Size(301, 388);
            this.listBoxEmployee.TabIndex = 19;
            this.listBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.listBoxEmployee_SelectedIndexChanged);
            // 
            // butGuardar
            // 
            this.butGuardar.Location = new System.Drawing.Point(346, 305);
            this.butGuardar.Name = "butGuardar";
            this.butGuardar.Size = new System.Drawing.Size(75, 23);
            this.butGuardar.TabIndex = 20;
            this.butGuardar.Text = "Guardar";
            this.butGuardar.UseVisualStyleBackColor = true;
            this.butGuardar.Click += new System.EventHandler(this.butGuardar_Click);
            // 
            // numericUpDownSalary
            // 
            this.numericUpDownSalary.Location = new System.Drawing.Point(152, 175);
            this.numericUpDownSalary.Name = "numericUpDownSalary";
            this.numericUpDownSalary.Size = new System.Drawing.Size(245, 22);
            this.numericUpDownSalary.TabIndex = 21;
            // 
            // numericUpDownManager_id
            // 
            this.numericUpDownManager_id.Location = new System.Drawing.Point(152, 206);
            this.numericUpDownManager_id.Name = "numericUpDownManager_id";
            this.numericUpDownManager_id.Size = new System.Drawing.Size(245, 22);
            this.numericUpDownManager_id.TabIndex = 22;
            // 
            // numericUpDownDepartment_id
            // 
            this.numericUpDownDepartment_id.Location = new System.Drawing.Point(152, 235);
            this.numericUpDownDepartment_id.Name = "numericUpDownDepartment_id";
            this.numericUpDownDepartment_id.Size = new System.Drawing.Size(244, 22);
            this.numericUpDownDepartment_id.TabIndex = 23;
            // 
            // numericUpDownJob_id
            // 
            this.numericUpDownJob_id.Location = new System.Drawing.Point(152, 264);
            this.numericUpDownJob_id.Name = "numericUpDownJob_id";
            this.numericUpDownJob_id.Size = new System.Drawing.Size(245, 22);
            this.numericUpDownJob_id.TabIndex = 24;
            // 
            // butSelect
            // 
            this.butSelect.Location = new System.Drawing.Point(625, 12);
            this.butSelect.Name = "butSelect";
            this.butSelect.Size = new System.Drawing.Size(75, 23);
            this.butSelect.TabIndex = 25;
            this.butSelect.Text = "Select";
            this.butSelect.UseVisualStyleBackColor = true;
            this.butSelect.Click += new System.EventHandler(this.butSelect_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.butSelect);
            this.Controls.Add(this.numericUpDownJob_id);
            this.Controls.Add(this.numericUpDownDepartment_id);
            this.Controls.Add(this.numericUpDownManager_id);
            this.Controls.Add(this.numericUpDownSalary);
            this.Controls.Add(this.butGuardar);
            this.Controls.Add(this.listBoxEmployee);
            this.Controls.Add(this.dateTimeHire_date);
            this.Controls.Add(this.textBoxPhone_number);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLast_name);
            this.Controls.Add(this.labDepartment_id);
            this.Controls.Add(this.labJob_id);
            this.Controls.Add(this.labManager_id);
            this.Controls.Add(this.labSalary);
            this.Controls.Add(this.labHire_date);
            this.Controls.Add(this.labPhone_number);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.labLast_name);
            this.Controls.Add(this.textBoxFirst_name);
            this.Controls.Add(this.labFirst_Name);
            this.Name = "FormEmployee";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownManager_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepartment_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJob_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labFirst_Name;
        private System.Windows.Forms.TextBox textBoxFirst_name;
        private System.Windows.Forms.Label labLast_name;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labPhone_number;
        private System.Windows.Forms.Label labHire_date;
        private System.Windows.Forms.Label labSalary;
        private System.Windows.Forms.Label labManager_id;
        private System.Windows.Forms.Label labJob_id;
        private System.Windows.Forms.Label labDepartment_id;
        private System.Windows.Forms.TextBox textBoxLast_name;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone_number;
        private System.Windows.Forms.ListBox listBoxEmployee;
        private System.Windows.Forms.Button butGuardar;
        private System.Windows.Forms.DateTimePicker dateTimeHire_date;
        private System.Windows.Forms.NumericUpDown numericUpDownSalary;
        private System.Windows.Forms.NumericUpDown numericUpDownManager_id;
        private System.Windows.Forms.NumericUpDown numericUpDownDepartment_id;
        private System.Windows.Forms.NumericUpDown numericUpDownJob_id;
        private System.Windows.Forms.Button butSelect;
    }
}