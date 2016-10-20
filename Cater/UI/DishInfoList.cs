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
using Common;
using Model;

namespace UI
{
    public partial class DishInfoList : Form
    {
        public DishInfoList()
        {
            InitializeComponent();
        }

        private DishInfoBll _diBll = new DishInfoBll();

        private void DishInfoList_Load(object sender, EventArgs e)
        {
            LoadList();
            LoadTypeList();
        }

        private void LoadList()
        {
            DishInfo di = new DishInfo();
            if (!string.IsNullOrEmpty(txtDTitleSearch.Text))
            {
                di.DTitle = txtDTitleSearch.Text;
            }
            if (!cbTypeTitleSearch.Text.Equals("全部"))
            {
                di.DTypeId = Convert.ToInt32(cbTypeTitleSearch.SelectedValue);
            }


            gv_DishInfoList.AutoGenerateColumns = false;
            gv_DishInfoList.DataSource = _diBll.GetList(di);
        }

        private void LoadTypeList()
        {
            DishTypeInfoBll dtiBll = new DishTypeInfoBll();

            cbTypeTitleAdd.DataSource = dtiBll.GetList();
            cbTypeTitleAdd.DisplayMember = "DTitle";
            cbTypeTitleAdd.ValueMember = "DId";

            var list = dtiBll.GetList();
            list.Insert(0, new DishTypeInfo()
            {
                DId = 0,
                DTitle = "全部"
            });
            cbTypeTitleSearch.DisplayMember = "Dtitle";
            cbTypeTitleSearch.ValueMember = "DId";
            cbTypeTitleSearch.DataSource = list;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtDId.Text = "添加时无需编号";
            txtDCharAdd.Text = "";
            txtDPriceAdd.Text = "";
            txtDTitleAdd.Text = "";
            cbTypeTitleAdd.SelectedIndex = 0;
            btnSave.Text = "添加";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DishInfo di = new DishInfo()
            {
                DTitle = txtDTitleAdd.Text,
                DChar = txtDCharAdd.Text,
                DPrice = Convert.ToDecimal(txtDPriceAdd.Text),
                DTypeId = Convert.ToInt32(cbTypeTitleAdd.SelectedValue)
            };
            if (btnSave.Text.Equals("添加"))
            {
                if (_diBll.Add(di))
                {
                    btnCancel_Click(null, null);
                    LoadList();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            else if (btnSave.Text.Equals("修改"))
            {
                di.Did = Convert.ToInt32(txtDId.Text);
                if (_diBll.Edit(di))
                {
                    btnCancel_Click(null, null);
                    LoadList();
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
            }
        }

        //private void txtDTitleAdd_Leave(object sender, EventArgs e)
        //{
        //    txtDCharAdd.Text = PinyinHelper.GetPinYin(txtDTitleAdd.Text);
        //}

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var row = gv_DishInfoList.SelectedRows;
            if (row.Count > 0)
            {
                DialogResult result = MessageBox.Show("确定要删除么?", "这只是一个提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    if (_diBll.Remove(Convert.ToInt32(row[0].Cells[0].Value)))
                    {
                        btnCancel_Click(null, null);
                        LoadList();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                }
            }
            else
            {
                MessageBox.Show("二货，你没有选中菜名！");
            }
        }

        private void gv_DishInfoList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = gv_DishInfoList.Rows[e.RowIndex];
            txtDId.Text = row.Cells[0].Value.ToString();
            txtDTitleAdd.Text = row.Cells[1].Value.ToString();
            cbTypeTitleAdd.Text = row.Cells[2].Value.ToString();
            txtDPriceAdd.Text = row.Cells[3].Value.ToString();
            txtDCharAdd.Text = row.Cells[4].Value.ToString();

            btnSave.Text = "修改";
        }

        private void txtDTitleAdd_TextChanged(object sender, EventArgs e)
        {
            txtDCharAdd.Text = PinyinHelper.GetPinYin(txtDTitleAdd.Text);
        }


        private void cbTypeTitleSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadList();
        }

        private void txtDTitleSearch_Leave(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            txtDTitleSearch.Text = "";
            cbTypeTitleSearch.SelectedIndex = 0;
            LoadList();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            DishTypeInfoList dtiList=new DishTypeInfoList();
            dtiList.UpdateTypeEvent += UdateType;
            dtiList.Show();
            dtiList.Focus();
        }

        private void UdateType()
        {
            LoadList();
            LoadTypeList();
        }
    }
}