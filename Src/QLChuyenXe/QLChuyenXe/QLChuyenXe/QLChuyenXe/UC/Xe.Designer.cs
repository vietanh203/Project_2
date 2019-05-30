namespace QLChuyenXe
{
    partial class Xe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmsXe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuThem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChinhSua = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBenXe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvXe = new MetroFramework.Controls.MetroGrid();
            this.iDXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bienSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDBenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBanVeXeKhachDataSet1 = new QLChuyenXe.QLBanVeXeKhachDataSet1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBX = new MetroFramework.Controls.MetroGrid();
            this.iDBenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBanVeXeKhachDataSet = new QLChuyenXe.QLBanVeXeKhachDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bENTableAdapter = new QLChuyenXe.QLBanVeXeKhachDataSetTableAdapters.BENTableAdapter();
            this.xETableAdapter = new QLChuyenXe.QLBanVeXeKhachDataSet1TableAdapters.XETableAdapter();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtBenXe = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtXe = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmsXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanVeXeKhachDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanVeXeKhachDataSet)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsXe
            // 
            this.cmsXe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmsXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsXe.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsXe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThem,
            this.menuChinhSua,
            this.menuXoa});
            this.cmsXe.Name = "cmsHangXe";
            this.cmsXe.Size = new System.Drawing.Size(155, 70);
            // 
            // menuThem
            // 
            this.menuThem.Name = "menuThem";
            this.menuThem.Size = new System.Drawing.Size(154, 22);
            this.menuThem.Text = "Thêm...";
            this.menuThem.Click += new System.EventHandler(this.menuThem_Click);
            // 
            // menuChinhSua
            // 
            this.menuChinhSua.Name = "menuChinhSua";
            this.menuChinhSua.Size = new System.Drawing.Size(154, 22);
            this.menuChinhSua.Text = "Chỉnh sửa...";
            this.menuChinhSua.Click += new System.EventHandler(this.menuChinhSua_Click);
            // 
            // menuXoa
            // 
            this.menuXoa.Name = "menuXoa";
            this.menuXoa.Size = new System.Drawing.Size(154, 22);
            this.menuXoa.Text = "Xóa...";
            this.menuXoa.Click += new System.EventHandler(this.menuXoa_Click);
            // 
            // lblBenXe
            // 
            this.lblBenXe.AutoSize = true;
            this.lblBenXe.BackColor = System.Drawing.Color.Transparent;
            this.lblBenXe.Font = new System.Drawing.Font("Open Sans Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBenXe.Location = new System.Drawing.Point(51, 23);
            this.lblBenXe.Name = "lblBenXe";
            this.lblBenXe.Size = new System.Drawing.Size(70, 26);
            this.lblBenXe.TabIndex = 44;
            this.lblBenXe.Text = "Bến Xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(421, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 45;
            this.label1.Text = "Danh Sách Xe";
            // 
            // dgvXe
            // 
            this.dgvXe.AllowUserToResizeRows = false;
            this.dgvXe.AutoGenerateColumns = false;
            this.dgvXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvXe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvXe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvXe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDXeDataGridViewTextBoxColumn,
            this.bienSoDataGridViewTextBoxColumn,
            this.maLoaiDataGridViewTextBoxColumn,
            this.iDBenDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn});
            this.dgvXe.ContextMenuStrip = this.cmsXe;
            this.dgvXe.DataSource = this.xEBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvXe.EnableHeadersVisualStyles = false;
            this.dgvXe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvXe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvXe.Location = new System.Drawing.Point(420, 139);
            this.dgvXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvXe.RowHeadersVisible = false;
            this.dgvXe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvXe.RowTemplate.Height = 24;
            this.dgvXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXe.Size = new System.Drawing.Size(735, 510);
            this.dgvXe.Style = MetroFramework.MetroColorStyle.Lime;
            this.dgvXe.TabIndex = 48;
            // 
            // iDXeDataGridViewTextBoxColumn
            // 
            this.iDXeDataGridViewTextBoxColumn.DataPropertyName = "IDXe";
            this.iDXeDataGridViewTextBoxColumn.HeaderText = "IDXe";
            this.iDXeDataGridViewTextBoxColumn.Name = "iDXeDataGridViewTextBoxColumn";
            // 
            // bienSoDataGridViewTextBoxColumn
            // 
            this.bienSoDataGridViewTextBoxColumn.DataPropertyName = "BienSo";
            this.bienSoDataGridViewTextBoxColumn.HeaderText = "BienSo";
            this.bienSoDataGridViewTextBoxColumn.Name = "bienSoDataGridViewTextBoxColumn";
            // 
            // maLoaiDataGridViewTextBoxColumn
            // 
            this.maLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.HeaderText = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
            // 
            // iDBenDataGridViewTextBoxColumn1
            // 
            this.iDBenDataGridViewTextBoxColumn1.DataPropertyName = "IDBen";
            this.iDBenDataGridViewTextBoxColumn1.HeaderText = "IDBen";
            this.iDBenDataGridViewTextBoxColumn1.Name = "iDBenDataGridViewTextBoxColumn1";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // xEBindingSource
            // 
            this.xEBindingSource.DataMember = "XE";
            this.xEBindingSource.DataSource = this.qLBanVeXeKhachDataSet1;
            // 
            // qLBanVeXeKhachDataSet1
            // 
            this.qLBanVeXeKhachDataSet1.DataSetName = "QLBanVeXeKhachDataSet1";
            this.qLBanVeXeKhachDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(416, 133);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 519);
            this.panel2.TabIndex = 49;
            // 
            // dgvBX
            // 
            this.dgvBX.AllowUserToResizeRows = false;
            this.dgvBX.AutoGenerateColumns = false;
            this.dgvBX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBX.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBX.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBX.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBenDataGridViewTextBoxColumn,
            this.tenBenDataGridViewTextBoxColumn});
            this.dgvBX.DataSource = this.bENBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBX.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBX.EnableHeadersVisualStyles = false;
            this.dgvBX.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvBX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBX.Location = new System.Drawing.Point(51, 139);
            this.dgvBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBX.Name = "dgvBX";
            this.dgvBX.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBX.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBX.RowHeadersVisible = false;
            this.dgvBX.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBX.RowTemplate.Height = 24;
            this.dgvBX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBX.Size = new System.Drawing.Size(327, 510);
            this.dgvBX.Style = MetroFramework.MetroColorStyle.Lime;
            this.dgvBX.TabIndex = 46;
            this.dgvBX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBX_CellClick);
            // 
            // iDBenDataGridViewTextBoxColumn
            // 
            this.iDBenDataGridViewTextBoxColumn.DataPropertyName = "IDBen";
            this.iDBenDataGridViewTextBoxColumn.HeaderText = "IDBen";
            this.iDBenDataGridViewTextBoxColumn.Name = "iDBenDataGridViewTextBoxColumn";
            // 
            // tenBenDataGridViewTextBoxColumn
            // 
            this.tenBenDataGridViewTextBoxColumn.DataPropertyName = "TenBen";
            this.tenBenDataGridViewTextBoxColumn.HeaderText = "TenBen";
            this.tenBenDataGridViewTextBoxColumn.Name = "tenBenDataGridViewTextBoxColumn";
            // 
            // bENBindingSource
            // 
            this.bENBindingSource.DataMember = "BEN";
            this.bENBindingSource.DataSource = this.qLBanVeXeKhachDataSet;
            // 
            // qLBanVeXeKhachDataSet
            // 
            this.qLBanVeXeKhachDataSet.DataSetName = "QLBanVeXeKhachDataSet";
            this.qLBanVeXeKhachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(45, 134);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 519);
            this.panel1.TabIndex = 47;
            // 
            // bENTableAdapter
            // 
            this.bENTableAdapter.ClearBeforeFill = true;
            // 
            // xETableAdapter
            // 
            this.xETableAdapter.ClearBeforeFill = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.panel6.Controls.Add(this.txtBenXe);
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Location = new System.Drawing.Point(45, 71);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(263, 44);
            this.panel6.TabIndex = 50;
            // 
            // txtBenXe
            // 
            this.txtBenXe.Location = new System.Drawing.Point(47, 11);
            this.txtBenXe.Margin = new System.Windows.Forms.Padding(4);
            this.txtBenXe.Name = "txtBenXe";
            this.txtBenXe.Size = new System.Drawing.Size(197, 22);
            this.txtBenXe.TabIndex = 5;
            this.txtBenXe.TextChanged += new System.EventHandler(this.txtBenXe_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QLChuyenXe.Properties.Resources.search;
            this.pictureBox3.Location = new System.Drawing.Point(11, 9);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.txtXe);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(416, 71);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 44);
            this.panel4.TabIndex = 51;
            // 
            // txtXe
            // 
            this.txtXe.Location = new System.Drawing.Point(47, 10);
            this.txtXe.Margin = new System.Windows.Forms.Padding(4);
            this.txtXe.Name = "txtXe";
            this.txtXe.Size = new System.Drawing.Size(242, 22);
            this.txtXe.TabIndex = 5;
            this.txtXe.TextChanged += new System.EventHandler(this.txtXe_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLChuyenXe.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(11, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnReload
            // 
            this.btnReload.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(72)))), ((int)(((byte)(24)))));
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(92)))), ((int)(((byte)(44)))));
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.BorderRadius = 7;
            this.btnReload.ButtonText = "RELOAD";
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.DisabledColor = System.Drawing.Color.Gray;
            this.btnReload.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReload.Iconimage = global::QLChuyenXe.Properties.Resources.circular_arrow;
            this.btnReload.Iconimage_right = null;
            this.btnReload.Iconimage_right_Selected = null;
            this.btnReload.Iconimage_Selected = null;
            this.btnReload.IconMarginLeft = 0;
            this.btnReload.IconMarginRight = 0;
            this.btnReload.IconRightVisible = true;
            this.btnReload.IconRightZoom = 0D;
            this.btnReload.IconVisible = true;
            this.btnReload.IconZoom = 38D;
            this.btnReload.IsTab = false;
            this.btnReload.Location = new System.Drawing.Point(732, 76);
            this.btnReload.Margin = new System.Windows.Forms.Padding(5);
            this.btnReload.Name = "btnReload";
            this.btnReload.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(92)))), ((int)(((byte)(44)))));
            this.btnReload.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(72)))), ((int)(((byte)(24)))));
            this.btnReload.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReload.selected = false;
            this.btnReload.Size = new System.Drawing.Size(113, 34);
            this.btnReload.TabIndex = 48;
            this.btnReload.Text = "RELOAD";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.Textcolor = System.Drawing.Color.White;
            this.btnReload.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgvXe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvBX);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBenXe);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Xe";
            this.Size = new System.Drawing.Size(1212, 736);
            this.Load += new System.EventHandler(this.Xe_Load);
            this.cmsXe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanVeXeKhachDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanVeXeKhachDataSet)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsXe;
        private System.Windows.Forms.ToolStripMenuItem menuThem;
        private System.Windows.Forms.ToolStripMenuItem menuChinhSua;
        private System.Windows.Forms.ToolStripMenuItem menuXoa;
        private System.Windows.Forms.Label lblBenXe;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroGrid dgvXe;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroGrid dgvBX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBenDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bENBindingSource;
        private QLBanVeXeKhachDataSet qLBanVeXeKhachDataSet;
        private QLBanVeXeKhachDataSetTableAdapters.BENTableAdapter bENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bienSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource xEBindingSource;
        private QLBanVeXeKhachDataSet1 qLBanVeXeKhachDataSet1;
        private QLBanVeXeKhachDataSet1TableAdapters.XETableAdapter xETableAdapter;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtBenXe;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnReload;
        private System.Windows.Forms.TextBox txtXe;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
