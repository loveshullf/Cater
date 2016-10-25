namespace UI
{
    partial class OrderPay
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
            this.gb_Member = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_TypeTitle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Money = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PayMoney = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_TotalMoney = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_Member = new System.Windows.Forms.CheckBox();
            this.gb_Member.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Member
            // 
            this.gb_Member.Controls.Add(this.checkBox2);
            this.gb_Member.Controls.Add(this.lbl_Discount);
            this.gb_Member.Controls.Add(this.label7);
            this.gb_Member.Controls.Add(this.lbl_TypeTitle);
            this.gb_Member.Controls.Add(this.label6);
            this.gb_Member.Controls.Add(this.lbl_Money);
            this.gb_Member.Controls.Add(this.label3);
            this.gb_Member.Controls.Add(this.txt_Phone);
            this.gb_Member.Controls.Add(this.label2);
            this.gb_Member.Controls.Add(this.txt_id);
            this.gb_Member.Controls.Add(this.label1);
            this.gb_Member.Location = new System.Drawing.Point(12, 34);
            this.gb_Member.Name = "gb_Member";
            this.gb_Member.Size = new System.Drawing.Size(230, 142);
            this.gb_Member.TabIndex = 0;
            this.gb_Member.TabStop = false;
            this.gb_Member.Text = "会员信息";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(147, 86);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "使用余额";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Location = new System.Drawing.Point(188, 115);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(11, 12);
            this.lbl_Discount.TabIndex = 9;
            this.lbl_Discount.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "折扣：";
            // 
            // lbl_TypeTitle
            // 
            this.lbl_TypeTitle.AutoSize = true;
            this.lbl_TypeTitle.Location = new System.Drawing.Point(77, 115);
            this.lbl_TypeTitle.Name = "lbl_TypeTitle";
            this.lbl_TypeTitle.Size = new System.Drawing.Size(53, 12);
            this.lbl_TypeTitle.TabIndex = 7;
            this.lbl_TypeTitle.Text = "普通会员";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "会员等级：";
            // 
            // lbl_Money
            // 
            this.lbl_Money.AutoSize = true;
            this.lbl_Money.Location = new System.Drawing.Point(77, 87);
            this.lbl_Money.Name = "lbl_Money";
            this.lbl_Money.Size = new System.Drawing.Size(11, 12);
            this.lbl_Money.TabIndex = 5;
            this.lbl_Money.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "账户余额：";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(89, 53);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(130, 21);
            this.txt_Phone.TabIndex = 3;
            this.txt_Phone.Leave += new System.EventHandler(this.txt_Phone_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "手 机 号：";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(89, 26);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(130, 21);
            this.txt_id.TabIndex = 1;
            this.txt_id.Leave += new System.EventHandler(this.txt_id_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员编号：";
            // 
            // lbl_PayMoney
            // 
            this.lbl_PayMoney.AutoSize = true;
            this.lbl_PayMoney.Location = new System.Drawing.Point(217, 192);
            this.lbl_PayMoney.Name = "lbl_PayMoney";
            this.lbl_PayMoney.Size = new System.Drawing.Size(11, 12);
            this.lbl_PayMoney.TabIndex = 11;
            this.lbl_PayMoney.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(146, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "应收金额：";
            // 
            // lbl_TotalMoney
            // 
            this.lbl_TotalMoney.AutoSize = true;
            this.lbl_TotalMoney.Location = new System.Drawing.Point(81, 192);
            this.lbl_TotalMoney.Name = "lbl_TotalMoney";
            this.lbl_TotalMoney.Size = new System.Drawing.Size(11, 12);
            this.lbl_TotalMoney.TabIndex = 9;
            this.lbl_TotalMoney.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 8;
            this.label12.Text = "消费金额：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "确认结账";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "暂不结账";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cb_Member
            // 
            this.cb_Member.AutoSize = true;
            this.cb_Member.Location = new System.Drawing.Point(12, 12);
            this.cb_Member.Name = "cb_Member";
            this.cb_Member.Size = new System.Drawing.Size(72, 16);
            this.cb_Member.TabIndex = 14;
            this.cb_Member.Text = "是否会员";
            this.cb_Member.UseVisualStyleBackColor = true;
            this.cb_Member.CheckedChanged += new System.EventHandler(this.cb_Member_CheckedChanged);
            // 
            // OrderPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 253);
            this.Controls.Add(this.cb_Member);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_PayMoney);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_TotalMoney);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gb_Member);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "OrderPay";
            this.ShowIcon = false;
            this.Text = "结账";
            this.Load += new System.EventHandler(this.OrderPay_Load);
            this.gb_Member.ResumeLayout(false);
            this.gb_Member.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Member;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_TypeTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Money;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.Label lbl_PayMoney;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_TotalMoney;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox cb_Member;
    }
}