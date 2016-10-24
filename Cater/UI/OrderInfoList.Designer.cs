namespace UI
{
    partial class OrderInfoList
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
            this.gv_DishInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_DishType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TitleChar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_TotalMoney = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gv_OrderDetailInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_XiaDan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DishInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_OrderDetailInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_DishInfo
            // 
            this.gv_DishInfo.AllowUserToAddRows = false;
            this.gv_DishInfo.AllowUserToDeleteRows = false;
            this.gv_DishInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_DishInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gv_DishInfo.Location = new System.Drawing.Point(0, 40);
            this.gv_DishInfo.MultiSelect = false;
            this.gv_DishInfo.Name = "gv_DishInfo";
            this.gv_DishInfo.ReadOnly = true;
            this.gv_DishInfo.RowTemplate.Height = 23;
            this.gv_DishInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_DishInfo.Size = new System.Drawing.Size(524, 423);
            this.gv_DishInfo.TabIndex = 0;
            this.gv_DishInfo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_DishInfo_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Did";
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DTitle";
            this.Column2.HeaderText = "名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DPrice";
            this.Column3.HeaderText = "价格";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DTypeId";
            this.Column4.HeaderText = "分类";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DChar";
            this.Column5.HeaderText = "首字母";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_DishType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_TitleChar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gv_DishInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 469);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜单";
            // 
            // cb_DishType
            // 
            this.cb_DishType.FormattingEnabled = true;
            this.cb_DishType.Location = new System.Drawing.Point(338, 14);
            this.cb_DishType.Name = "cb_DishType";
            this.cb_DishType.Size = new System.Drawing.Size(183, 20);
            this.cb_DishType.TabIndex = 4;
            this.cb_DishType.SelectedIndexChanged += new System.EventHandler(this.cb_DishType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "菜品分类";
            // 
            // txt_TitleChar
            // 
            this.txt_TitleChar.Location = new System.Drawing.Point(77, 14);
            this.txt_TitleChar.Name = "txt_TitleChar";
            this.txt_TitleChar.Size = new System.Drawing.Size(196, 21);
            this.txt_TitleChar.TabIndex = 2;
            this.txt_TitleChar.TextChanged += new System.EventHandler(this.txt_TitleChar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "菜单首字母";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_XiaDan);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbl_TotalMoney);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.gv_OrderDetailInfo);
            this.groupBox2.Location = new System.Drawing.Point(545, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 469);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "菜单";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(269, 14);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "删除选中行";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(65, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "￥";
            // 
            // lbl_TotalMoney
            // 
            this.lbl_TotalMoney.AutoSize = true;
            this.lbl_TotalMoney.ForeColor = System.Drawing.Color.Red;
            this.lbl_TotalMoney.Location = new System.Drawing.Point(88, 17);
            this.lbl_TotalMoney.Name = "lbl_TotalMoney";
            this.lbl_TotalMoney.Size = new System.Drawing.Size(0, 12);
            this.lbl_TotalMoney.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "已消费：";
            // 
            // gv_OrderDetailInfo
            // 
            this.gv_OrderDetailInfo.AllowUserToAddRows = false;
            this.gv_OrderDetailInfo.AllowUserToDeleteRows = false;
            this.gv_OrderDetailInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_OrderDetailInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.gv_OrderDetailInfo.Location = new System.Drawing.Point(0, 40);
            this.gv_OrderDetailInfo.MultiSelect = false;
            this.gv_OrderDetailInfo.Name = "gv_OrderDetailInfo";
            this.gv_OrderDetailInfo.RowTemplate.Height = 23;
            this.gv_OrderDetailInfo.Size = new System.Drawing.Size(445, 417);
            this.gv_OrderDetailInfo.TabIndex = 0;
            this.gv_OrderDetailInfo.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_OrderDetailInfo_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OId";
            this.dataGridViewTextBoxColumn1.HeaderText = "编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DishTitle";
            this.dataGridViewTextBoxColumn2.HeaderText = "名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DishPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "价格";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn4.HeaderText = "数量";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btn_XiaDan
            // 
            this.btn_XiaDan.Location = new System.Drawing.Point(350, 14);
            this.btn_XiaDan.Name = "btn_XiaDan";
            this.btn_XiaDan.Size = new System.Drawing.Size(75, 23);
            this.btn_XiaDan.TabIndex = 5;
            this.btn_XiaDan.Text = "下单";
            this.btn_XiaDan.UseVisualStyleBackColor = true;
            this.btn_XiaDan.Click += new System.EventHandler(this.btn_XiaDan_Click);
            // 
            // OrderInfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 481);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderInfoList";
            this.Text = "开单/点菜";
            this.Load += new System.EventHandler(this.OrderInfoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_DishInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_OrderDetailInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_DishInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cb_DishType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TitleChar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gv_OrderDetailInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lbl_TotalMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btn_XiaDan;
    }
}