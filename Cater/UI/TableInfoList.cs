using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;
using Model;

namespace UI
{
    public partial class TableInfoList : Form
    {
        public TableInfoList()
        {
            InitializeComponent();
        }

        private readonly TableInfoBll _tiBll = new TableInfoBll();

        private void TableInfoList_Load(object sender, EventArgs e)
        {
            LoadList();
            LoadSearch();
        }

        private void LoadSearch()
        {
            HallInfoBll hiBll = new HallInfoBll();
            var list = hiBll.GetList();
            var listSearch = hiBll.GetList();
            listSearch.Insert(0, new HallInfo()
            {
                HId = -1,
                HTitle = "全部"
            });
            cbHallTypeSearch.DisplayMember = "HTitle";
            cbHallTypeSearch.ValueMember = "HId";
            cbHallTypeSearch.DataSource = listSearch;

            cbHallTitleAdd.DisplayMember = "HTitle";
            cbHallTitleAdd.ValueMember = "HId";
            cbHallTitleAdd.DataSource = list;


            List<TableState> listState = new List<TableState>();

            listState.Add(new TableState(-1, "全部"));
            listState.Add(new TableState(0, "非空闲"));
            listState.Add(new TableState(1, "空闲"));

            cbTIsFreeSearch.DisplayMember = "Title";
            cbTIsFreeSearch.ValueMember = "State";
            cbTIsFreeSearch.DataSource = listState;
        }

        private void LoadList()
        {
            TableInfo ti = new TableInfo();
            ti.THallId = Convert.ToInt32(cbHallTypeSearch.SelectedValue);
            ti.IsFreeSearch = Convert.ToInt32(cbTIsFreeSearch.SelectedValue);


            gv_TableInfoList.AutoGenerateColumns = false;
            gv_TableInfoList.DataSource = _tiBll.GetList(ti);
        }

        private void gv_TableInfoList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (Convert.ToBoolean(e.Value))
                {
                    e.Value = "是";
                }
                else
                {
                    e.Value = "否";
                }
            }
        }

        private void cbHallTypeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadList();
        }

        private void cbTIsFreeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            cbHallTypeSearch.SelectedIndex = 0;
            cbTIsFreeSearch.SelectedIndex = 0;
            LoadList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TableInfo ti = new TableInfo()
            {
                TTitle = txtTTitleAdd.Text,
                THallId = Convert.ToInt32(cbHallTitleAdd.SelectedValue),
                TIsFree = Convert.ToBoolean(radioIsFree.Checked ? 1 : 0),
            };
            if (btnSave.Text.Equals("添加"))
            {
                if (_tiBll.Add(ti))
                {
                    LoadList();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            else if (btnSave.Text.Equals("修改"))
            {
                ti.TId = Convert.ToInt32(txtTIdAdd.Text);
                if (_tiBll.Edit(ti))
                {
                    LoadList();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTIdAdd.Text = "添加时无需编号";
            txtTTitleAdd.Text = "";
            cbHallTitleAdd.SelectedIndex=0;
            radioIsFree.Checked = true;
            radioNotFree.Checked = false;
            btnSave.Text = "添加";
        }

        private void gv_TableInfoList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = gv_TableInfoList.Rows[e.RowIndex];

            txtTIdAdd.Text = row.Cells[0].Value.ToString();
            txtTTitleAdd.Text = row.Cells[1].Value.ToString();
            cbHallTitleAdd.Text = row.Cells[2].Value.ToString();
            if (Convert.ToBoolean(row.Cells[3].Value))
            {
                radioIsFree.Checked = true;
            }
            else
            {
                radioNotFree.Checked = true;
            }

            btnSave.Text = "修改";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var row = gv_TableInfoList.SelectedRows;

            if (row.Count>0)
            {
                if (_tiBll.Remove(Convert.ToInt32(row[0].Cells[0].Value)))
                {
                    LoadList();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            else
            {
                MessageBox.Show("二货，没有选中要删除的餐桌");
            }
        }

        private void btnAddHall_Click(object sender, EventArgs e)
        {
            HallInfoList hiList = FormFactory.CreatehHallInfoList();
            hiList.UpdateHallEvent += UpdateHall;
            hiList.Show();
            hiList.Focus();
        }

        private void UpdateHall()
        {
            LoadList();
            LoadSearch();
        }
    }
}