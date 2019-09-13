namespace tposDesktop.SubForms.frontEnd
{
    partial class FormChangeAgents
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
            this.btnChange = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbTelephone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaption)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCaption
            // 
            this.pbCaption.Location = new System.Drawing.Point(0, 0);
            this.pbCaption.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCaption.Size = new System.Drawing.Size(897, 81);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(805, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Size = new System.Drawing.Size(92, 81);
            // 
            // lblCaption
            // 
            this.lblCaption.Location = new System.Drawing.Point(16, 15);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaption.Size = new System.Drawing.Size(512, 42);
            this.lblCaption.Text = "Добавление нового агента";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Yellow;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnChange.Location = new System.Drawing.Point(628, 292);
            this.btnChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(255, 50);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Добавить";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblname.Location = new System.Drawing.Point(19, 100);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(121, 25);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Имя агента";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbName.Location = new System.Drawing.Point(16, 144);
            this.txbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(864, 30);
            this.txbName.TabIndex = 2;
            // 
            // txbTelephone
            // 
            this.txbTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbTelephone.Location = new System.Drawing.Point(16, 240);
            this.txbTelephone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTelephone.Name = "txbTelephone";
            this.txbTelephone.Size = new System.Drawing.Size(864, 30);
            this.txbTelephone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(19, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Телефон агента";
            // 
            // FormChangeAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 366);
            this.Controls.Add(this.txbTelephone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnChange);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormChangeAgents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChangeAgents";
            this.Controls.SetChildIndex(this.btnChange, 0);
            this.Controls.SetChildIndex(this.lblname, 0);
            this.Controls.SetChildIndex(this.txbName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txbTelephone, 0);
            this.Controls.SetChildIndex(this.pbCaption, 0);
            this.Controls.SetChildIndex(this.lblCaption, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbCaption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbTelephone;
        private System.Windows.Forms.Label label2;
    }
}