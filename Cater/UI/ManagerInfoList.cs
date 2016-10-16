using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;
using Model;
namespace UI
{
    public partial class ManagerInfoList : Form
    {
        public ManagerInfoList()
        {
            InitializeComponent();
        }

       private ManagerInfoBll miBll = new ManagerInfoBll();
        private void ManagerInfoList_Load(object sender, EventArgs e)
        {
            LoadList();
        }
        private void LoadList()
        {
            gv_ManagerInfoList.AutoGenerateColumns = false;
            gv_ManagerInfoList.DataSource = miBll.GetList();
        }

        private void gv_ManagerInfoList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                switch (e.Value.ToString())
                {
                    case "1":
                        e.Value = "经理";
                        break;
                    case "0":
                        e.Value = "店员";
                        break;

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ManagerInfo mi = new ManagerInfo()
            {
                MName = txtName.Text,
                MPwd = txtPwd.Text,
                MType = radioMa.Checked ? 1 : 0
            };

            if (btnSave.Text.ToString() == "添加")
            {
                if (miBll.Add(mi))
                {
                    LoadList();
                    btnCancel_Click(null, null);
                }
                else
                {
                    MessageBox.Show("添加失败");
                }

            }
            if (btnSave.Text.ToString() == "修改")
            {
                mi.Mid = Convert.ToInt32(txtId.Text);
                if (miBll.Edit(mi))
                {
                    LoadList();
                    btnCancel_Click(null,null);
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtId.Text = "添加时无需编号";
            txtName.Text = "";
            txtPwd.Text = "";
            radioEm.Checked = true;
            btnSave.Text = "添加";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var rows = gv_ManagerInfoList.SelectedRows;
            if (rows.Count > 0)
            {
               DialogResult result = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    int id = Convert.ToInt32(rows[0].Cells[0].Value);
                    if (miBll.Remove(id))
                    {
                       LoadList();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("二货，还没选中店员呢");
            }
        }

        private void gv_ManagerInfoList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row=gv_ManagerInfoList.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtPwd.Text = "******";
            if (row.Cells[2].Value.ToString() == "1")
            {
                radioMa.Checked = true;
                radioEm.Checked = false;
            }
            else
            {
                radioMa.Checked = false;
                radioEm.Checked = true;
            }
            btnSave.Text = "修改";
        }
    }
}
