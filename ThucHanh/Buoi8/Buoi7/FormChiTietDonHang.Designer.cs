namespace Buoi7
{
    partial class FormChiTietDonHang
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
            this.lstViewDSThucUong = new System.Windows.Forms.ListView();
            this.btnThemMoiThucUong = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxMSHH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxSoLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxTiLeGiam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstViewDSThucUong
            // 
            this.lstViewDSThucUong.Location = new System.Drawing.Point(12, 12);
            this.lstViewDSThucUong.Name = "lstViewDSThucUong";
            this.lstViewDSThucUong.Size = new System.Drawing.Size(430, 274);
            this.lstViewDSThucUong.TabIndex = 1;
            this.lstViewDSThucUong.UseCompatibleStateImageBehavior = false;
            this.lstViewDSThucUong.View = System.Windows.Forms.View.Details;
            // 
            // btnThemMoiThucUong
            // 
            this.btnThemMoiThucUong.Location = new System.Drawing.Point(630, 167);
            this.btnThemMoiThucUong.Name = "btnThemMoiThucUong";
            this.btnThemMoiThucUong.Size = new System.Drawing.Size(163, 23);
            this.btnThemMoiThucUong.TabIndex = 2;
            this.btnThemMoiThucUong.Text = "Them thuc uong";
            this.btnThemMoiThucUong.UseVisualStyleBackColor = true;
            this.btnThemMoiThucUong.Click += new System.EventHandler(this.btnThemMoiThucUong_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(662, 217);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(163, 23);
            this.btnHuyBo.TabIndex = 4;
            this.btnHuyBo.Text = "Huy bo";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnDatHang
            // 
            this.btnDatHang.Location = new System.Drawing.Point(478, 217);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(163, 23);
            this.btnDatHang.TabIndex = 5;
            this.btnDatHang.Text = "Dat hang";
            this.btnDatHang.UseVisualStyleBackColor = true;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "MSHH";
            // 
            // txtBoxMSHH
            // 
            this.txtBoxMSHH.Location = new System.Drawing.Point(577, 34);
            this.txtBoxMSHH.Name = "txtBoxMSHH";
            this.txtBoxMSHH.Size = new System.Drawing.Size(272, 20);
            this.txtBoxMSHH.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "So luong";
            // 
            // txtBoxSoLuong
            // 
            this.txtBoxSoLuong.Location = new System.Drawing.Point(577, 79);
            this.txtBoxSoLuong.Name = "txtBoxSoLuong";
            this.txtBoxSoLuong.Size = new System.Drawing.Size(272, 20);
            this.txtBoxSoLuong.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ti le giam";
            // 
            // txtBoxTiLeGiam
            // 
            this.txtBoxTiLeGiam.Location = new System.Drawing.Point(577, 130);
            this.txtBoxTiLeGiam.Name = "txtBoxTiLeGiam";
            this.txtBoxTiLeGiam.Size = new System.Drawing.Size(272, 20);
            this.txtBoxTiLeGiam.TabIndex = 11;
            // 
            // FormChiTietDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 430);
            this.Controls.Add(this.txtBoxTiLeGiam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxSoLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxMSHH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnThemMoiThucUong);
            this.Controls.Add(this.lstViewDSThucUong);
            this.Name = "FormChiTietDonHang";
            this.Text = "Chi Tiet Don Hang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewDSThucUong;
        private System.Windows.Forms.Button btnThemMoiThucUong;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMSHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxTiLeGiam;
    }
}

