﻿namespace Bai2
{
    partial class FrmThemSinhVien
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
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiemHoa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiemLy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiemToan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(126, 67);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(282, 21);
            this.cboLop.TabIndex = 16;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(12, 195);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(396, 23);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lớp";
            // 
            // txtDiemHoa
            // 
            this.txtDiemHoa.Location = new System.Drawing.Point(126, 160);
            this.txtDiemHoa.Name = "txtDiemHoa";
            this.txtDiemHoa.Size = new System.Drawing.Size(282, 20);
            this.txtDiemHoa.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Điểm hóa";
            // 
            // txtDiemLy
            // 
            this.txtDiemLy.Location = new System.Drawing.Point(126, 129);
            this.txtDiemLy.Name = "txtDiemLy";
            this.txtDiemLy.Size = new System.Drawing.Size(282, 20);
            this.txtDiemLy.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Điểm lý";
            // 
            // txtDiemToan
            // 
            this.txtDiemToan.Location = new System.Drawing.Point(126, 98);
            this.txtDiemToan.Name = "txtDiemToan";
            this.txtDiemToan.Size = new System.Drawing.Size(282, 20);
            this.txtDiemToan.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Điểm toán";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(126, 36);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(282, 20);
            this.txtTenSV.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên sinh viên";
            // 
            // txtMSV
            // 
            this.txtMSV.Location = new System.Drawing.Point(126, 5);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(282, 20);
            this.txtMSV.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã sinh viên";
            // 
            // FrmThemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 223);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiemHoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiemLy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiemToan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMSV);
            this.Controls.Add(this.label1);
            this.Name = "FrmThemSinhVien";
            this.Text = "Thêm sinh viên";
            this.Load += new System.EventHandler(this.FrmThemSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiemHoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiemLy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiemToan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.Label label1;
    }
}