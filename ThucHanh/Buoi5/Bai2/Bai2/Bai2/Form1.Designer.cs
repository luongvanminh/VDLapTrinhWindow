namespace Bai2
{
    partial class FormBai2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxTuSoA = new System.Windows.Forms.TextBox();
            this.txtBoxMauSoA = new System.Windows.Forms.TextBox();
            this.txtBoxTuSoB = new System.Windows.Forms.TextBox();
            this.txtBoxMauSoB = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnCongPhanSo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhap tu so cua phan so a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhap mau so cua phan so a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhap tu so cua phan so b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhap mau so cua phan so b";
            // 
            // txtBoxTuSoA
            // 
            this.txtBoxTuSoA.Location = new System.Drawing.Point(192, 57);
            this.txtBoxTuSoA.Name = "txtBoxTuSoA";
            this.txtBoxTuSoA.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTuSoA.TabIndex = 4;
            // 
            // txtBoxMauSoA
            // 
            this.txtBoxMauSoA.Location = new System.Drawing.Point(192, 89);
            this.txtBoxMauSoA.Name = "txtBoxMauSoA";
            this.txtBoxMauSoA.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMauSoA.TabIndex = 5;
            // 
            // txtBoxTuSoB
            // 
            this.txtBoxTuSoB.Location = new System.Drawing.Point(192, 124);
            this.txtBoxTuSoB.Name = "txtBoxTuSoB";
            this.txtBoxTuSoB.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTuSoB.TabIndex = 6;
            // 
            // txtBoxMauSoB
            // 
            this.txtBoxMauSoB.Location = new System.Drawing.Point(192, 155);
            this.txtBoxMauSoB.Name = "txtBoxMauSoB";
            this.txtBoxMauSoB.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMauSoB.TabIndex = 7;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(137, 206);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(0, 13);
            this.lblKetQua.TabIndex = 8;
            // 
            // btnCongPhanSo
            // 
            this.btnCongPhanSo.Location = new System.Drawing.Point(96, 263);
            this.btnCongPhanSo.Name = "btnCongPhanSo";
            this.btnCongPhanSo.Size = new System.Drawing.Size(138, 23);
            this.btnCongPhanSo.TabIndex = 9;
            this.btnCongPhanSo.Text = "Thuc hien phep cong";
            this.btnCongPhanSo.UseVisualStyleBackColor = true;
            this.btnCongPhanSo.Click += new System.EventHandler(this.btnCongPhanSo_Click);
            // 
            // FormBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 330);
            this.Controls.Add(this.btnCongPhanSo);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtBoxMauSoB);
            this.Controls.Add(this.txtBoxTuSoB);
            this.Controls.Add(this.txtBoxMauSoA);
            this.Controls.Add(this.txtBoxTuSoA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBai2";
            this.Text = "Bai2-Buoi5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxTuSoA;
        private System.Windows.Forms.TextBox txtBoxMauSoA;
        private System.Windows.Forms.TextBox txtBoxTuSoB;
        private System.Windows.Forms.TextBox txtBoxMauSoB;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnCongPhanSo;
    }
}

