using System;
using System.Windows.Forms;
using Bll;
using Model;

namespace UI
{
    public partial class MemberTypeInfoList : Form
    {
        private readonly MemberTypeInfoBll mtiBll = new MemberTypeInfoBll();

        public MemberTypeInfoList()
        {
            InitializeComponent();
        }

        private void MemberTypeInfoList_Load(object sender, EventArgs e)
        {
            Load_List();
        }

        private void Load_List()
        {
            gv_MemberTypeInfoList.AutoGenerateColumns = false;
            gv_MemberTypeInfoList.DataSource = mtiBll.GetList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var mti = new MemberTypeInfo
            {
                MTitle = txtTitle.Text,
                MDiscount = Convert.ToDecimal(txtDiscount.Text)
            };
            if (btnSave.Text.Equals("添加"))
            {
                if (mtiBll.Add(mti))
                {
                    btnCancel_Click(null, null);
                    Load_List();
                    UpdateTypeEvent?.Invoke();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            else if (btnSave.Text.Equals("修改"))
            {
                mti.Mid = Convert.ToInt32(txtId.Text);
                if (mtiBll.Edit(mti))
                {
                    btnCancel_Click(null, null);
                    Load_List();
                    UpdateTypeEvent?.Invoke();
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
            txtTitle.Text = "";
            txtDiscount.Text = "";
            btnSave.Text = "添加";
        }


        private void gv_MemberTypeInfoList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = gv_MemberTypeInfoList.Rows[e.RowIndex];

            txtId.Text = row.Cells[0].Value.ToString();
            txtDiscount.Text = row.Cells[2].Value.ToString();
            txtTitle.Text = row.Cells[1].Value.ToString();
            btnSave.Text = "修改";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var rows = gv_MemberTypeInfoList.SelectedRows;
            if (rows.Count > 0)
            {
                var result = MessageBox.Show("确定要删除么？", "提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    var id = int.Parse(rows[0].Cells[0].Value.ToString());
                    if (mtiBll.Remove(id))
                    {
                        Load_List();
                        UpdateTypeEvent?.Invoke();
                    }

                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的数据");
            }
        }

        public event Action UpdateTypeEvent;
    }
}