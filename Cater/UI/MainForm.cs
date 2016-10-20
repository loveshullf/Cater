using System;
using System.Windows.Forms;

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
    }
}