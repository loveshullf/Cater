using Model;
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
            ManagerInfo mi = new ManagerInfo();
            mi.MName = txtName.Text.ToString();
            mi.MPwd = txtPwd.Text.ToString();

            ManagerInfoBll miBll = new ManagerInfoBll();
            if (miBll.Login(mi))
            {
                MainForm mainForm = new MainForm();
                mainForm.Tag = mi.MType.ToString();
                mainForm.Show();
                this.Visible=false;
            }
            else
            {
                MessageBox.Show("用户名或者密码错误");
            }
            
        }
    }
}
