using System;
using System.Globalization;
using System.Windows.Forms;
using Bll;
using Model;

namespace UI
{
    public partial class OrderPay : Form
    {
        public OrderPay()
        {
            InitializeComponent();
        }
       private OrderInfoBll oiBll = new OrderInfoBll();
        private void OrderPay_Load(object sender, EventArgs e)
        {
            gb_Member.Enabled = false;
            Text = "为【" + Tag + "】号餐桌结账付款；";
            
            lbl_TotalMoney.Text = oiBll.GetMoneyByTId(Convert.ToInt32(Tag)).ToString();
        }

        private void cb_Member_CheckedChanged(object sender, EventArgs e)
        {
            gb_Member.Enabled = cb_Member.Checked;
        }

        private void txt_id_Leave(object sender, EventArgs e)
        {
            GetMemberInfo();
        }

        private void txt_Phone_Leave(object sender, EventArgs e)
        {
            GetMemberInfo();
        }
         /// <summary>
         /// 获取会员信息
         /// </summary>
        private void GetMemberInfo()
        {
            var mi = new MemberInfo();
            if (!string.IsNullOrEmpty(txt_id.Text))
                mi.Mid = Convert.ToInt32(txt_id.Text);
            if (!string.IsNullOrEmpty(txt_Phone.Text))
                mi.MPhone = txt_Phone.Text;

            var miBll = new MemberInfoBll();
            var list = miBll.GetList(mi);
            if (list.Count == 1)
            {
                //只有查询到一个信息
                mi = list[0];
                txt_id.Text = mi.Mid.ToString();
                txt_Phone.Text = mi.MPhone;
                lbl_Money.Text = mi.MMoney.ToString();
                lbl_TypeTitle.Text = mi.TyptTitle;
                lbl_Discount.Text = mi.TypeDiscount.ToString();
                lbl_PayMoney.Text = (mi.TypeDiscount*Convert.ToDecimal(lbl_TotalMoney.Text)).ToString();
            }
            else
            {
                MessageBox.Show("信息有误！请核对");
            }
        }
    }
}