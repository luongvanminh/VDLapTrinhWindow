namespace Buoi7
{
    partial class FormXoaThucUong
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
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma so hang hoa can xoa";
            // 
            // txtBoxMSHH
            // 
            this.txtBoxMSHH.Location = new System.Drawing.Point(147, 32);
            this.txtBoxMSHH.Name = "txtBoxMSHH";
            this.txtBoxMSHH.Size = new System.Drawing.Size(212, 20);
            this.txtBoxMSHH.TabIndex = 1;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(79, 94);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(91, 23);
            this.btnThemMoi.TabIndex = 9;
            this.btnThemMoi.Text = "Xoa";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(220, 94);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(86, 23);
            this.btnHuyBo.TabIndex = 10;
            this.btnHuyBo.Text = "Huy";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // FormXoaThucUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 148);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.txtBoxMSHH);
            this.Controls.Add(this.label1);
            this.Name = "FormXoaThucUong";
            this.Text = "Form Xoa Hang Hoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMSHH;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnHuyBo;

    }
}

