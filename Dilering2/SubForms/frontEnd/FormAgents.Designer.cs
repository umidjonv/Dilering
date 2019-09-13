namespace tposDesktop.SubForms.frontEnd
{
    partial class FormAgents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dgvAgents = new System.Windows.Forms.DataGridView();
            this.agentsTableAdapter1 = new tposDesktop.DataSetTposTableAdapters.agentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCaption
            // 
            this.pbCaption.Location = new System.Drawing.Point(-4, 0);
            this.pbCaption.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCaption.Size = new System.Drawing.Size(1044, 81);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(948, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Size = new System.Drawing.Size(92, 81);
            // 
            // lblCaption
            // 
            this.lblCaption.Location = new System.Drawing.Point(16, 15);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaption.Size = new System.Drawing.Size(377, 42);
            this.lblCaption.Text = "Добавление агента";
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Yellow;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddNew.Location = new System.Drawing.Point(768, 635);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(255, 50);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Добавить";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dgvAgents
            // 
            this.dgvAgents.AllowUserToAddRows = false;
            this.dgvAgents.AllowUserToDeleteRows = false;
            this.dgvAgents.AllowUserToResizeRows = false;
            this.dgvAgents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvAgents.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvAgents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgents.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAgents.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAgents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAgents.Location = new System.Drawing.Point(16, 89);
            this.dgvAgents.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvAgents.MultiSelect = false;
            this.dgvAgents.Name = "dgvAgents";
            this.dgvAgents.RowHeadersVisible = false;
            this.dgvAgents.RowHeadersWidth = 50;
            this.dgvAgents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgents.Size = new System.Drawing.Size(1007, 521);
            this.dgvAgents.TabIndex = 1;
            this.dgvAgents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgents_CellContentClick);
            this.dgvAgents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgents_CellDoubleClick);
            this.dgvAgents.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvAgents_CellPainting);
            // 
            // agentsTableAdapter1
            // 
            this.agentsTableAdapter1.ClearBeforeFill = true;
            // 
            // FormAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 710);
            this.Controls.Add(this.dgvAgents);
            this.Controls.Add(this.btnAddNew);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAgents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgents";
            this.Load += new System.EventHandler(this.FormAgents_Load);
            this.Controls.SetChildIndex(this.btnAddNew, 0);
            this.Controls.SetChildIndex(this.dgvAgents, 0);
            this.Controls.SetChildIndex(this.pbCaption, 0);
            this.Controls.SetChildIndex(this.lblCaption, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbCaption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dgvAgents;
        private DataSetTposTableAdapters.agentsTableAdapter agentsTableAdapter1;
    }
}