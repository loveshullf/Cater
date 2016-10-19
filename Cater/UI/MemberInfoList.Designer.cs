namespace UI
{
    partial class MemberInfoList
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddType = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMoneyAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneAdd = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameAdd = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gv_MemberInfoList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearchAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhoneSearch = new System.Windows.Forms.TextBox();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_MemberInfoList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddType);
            this.groupBox2.Controls.Add(this.cbType);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMoneyAdd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPhoneAdd);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNameAdd);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(570, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 259);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "添加/删除";
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(69, 107);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(134, 23);
            this.btnAddType.TabIndex = 17;
            this.btnAddType.Text = "会员类型管理";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(69, 81);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(134, 20);
            this.cbType.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(4, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "余    额:";
            // 
            // txtMoneyAdd
            // 
            this.txtMoneyAdd.Location = new System.Drawing.Point(69, 163);
            this.txtMoneyAdd.Name = "txtMoneyAdd";
            this.txtMoneyAdd.Size = new System.Drawing.Size(134, 21);
            this.txtMoneyAdd.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(4, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "手机号码:";
            // 
            // txtPhoneAdd
            // 
            this.txtPhoneAdd.Location = new System.Drawing.Point(69, 136);
            this.txtPhoneAdd.Name = "txtPhoneAdd";
            this.txtPhoneAdd.Size = new System.Drawing.Size(134, 21);
            this.txtPhoneAdd.TabIndex = 12;
            // 
            // btnRemove
            // 
            this.btnRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemove.Location = new System.Drawing.Point(54, 219);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(123, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "删除选中会员";
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
            this.label4.Text = "会员类型:";
            // 
            // txtNameAdd
            // 
            this.txtNameAdd.Location = new System.Drawing.Point(69, 54);
            this.txtNameAdd.Name = "txtNameAdd";
            this.txtNameAdd.Size = new System.Drawing.Size(134, 21);
            this.txtNameAdd.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(69, 27);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(134, 21);
            this.txtId.TabIndex = 4;
            this.txtId.Text = "添加时无需编号";
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
            this.label3.Text = "姓    名:";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gv_MemberInfoList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 379);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "列表";
            // 
            // gv_MemberInfoList
            // 
            this.gv_MemberInfoList.AllowUserToAddRows = false;
            this.gv_MemberInfoList.AllowUserToDeleteRows = false;
            this.gv_MemberInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_MemberInfoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gv_MemberInfoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_MemberInfoList.Location = new System.Drawing.Point(3, 17);
            this.gv_MemberInfoList.MultiSelect = false;
            this.gv_MemberInfoList.Name = "gv_MemberInfoList";
            this.gv_MemberInfoList.ReadOnly = true;
            this.gv_MemberInfoList.RowTemplate.Height = 23;
            this.gv_MemberInfoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_MemberInfoList.Size = new System.Drawing.Size(546, 359);
            this.gv_MemberInfoList.TabIndex = 0;
            this.gv_MemberInfoList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_MemberInfoList_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MId";
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MName";
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TyptTitle";
            this.Column3.HeaderText = "类型";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Mphone";
            this.Column4.HeaderText = "手机号";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MMoney";
            this.Column5.HeaderText = "账户余额";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearchAll);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtPhoneSearch);
            this.groupBox3.Controls.Add(this.txtNameSearch);
            this.groupBox3.Location = new System.Drawing.Point(570, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 114);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "搜索";
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.Location = new System.Drawing.Point(69, 85);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(134, 23);
            this.btnSearchAll.TabIndex = 18;
            this.btnSearchAll.Text = "显示全部";
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
            this.label6.Text = "手机号码:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "姓    名:";
            // 
            // txtPhoneSearch
            // 
            this.txtPhoneSearch.Location = new System.Drawing.Point(69, 60);
            this.txtPhoneSearch.Name = "txtPhoneSearch";
            this.txtPhoneSearch.Size = new System.Drawing.Size(134, 21);
            this.txtPhoneSearch.TabIndex = 6;
            this.txtPhoneSearch.Leave += new System.EventHandler(this.txtPhoneSearch_Leave);
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(69, 20);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(134, 21);
            this.txtNameSearch.TabIndex = 5;
            this.txtNameSearch.Leave += new System.EventHandler(this.txtNameSearch_Leave);
            // 
            // MemberInfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 394);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MemberInfoList";
            this.ShowIcon = false;
            this.Text = "会员管理";
            this.Load += new System.EventHandler(this.MemberInfoList_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_MemberInfoList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameAdd;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gv_MemberInfoList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPhoneSearch;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMoneyAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhoneAdd;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearchAll;
        private System.Windows.Forms.Button btnAddType;
    }
}