using System;
using System.Windows.Forms;
using Bll;
using Model;

namespace UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //if (this.Tag.ToString() == "0")
            //{
            //    menuManager.Visible = false;
            //}
            LoadHallInfo();
        }
        //tablecontrol控件
        private void LoadHallInfo()
        {
            HallInfoBll hiBll=new HallInfoBll();
            var list = hiBll.GetList();

            foreach (HallInfo hallInfo in list)
            {
                TabPage page=new TabPage(hallInfo.HTitle);
                page.Tag = hallInfo.HId;
                tabHall.TabPages.Add(page);
            }
            tabHall_SelectedIndexChanged(null, null);
        }

        private void menuQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuManager_Click(object sender, EventArgs e)
        {
            var miList = new ManagerInfoList();
            miList.Show();
        }

        private void menuMenber_Click(object sender, EventArgs e)
        {
            MemberInfoList miList = FormFactory.CreateMemberInfoList();
            miList.Show();
            miList.Focus();
        }

        private void menuDisk_Click(object sender, EventArgs e)
        {
            DishInfoList diList = FormFactory.CreateDishInfoList();
            diList.Show();
            diList.Focus();
        }

        private void menuTable_Click(object sender, EventArgs e)
        {
            TableInfoList tiListist = FormFactory.CreateTableInfoList();
            tiListist.Show();
            tiListist.Focus();
        }

        private void tabHall_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabPage = tabHall.SelectedTab;
            int hid=Convert.ToInt32(tabPage.Tag);
            TableInfoBll tiBll=new TableInfoBll();
            //创建搜索table数据
            TableInfo tiSearch=new TableInfo();
            tiSearch.THallId = hid;
            tiSearch.IsFreeSearch = -1;
            //tableList
            var listTableInfo = tiBll.GetList(tiSearch);

            //listview 设置图片 风格 双击事件
            ListView listView=new ListView();
            listView.MultiSelect = false;
            listView.LargeImageList = imageList1;
            listView.DoubleClick += ListView_DoubleClick;
            listView.Dock = DockStyle.Fill;

            //listview 添加到 tabPage
            foreach (TableInfo tableInfo in listTableInfo)
            {
                //图片索引 0为空闲 1位不空闲
                ListViewItem item=new ListViewItem(tableInfo.TTitle, tableInfo.TIsFree?0:1);
                item.Tag = tableInfo.TId;
                listView.Items.Add(item);
            }

            tabPage.Controls.Add(listView);
        }

        private void ListView_DoubleClick(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;
            ListViewItem item = listView.SelectedItems[0];
            int tableId = Convert.ToInt32(item.Tag);
            
            //状态为空闲 开单
            //状态为非空闲 加菜
            if (item.ImageIndex == 0)
            {
                item.ImageIndex = 1;
                OrderInfoBll oiBll = new OrderInfoBll();
                if (oiBll.KaiDan(tableId))
                {
                    
                }
            }
            else
            {
                
            }
           //显示界面
            OrderInfoList oiList = FormFactory.CreateOrderInfoList();
            oiList.Tag = tableId;
            oiList.Show();
            oiList.Focus();



        }
    }
}