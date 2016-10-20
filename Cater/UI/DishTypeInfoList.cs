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
    public partial class DishTypeInfoList : Form
    {
        public DishTypeInfoList()
        {
            InitializeComponent();
        }
        public event Action UpdateTypeEvent;
        private readonly DishTypeInfoBll _dtiBll = new DishTypeInfoBll();

        private void DishTypeInfoList_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            gv_DishTypeInfoList.AutoGenerateColumns = false;
            gv_DishTypeInfoList.DataSource = _dtiBll.GetList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DishTypeInfo dti = new DishTypeInfo();
            dti.DTitle = txtDtitle.Text.ToString();

            if (btnSave.Text.Equals("添加"))
            {
                if (_dtiBll.Add(dti))
                {
                    UpdateTypeEvent?.Invoke();
                    LoadList();
                }
                else
                {
                    MessageBox.Show("添加失败!");
                }
            }
            else if (btnSave.Text.Equals("修改"))
            {
                dti.DId = int.Parse(txtDId.Text);
                if (_dtiBll.Edit(dti))
                {
                    UpdateTypeEvent?.Invoke();
                    LoadList();
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtDId.Text = "";
            txtDtitle.Text = "";
            btnSave.Text = "添加时无需编号";
        }

        private void gv_DishTypeInfoList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = gv_DishTypeInfoList.Rows[e.RowIndex];
            txtDId.Text = row.Cells[0].Value.ToString();
            txtDtitle.Text = row.Cells[1].Value.ToString();
            btnSave.Text = "修改";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var row = gv_DishTypeInfoList.SelectedRows;
            if (row.Count > 0)
            {
                DialogResult result = MessageBox.Show("确定要删除么?", "我是提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    int id = Convert.ToInt32(row[0].Cells[0].Value);
                    if (_dtiBll.Remove(id))
                    {
                        UpdateTypeEvent?.Invoke();
                        LoadList();
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }
            else
            {
                MessageBox.Show("二货，你又忘记选择了");
            }
        }


        
    }
}