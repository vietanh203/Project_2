namespace QLChuyenXe
{
    partial class AddTuyenDuong
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
            this.cbDiemDen = new MetroFramework.Controls.MetroComboBox();
            this.cbDiemKhoiHanh = new MetroFramework.Controls.MetroComboBox();
            this.lblDiemDen = new System.Windows.Forms.Label();
            this.lblDiemKhoiHanh = new System.Windows.Forms.Label();
            this.chbThemChieuNguocLai = new MetroFramework.Controls.MetroCheckBox();
            this.btnReload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // cbDiemDen
            // 
            this.cbDiemDen.FormattingEnabled = true;
            this.cbDiemDen.ItemHeight = 23;
            this.cbDiemDen.Location = new System.Drawing.Point(140, 117);
            this.cbDiemDen.Margin = new System.Windows.Forms.Padding(2);
            this.cbDiemDen.Name = "cbDiemDen";
            this.cbDiemDen.Size = new System.Drawing.Size(175, 29);
            this.cbDiemDen.TabIndex = 10;
            this.cbDiemDen.UseSelectable = true;
            // 
            // cbDiemKhoiHanh
            // 
            this.cbDiemKhoiHanh.FormattingEnabled = true;
            this.cbDiemKhoiHanh.ItemHeight = 23;
            this.cbDiemKhoiHanh.Location = new System.Drawing.Point(140, 80);
            this.cbDiemKhoiHanh.Margin = new System.Windows.Forms.Padding(2);
            this.cbDiemKhoiHanh.Name = "cbDiemKhoiHanh";
            this.cbDiemKhoiHanh.Size = new System.Drawing.Size(175, 29);
            this.cbDiemKhoiHanh.TabIndex = 9;
            this.cbDiemKhoiHanh.UseSelectable = true;
            // 
            // lblDiemDen
            // 
            this.lblDiemDen.AutoSize = true;
            this.lblDiemDen.BackColor = System.Drawing.Color.White;
            this.lblDiemDen.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiemDen.Location = new System.Drawing.Point(64, 120);
            this.lblDiemDen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiemDen.Name = "lblDiemDen";
            this.lblDiemDen.Size = new System.Drawing.Size(80, 22);
            this.lblDiemDen.TabIndex = 8;
            this.lblDiemDen.Text = "Điểm đến";
            // 
            // lblDiemKhoiHanh
            // 
            this.lblDiemKhoiHanh.AutoSize = true;
            this.lblDiemKhoiHanh.BackColor = System.Drawing.Color.White;
            this.lblDiemKhoiHanh.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiemKhoiHanh.Location = new System.Drawing.Point(26, 84);
            this.lblDiemKhoiHanh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiemKhoiHanh.Name = "lblDiemKhoiHanh";
            this.lblDiemKhoiHanh.Size = new System.Drawing.Size(121, 22);
            this.lblDiemKhoiHanh.TabIndex = 7;
            this.lblDiemKhoiHanh.Text = "Điểm khởi hành";
            // 
            // chbThemChieuNguocLai
            // 
            this.chbThemChieuNguocLai.AutoSize = true;
            this.chbThemChieuNguocLai.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chbThemChieuNguocLai.Location = new System.Drawing.Point(30, 163);
            this.chbThemChieuNguocLai.Margin = new System.Windows.Forms.Padding(2);
            this.chbThemChieuNguocLai.Name = "chbThemChieuNguocLai";
            this.chbThemChieuNguocLai.Size = new System.Drawing.Size(224, 19);
            this.chbThemChieuNguocLai.TabIndex = 11;
            this.chbThemChieuNguocLai.Text = "Thêm/ Chỉnh sửa chiều ngược lại";
            this.chbThemChieuNguocLai.UseSelectable = true;
            // 
            // btnReload
            // 
            this.btnReload.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(72)))), ((int)(((byte)(24)))));
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(92)))), ((int)(((byte)(44)))));
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.BorderRadius = 7;
            this.btnReload.ButtonText = "CANCEL";
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.DisabledColor = System.Drawing.Color.Gray;
            this.btnReload.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReload.Iconimage = null;
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
            this.btnReload.Location = new System.Drawing.Point(235, 194);
            this.btnReload.Name = "btnReload";
            this.btnReload.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(92)))), ((int)(((byte)(44)))));
            this.btnReload.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(72)))), ((int)(((byte)(24)))));
            this.btnReload.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReload.selected = false;
            this.btnReload.Size = new System.Drawing.Size(79, 36);
            this.btnReload.TabIndex = 43;
            this.btnReload.Text = "CANCEL";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload.Textcolor = System.Drawing.Color.White;
            this.btnReload.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(119)))), ((int)(((byte)(81)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(139)))), ((int)(((byte)(101)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 7;
            this.btnSave.ButtonText = "SAVE";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = null;
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 40D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(138, 194);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(139)))), ((int)(((byte)(101)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(119)))), ((int)(((byte)(81)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(81, 36);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddTuyenDuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 251);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chbThemChieuNguocLai);
            this.Controls.Add(this.cbDiemDen);
            this.Controls.Add(this.cbDiemKhoiHanh);
            this.Controls.Add(this.lblDiemDen);
            this.Controls.Add(this.lblDiemKhoiHanh);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddTuyenDuong";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Thêm/ Chỉnh Sửa Tuyến Đường";
            this.Load += new System.EventHandler(this.AddTuyenDuong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbDiemDen;
        private MetroFramework.Controls.MetroComboBox cbDiemKhoiHanh;
        private System.Windows.Forms.Label lblDiemDen;
        private System.Windows.Forms.Label lblDiemKhoiHanh;
        private MetroFramework.Controls.MetroCheckBox chbThemChieuNguocLai;
        private Bunifu.Framework.UI.BunifuFlatButton btnReload;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
    }
}