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
    public partial class MemberInfoList : Form
    {
        public  MemberInfoList()
        {
            InitializeComponent();
        }

        private MemberInfoBll miBll = new MemberInfoBll();

        private void MemberInfoList_Load(object sender, EventArgs e)
        {
            LoadList();
            LoadTypeList();
        }

        private void LoadList()
        {
            MemberInfo mi = new MemberInfo();
            mi.MName = txtNameSearch.Text;
            mi.MPhone = txtPhoneSearch.Text;
            gv_MemberInfoList.AutoGenerateColumns = false;
            gv_MemberInfoList.DataSource = miBll.GetList(mi);
        }

        private void LoadTypeList()
        {
            MemberTypeInfoBll mtiBll = new MemberTypeInfoBll();
            List<MemberTypeInfo> list = mtiBll.GetList();
            //绑定控件
            cbType.DisplayMember = "MTitle";
            cbType.ValueMember = "MId";
            cbType.DataSource = list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MemberInfo mi = new MemberInfo
            {
                MName = txtNameAdd.Text,
                MMoney = Convert.ToDecimal(txtMoneyAdd.Text),
                MPhone = txtPhoneAdd.Text,
                MTypeId = Convert.ToInt32(cbType.SelectedValue)
            };
            if (btnSave.Text.Equals("添加"))
            {
                //添加
                if (miBll.Add(mi))
                {
                    btnCancel_Click(null, null);
                    LoadList();
                }
                else
                {
                    MessageBox.Show("添加失敗!!");
                }
            }
            else if (btnSave.Text.Equals("修改"))
            {
                //修改
                if (miBll.Edit(mi))
                {
                    btnCancel_Click(null, null);
                    LoadList();
                }
                else
                {
                    MessageBox.Show("修改失敗!!");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtId.Text = "添加时无需编号";
            txtMoneyAdd.Text = "";
            txtNameAdd.Text = "";
            txtPhoneAdd.Text = "";
            cbType.SelectedIndex = 0;
            btnSave.Text = "添加";
        }

        private void gv_MemberInfoList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = gv_MemberInfoList.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtNameAdd.Text = row.Cells[1].Value.ToString();
            cbType.Text = row.Cells[2].Value.ToString();
            txtPhoneAdd.Text = row.Cells[3].Value.ToString();
            txtMoneyAdd.Text = row.Cells[4].Value.ToString();

            btnSave.Text = "修改";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var row = gv_MemberInfoList.SelectedRows;
            if (row.Count > 0)
            {
                DialogResult result = MessageBox.Show("确定删除", "这只是一个提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    int id = int.Parse(row[0].Cells[0].Value.ToString());
                    if (miBll.Delete(id))
                    {
                        LoadList();
                    }
                    else
                    {
                        MessageBox.Show("删除失败!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("二货，你还没选中会员.");
            }
        }

        private void txtNameSearch_Leave(object sender, EventArgs e)
        {
            LoadList();
        }

        private void txtPhoneSearch_Leave(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            txtNameSearch.Text = "";
            txtPhoneSearch.Text = "";
            LoadList();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            MemberTypeInfoList mtiList = FormFactory.CreateMemberTypeInfoList();
            mtiList.Show();
            mtiList.Focus();
        }

      
    }
}