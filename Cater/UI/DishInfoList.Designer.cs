namespace UI
{
    partial class DishInfoList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gv_DishInfoList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbTypeTitleSearch = new System.Windows.Forms.ComboBox();
            this.btnSearchAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDTitleSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddType = new System.Windows.Forms.Button();
            this.cbTypeTitleAdd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDCharAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDPriceAdd = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDTitleAdd = new System.Windows.Forms.TextBox();
            this.txtDId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DishInfoList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gv_DishInfoList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 383);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "列表";
            // 
            // gv_DishInfoList
            // 
            this.gv_DishInfoList.AllowUserToAddRows = false;
            this.gv_DishInfoList.AllowUserToDeleteRows = false;
            this.gv_DishInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_DishInfoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gv_DishInfoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_DishInfoList.Location = new System.Drawing.Point(3, 17);
            this.gv_DishInfoList.MultiSelect = false;
            this.gv_DishInfoList.Name = "gv_DishInfoList";
            this.gv_DishInfoList.ReadOnly = true;
            this.gv_DishInfoList.RowTemplate.Height = 23;
            this.gv_DishInfoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_DishInfoList.Size = new System.Drawing.Size(545, 363);
            this.gv_DishInfoList.TabIndex = 0;
            this.gv_DishInfoList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_DishInfoList_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DId";
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
            this.Column3.DataPropertyName = "TypeTitle";
            this.Column3.HeaderText = "分类";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DPrice";
            this.Column4.HeaderText = "价格";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DChar";
            this.Column5.HeaderText = "拼音";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbTypeTitleSearch);
            this.groupBox3.Controls.Add(this.btnSearchAll);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtDTitleSearch);
            this.groupBox3.Location = new System.Drawing.Point(569, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 114);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "搜索";
            // 
            // cbTypeTitleSearch
            // 
            this.cbTypeTitleSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeTitleSearch.FormattingEnabled = true;
            this.cbTypeTitleSearch.Location = new System.Drawing.Point(69, 59);
            this.cbTypeTitleSearch.Name = "cbTypeTitleSearch";
            this.cbTypeTitleSearch.Size = new System.Drawing.Size(134, 20);
            this.cbTypeTitleSearch.TabIndex = 19;
            this.cbTypeTitleSearch.SelectedIndexChanged += new System.EventHandler(this.cbTypeTitleSearch_SelectedIndexChanged);
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.Location = new System.Drawing.Point(69, 85);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(134, 23);
            this.btnSearchAll.TabIndex = 18;
            this.btnSearchAll.Text = "显示所有";
            this.btnSearchAll.UseVisualStyleBackColor = true;
            this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "分    类:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "名    称:";
            // 
            // txtDTitleSearch
            // 
            this.txtDTitleSearch.Location = new System.Drawing.Point(69, 20);
            this.txtDTitleSearch.Name = "txtDTitleSearch";
            this.txtDTitleSearch.Size = new System.Drawing.Size(134, 21);
            this.txtDTitleSearch.TabIndex = 5;
            this.txtDTitleSearch.Leave += new System.EventHandler(this.txtDTitleSearch_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddType);
            this.groupBox2.Controls.Add(this.cbTypeTitleAdd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDCharAdd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDPriceAdd);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDTitleAdd);
            this.groupBox2.Controls.Add(this.txtDId);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(569, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 269);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "添加/删除";
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(69, 107);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(134, 23);
            this.btnAddType.TabIndex = 17;
            this.btnAddType.Text = "分类管理";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // cbTypeTitleAdd
            // 
            this.cbTypeTitleAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeTitleAdd.FormattingEnabled = true;
            this.cbTypeTitleAdd.Location = new System.Drawing.Point(69, 81);
            this.cbTypeTitleAdd.Name = "cbTypeTitleAdd";
            this.cbTypeTitleAdd.Size = new System.Drawing.Size(134, 20);
            this.cbTypeTitleAdd.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(4, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "拼    音:";
            // 
            // txtDCharAdd
            // 
            this.txtDCharAdd.Location = new System.Drawing.Point(69, 163);
            this.txtDCharAdd.Name = "txtDCharAdd";
            this.txtDCharAdd.Size = new System.Drawing.Size(134, 21);
            this.txtDCharAdd.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(4, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "价    格:";
            // 
            // txtDPriceAdd
            // 
            this.txtDPriceAdd.Location = new System.Drawing.Point(69, 136);
            this.txtDPriceAdd.Name = "txtDPriceAdd";
            this.txtDPriceAdd.Size = new System.Drawing.Size(134, 21);
            this.txtDPriceAdd.TabIndex = 12;
            // 
            // btnRemove
            // 
            this.btnRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemove.Location = new System.Drawing.Point(54, 235);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(123, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "删除选中菜";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(121, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(4, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "分    类:";
            // 
            // txtDTitleAdd
            // 
            this.txtDTitleAdd.Location = new System.Drawing.Point(69, 54);
            this.txtDTitleAdd.Name = "txtDTitleAdd";
            this.txtDTitleAdd.Size = new System.Drawing.Size(134, 21);
            this.txtDTitleAdd.TabIndex = 5;
            this.txtDTitleAdd.TextChanged += new System.EventHandler(this.txtDTitleAdd_TextChanged);
            // 
            // txtDId
            // 
            this.txtDId.Location = new System.Drawing.Point(69, 27);
            this.txtDId.Name = "txtDId";
            this.txtDId.ReadOnly = true;
            this.txtDId.Size = new System.Drawing.Size(134, 21);
            this.txtDId.TabIndex = 4;
            this.txtDId.Text = "添加时无需编号";
            // 
            // btnSave
            // 
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(34, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "添加";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(4, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "名    称:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编    号:";
            // 
            // DishInfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 400);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DishInfoList";
            this.Text = "菜单管理";
            this.Load += new System.EventHandler(this.DishInfoList_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_DishInfoList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gv_DishInfoList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSearchAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDTitleSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.ComboBox cbTypeTitleAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDCharAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDPriceAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDTitleAdd;
        private System.Windows.Forms.TextBox txtDId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTypeTitleSearch;
    }
}