namespace PL
{
    partial class PL_Book_Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PL_Book_Return));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ttbNgayTra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ttbSoNgayTT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ttbNgayMuon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ttbTenDocGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ttbMaDocGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvSachMuon = new System.Windows.Forms.DataGridView();
            this.dtgvcMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvcTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvcTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvcTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvcTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvcTriGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvcNhaXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvcNamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 43);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(384, 287);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 32);
            this.button2.TabIndex = 61;
            this.button2.Text = "Lập phiếu thu tiền phạt";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.Location = new System.Drawing.Point(290, 287);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 32);
            this.button4.TabIndex = 59;
            this.button4.Text = "Đóng";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(184, 287);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 58;
            this.button1.Text = "Trả Sách";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(77, 287);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 32);
            this.button3.TabIndex = 57;
            this.button3.Text = "Tra cứu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // ttbNgayTra
            // 
            this.ttbNgayTra.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ttbNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttbNgayTra.Location = new System.Drawing.Point(697, 231);
            this.ttbNgayTra.Margin = new System.Windows.Forms.Padding(2);
            this.ttbNgayTra.Name = "ttbNgayTra";
            this.ttbNgayTra.Size = new System.Drawing.Size(153, 28);
            this.ttbNgayTra.TabIndex = 56;
            this.ttbNgayTra.Text = "17/11/2020";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(594, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 55;
            this.label6.Text = "Ngày trả";
            // 
            // ttbSoNgayTT
            // 
            this.ttbSoNgayTT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ttbSoNgayTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttbSoNgayTT.Location = new System.Drawing.Point(422, 230);
            this.ttbSoNgayTT.Margin = new System.Windows.Forms.Padding(2);
            this.ttbSoNgayTT.Name = "ttbSoNgayTT";
            this.ttbSoNgayTT.Size = new System.Drawing.Size(153, 28);
            this.ttbSoNgayTT.TabIndex = 54;
            this.ttbSoNgayTT.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 53;
            this.label5.Text = "Số ngày trả trễ";
            // 
            // ttbNgayMuon
            // 
            this.ttbNgayMuon.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ttbNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttbNgayMuon.Location = new System.Drawing.Point(697, 190);
            this.ttbNgayMuon.Margin = new System.Windows.Forms.Padding(2);
            this.ttbNgayMuon.Name = "ttbNgayMuon";
            this.ttbNgayMuon.Size = new System.Drawing.Size(153, 28);
            this.ttbNgayMuon.TabIndex = 52;
            this.ttbNgayMuon.Text = "16/11/2020";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(591, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "Ngày mượn";
            // 
            // ttbTenDocGia
            // 
            this.ttbTenDocGia.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ttbTenDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttbTenDocGia.Location = new System.Drawing.Point(422, 191);
            this.ttbTenDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.ttbTenDocGia.Name = "ttbTenDocGia";
            this.ttbTenDocGia.Size = new System.Drawing.Size(153, 28);
            this.ttbTenDocGia.TabIndex = 50;
            this.ttbTenDocGia.Text = "Lê Huỳnh Đức";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Tên độc giả";
            // 
            // ttbMaDocGia
            // 
            this.ttbMaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttbMaDocGia.Location = new System.Drawing.Point(176, 191);
            this.ttbMaDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.ttbMaDocGia.Name = "ttbMaDocGia";
            this.ttbMaDocGia.Size = new System.Drawing.Size(120, 28);
            this.ttbMaDocGia.TabIndex = 48;
            this.ttbMaDocGia.Text = "DG001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "Mã độc giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 37);
            this.label4.TabIndex = 46;
            this.label4.Text = "Nhận trả sách";
            // 
            // dtgvSachMuon
            // 
            this.dtgvSachMuon.AllowUserToAddRows = false;
            this.dtgvSachMuon.AllowUserToDeleteRows = false;
            this.dtgvSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSachMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgvcMaSach,
            this.dtgvcTenSach,
            this.dtgvcTacGia,
            this.dtgvcTheLoai,
            this.dtgvcTinhTrang,
            this.dtgvcTriGia,
            this.dtgvcNhaXB,
            this.dtgvcNamXB});
            this.dtgvSachMuon.Location = new System.Drawing.Point(77, 336);
            this.dtgvSachMuon.Name = "dtgvSachMuon";
            this.dtgvSachMuon.ReadOnly = true;
            this.dtgvSachMuon.RowHeadersVisible = false;
            this.dtgvSachMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSachMuon.Size = new System.Drawing.Size(773, 141);
            this.dtgvSachMuon.TabIndex = 63;
            // 
            // dtgvcMaSach
            // 
            this.dtgvcMaSach.HeaderText = "Mã Sách";
            this.dtgvcMaSach.Name = "dtgvcMaSach";
            this.dtgvcMaSach.ReadOnly = true;
            // 
            // dtgvcTenSach
            // 
            this.dtgvcTenSach.HeaderText = "Tên Sách";
            this.dtgvcTenSach.Name = "dtgvcTenSach";
            this.dtgvcTenSach.ReadOnly = true;
            // 
            // dtgvcTacGia
            // 
            this.dtgvcTacGia.HeaderText = "Tác Giả";
            this.dtgvcTacGia.Name = "dtgvcTacGia";
            this.dtgvcTacGia.ReadOnly = true;
            // 
            // dtgvcTheLoai
            // 
            this.dtgvcTheLoai.HeaderText = "Thể Loại";
            this.dtgvcTheLoai.Name = "dtgvcTheLoai";
            this.dtgvcTheLoai.ReadOnly = true;
            // 
            // dtgvcTinhTrang
            // 
            this.dtgvcTinhTrang.HeaderText = "Tình Trạng";
            this.dtgvcTinhTrang.Name = "dtgvcTinhTrang";
            this.dtgvcTinhTrang.ReadOnly = true;
            // 
            // dtgvcTriGia
            // 
            this.dtgvcTriGia.HeaderText = "Trị Giá";
            this.dtgvcTriGia.Name = "dtgvcTriGia";
            this.dtgvcTriGia.ReadOnly = true;
            // 
            // dtgvcNhaXB
            // 
            this.dtgvcNhaXB.HeaderText = "Nhà Xuất Bản";
            this.dtgvcNhaXB.Name = "dtgvcNhaXB";
            this.dtgvcNhaXB.ReadOnly = true;
            // 
            // dtgvcNamXB
            // 
            this.dtgvcNamXB.HeaderText = "Năm Xuất Bản";
            this.dtgvcNamXB.Name = "dtgvcNamXB";
            this.dtgvcNamXB.ReadOnly = true;
            // 
            // PL_Book_Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 489);
            this.Controls.Add(this.dtgvSachMuon);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ttbNgayTra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ttbSoNgayTT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ttbNgayMuon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ttbTenDocGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ttbMaDocGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "PL_Book_Return";
            this.Text = "PL_Book_Return";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox ttbNgayTra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ttbSoNgayTT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ttbNgayMuon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ttbTenDocGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttbMaDocGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvSachMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvcMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvcTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvcTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvcTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvcTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvcTriGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvcNhaXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvcNamXB;
    }
}