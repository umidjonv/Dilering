namespace tposDesktop
{
    partial class AddForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxShtrix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPack = new System.Windows.Forms.Label();
            this.tbxPrice = new Classes.NumericTextBox();
            this.tbxPack = new Classes.NumericTextBox();
            this.measureRadio = new System.Windows.Forms.RadioButton();
            this.measureRadio2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.balanceTableAdapter1 = new tposDesktop.DataSetTposTableAdapters.balanceTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.prCmbx = new System.Windows.Forms.ComboBox();
            this.providerTableAdapter1 = new tposDesktop.DataSetTposTableAdapters.providerTableAdapter();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxRozPrice = new Classes.NumericTextBox();
            this.measureRadio3 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxMwidth = new Classes.NumericTextBox();
            this.tbxMheight = new Classes.NumericTextBox();
            this.lblX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaption)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCaption
            // 
            this.pbCaption.Size = new System.Drawing.Size(788, 66);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(716, 0);
            // 
            // lblCaption
            // 
            this.lblCaption.Size = new System.Drawing.Size(243, 33);
            this.lblCaption.Text = "Добавить товар";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 94);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Товар";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(139, 96);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(618, 28);
            this.tbxName.TabIndex = 1;
            this.tbxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_keypress);
            // 
            // tbxShtrix
            // 
            this.tbxShtrix.Enabled = false;
            this.tbxShtrix.Location = new System.Drawing.Point(139, 143);
            this.tbxShtrix.Name = "tbxShtrix";
            this.tbxShtrix.Size = new System.Drawing.Size(288, 28);
            this.tbxShtrix.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Штрих";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Цена";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Yellow;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(579, 316);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(178, 46);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.AddOrEdit);
            // 
            // lblPack
            // 
            this.lblPack.AutoSize = true;
            this.lblPack.Location = new System.Drawing.Point(20, 196);
            this.lblPack.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPack.Name = "lblPack";
            this.lblPack.Size = new System.Drawing.Size(48, 24);
            this.lblPack.TabIndex = 0;
            this.lblPack.Text = "Кол.";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(139, 241);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(148, 28);
            this.tbxPrice.TabIndex = 4;
            this.tbxPrice.Text = "0";
            // 
            // tbxPack
            // 
            this.tbxPack.Location = new System.Drawing.Point(139, 192);
            this.tbxPack.Name = "tbxPack";
            this.tbxPack.Size = new System.Drawing.Size(148, 28);
            this.tbxPack.TabIndex = 3;
            this.tbxPack.Text = "0";
            // 
            // measureRadio
            // 
            this.measureRadio.AutoSize = true;
            this.measureRadio.Location = new System.Drawing.Point(342, 196);
            this.measureRadio.Name = "measureRadio";
            this.measureRadio.Size = new System.Drawing.Size(51, 28);
            this.measureRadio.TabIndex = 11;
            this.measureRadio.TabStop = true;
            this.measureRadio.Text = "шт";
            this.measureRadio.UseVisualStyleBackColor = true;
            this.measureRadio.CheckedChanged += new System.EventHandler(this.measureRadio_checkedChanged);
            // 
            // measureRadio2
            // 
            this.measureRadio2.AutoSize = true;
            this.measureRadio2.Location = new System.Drawing.Point(342, 241);
            this.measureRadio2.Name = "measureRadio2";
            this.measureRadio2.Size = new System.Drawing.Size(45, 28);
            this.measureRadio2.TabIndex = 12;
            this.measureRadio2.TabStop = true;
            this.measureRadio2.Text = "кг";
            this.measureRadio2.UseVisualStyleBackColor = true;
            this.measureRadio2.CheckedChanged += new System.EventHandler(this.measureRadio_checkedChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::tposDesktop.Properties.Resources.printer_icon_vector_test_vector_532760;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(469, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // balanceTableAdapter1
            // 
            this.balanceTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Поставщик:";
            // 
            // prCmbx
            // 
            this.prCmbx.FormattingEnabled = true;
            this.prCmbx.Location = new System.Drawing.Point(139, 332);
            this.prCmbx.Name = "prCmbx";
            this.prCmbx.Size = new System.Drawing.Size(423, 30);
            this.prCmbx.TabIndex = 15;
            // 
            // providerTableAdapter1
            // 
            this.providerTableAdapter1.ClearBeforeFill = true;
            // 
            // btnBarcode
            // 
            this.btnBarcode.Location = new System.Drawing.Point(579, 152);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(178, 44);
            this.btnBarcode.TabIndex = 16;
            this.btnBarcode.Text = "Печать этикеток";
            this.btnBarcode.UseVisualStyleBackColor = true;
            this.btnBarcode.Click += new System.EventHandler(this.btnBarcode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Роз. цена";
            // 
            // tbxRozPrice
            // 
            this.tbxRozPrice.Location = new System.Drawing.Point(139, 286);
            this.tbxRozPrice.Name = "tbxRozPrice";
            this.tbxRozPrice.Size = new System.Drawing.Size(148, 28);
            this.tbxRozPrice.TabIndex = 4;
            this.tbxRozPrice.Text = "0";
            // 
            // measureRadio3
            // 
            this.measureRadio3.AutoSize = true;
            this.measureRadio3.Location = new System.Drawing.Point(341, 286);
            this.measureRadio3.Name = "measureRadio3";
            this.measureRadio3.Size = new System.Drawing.Size(43, 28);
            this.measureRadio3.TabIndex = 12;
            this.measureRadio3.TabStop = true;
            this.measureRadio3.Text = "m";
            this.measureRadio3.UseVisualStyleBackColor = true;
            this.measureRadio3.CheckedChanged += new System.EventHandler(this.measureRadio_checkedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(381, 286);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "2";
            // 
            // tbxMwidth
            // 
            this.tbxMwidth.Location = new System.Drawing.Point(408, 290);
            this.tbxMwidth.Name = "tbxMwidth";
            this.tbxMwidth.Size = new System.Drawing.Size(61, 28);
            this.tbxMwidth.TabIndex = 3;
            this.tbxMwidth.Text = "0";
            this.tbxMwidth.Visible = false;
            // 
            // tbxMheight
            // 
            this.tbxMheight.Location = new System.Drawing.Point(501, 290);
            this.tbxMheight.Name = "tbxMheight";
            this.tbxMheight.Size = new System.Drawing.Size(61, 28);
            this.tbxMheight.TabIndex = 4;
            this.tbxMheight.Text = "0";
            this.tbxMheight.Visible = false;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblX.Location = new System.Drawing.Point(477, 294);
            this.lblX.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(16, 16);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            this.lblX.Visible = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(783, 387);
            this.Controls.Add(this.btnBarcode);
            this.Controls.Add(this.prCmbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.measureRadio3);
            this.Controls.Add(this.measureRadio2);
            this.Controls.Add(this.measureRadio);
            this.Controls.Add(this.tbxRozPrice);
            this.Controls.Add(this.tbxMheight);
            this.Controls.Add(this.tbxMwidth);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxPack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxShtrix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.Text = "Добавить товар";
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbxName, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblPack, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lblX, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbxShtrix, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.tbxPack, 0);
            this.Controls.SetChildIndex(this.tbxPrice, 0);
            this.Controls.SetChildIndex(this.tbxMwidth, 0);
            this.Controls.SetChildIndex(this.tbxMheight, 0);
            this.Controls.SetChildIndex(this.tbxRozPrice, 0);
            this.Controls.SetChildIndex(this.pbCaption, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblCaption, 0);
            this.Controls.SetChildIndex(this.measureRadio, 0);
            this.Controls.SetChildIndex(this.measureRadio2, 0);
            this.Controls.SetChildIndex(this.measureRadio3, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.prCmbx, 0);
            this.Controls.SetChildIndex(this.btnBarcode, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbCaption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxShtrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPack;
        private Classes.NumericTextBox tbxPack;
        private Classes.NumericTextBox tbxPrice;
        private System.Windows.Forms.RadioButton measureRadio;
        private System.Windows.Forms.RadioButton measureRadio2;
        private System.Windows.Forms.Button button1;
        private DataSetTposTableAdapters.balanceTableAdapter balanceTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox prCmbx;
        private DataSetTposTableAdapters.providerTableAdapter providerTableAdapter1;
        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.Label label4;
        private Classes.NumericTextBox tbxRozPrice;
        private System.Windows.Forms.RadioButton measureRadio3;
        private System.Windows.Forms.Label label5;
        private Classes.NumericTextBox tbxMwidth;
        private Classes.NumericTextBox tbxMheight;
        private System.Windows.Forms.Label lblX;
    }
}