namespace Buoi7
{
    partial class FormThemMoi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxMSHH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxTenHangHoa = new System.Windows.Forms.TextBox();
            this.txtBoxGia = new System.Windows.Forms.TextBox();
            this.rdBtnConHang = new System.Windows.Forms.RadioButton();
            this.rdBtnHetHang = new System.Windows.Forms.RadioButton();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma so hang hoa";
            // 
            // txtBoxMSHH
            // 
            this.txtBoxMSHH.Location = new System.Drawing.Point(147, 32);
            this.txtBoxMSHH.Name = "txtBoxMSHH";
            this.txtBoxMSHH.Size = new System.Drawing.Size(212, 20);
            this.txtBoxMSHH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ten hang hoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tinh trang";
            // 
            // txtBoxTenHangHoa
            // 
            this.txtBoxTenHangHoa.Location = new System.Drawing.Point(147, 73);
            this.txtBoxTenHangHoa.Name = "txtBoxTenHangHoa";
            this.txtBoxTenHangHoa.Size = new System.Drawing.Size(212, 20);
            this.txtBoxTenHangHoa.TabIndex = 5;
            // 
            // txtBoxGia
            // 
            this.txtBoxGia.Location = new System.Drawing.Point(147, 114);
            this.txtBoxGia.Name = "txtBoxGia";
            this.txtBoxGia.Size = new System.Drawing.Size(212, 20);
            this.txtBoxGia.TabIndex = 6;
            // 
            // rdBtnConHang
            // 
            this.rdBtnConHang.AutoSize = true;
            this.rdBtnConHang.Checked = true;
            this.rdBtnConHang.Location = new System.Drawing.Point(147, 159);
            this.rdBtnConHang.Name = "rdBtnConHang";
            this.rdBtnConHang.Size = new System.Drawing.Size(71, 17);
            this.rdBtnConHang.TabIndex = 7;
            this.rdBtnConHang.TabStop = true;
            this.rdBtnConHang.Text = "Con hang";
            this.rdBtnConHang.UseVisualStyleBackColor = true;
            // 
            // rdBtnHetHang
            // 
            this.rdBtnHetHang.AutoSize = true;
            this.rdBtnHetHang.Location = new System.Drawing.Point(238, 159);
            this.rdBtnHetHang.Name = "rdBtnHetHang";
            this.rdBtnHetHang.Size = new System.Drawing.Size(69, 17);
            this.rdBtnHetHang.TabIndex = 8;
            this.rdBtnHetHang.TabStop = true;
            this.rdBtnHetHang.Text = "Het hang";
            this.rdBtnHetHang.UseVisualStyleBackColor = true;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(97, 265);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(91, 23);
            this.btnThemMoi.TabIndex = 9;
            this.btnThemMoi.Text = "Them moi";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(227, 265);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(86, 23);
            this.btnHuyBo.TabIndex = 10;
            this.btnHuyBo.Text = "Huy";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // FormThemMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 352);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.rdBtnHetHang);
            this.Controls.Add(this.rdBtnConHang);
            this.Controls.Add(this.txtBoxGia);
            this.Controls.Add(this.txtBoxTenHangHoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxMSHH);
            this.Controls.Add(this.label1);
            this.Name = "FormThemMoi";
            this.Text = "Form Them Moi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMSHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxTenHangHoa;
        private System.Windows.Forms.TextBox txtBoxGia;
        private System.Windows.Forms.RadioButton rdBtnConHang;
        private System.Windows.Forms.RadioButton rdBtnHetHang;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnHuyBo;

    }
}

