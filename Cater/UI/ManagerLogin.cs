using System;
using System.Windows.Forms;
using Bll;
using Model;

namespace UI
{
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void ManagerLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var mi = new ManagerInfo();
            mi.MName = txtName.Text;
            mi.MPwd = txtPwd.Text;

            var miBll = new ManagerInfoBll();
            if (miBll.Login(mi))
            {
                var mainForm = new MainForm();
                mainForm.Tag = mi.MType.ToString();
                mainForm.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("用户名或者密码错误");
            }
        }
    }
}