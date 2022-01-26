namespace StaffManager
{
    partial class AddEditEmployee
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
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lbEmploymentDate = new System.Windows.Forms.Label();
            this.dtpEmploymentDate = new System.Windows.Forms.DateTimePicker();
            this.lbSalary = new System.Windows.Forms.Label();
            this.nupSalary = new System.Windows.Forms.NumericUpDown();
            this.lbComments = new System.Windows.Forms.Label();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(12, 42);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(65, 15);
            this.lbFirstName.TabIndex = 0;
            this.lbFirstName.Text = "First name:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(119, 39);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(248, 23);
            this.tbFirstName.TabIndex = 1;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(119, 10);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(248, 23);
            this.tbId.TabIndex = 12;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(13, 13);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(20, 15);
            this.lbId.TabIndex = 2;
            this.lbId.Text = "Id:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(119, 68);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(248, 23);
            this.tbLastName.TabIndex = 2;
            this.tbLastName.Text = " ";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(12, 71);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(61, 15);
            this.lbLastName.TabIndex = 4;
            this.lbLastName.Text = "Last name";
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Location = new System.Drawing.Point(13, 105);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(64, 15);
            this.lbBirthDate.TabIndex = 6;
            this.lbBirthDate.Text = "Birth date: ";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(119, 99);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(248, 23);
            this.dtpBirthDate.TabIndex = 3;
            // 
            // lbEmploymentDate
            // 
            this.lbEmploymentDate.AutoSize = true;
            this.lbEmploymentDate.Location = new System.Drawing.Point(12, 193);
            this.lbEmploymentDate.Name = "lbEmploymentDate";
            this.lbEmploymentDate.Size = new System.Drawing.Size(101, 15);
            this.lbEmploymentDate.TabIndex = 8;
            this.lbEmploymentDate.Text = "Employment date";
            // 
            // dtpEmploymentDate
            // 
            this.dtpEmploymentDate.Location = new System.Drawing.Point(119, 190);
            this.dtpEmploymentDate.Name = "dtpEmploymentDate";
            this.dtpEmploymentDate.Size = new System.Drawing.Size(248, 23);
            this.dtpEmploymentDate.TabIndex = 6;
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Location = new System.Drawing.Point(13, 221);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(38, 15);
            this.lbSalary.TabIndex = 10;
            this.lbSalary.Text = "Salary";
            // 
            // nupSalary
            // 
            this.nupSalary.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nupSalary.Location = new System.Drawing.Point(119, 219);
            this.nupSalary.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nupSalary.Name = "nupSalary";
            this.nupSalary.Size = new System.Drawing.Size(248, 23);
            this.nupSalary.TabIndex = 7;
            // 
            // lbComments
            // 
            this.lbComments.AutoSize = true;
            this.lbComments.Location = new System.Drawing.Point(13, 251);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(66, 15);
            this.lbComments.TabIndex = 12;
            this.lbComments.Text = "Comments";
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(119, 248);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(248, 116);
            this.rtbComments.TabIndex = 8;
            this.rtbComments.Text = "";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(179, 370);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(91, 23);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(276, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(119, 132);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(248, 23);
            this.tbEmail.TabIndex = 4;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(12, 135);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(39, 15);
            this.lbEmail.TabIndex = 17;
            this.lbEmail.Text = "Email:";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(12, 164);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(89, 15);
            this.lbPhoneNumber.TabIndex = 19;
            this.lbPhoneNumber.Text = "Phone number:";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(119, 161);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(248, 23);
            this.tbPhoneNumber.TabIndex = 5;
            // 
            // AddEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 405);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.nupSalary);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.dtpEmploymentDate);
            this.Controls.Add(this.lbEmploymentDate);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lbBirthDate);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbFirstName);
            this.Name = "AddEditEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.nupSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lbEmploymentDate;
        private System.Windows.Forms.DateTimePicker dtpEmploymentDate;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.NumericUpDown nupSalary;
        private System.Windows.Forms.Label lbComments;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.TextBox tbPhoneNumber;
    }
}