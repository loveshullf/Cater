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
    public partial class HallInfoList : Form
    {
        public HallInfoList()
        {
            InitializeComponent();
        }

        private readonly HallInfoBll _hiBll = new HallInfoBll();
        public event Action UpdateHallEvent;

        private void HallInfoList_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            gv_HallInfoList.AutoGenerateColumns = false;
            gv_HallInfoList.DataSource = _hiBll.GetList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            HallInfo hi=new HallInfo()
            {
                HTitle = txtHTitle.Text
            };
            if (btnSave.Text.Equals("添加"))
            {
               if (_hiBll.Add(hi))
               {
                    UpdateHallEvent?.Invoke();
                    LoadList();
               }
               else
               {
                   MessageBox.Show("添加失败");
               }
            }
            else if (btnSave.Text.Equals("修改"))
            {
                hi.HId = Convert.ToInt32(txtDId.Text);
                if (_hiBll.Edit(hi))
                {
                    UpdateHallEvent?.Invoke();
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
            txtDId.Text = "添加时无需编号";
            txtHTitle.Text = "";
            btnSave.Text = "添加";
        }

        private void gv_HallInfoList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           var row = gv_HallInfoList.Rows[e.RowIndex];
            txtDId.Text = row.Cells[0].Value.ToString();
            txtHTitle.Text = row.Cells[1].Value.ToString();
            btnSave.Text = "修改";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
             var row =gv_HallInfoList.SelectedRows;
            if (row.Count > 0)
            {
                
                if (_hiBll.Remove(Convert.ToInt32(row[0].Cells[0].Value)))
                {
                    UpdateHallEvent?.Invoke();
                    LoadList();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }
    }
}