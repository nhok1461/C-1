namespace QuanLyThuVien.process
{
    partial class LuaChon
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
            this.btDocGia = new System.Windows.Forms.Button();
            this.btSách = new System.Windows.Forms.Button();
            this.btPhieuMuon = new System.Windows.Forms.Button();
            this.btThongKe = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDocGia
            // 
            this.btDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDocGia.Location = new System.Drawing.Point(145, 64);
            this.btDocGia.Name = "btDocGia";
            this.btDocGia.Size = new System.Drawing.Size(113, 42);
            this.btDocGia.TabIndex = 0;
            this.btDocGia.Text = "Đọc Giả";
            this.btDocGia.UseVisualStyleBackColor = true;
            // 
            // btSách
            // 
            this.btSách.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSách.Location = new System.Drawing.Point(145, 124);
            this.btSách.Name = "btSách";
            this.btSách.Size = new System.Drawing.Size(113, 41);
            this.btSách.TabIndex = 1;
            this.btSách.Text = "Sách";
            this.btSách.UseVisualStyleBackColor = true;
            // 
            // btPhieuMuon
            // 
            this.btPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPhieuMuon.Location = new System.Drawing.Point(145, 180);
            this.btPhieuMuon.Name = "btPhieuMuon";
            this.btPhieuMuon.Size = new System.Drawing.Size(113, 42);
            this.btPhieuMuon.TabIndex = 2;
            this.btPhieuMuon.Text = "Phiếu Mượn";
            this.btPhieuMuon.UseVisualStyleBackColor = true;
            // 
            // btThongKe
            // 
            this.btThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongKe.Location = new System.Drawing.Point(145, 243);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(113, 44);
            this.btThongKe.TabIndex = 3;
            this.btThongKe.Text = "Thống Kê";
            this.btThongKe.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(315, 334);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(102, 40);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // LuaChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 376);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btThongKe);
            this.Controls.Add(this.btPhieuMuon);
            this.Controls.Add(this.btSách);
            this.Controls.Add(this.btDocGia);
            this.Name = "LuaChon";
            this.Text = "Lựa Chọn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDocGia;
        private System.Windows.Forms.Button btSách;
        private System.Windows.Forms.Button btPhieuMuon;
        private System.Windows.Forms.Button btThongKe;
        private System.Windows.Forms.Button btThoat;
    }
}