namespace Buoi7
{
    partial class Buoi7
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
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXoaThucUong = new System.Windows.Forms.Button();
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
            this.btnThemMoiThucUong.Location = new System.Drawing.Point(478, 12);
            this.btnThemMoiThucUong.Name = "btnThemMoiThucUong";
            this.btnThemMoiThucUong.Size = new System.Drawing.Size(163, 23);
            this.btnThemMoiThucUong.TabIndex = 2;
            this.btnThemMoiThucUong.Text = "Them thuc uong";
            this.btnThemMoiThucUong.UseVisualStyleBackColor = true;
            this.btnThemMoiThucUong.Click += new System.EventHandler(this.btnThemMoiThucUong_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(478, 53);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(163, 23);
            this.btnChinhSua.TabIndex = 3;
            this.btnChinhSua.Text = "Chinh sua thuc uong";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnXoaThucUong
            // 
            this.btnXoaThucUong.Location = new System.Drawing.Point(478, 92);
            this.btnXoaThucUong.Name = "btnXoaThucUong";
            this.btnXoaThucUong.Size = new System.Drawing.Size(163, 23);
            this.btnXoaThucUong.TabIndex = 4;
            this.btnXoaThucUong.Text = "Xoa thuc uong";
            this.btnXoaThucUong.UseVisualStyleBackColor = true;
            this.btnXoaThucUong.Click += new System.EventHandler(this.btnXoaThucUong_Click);
            // 
            // Buoi7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 430);
            this.Controls.Add(this.btnXoaThucUong);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnThemMoiThucUong);
            this.Controls.Add(this.lstViewDSThucUong);
            this.Name = "Buoi7";
            this.Text = "Buoi7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstViewDSThucUong;
        private System.Windows.Forms.Button btnThemMoiThucUong;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXoaThucUong;
    }
}

