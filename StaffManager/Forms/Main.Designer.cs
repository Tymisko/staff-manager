using System.Windows.Forms;

namespace StaffManager
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDismiss = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.dgvDiary = new System.Windows.Forms.DataGridView();
            this.cmbEmploymentFilters = new System.Windows.Forms.ComboBox();
            this.lbFilters = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiary)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(98, 22);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDismiss
            // 
            this.BtnDismiss.Location = new System.Drawing.Point(220, 12);
            this.BtnDismiss.Name = "BtnDismiss";
            this.BtnDismiss.Size = new System.Drawing.Size(98, 22);
            this.BtnDismiss.TabIndex = 1;
            this.BtnDismiss.Text = "Dismiss";
            this.BtnDismiss.UseVisualStyleBackColor = true;
            this.BtnDismiss.Click += new System.EventHandler(this.BtnDismiss_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(116, 12);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(98, 22);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // dgvDiary
            // 
            this.dgvDiary.AllowUserToAddRows = false;
            this.dgvDiary.AllowUserToDeleteRows = false;
            this.dgvDiary.AllowUserToResizeColumns = false;
            this.dgvDiary.AllowUserToResizeRows = false;
            this.dgvDiary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiary.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiary.Location = new System.Drawing.Point(12, 40);
            this.dgvDiary.MultiSelect = false;
            this.dgvDiary.Name = "dgvDiary";
            this.dgvDiary.ReadOnly = true;
            this.dgvDiary.RowHeadersVisible = false;
            this.dgvDiary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDiary.RowTemplate.Height = 25;
            this.dgvDiary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiary.Size = new System.Drawing.Size(982, 764);
            this.dgvDiary.TabIndex = 3;
            // 
            // cmbEmploymentFilters
            // 
            this.cmbEmploymentFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEmploymentFilters.FormattingEnabled = true;
            this.cmbEmploymentFilters.Location = new System.Drawing.Point(765, 12);
            this.cmbEmploymentFilters.Name = "cmbEmploymentFilters";
            this.cmbEmploymentFilters.Size = new System.Drawing.Size(229, 23);
            this.cmbEmploymentFilters.TabIndex = 4;
            // 
            // lbFilters
            // 
            this.lbFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFilters.AutoSize = true;
            this.lbFilters.Location = new System.Drawing.Point(718, 15);
            this.lbFilters.Name = "lbFilters";
            this.lbFilters.Size = new System.Drawing.Size(41, 15);
            this.lbFilters.TabIndex = 5;
            this.lbFilters.Text = "Filters:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 821);
            this.Controls.Add(this.lbFilters);
            this.Controls.Add(this.cmbEmploymentFilters);
            this.Controls.Add(this.dgvDiary);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDismiss);
            this.Controls.Add(this.BtnAdd);
            this.MinimumSize = new System.Drawing.Size(1024, 860);
            this.Name = "Main";
            this.Text = "Staff Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnAdd;
        private Button BtnDismiss;
        private Button BtnEdit;
        private DataGridView dgvDiary;
        private ComboBox cmbEmploymentFilters;
        private Label lbFilters;
    }
}