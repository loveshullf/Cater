using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;
using Model;

namespace UI
{
    public partial class OrderInfoList : Form
    {
        public OrderInfoList()
        {
            InitializeComponent();
        }

        private OrderInfoBll oiBll = new OrderInfoBll();
        private int orderId = -1;

        private void OrderInfoList_Load(object sender, EventArgs e)
        {
            int tableId = Convert.ToInt32(Tag);
            orderId = oiBll.GetOIdByTId(tableId);
            LoadDishInfo();
        }

        private void LoadDishInfo()
        {
            DishInfo di = new DishInfo();
            di.DChar = txt_TitleChar.Text;
            di.DTypeId = Convert.ToInt32(cb_DishType.SelectedValue);
            DishInfoBll diBll = new DishInfoBll();
            gv_DishInfo.AutoGenerateColumns = false;
            gv_DishInfo.DataSource = diBll.GetList(di);
            //载入菜品列表
            LoadDishTypeInfo();
            //载入订单详情
            LoadOrderDetailList();
        }

        private void LoadDishTypeInfo()
        {
            DishTypeInfoBll dtiBll = new DishTypeInfoBll();
            cb_DishType.DisplayMember = "DTitle";
            cb_DishType.ValueMember = "Did";

            var list = dtiBll.GetList();

            list.Insert(0, new DishTypeInfo()
            {
                DId = -1,
                DTitle = "全部"
            });
            cb_DishType.DataSource = list;
        }

        private void txt_TitleChar_TextChanged(object sender, EventArgs e)
        {
            LoadDishInfo();
        }

        private void cb_DishType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDishInfo();
        }

        private void gv_DishInfo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = gv_DishInfo.SelectedRows;
            int dishId = Convert.ToInt32(row[0].Cells[0].Value);
            if (oiBll.DianCai(orderId, dishId))
            {
                LoadOrderDetailList();
            }
        }

        private void LoadOrderDetailList()
        {
            gv_OrderDetailInfo.AutoGenerateColumns = false;
            gv_OrderDetailInfo.DataSource = oiBll.GetDetailList(orderId);
            GetOrderMoney();
        }

        private void gv_OrderDetailInfo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = gv_OrderDetailInfo.Rows[e.RowIndex];
            int oid = Convert.ToInt32(row.Cells[0].Value);
            int count = Convert.ToInt32(row.Cells[e.ColumnIndex].Value);
            if (oiBll.UpdateDishCount(oid, count))
            {
                GetOrderMoney();
            }
        }

        private void GetOrderMoney()
        {
            decimal total = 0;
            var rows = gv_OrderDetailInfo.Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                int count = Convert.ToInt32(rows[i].Cells[3].Value);
                decimal price = Convert.ToDecimal(rows[i].Cells[2].Value);
                total += count*price;
            }
            lbl_TotalMoney.Text = total.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {   //有一个bug
            var row = gv_OrderDetailInfo.SelectedRows[0];
            int oid = Convert.ToInt32(row.Cells[0].Value);
            if (oiBll.DeleteDish(oid))
            {
                LoadOrderDetailList();
            }
        }

        private void btn_XiaDan_Click(object sender, EventArgs e)
        {
            decimal totalMomey = Convert.ToDecimal(lbl_TotalMoney.Text);
            if (oiBll.XiaDan(orderId, totalMomey))
            {
                this.Close();
            }
        }
    }
}