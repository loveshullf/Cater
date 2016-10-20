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
            TableInfo tiSearch=new TableInfo();
            tiSearch.THallId = hid;
            tiSearch.IsFreeSearch = -1;

            var listTableInfo = tiBll.GetList(tiSearch);

            ListView listView=new ListView();
            listView.Dock = DockStyle.Fill;
            foreach (TableInfo tableInfo in listTableInfo)
            {
                ListViewItem item1=new ListViewItem(tableInfo.TTitle);
                ListViewItem item2 = new ListViewItem(tableInfo.TIsFree.ToString());
                listView.Items.Add(item1);
                listView.Items.Add(item2);
            }

            tabPage.Controls.Add(listView);

        }
    }
}