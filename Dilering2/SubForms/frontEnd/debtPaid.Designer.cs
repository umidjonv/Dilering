namespace tposDesktop
{
    partial class debtPaid
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
            this.tbxSum = new System.Windows.Forms.TextBox();
            this.rbtNal = new System.Windows.Forms.RadioButton();
            this.rbtTerminal = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.rbtPerevod = new System.Windows.Forms.RadioButton();
            this.rbtOther = new System.Windows.Forms.RadioButton();
            this.tbxChargeSum = new System.Windows.Forms.TextBox();
            this.cmbNameAg = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaption)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCaption
            // 
            this.pbCaption.Size = new System.Drawing.Size(230, 39);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(183, 0);
            this.btnCancel.Size = new System.Drawing.Size(44, 39);
            // 
            // lblCaption
            // 
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblCaption.Location = new System.Drawing.Point(12, 8);
            this.lblCaption.Size = new System.Drawing.Size(125, 24);
            this.lblCaption.Text = "Вид оплаты";
            // 
            // tbxSum
            // 
            this.tbxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.tbxSum.Location = new System.Drawing.Point(18, 98);
            this.tbxSum.Name = "tbxSum";
            this.tbxSum.Size = new System.Drawing.Size(189, 28);
            this.tbxSum.TabIndex = 11;
            // 
            // rbtNal
            // 
            this.rbtNal.AutoSize = true;
            this.rbtNal.Checked = true;
            this.rbtNal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.rbtNal.Location = new System.Drawing.Point(18, 186);
            this.rbtNal.Name = "rbtNal";
            this.rbtNal.Size = new System.Drawing.Size(66, 28);
            this.rbtNal.TabIndex = 12;
            this.rbtNal.TabStop = true;
            this.rbtNal.Text = "Нал.";
            this.rbtNal.UseVisualStyleBackColor = true;
            this.rbtNal.CheckedChanged += new System.EventHandler(this.rbt_checked);
            // 
            // rbtTerminal
            // 
            this.rbtTerminal.AutoSize = true;
            this.rbtTerminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.rbtTerminal.Location = new System.Drawing.Point(18, 230);
            this.rbtTerminal.Name = "rbtTerminal";
            this.rbtTerminal.Size = new System.Drawing.Size(117, 28);
            this.rbtTerminal.TabIndex = 13;
            this.rbtTerminal.Text = "Терминал";
            this.rbtTerminal.UseVisualStyleBackColor = true;
            this.rbtTerminal.CheckedChanged += new System.EventHandler(this.rbt_checked);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Yellow;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Location = new System.Drawing.Point(16, 362);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(191, 41);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rbtPerevod
            // 
            this.rbtPerevod.AutoSize = true;
            this.rbtPerevod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.rbtPerevod.Location = new System.Drawing.Point(18, 274);
            this.rbtPerevod.Name = "rbtPerevod";
            this.rbtPerevod.Size = new System.Drawing.Size(108, 28);
            this.rbtPerevod.TabIndex = 13;
            this.rbtPerevod.Text = "Перевод";
            this.rbtPerevod.UseVisualStyleBackColor = true;
            this.rbtPerevod.CheckedChanged += new System.EventHandler(this.rbt_checked);
            // 
            // rbtOther
            // 
            this.rbtOther.AutoSize = true;
            this.rbtOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.rbtOther.Location = new System.Drawing.Point(18, 318);
            this.rbtOther.Name = "rbtOther";
            this.rbtOther.Size = new System.Drawing.Size(93, 28);
            this.rbtOther.TabIndex = 13;
            this.rbtOther.Text = "Другое";
            this.rbtOther.UseVisualStyleBackColor = true;
            this.rbtOther.CheckedChanged += new System.EventHandler(this.rbt_checked);
            // 
            // tbxChargeSum
            // 
            this.tbxChargeSum.Enabled = false;
            this.tbxChargeSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.tbxChargeSum.Location = new System.Drawing.Point(18, 142);
            this.tbxChargeSum.Name = "tbxChargeSum";
            this.tbxChargeSum.Size = new System.Drawing.Size(189, 28);
            this.tbxChargeSum.TabIndex = 11;
            // 
            // cmbNameAg
            // 
            this.cmbNameAg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNameAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cmbNameAg.FormattingEnabled = true;
            this.cmbNameAg.Location = new System.Drawing.Point(18, 54);
            this.cmbNameAg.Name = "cmbNameAg";
            this.cmbNameAg.Size = new System.Drawing.Size(189, 28);
            this.cmbNameAg.TabIndex = 20;
            this.cmbNameAg.SelectedIndexChanged += new System.EventHandler(this.cmbNameAg_SelectedIndexChanged);
            // 
            // debtPaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 418);
            this.Controls.Add(this.cmbNameAg);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rbtOther);
            this.Controls.Add(this.rbtPerevod);
            this.Controls.Add(this.rbtTerminal);
            this.Controls.Add(this.rbtNal);
            this.Controls.Add(this.tbxChargeSum);
            this.Controls.Add(this.tbxSum);
            this.Location = new System.Drawing.Point(600, 100);
            this.Name = "debtPaid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "debtPaid";
            this.Controls.SetChildIndex(this.tbxSum, 0);
            this.Controls.SetChildIndex(this.tbxChargeSum, 0);
            this.Controls.SetChildIndex(this.rbtNal, 0);
            this.Controls.SetChildIndex(this.rbtTerminal, 0);
            this.Controls.SetChildIndex(this.rbtPerevod, 0);
            this.Controls.SetChildIndex(this.rbtOther, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.pbCaption, 0);
            this.Controls.SetChildIndex(this.lblCaption, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.cmbNameAg, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbCaption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSum;
        private System.Windows.Forms.RadioButton rbtNal;
        private System.Windows.Forms.RadioButton rbtTerminal;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton rbtPerevod;
        private System.Windows.Forms.RadioButton rbtOther;
        private System.Windows.Forms.TextBox tbxChargeSum;
        private System.Windows.Forms.ComboBox cmbNameAg;
    }
}