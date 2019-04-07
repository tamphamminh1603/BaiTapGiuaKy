namespace QLKS
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btn_DN = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_DN
            // 
            this.btn_DN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DN.Location = new System.Drawing.Point(334, 128);
            this.btn_DN.Name = "btn_DN";
            this.btn_DN.Size = new System.Drawing.Size(77, 32);
            this.btn_DN.TabIndex = 2;
            this.btn_DN.Text = "Đăng Nhập";
            this.btn_DN.UseVisualStyleBackColor = true;
            this.btn_DN.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(428, 128);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(77, 32);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Exit";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTaiKhoan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 52);
            this.panel1.TabIndex = 1;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(183, 16);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(313, 20);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMatKhau);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(6, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 52);
            this.panel3.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(183, 16);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(313, 20);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Thoat);
            this.panel2.Controls.Add(this.btn_DN);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(22, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 183);
            this.panel2.TabIndex = 9;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btn_DN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Thoat;
            this.ClientSize = new System.Drawing.Size(555, 247);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_DN;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}

