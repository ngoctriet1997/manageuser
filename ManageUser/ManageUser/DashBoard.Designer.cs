namespace ManageUser
{
    partial class DashBoard
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnThongTinCaNhan = new DevExpress.XtraEditors.SimpleButton();
            this.btnCacLoaiNguoiDung = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(1, 37);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(943, 467);
            this.pnlMain.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.btnCacLoaiNguoiDung);
            this.panelControl2.Controls.Add(this.btnThongTinCaNhan);
            this.panelControl2.Location = new System.Drawing.Point(1, 1);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(943, 40);
            this.panelControl2.TabIndex = 15;
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinCaNhan.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.btnThongTinCaNhan.Appearance.Options.UseFont = true;
            this.btnThongTinCaNhan.Appearance.Options.UseForeColor = true;
            this.btnThongTinCaNhan.Location = new System.Drawing.Point(0, 0);
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            this.btnThongTinCaNhan.Size = new System.Drawing.Size(208, 48);
            this.btnThongTinCaNhan.TabIndex = 17;
            this.btnThongTinCaNhan.Text = "Thông tin cá nhân";
            // 
            // btnCacLoaiNguoiDung
            // 
            this.btnCacLoaiNguoiDung.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCacLoaiNguoiDung.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.btnCacLoaiNguoiDung.Appearance.Options.UseFont = true;
            this.btnCacLoaiNguoiDung.Appearance.Options.UseForeColor = true;
            this.btnCacLoaiNguoiDung.Location = new System.Drawing.Point(203, 0);
            this.btnCacLoaiNguoiDung.Name = "btnCacLoaiNguoiDung";
            this.btnCacLoaiNguoiDung.Size = new System.Drawing.Size(208, 48);
            this.btnCacLoaiNguoiDung.TabIndex = 19;
            this.btnCacLoaiNguoiDung.Text = "Các loại người dùng";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 503);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.pnlMain);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnThongTinCaNhan;
        private DevExpress.XtraEditors.SimpleButton btnCacLoaiNguoiDung;
    }
}