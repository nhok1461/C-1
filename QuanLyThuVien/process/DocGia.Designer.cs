namespace QuanLyThuVien.process
{
    partial class DocGia
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mãĐọcGiảDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tênĐọcGiảDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sĐTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.đọcGiảBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVDataSet = new QuanLyThuVien.QLTVDataSet();
            this.đọcGiảTableAdapter = new QuanLyThuVien.QLTVDataSetTableAdapters.ĐọcGiảTableAdapter();
            this.btNhap = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.lbMaDocGia = new System.Windows.Forms.Label();
            this.lbTenDocGia = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbNamSinh = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btQuayLai = new System.Windows.Forms.Button();
            this.tbMaDocGia = new System.Windows.Forms.TextBox();
            this.tbTenDocGia = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbSex = new System.Windows.Forms.TextBox();
            this.dtNamSinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.đọcGiảBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mãĐọcGiảDataGridViewTextBoxColumn,
            this.tênĐọcGiảDataGridViewTextBoxColumn,
            this.sĐTDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.đọcGiảBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 194);
            this.dataGridView1.TabIndex = 0;
            // 
            // mãĐọcGiảDataGridViewTextBoxColumn
            // 
            this.mãĐọcGiảDataGridViewTextBoxColumn.DataPropertyName = "Mã Đọc Giả";
            this.mãĐọcGiảDataGridViewTextBoxColumn.HeaderText = "Mã Đọc Giả";
            this.mãĐọcGiảDataGridViewTextBoxColumn.Name = "mãĐọcGiảDataGridViewTextBoxColumn";
            // 
            // tênĐọcGiảDataGridViewTextBoxColumn
            // 
            this.tênĐọcGiảDataGridViewTextBoxColumn.DataPropertyName = "Tên Đọc Giả";
            this.tênĐọcGiảDataGridViewTextBoxColumn.HeaderText = "Tên Đọc Giả";
            this.tênĐọcGiảDataGridViewTextBoxColumn.Name = "tênĐọcGiảDataGridViewTextBoxColumn";
            // 
            // sĐTDataGridViewTextBoxColumn
            // 
            this.sĐTDataGridViewTextBoxColumn.DataPropertyName = "SĐT";
            this.sĐTDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.sĐTDataGridViewTextBoxColumn.Name = "sĐTDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // đọcGiảBindingSource
            // 
            this.đọcGiảBindingSource.DataMember = "ĐọcGiả";
            this.đọcGiảBindingSource.DataSource = this.qLTVDataSet;
            // 
            // qLTVDataSet
            // 
            this.qLTVDataSet.DataSetName = "QLTVDataSet";
            this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // đọcGiảTableAdapter
            // 
            this.đọcGiảTableAdapter.ClearBeforeFill = true;
            // 
            // btNhap
            // 
            this.btNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhap.Location = new System.Drawing.Point(12, 52);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(75, 31);
            this.btNhap.TabIndex = 1;
            this.btNhap.Text = "Nhập";
            this.btNhap.UseVisualStyleBackColor = true;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(509, 52);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(97, 31);
            this.btTimKiem.TabIndex = 2;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(137, 52);
            this.txtCommand.Multiline = true;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(339, 31);
            this.txtCommand.TabIndex = 3;
            // 
            // lbMaDocGia
            // 
            this.lbMaDocGia.AutoSize = true;
            this.lbMaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaDocGia.Location = new System.Drawing.Point(12, 173);
            this.lbMaDocGia.Name = "lbMaDocGia";
            this.lbMaDocGia.Size = new System.Drawing.Size(84, 16);
            this.lbMaDocGia.TabIndex = 4;
            this.lbMaDocGia.Text = "Mã Đọc Giả :";
            // 
            // lbTenDocGia
            // 
            this.lbTenDocGia.AutoSize = true;
            this.lbTenDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDocGia.Location = new System.Drawing.Point(12, 213);
            this.lbTenDocGia.Name = "lbTenDocGia";
            this.lbTenDocGia.Size = new System.Drawing.Size(89, 16);
            this.lbTenDocGia.TabIndex = 5;
            this.lbTenDocGia.Text = "Tên Đọc Giả :";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(2, 260);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(99, 16);
            this.lbSDT.TabIndex = 6;
            this.lbSDT.Text = "Số Điện Thoại :";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(349, 169);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(39, 16);
            this.lbMail.TabIndex = 7;
            this.lbMail.Text = "Mail :";
            // 
            // lbNamSinh
            // 
            this.lbNamSinh.AutoSize = true;
            this.lbNamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamSinh.Location = new System.Drawing.Point(349, 213);
            this.lbNamSinh.Name = "lbNamSinh";
            this.lbNamSinh.Size = new System.Drawing.Size(72, 16);
            this.lbNamSinh.TabIndex = 8;
            this.lbNamSinh.Text = "Năm Sinh :";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSex.Location = new System.Drawing.Point(349, 263);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(67, 16);
            this.lbSex.TabIndex = 9;
            this.lbSex.Text = "Giới Tính :";
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(15, 105);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 35);
            this.btAdd.TabIndex = 10;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(266, 105);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 35);
            this.btEdit.TabIndex = 11;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btDel
            // 
            this.btDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.Location = new System.Drawing.Point(509, 105);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 35);
            this.btDel.TabIndex = 12;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = true;
            // 
            // btQuayLai
            // 
            this.btQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuayLai.Location = new System.Drawing.Point(563, 3);
            this.btQuayLai.Name = "btQuayLai";
            this.btQuayLai.Size = new System.Drawing.Size(96, 27);
            this.btQuayLai.TabIndex = 13;
            this.btQuayLai.Text = "Quay Lại";
            this.btQuayLai.UseVisualStyleBackColor = true;
            this.btQuayLai.Click += new System.EventHandler(this.btQuayLai_Click);
            // 
            // tbMaDocGia
            // 
            this.tbMaDocGia.Location = new System.Drawing.Point(102, 169);
            this.tbMaDocGia.Name = "tbMaDocGia";
            this.tbMaDocGia.Size = new System.Drawing.Size(210, 20);
            this.tbMaDocGia.TabIndex = 14;
            // 
            // tbTenDocGia
            // 
            this.tbTenDocGia.Location = new System.Drawing.Point(102, 212);
            this.tbTenDocGia.Name = "tbTenDocGia";
            this.tbTenDocGia.Size = new System.Drawing.Size(210, 20);
            this.tbTenDocGia.TabIndex = 15;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(102, 256);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(210, 20);
            this.tbSDT.TabIndex = 16;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(431, 169);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(175, 20);
            this.tbMail.TabIndex = 17;
            // 
            // tbSex
            // 
            this.tbSex.Location = new System.Drawing.Point(431, 259);
            this.tbSex.Name = "tbSex";
            this.tbSex.Size = new System.Drawing.Size(175, 20);
            this.tbSex.TabIndex = 19;
            // 
            // dtNamSinh
            // 
            this.dtNamSinh.Location = new System.Drawing.Point(431, 212);
            this.dtNamSinh.Name = "dtNamSinh";
            this.dtNamSinh.Size = new System.Drawing.Size(200, 20);
            this.dtNamSinh.TabIndex = 20;
            // 
            // DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 513);
            this.Controls.Add(this.dtNamSinh);
            this.Controls.Add(this.tbSex);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.tbTenDocGia);
            this.Controls.Add(this.tbMaDocGia);
            this.Controls.Add(this.btQuayLai);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.lbNamSinh);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.lbTenDocGia);
            this.Controls.Add(this.lbMaDocGia);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.btNhap);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DocGia";
            this.Text = "Đọc Giả";
            this.Load += new System.EventHandler(this.DocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.đọcGiảBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource đọcGiảBindingSource;
        private QLTVDataSetTableAdapters.ĐọcGiảTableAdapter đọcGiảTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãĐọcGiảDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênĐọcGiảDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sĐTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Label lbMaDocGia;
        private System.Windows.Forms.Label lbTenDocGia;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label lbNamSinh;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btQuayLai;
        private System.Windows.Forms.TextBox tbMaDocGia;
        private System.Windows.Forms.TextBox tbTenDocGia;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbSex;
        private System.Windows.Forms.DateTimePicker dtNamSinh;
    }
}