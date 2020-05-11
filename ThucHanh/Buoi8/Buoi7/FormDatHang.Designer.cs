namespace Buoi7
{
    partial class FormDatHang
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
            this.txtBoxMSDH = new System.Windows.Forms.TextBox();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma so don hang";
            // 
            // txtBoxMSDH
            // 
            this.txtBoxMSDH.Location = new System.Drawing.Point(147, 32);
            this.txtBoxMSDH.Name = "txtBoxMSDH";
            this.txtBoxMSDH.Size = new System.Drawing.Size(212, 20);
            this.txtBoxMSDH.TabIndex = 1;
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(79, 94);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(91, 23);
            this.btnTaoMoi.TabIndex = 9;
            this.btnTaoMoi.Text = "Tao moi";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
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
            // FormDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 148);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.txtBoxMSDH);
            this.Controls.Add(this.label1);
            this.Name = "FormDatHang";
            this.Text = "Form Dat Hang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMSDH;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnHuyBo;

    }
}

