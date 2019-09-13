namespace tposDesktop.SubForms.frontEnd
{
    partial class FormDebt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDebt));
            this.dgvDebt = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCaption
            // 
            this.pbCaption.Location = new System.Drawing.Point(0, 0);
            this.pbCaption.Size = new System.Drawing.Size(850, 66);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(781, 0);
            // 
            // lblCaption
            // 
            this.lblCaption.Size = new System.Drawing.Size(378, 33);
            this.lblCaption.Text = "Расчёты по получателям";
            // 
            // dgvDebt
            // 
            this.dgvDebt.AllowUserToAddRows = false;
            this.dgvDebt.AllowUserToDeleteRows = false;
            this.dgvDebt.AllowUserToResizeRows = false;
            this.dgvDebt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDebt.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvDebt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDebt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDebt.ColumnHeadersHeight = 40;
            this.dgvDebt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDebt.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDebt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDebt.Location = new System.Drawing.Point(12, 116);
            this.dgvDebt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDebt.MultiSelect = false;
            this.dgvDebt.Name = "dgvDebt";
            this.dgvDebt.RowHeadersVisible = false;
            this.dgvDebt.RowHeadersWidth = 50;
            this.dgvDebt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDebt.Size = new System.Drawing.Size(826, 478);
            this.dgvDebt.TabIndex = 0;
            this.dgvDebt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDebt_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // tbxFilter
            // 
            this.tbxFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.tbxFilter.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxFilter.Location = new System.Drawing.Point(54, 81);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(728, 28);
            this.tbxFilter.TabIndex = 22;
            this.tbxFilter.Text = "Поиск";
            this.tbxFilter.TextChanged += new System.EventHandler(this.tbxFilter_TextChanged);
            this.tbxFilter.Enter += new System.EventHandler(this.tbxFilter_Enter);
            this.tbxFilter.Leave += new System.EventHandler(this.tbxFilter_Leave);
            // 
            // FormDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 605);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.dgvDebt);
            this.Name = "FormDebt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDebt";
            this.Load += new System.EventHandler(this.FormDebt_Load);
            this.Controls.SetChildIndex(this.dgvDebt, 0);
            this.Controls.SetChildIndex(this.pbCaption, 0);
            this.Controls.SetChildIndex(this.lblCaption, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.tbxFilter, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbCaption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDebt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxFilter;
    }
}