namespace UI
{
    partial class TableInfoList
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbTIsFreeSearch = new System.Windows.Forms.ComboBox();
            this.btnSearchAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddHall = new System.Windows.Forms.Button();
            this.cbHallTitleAdd = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTTitleAdd = new System.Windows.Forms.TextBox();
            this.txtTIdAdd = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gv_TableInfoList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbHallTypeSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioIsFree = new System.Windows.Forms.RadioButton();
            this.radioNotFree = new System.Windows.Forms.RadioButton();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TableInfoList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbHallTypeSearch);
            this.groupBox3.Controls.Add(this.cbTIsFreeSearch);
            this.groupBox3.Controls.Add(this.btnSearchAll);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(468, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 114);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "搜索";
            // 
            // cbTIsFreeSearch
            // 
            this.cbTIsFreeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTIsFreeSearch.FormattingEnabled = true;
            this.cbTIsFreeSearch.Location = new System.Drawing.Point(69, 59);
            this.cbTIsFreeSearch.Name = "cbTIsFreeSearch";
            this.cbTIsFreeSearch.Size = new System.Drawing.Size(134, 20);
            this.cbTIsFreeSearch.TabIndex = 19;
            this.cbTIsFreeSearch.SelectedIndexChanged += new System.EventHandler(this.cbTIsFreeSearch_SelectedIndexChanged);
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
            this.label6.Text = "状    态:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "厅    包:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.radioIsFree);
            this.groupBox2.Controls.Add(this.radioNotFree);
            this.groupBox2.Controls.Add(this.btnAddHall);
            this.groupBox2.Controls.Add(this.cbHallTitleAdd);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTTitleAdd);
            this.groupBox2.Controls.Add(this.txtTIdAdd);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(468, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 269);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "添加/删除";
            // 
            // btnAddHall
            // 
            this.btnAddHall.Location = new System.Drawing.Point(69, 107);
            this.btnAddHall.Name = "btnAddHall";
            this.btnAddHall.Size = new System.Drawing.Size(134, 23);
            this.btnAddHall.TabIndex = 17;
            this.btnAddHall.Text = "厅包管理";
            this.btnAddHall.UseVisualStyleBackColor = true;
            this.btnAddHall.Click += new System.EventHandler(this.btnAddHall_Click);
            // 
            // cbHallTitleAdd
            // 
            this.cbHallTitleAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHallTitleAdd.FormattingEnabled = true;
            this.cbHallTitleAdd.Location = new System.Drawing.Point(69, 81);
            this.cbHallTitleAdd.Name = "cbHallTitleAdd";
            this.cbHallTitleAdd.Size = new System.Drawing.Size(134, 20);
            this.cbHallTitleAdd.TabIndex = 16;
            // 
            // btnRemove
            // 
            this.btnRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemove.Location = new System.Drawing.Point(51, 213);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(123, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "删除选中餐桌";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(118, 168);
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
            this.label4.Text = "厅    包:";
            // 
            // txtTTitleAdd
            // 
            this.txtTTitleAdd.Location = new System.Drawing.Point(69, 54);
            this.txtTTitleAdd.Name = "txtTTitleAdd";
            this.txtTTitleAdd.Size = new System.Drawing.Size(134, 21);
            this.txtTTitleAdd.TabIndex = 5;
            // 
            // txtTIdAdd
            // 
            this.txtTIdAdd.Location = new System.Drawing.Point(69, 27);
            this.txtTIdAdd.Name = "txtTIdAdd";
            this.txtTIdAdd.ReadOnly = true;
            this.txtTIdAdd.Size = new System.Drawing.Size(134, 21);
            this.txtTIdAdd.TabIndex = 4;
            this.txtTIdAdd.Text = "添加时无需编号";
            // 
            // btnSave
            // 
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(31, 168);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gv_TableInfoList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 383);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "列表";
            // 
            // gv_TableInfoList
            // 
            this.gv_TableInfoList.AllowUserToAddRows = false;
            this.gv_TableInfoList.AllowUserToDeleteRows = false;
            this.gv_TableInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_TableInfoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.gv_TableInfoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_TableInfoList.Location = new System.Drawing.Point(3, 17);
            this.gv_TableInfoList.MultiSelect = false;
            this.gv_TableInfoList.Name = "gv_TableInfoList";
            this.gv_TableInfoList.ReadOnly = true;
            this.gv_TableInfoList.RowTemplate.Height = 23;
            this.gv_TableInfoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_TableInfoList.Size = new System.Drawing.Size(444, 363);
            this.gv_TableInfoList.TabIndex = 0;
            this.gv_TableInfoList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gv_TableInfoList_CellFormatting);
            this.gv_TableInfoList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_TableInfoList_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TId";
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TTitle";
            this.Column2.HeaderText = "名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HallTitle";
            this.Column3.HeaderText = "厅包";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TIsFree";
            this.Column4.HeaderText = "是否空闲";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // cbHallTypeSearch
            // 
            this.cbHallTypeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHallTypeSearch.FormattingEnabled = true;
            this.cbHallTypeSearch.Location = new System.Drawing.Point(69, 20);
            this.cbHallTypeSearch.Name = "cbHallTypeSearch";
            this.cbHallTypeSearch.Size = new System.Drawing.Size(134, 20);
            this.cbHallTypeSearch.TabIndex = 20;
            this.cbHallTypeSearch.SelectedIndexChanged += new System.EventHandler(this.cbHallTypeSearch_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(6, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "是否空闲:";
            // 
            // radioIsFree
            // 
            this.radioIsFree.AutoSize = true;
            this.radioIsFree.Checked = true;
            this.radioIsFree.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioIsFree.Location = new System.Drawing.Point(71, 146);
            this.radioIsFree.Name = "radioIsFree";
            this.radioIsFree.Size = new System.Drawing.Size(47, 16);
            this.radioIsFree.TabIndex = 19;
            this.radioIsFree.TabStop = true;
            this.radioIsFree.Text = "空闲";
            this.radioIsFree.UseVisualStyleBackColor = true;
            // 
            // radioNotFree
            // 
            this.radioNotFree.AutoSize = true;
            this.radioNotFree.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioNotFree.Location = new System.Drawing.Point(145, 146);
            this.radioNotFree.Name = "radioNotFree";
            this.radioNotFree.Size = new System.Drawing.Size(59, 16);
            this.radioNotFree.TabIndex = 18;
            this.radioNotFree.Text = "非空闲";
            this.radioNotFree.UseVisualStyleBackColor = true;
            // 
            // TableInfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 396);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TableInfoList";
            this.Text = "餐桌管理";
            this.Load += new System.EventHandler(this.TableInfoList_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_TableInfoList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbTIsFreeSearch;
        private System.Windows.Forms.Button btnSearchAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddHall;
        private System.Windows.Forms.ComboBox cbHallTitleAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTTitleAdd;
        private System.Windows.Forms.TextBox txtTIdAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gv_TableInfoList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox cbHallTypeSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioIsFree;
        private System.Windows.Forms.RadioButton radioNotFree;
    }
}