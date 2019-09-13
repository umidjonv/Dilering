using Classes;
namespace tposDesktop
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLastCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVozvrat = new System.Windows.Forms.Button();
            this.soat = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblActionResult = new System.Windows.Forms.Label();
            this.lblNumResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnById = new System.Windows.Forms.Button();
            this.tbxSearchTovar = new System.Windows.Forms.TextBox();
            this.dgvTovar = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSum = new System.Windows.Forms.TextBox();
            this.btnOplata = new System.Windows.Forms.Button();
            this.dgvExpense = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hot_1 = new System.Windows.Forms.Button();
            this.hot_2 = new System.Windows.Forms.Button();
            this.hot_3 = new System.Windows.Forms.Button();
            this.hot_4 = new System.Windows.Forms.Button();
            this.hot_5 = new System.Windows.Forms.Button();
            this.hot_6 = new System.Windows.Forms.Button();
            this.hot_7 = new System.Windows.Forms.Button();
            this.hot_8 = new System.Windows.Forms.Button();
            this.hot_9 = new System.Windows.Forms.Button();
            this.hot_10 = new System.Windows.Forms.Button();
            this.hot_11 = new System.Windows.Forms.Button();
            this.hot_12 = new System.Windows.Forms.Button();
            this.hot_13 = new System.Windows.Forms.Button();
            this.hot_14 = new System.Windows.Forms.Button();
            this.hot_15 = new System.Windows.Forms.Button();
            this.hot_16 = new System.Windows.Forms.Button();
            this.hot_17 = new System.Windows.Forms.Button();
            this.hot_18 = new System.Windows.Forms.Button();
            this.hot_19 = new System.Windows.Forms.Button();
            this.hot_20 = new System.Windows.Forms.Button();
            this.hot_21 = new System.Windows.Forms.Button();
            this.hot_22 = new System.Windows.Forms.Button();
            this.hot_23 = new System.Windows.Forms.Button();
            this.hot_24 = new System.Windows.Forms.Button();
            this.hot_25 = new System.Windows.Forms.Button();
            this.hot_26 = new System.Windows.Forms.Button();
            this.hot_27 = new System.Windows.Forms.Button();
            this.hot_28 = new System.Windows.Forms.Button();
            this.hot_29 = new System.Windows.Forms.Button();
            this.hot_30 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataSetTpos = new tposDesktop.DataSetTpos();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new tposDesktop.DataSetTposTableAdapters.ordersTableAdapter();
            this.hotkeysTableAdapter1 = new tposDesktop.DataSetTposTableAdapters.hotkeysTableAdapter();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnRozn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTovar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTpos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(118)))), ((int)(((byte)(55)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdmin,
            this.exitMenu,
            this.menuUpdate,
            this.menuLastCheck});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1024, 52);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAdmin
            // 
            this.menuAdmin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuAdmin.ForeColor = System.Drawing.Color.Yellow;
            this.menuAdmin.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(119, 44);
            this.menuAdmin.Text = "Администратор";
            this.menuAdmin.Visible = false;
            this.menuAdmin.Click += new System.EventHandler(this.администраторToolStripMenuItem_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitMenu.Image = global::tposDesktop.Properties.Resources.quit;
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(52, 44);
            this.exitMenu.Text = "Выход";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // menuUpdate
            // 
            this.menuUpdate.Name = "menuUpdate";
            this.menuUpdate.Size = new System.Drawing.Size(82, 44);
            this.menuUpdate.Text = "Обновить";
            this.menuUpdate.Click += new System.EventHandler(this.menuUpdate_Click);
            // 
            // menuLastCheck
            // 
            this.menuLastCheck.Name = "menuLastCheck";
            this.menuLastCheck.Size = new System.Drawing.Size(121, 44);
            this.menuLastCheck.Text = "Последний чек";
            this.menuLastCheck.Visible = false;
            this.menuLastCheck.Click += new System.EventHandler(this.menuLastCheck_Click);
            // 
            // btnVozvrat
            // 
            this.btnVozvrat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVozvrat.BackColor = System.Drawing.Color.Blue;
            this.btnVozvrat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVozvrat.BackgroundImage")));
            this.btnVozvrat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVozvrat.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.btnVozvrat.FlatAppearance.BorderSize = 0;
            this.btnVozvrat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnVozvrat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnVozvrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVozvrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVozvrat.Location = new System.Drawing.Point(862, 6);
            this.btnVozvrat.Name = "btnVozvrat";
            this.btnVozvrat.Size = new System.Drawing.Size(40, 40);
            this.btnVozvrat.TabIndex = 3;
            this.btnVozvrat.UseVisualStyleBackColor = false;
            this.btnVozvrat.Click += new System.EventHandler(this.btnVozvrat_Click);
            // 
            // soat
            // 
            this.soat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.soat.AutoSize = true;
            this.soat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(118)))), ((int)(((byte)(55)))));
            this.soat.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.soat.ForeColor = System.Drawing.Color.White;
            this.soat.Location = new System.Drawing.Point(563, 6);
            this.soat.Name = "soat";
            this.soat.Size = new System.Drawing.Size(99, 37);
            this.soat.TabIndex = 4;
            this.soat.Text = "00:00";
            this.soat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(118)))), ((int)(((byte)(55)))));
            this.pictureBox2.BackgroundImage = global::tposDesktop.Properties.Resources.logo_interface;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(368, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 52);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(179)))));
            this.panel3.Controls.Add(this.lblActionResult);
            this.panel3.Controls.Add(this.lblNumResult);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Location = new System.Drawing.Point(12, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 650);
            this.panel3.TabIndex = 8;
            // 
            // lblActionResult
            // 
            this.lblActionResult.AutoSize = true;
            this.lblActionResult.Location = new System.Drawing.Point(490, 394);
            this.lblActionResult.Name = "lblActionResult";
            this.lblActionResult.Size = new System.Drawing.Size(0, 24);
            this.lblActionResult.TabIndex = 10;
            // 
            // lblNumResult
            // 
            this.lblNumResult.AutoSize = true;
            this.lblNumResult.Location = new System.Drawing.Point(392, 394);
            this.lblNumResult.Name = "lblNumResult";
            this.lblNumResult.Size = new System.Drawing.Size(0, 24);
            this.lblNumResult.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnById);
            this.groupBox1.Controls.Add(this.tbxSearchTovar);
            this.groupBox1.Controls.Add(this.dgvTovar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 335);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnById
            // 
            this.btnById.BackColor = System.Drawing.Color.Khaki;
            this.btnById.FlatAppearance.BorderSize = 0;
            this.btnById.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnById.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnById.Location = new System.Drawing.Point(297, 14);
            this.btnById.Name = "btnById";
            this.btnById.Size = new System.Drawing.Size(50, 30);
            this.btnById.TabIndex = 14;
            this.btnById.Text = "ID";
            this.btnById.UseVisualStyleBackColor = false;
            this.btnById.Click += new System.EventHandler(this.btnById_Click);
            // 
            // tbxSearchTovar
            // 
            this.tbxSearchTovar.ForeColor = System.Drawing.Color.Silver;
            this.tbxSearchTovar.Location = new System.Drawing.Point(6, 14);
            this.tbxSearchTovar.Name = "tbxSearchTovar";
            this.tbxSearchTovar.Size = new System.Drawing.Size(179, 26);
            this.tbxSearchTovar.TabIndex = 0;
            this.tbxSearchTovar.Text = "По имени";
            this.tbxSearchTovar.TextChanged += new System.EventHandler(this.tbxSearchTovar_TextChanged);
            this.tbxSearchTovar.Enter += new System.EventHandler(this.tbxEnter);
            this.tbxSearchTovar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_KeyPress);
            this.tbxSearchTovar.Leave += new System.EventHandler(this.tbxLeave);
            // 
            // dgvTovar
            // 
            this.dgvTovar.AllowUserToAddRows = false;
            this.dgvTovar.AllowUserToDeleteRows = false;
            this.dgvTovar.AllowUserToResizeColumns = false;
            this.dgvTovar.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTovar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTovar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTovar.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvTovar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTovar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTovar.ColumnHeadersHeight = 30;
            this.dgvTovar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTovar.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTovar.GridColor = System.Drawing.Color.PaleGreen;
            this.dgvTovar.Location = new System.Drawing.Point(6, 46);
            this.dgvTovar.MultiSelect = false;
            this.dgvTovar.Name = "dgvTovar";
            this.dgvTovar.ReadOnly = true;
            this.dgvTovar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTovar.RowHeadersVisible = false;
            this.dgvTovar.RowHeadersWidth = 10;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvTovar.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTovar.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dgvTovar.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvTovar.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTovar.RowTemplate.Height = 45;
            this.dgvTovar.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTovar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTovar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTovar.Size = new System.Drawing.Size(540, 283);
            this.dgvTovar.TabIndex = 3;
            this.dgvTovar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTovar_CellContentClick);
            this.dgvTovar.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvSchet_CellPainting);
            this.dgvTovar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.dgvExpense);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(574, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 630);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Счёт на расход ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSum);
            this.panel1.Controls.Add(this.btnOplata);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 499);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 128);
            this.panel1.TabIndex = 7;
            // 
            // lblSum
            // 
            this.lblSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(118)))), ((int)(((byte)(55)))));
            this.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSum.ForeColor = System.Drawing.Color.MintCream;
            this.lblSum.Location = new System.Drawing.Point(1, 0);
            this.lblSum.Name = "lblSum";
            this.lblSum.ReadOnly = true;
            this.lblSum.Size = new System.Drawing.Size(408, 47);
            this.lblSum.TabIndex = 9;
            this.lblSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOplata
            // 
            this.btnOplata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOplata.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOplata.BackColor = System.Drawing.Color.Crimson;
            this.btnOplata.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btnOplata.FlatAppearance.BorderSize = 0;
            this.btnOplata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.btnOplata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOplata.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOplata.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnOplata.Location = new System.Drawing.Point(3, 51);
            this.btnOplata.Name = "btnOplata";
            this.btnOplata.Size = new System.Drawing.Size(400, 78);
            this.btnOplata.TabIndex = 2;
            this.btnOplata.Text = "Отправить(+)";
            this.btnOplata.UseVisualStyleBackColor = false;
            this.btnOplata.Click += new System.EventHandler(this.btnOplata_Click);
            // 
            // dgvExpense
            // 
            this.dgvExpense.AllowUserToAddRows = false;
            this.dgvExpense.AllowUserToResizeColumns = false;
            this.dgvExpense.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.dgvExpense.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvExpense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExpense.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvExpense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpense.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvExpense.ColumnHeadersHeight = 35;
            this.dgvExpense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.productPrice});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpense.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvExpense.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvExpense.GridColor = System.Drawing.Color.PaleGreen;
            this.dgvExpense.Location = new System.Drawing.Point(6, 25);
            this.dgvExpense.Name = "dgvExpense";
            this.dgvExpense.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvExpense.RowHeadersVisible = false;
            this.dgvExpense.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvExpense.RowTemplate.Height = 55;
            this.dgvExpense.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpense.Size = new System.Drawing.Size(403, 479);
            this.dgvExpense.TabIndex = 1;
            this.dgvExpense.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvExpense_CellBeginEdit);
            this.dgvExpense.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpenseRow_Click);
            this.dgvExpense.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpense_CellContentClick);
            this.dgvExpense.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvSchet_CellPainting);
            this.dgvExpense.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpense_CellValueChanged);
            this.dgvExpense.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvExpense_RowsAdded);
            this.dgvExpense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_KeyPress);
            // 
            // ProductName
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductName.DefaultCellStyle = dataGridViewCellStyle12;
            this.ProductName.HeaderText = "Наименование";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 147;
            // 
            // productPrice
            // 
            this.productPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.NullValue = null;
            this.productPrice.DefaultCellStyle = dataGridViewCellStyle13;
            this.productPrice.FillWeight = 5F;
            this.productPrice.HeaderText = "Цена";
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            this.productPrice.Width = 73;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.Controls.Add(this.hot_1);
            this.flowLayoutPanel1.Controls.Add(this.hot_2);
            this.flowLayoutPanel1.Controls.Add(this.hot_3);
            this.flowLayoutPanel1.Controls.Add(this.hot_4);
            this.flowLayoutPanel1.Controls.Add(this.hot_5);
            this.flowLayoutPanel1.Controls.Add(this.hot_6);
            this.flowLayoutPanel1.Controls.Add(this.hot_7);
            this.flowLayoutPanel1.Controls.Add(this.hot_8);
            this.flowLayoutPanel1.Controls.Add(this.hot_9);
            this.flowLayoutPanel1.Controls.Add(this.hot_10);
            this.flowLayoutPanel1.Controls.Add(this.hot_11);
            this.flowLayoutPanel1.Controls.Add(this.hot_12);
            this.flowLayoutPanel1.Controls.Add(this.hot_13);
            this.flowLayoutPanel1.Controls.Add(this.hot_14);
            this.flowLayoutPanel1.Controls.Add(this.hot_15);
            this.flowLayoutPanel1.Controls.Add(this.hot_16);
            this.flowLayoutPanel1.Controls.Add(this.hot_17);
            this.flowLayoutPanel1.Controls.Add(this.hot_18);
            this.flowLayoutPanel1.Controls.Add(this.hot_19);
            this.flowLayoutPanel1.Controls.Add(this.hot_20);
            this.flowLayoutPanel1.Controls.Add(this.hot_21);
            this.flowLayoutPanel1.Controls.Add(this.hot_22);
            this.flowLayoutPanel1.Controls.Add(this.hot_23);
            this.flowLayoutPanel1.Controls.Add(this.hot_24);
            this.flowLayoutPanel1.Controls.Add(this.hot_25);
            this.flowLayoutPanel1.Controls.Add(this.hot_26);
            this.flowLayoutPanel1.Controls.Add(this.hot_27);
            this.flowLayoutPanel1.Controls.Add(this.hot_28);
            this.flowLayoutPanel1.Controls.Add(this.hot_29);
            this.flowLayoutPanel1.Controls.Add(this.hot_30);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 353);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(472, 285);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // hot_1
            // 
            this.hot_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_1.FlatAppearance.BorderSize = 0;
            this.hot_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_1.Location = new System.Drawing.Point(3, 3);
            this.hot_1.Name = "hot_1";
            this.hot_1.Size = new System.Drawing.Size(86, 50);
            this.hot_1.TabIndex = 0;
            this.hot_1.Text = "1";
            this.hot_1.UseVisualStyleBackColor = false;
            this.hot_1.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_2
            // 
            this.hot_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_2.FlatAppearance.BorderSize = 0;
            this.hot_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_2.Location = new System.Drawing.Point(95, 3);
            this.hot_2.Name = "hot_2";
            this.hot_2.Size = new System.Drawing.Size(86, 50);
            this.hot_2.TabIndex = 1;
            this.hot_2.Text = "2";
            this.hot_2.UseVisualStyleBackColor = false;
            this.hot_2.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_3
            // 
            this.hot_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_3.FlatAppearance.BorderSize = 0;
            this.hot_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_3.Location = new System.Drawing.Point(187, 3);
            this.hot_3.Name = "hot_3";
            this.hot_3.Size = new System.Drawing.Size(86, 50);
            this.hot_3.TabIndex = 2;
            this.hot_3.Text = "3";
            this.hot_3.UseVisualStyleBackColor = false;
            this.hot_3.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_4
            // 
            this.hot_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_4.FlatAppearance.BorderSize = 0;
            this.hot_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_4.Location = new System.Drawing.Point(279, 3);
            this.hot_4.Name = "hot_4";
            this.hot_4.Size = new System.Drawing.Size(86, 50);
            this.hot_4.TabIndex = 3;
            this.hot_4.Text = "4";
            this.hot_4.UseVisualStyleBackColor = false;
            this.hot_4.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_5
            // 
            this.hot_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_5.FlatAppearance.BorderSize = 0;
            this.hot_5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_5.Location = new System.Drawing.Point(371, 3);
            this.hot_5.Name = "hot_5";
            this.hot_5.Size = new System.Drawing.Size(86, 50);
            this.hot_5.TabIndex = 10;
            this.hot_5.Text = "5";
            this.hot_5.UseVisualStyleBackColor = false;
            this.hot_5.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_6
            // 
            this.hot_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_6.FlatAppearance.BorderSize = 0;
            this.hot_6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_6.Location = new System.Drawing.Point(3, 59);
            this.hot_6.Name = "hot_6";
            this.hot_6.Size = new System.Drawing.Size(86, 50);
            this.hot_6.TabIndex = 11;
            this.hot_6.Text = "6";
            this.hot_6.UseVisualStyleBackColor = false;
            this.hot_6.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_7
            // 
            this.hot_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_7.FlatAppearance.BorderSize = 0;
            this.hot_7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_7.Location = new System.Drawing.Point(95, 59);
            this.hot_7.Name = "hot_7";
            this.hot_7.Size = new System.Drawing.Size(86, 50);
            this.hot_7.TabIndex = 12;
            this.hot_7.Text = "7";
            this.hot_7.UseVisualStyleBackColor = false;
            this.hot_7.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_8
            // 
            this.hot_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_8.FlatAppearance.BorderSize = 0;
            this.hot_8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_8.Location = new System.Drawing.Point(187, 59);
            this.hot_8.Name = "hot_8";
            this.hot_8.Size = new System.Drawing.Size(86, 50);
            this.hot_8.TabIndex = 13;
            this.hot_8.Text = "8";
            this.hot_8.UseVisualStyleBackColor = false;
            this.hot_8.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_9
            // 
            this.hot_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_9.FlatAppearance.BorderSize = 0;
            this.hot_9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_9.Location = new System.Drawing.Point(279, 59);
            this.hot_9.Name = "hot_9";
            this.hot_9.Size = new System.Drawing.Size(86, 50);
            this.hot_9.TabIndex = 8;
            this.hot_9.Text = "9";
            this.hot_9.UseVisualStyleBackColor = false;
            this.hot_9.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_10
            // 
            this.hot_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_10.FlatAppearance.BorderSize = 0;
            this.hot_10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_10.Location = new System.Drawing.Point(371, 59);
            this.hot_10.Name = "hot_10";
            this.hot_10.Size = new System.Drawing.Size(86, 50);
            this.hot_10.TabIndex = 9;
            this.hot_10.Text = "10";
            this.hot_10.UseVisualStyleBackColor = false;
            this.hot_10.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_11
            // 
            this.hot_11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_11.FlatAppearance.BorderSize = 0;
            this.hot_11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_11.Location = new System.Drawing.Point(3, 115);
            this.hot_11.Name = "hot_11";
            this.hot_11.Size = new System.Drawing.Size(86, 50);
            this.hot_11.TabIndex = 14;
            this.hot_11.Text = "11";
            this.hot_11.UseVisualStyleBackColor = false;
            this.hot_11.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_12
            // 
            this.hot_12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_12.FlatAppearance.BorderSize = 0;
            this.hot_12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_12.Location = new System.Drawing.Point(95, 115);
            this.hot_12.Name = "hot_12";
            this.hot_12.Size = new System.Drawing.Size(86, 50);
            this.hot_12.TabIndex = 15;
            this.hot_12.Text = "12";
            this.hot_12.UseVisualStyleBackColor = false;
            this.hot_12.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_13
            // 
            this.hot_13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_13.FlatAppearance.BorderSize = 0;
            this.hot_13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_13.Location = new System.Drawing.Point(187, 115);
            this.hot_13.Name = "hot_13";
            this.hot_13.Size = new System.Drawing.Size(86, 50);
            this.hot_13.TabIndex = 16;
            this.hot_13.Text = "13";
            this.hot_13.UseVisualStyleBackColor = false;
            this.hot_13.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_14
            // 
            this.hot_14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_14.FlatAppearance.BorderSize = 0;
            this.hot_14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_14.Location = new System.Drawing.Point(279, 115);
            this.hot_14.Name = "hot_14";
            this.hot_14.Size = new System.Drawing.Size(86, 50);
            this.hot_14.TabIndex = 17;
            this.hot_14.Text = "14";
            this.hot_14.UseVisualStyleBackColor = false;
            this.hot_14.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_15
            // 
            this.hot_15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_15.FlatAppearance.BorderSize = 0;
            this.hot_15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_15.Location = new System.Drawing.Point(371, 115);
            this.hot_15.Name = "hot_15";
            this.hot_15.Size = new System.Drawing.Size(86, 50);
            this.hot_15.TabIndex = 18;
            this.hot_15.Text = "15";
            this.hot_15.UseVisualStyleBackColor = false;
            this.hot_15.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_16
            // 
            this.hot_16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_16.FlatAppearance.BorderSize = 0;
            this.hot_16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_16.Location = new System.Drawing.Point(3, 171);
            this.hot_16.Name = "hot_16";
            this.hot_16.Size = new System.Drawing.Size(86, 50);
            this.hot_16.TabIndex = 19;
            this.hot_16.Text = "16";
            this.hot_16.UseVisualStyleBackColor = false;
            this.hot_16.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_17
            // 
            this.hot_17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_17.FlatAppearance.BorderSize = 0;
            this.hot_17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_17.Location = new System.Drawing.Point(95, 171);
            this.hot_17.Name = "hot_17";
            this.hot_17.Size = new System.Drawing.Size(86, 50);
            this.hot_17.TabIndex = 20;
            this.hot_17.Text = "17";
            this.hot_17.UseVisualStyleBackColor = false;
            this.hot_17.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_18
            // 
            this.hot_18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_18.FlatAppearance.BorderSize = 0;
            this.hot_18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_18.Location = new System.Drawing.Point(187, 171);
            this.hot_18.Name = "hot_18";
            this.hot_18.Size = new System.Drawing.Size(86, 50);
            this.hot_18.TabIndex = 21;
            this.hot_18.Text = "18";
            this.hot_18.UseVisualStyleBackColor = false;
            this.hot_18.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_19
            // 
            this.hot_19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_19.FlatAppearance.BorderSize = 0;
            this.hot_19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_19.Location = new System.Drawing.Point(279, 171);
            this.hot_19.Name = "hot_19";
            this.hot_19.Size = new System.Drawing.Size(86, 50);
            this.hot_19.TabIndex = 22;
            this.hot_19.Text = "19";
            this.hot_19.UseVisualStyleBackColor = false;
            this.hot_19.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_20
            // 
            this.hot_20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_20.FlatAppearance.BorderSize = 0;
            this.hot_20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_20.Location = new System.Drawing.Point(371, 171);
            this.hot_20.Name = "hot_20";
            this.hot_20.Size = new System.Drawing.Size(86, 50);
            this.hot_20.TabIndex = 23;
            this.hot_20.Text = "20";
            this.hot_20.UseVisualStyleBackColor = false;
            this.hot_20.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_21
            // 
            this.hot_21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_21.FlatAppearance.BorderSize = 0;
            this.hot_21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_21.Location = new System.Drawing.Point(3, 227);
            this.hot_21.Name = "hot_21";
            this.hot_21.Size = new System.Drawing.Size(86, 50);
            this.hot_21.TabIndex = 24;
            this.hot_21.Text = "21";
            this.hot_21.UseVisualStyleBackColor = false;
            this.hot_21.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_22
            // 
            this.hot_22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_22.FlatAppearance.BorderSize = 0;
            this.hot_22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_22.Location = new System.Drawing.Point(95, 227);
            this.hot_22.Name = "hot_22";
            this.hot_22.Size = new System.Drawing.Size(86, 50);
            this.hot_22.TabIndex = 25;
            this.hot_22.Text = "22";
            this.hot_22.UseVisualStyleBackColor = false;
            this.hot_22.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_23
            // 
            this.hot_23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_23.FlatAppearance.BorderSize = 0;
            this.hot_23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_23.Location = new System.Drawing.Point(187, 227);
            this.hot_23.Name = "hot_23";
            this.hot_23.Size = new System.Drawing.Size(86, 50);
            this.hot_23.TabIndex = 26;
            this.hot_23.Text = "23";
            this.hot_23.UseVisualStyleBackColor = false;
            this.hot_23.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_24
            // 
            this.hot_24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_24.FlatAppearance.BorderSize = 0;
            this.hot_24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_24.Location = new System.Drawing.Point(279, 227);
            this.hot_24.Name = "hot_24";
            this.hot_24.Size = new System.Drawing.Size(86, 50);
            this.hot_24.TabIndex = 27;
            this.hot_24.Text = "24";
            this.hot_24.UseVisualStyleBackColor = false;
            this.hot_24.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_25
            // 
            this.hot_25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.hot_25.FlatAppearance.BorderSize = 0;
            this.hot_25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.hot_25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hot_25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_25.Location = new System.Drawing.Point(371, 227);
            this.hot_25.Name = "hot_25";
            this.hot_25.Size = new System.Drawing.Size(86, 50);
            this.hot_25.TabIndex = 28;
            this.hot_25.Text = "25";
            this.hot_25.UseVisualStyleBackColor = false;
            this.hot_25.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_26
            // 
            this.hot_26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_26.Location = new System.Drawing.Point(3, 283);
            this.hot_26.Name = "hot_26";
            this.hot_26.Size = new System.Drawing.Size(86, 50);
            this.hot_26.TabIndex = 29;
            this.hot_26.Text = "26";
            this.hot_26.UseVisualStyleBackColor = true;
            this.hot_26.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_27
            // 
            this.hot_27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_27.Location = new System.Drawing.Point(95, 283);
            this.hot_27.Name = "hot_27";
            this.hot_27.Size = new System.Drawing.Size(86, 50);
            this.hot_27.TabIndex = 30;
            this.hot_27.Text = "27";
            this.hot_27.UseVisualStyleBackColor = true;
            this.hot_27.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_28
            // 
            this.hot_28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_28.Location = new System.Drawing.Point(187, 283);
            this.hot_28.Name = "hot_28";
            this.hot_28.Size = new System.Drawing.Size(86, 50);
            this.hot_28.TabIndex = 31;
            this.hot_28.Text = "28";
            this.hot_28.UseVisualStyleBackColor = true;
            this.hot_28.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_29
            // 
            this.hot_29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_29.Location = new System.Drawing.Point(279, 283);
            this.hot_29.Name = "hot_29";
            this.hot_29.Size = new System.Drawing.Size(86, 50);
            this.hot_29.TabIndex = 32;
            this.hot_29.Text = "29";
            this.hot_29.UseVisualStyleBackColor = true;
            this.hot_29.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // hot_30
            // 
            this.hot_30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hot_30.Location = new System.Drawing.Point(371, 283);
            this.hot_30.Name = "hot_30";
            this.hot_30.Size = new System.Drawing.Size(86, 50);
            this.hot_30.TabIndex = 33;
            this.hot_30.Text = "30";
            this.hot_30.UseVisualStyleBackColor = true;
            this.hot_30.Click += new System.EventHandler(this.hotKeyBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(148)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 680);
            this.panel2.TabIndex = 7;
            // 
            // dataSetTpos
            // 
            this.dataSetTpos.DataSetName = "DataSetTpos";
            this.dataSetTpos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.dataSetTpos;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // hotkeysTableAdapter1
            // 
            this.hotkeysTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewButtonColumn1.HeaderText = "Column1";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            // 
            // btnRozn
            // 
            this.btnRozn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRozn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(118)))), ((int)(((byte)(55)))));
            this.btnRozn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRozn.BackgroundImage")));
            this.btnRozn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRozn.FlatAppearance.BorderSize = 0;
            this.btnRozn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(118)))), ((int)(((byte)(55)))));
            this.btnRozn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(118)))), ((int)(((byte)(55)))));
            this.btnRozn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRozn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRozn.Location = new System.Drawing.Point(729, 0);
            this.btnRozn.Name = "btnRozn";
            this.btnRozn.Size = new System.Drawing.Size(59, 52);
            this.btnRozn.TabIndex = 3;
            this.btnRozn.UseVisualStyleBackColor = false;
            this.btnRozn.Click += new System.EventHandler(this.btnRozn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1024, 732);
            this.Controls.Add(this.btnRozn);
            this.Controls.Add(this.btnVozvrat);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.soat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажа";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTovar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTpos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAdmin;
        private System.Windows.Forms.Button btnVozvrat;
        private DataSetTpos dataSetTpos;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DataSetTposTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.Label soat;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DataSetTposTableAdapters.hotkeysTableAdapter hotkeysTableAdapter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private NumericTextBox tbxSearchPrice;
        private System.Windows.Forms.TextBox tbxSearchTovar;
        private System.Windows.Forms.DataGridView dgvTovar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox lblSum;
        private System.Windows.Forms.Button btnOplata;
        private System.Windows.Forms.DataGridView dgvExpense;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button hot_1;
        private System.Windows.Forms.Button hot_2;
        private System.Windows.Forms.Button hot_3;
        private System.Windows.Forms.Button hot_4;
        private System.Windows.Forms.Button hot_5;
        private System.Windows.Forms.Button hot_6;
        private System.Windows.Forms.Button hot_7;
        private System.Windows.Forms.Button hot_8;
        private System.Windows.Forms.Button hot_9;
        private System.Windows.Forms.Button hot_10;
        private System.Windows.Forms.Button hot_11;
        private System.Windows.Forms.Button hot_12;
        private System.Windows.Forms.Button hot_13;
        private System.Windows.Forms.Button hot_14;
        private System.Windows.Forms.Button hot_15;
        private System.Windows.Forms.Button hot_16;
        private System.Windows.Forms.Button hot_17;
        private System.Windows.Forms.Button hot_18;
        private System.Windows.Forms.Button hot_19;
        private System.Windows.Forms.Button hot_20;
        private System.Windows.Forms.Button hot_21;
        private System.Windows.Forms.Button hot_22;
        private System.Windows.Forms.Button hot_23;
        private System.Windows.Forms.Button hot_24;
        private System.Windows.Forms.Button hot_25;
        private System.Windows.Forms.Button hot_26;
        private System.Windows.Forms.Button hot_27;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNumResult;
        private System.Windows.Forms.Label lblActionResult;
        private System.Windows.Forms.Button hot_28;
        private System.Windows.Forms.Button hot_29;
        private System.Windows.Forms.Button hot_30;
        private System.Windows.Forms.Button btnById;
        private System.Windows.Forms.ToolStripMenuItem menuUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuLastCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.Button btnRozn;
    }
}