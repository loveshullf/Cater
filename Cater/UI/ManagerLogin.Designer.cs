namespace UI
{
    partial class ManagerLogin
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(100, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 29);
            this.txtName.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd.Location = new System.Drawing.Point(100, 76);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(147, 29);
            this.txtPwd.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(58, 121);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(147, 121);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // ManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(265, 158);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.MaximizeBox = false;
            this.Name = "ManagerLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "店员登录";
            this.Load += new System.EventHandler(this.ManagerLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnQuit;
    }
}