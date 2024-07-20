namespace Bai2
{
    partial class Form1
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
            this.dgvDanhSachSinhVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLopHoc = new System.Windows.Forms.ComboBox();
            this.btnThemSinhVien = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachSinhVien
            // 
            this.dgvDanhSachSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachSinhVien.Location = new System.Drawing.Point(0, 215);
            this.dgvDanhSachSinhVien.Name = "dgvDanhSachSinhVien";
            this.dgvDanhSachSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachSinhVien.Size = new System.Drawing.Size(700, 249);
            this.dgvDanhSachSinhVien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lớp";
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.FormattingEnabled = true;
            this.cboLopHoc.Location = new System.Drawing.Point(12, 25);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(676, 21);
            this.cboLopHoc.TabIndex = 2;
            this.cboLopHoc.SelectedIndexChanged += new System.EventHandler(this.cboLopHoc_SelectedIndexChanged);
            // 
            // btnThemSinhVien
            // 
            this.btnThemSinhVien.Location = new System.Drawing.Point(12, 52);
            this.btnThemSinhVien.Name = "btnThemSinhVien";
            this.btnThemSinhVien.Size = new System.Drawing.Size(123, 23);
            this.btnThemSinhVien.TabIndex = 3;
            this.btnThemSinhVien.Text = "Thêm sinh viên";
            this.btnThemSinhVien.UseVisualStyleBackColor = true;
            this.btnThemSinhVien.Click += new System.EventHandler(this.btnThemSinhVien_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(141, 52);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 464);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemSinhVien);
            this.Controls.Add(this.cboLopHoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachSinhVien);
            this.Name = "Form1";
            this.Text = "Quản lý sinh viên";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachSinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLopHoc;
        private System.Windows.Forms.Button btnThemSinhVien;
        private System.Windows.Forms.Button btnXoa;
    }
}

