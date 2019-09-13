namespace tposDesktop.SubForms.frontEnd
{
    partial class FormPay
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbPay = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.rbtnTerminal = new System.Windows.Forms.RadioButton();
            this.rbtnTransfer = new System.Windows.Forms.RadioButton();
            this.dgvExp = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExp)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCaption
            // 
            this.pbCaption.Size = new System.Drawing.Size(1003, 66);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(931, 0);
            // 
            // lblCaption
            // 
            this.lblCaption.Size = new System.Drawing.Size(127, 33);
            this.lblCaption.Text = "Оплаты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(14, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Сумма оплаты :";
            // 
            // txbPay
            // 
            this.txbPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbPay.Location = new System.Drawing.Point(157, 100);
            this.txbPay.Name = "txbPay";
            this.txbPay.Size = new System.Drawing.Size(181, 26);
            this.txbPay.TabIndex = 12;
            this.txbPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPay_KeyPress);
            // 
            // btnPay
            // 
            this.btnPay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPay.Location = new System.Drawing.Point(241, 355);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(97, 37);
            this.btnPay.TabIndex = 13;
            this.btnPay.Text = "Оплатить";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbtnCash.Location = new System.Drawing.Point(157, 158);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Size = new System.Drawing.Size(105, 24);
            this.rbtnCash.TabIndex = 14;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.Text = "Наличные";
            this.rbtnCash.UseVisualStyleBackColor = true;
            this.rbtnCash.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnTerminal
            // 
            this.rbtnTerminal.AutoSize = true;
            this.rbtnTerminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbtnTerminal.Location = new System.Drawing.Point(157, 214);
            this.rbtnTerminal.Name = "rbtnTerminal";
            this.rbtnTerminal.Size = new System.Drawing.Size(102, 24);
            this.rbtnTerminal.TabIndex = 15;
            this.rbtnTerminal.TabStop = true;
            this.rbtnTerminal.Text = "Терминал";
            this.rbtnTerminal.UseVisualStyleBackColor = true;
            this.rbtnTerminal.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnTransfer
            // 
            this.rbtnTransfer.AutoSize = true;
            this.rbtnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbtnTransfer.Location = new System.Drawing.Point(157, 270);
            this.rbtnTransfer.Name = "rbtnTransfer";
            this.rbtnTransfer.Size = new System.Drawing.Size(138, 24);
            this.rbtnTransfer.TabIndex = 16;
            this.rbtnTransfer.TabStop = true;
            this.rbtnTransfer.Text = "Перечисление";
            this.rbtnTransfer.UseVisualStyleBackColor = true;
            this.rbtnTransfer.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // dgvExp
            // 
            this.dgvExp.AllowUserToAddRows = false;
            this.dgvExp.AllowUserToDeleteRows = false;
            this.dgvExp.AllowUserToResizeRows = false;
            this.dgvExp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvExp.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvExp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExp.ColumnHeadersHeight = 40;
            this.dgvExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExp.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExp.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvExp.Location = new System.Drawing.Point(344, 71);
            this.dgvExp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvExp.MultiSelect = false;
            this.dgvExp.Name = "dgvExp";
            this.dgvExp.RowHeadersVisible = false;
            this.dgvExp.RowHeadersWidth = 50;
            this.dgvExp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExp.Size = new System.Drawing.Size(644, 321);
            this.dgvExp.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(14, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Вид оплаты:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(15, 355);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(57, 20);
            this.lblError.TabIndex = 19;
            this.lblError.Text = "label3";
            // 
            // FormPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 404);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvExp);
            this.Controls.Add(this.rbtnTransfer);
            this.Controls.Add(this.rbtnTerminal);
            this.Controls.Add(this.rbtnCash);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txbPay);
            this.Controls.Add(this.label1);
            this.Name = "FormPay";
            this.Text = "FormPay";
            this.Controls.SetChildIndex(this.pbCaption, 0);
            this.Controls.SetChildIndex(this.lblCaption, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txbPay, 0);
            this.Controls.SetChildIndex(this.btnPay, 0);
            this.Controls.SetChildIndex(this.rbtnCash, 0);
            this.Controls.SetChildIndex(this.rbtnTerminal, 0);
            this.Controls.SetChildIndex(this.rbtnTransfer, 0);
            this.Controls.SetChildIndex(this.dgvExp, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblError, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbCaption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPay;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.RadioButton rbtnCash;
        private System.Windows.Forms.RadioButton rbtnTerminal;
        private System.Windows.Forms.RadioButton rbtnTransfer;
        private System.Windows.Forms.DataGridView dgvExp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblError;
    }
}