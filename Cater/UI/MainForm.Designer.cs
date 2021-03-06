﻿namespace UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuManager = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMenber = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDisk = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTable = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabHall = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuManager,
            this.menuMenber,
            this.menuDisk,
            this.menuTable,
            this.menuOrder,
            this.menuQuit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuManager
            // 
            this.menuManager.Name = "menuManager";
            this.menuManager.Size = new System.Drawing.Size(56, 21);
            this.menuManager.Text = "管理员";
            this.menuManager.Click += new System.EventHandler(this.menuManager_Click);
            // 
            // menuMenber
            // 
            this.menuMenber.Name = "menuMenber";
            this.menuMenber.Size = new System.Drawing.Size(68, 21);
            this.menuMenber.Text = "会员管理";
            this.menuMenber.Click += new System.EventHandler(this.menuMenber_Click);
            // 
            // menuDisk
            // 
            this.menuDisk.Name = "menuDisk";
            this.menuDisk.Size = new System.Drawing.Size(68, 21);
            this.menuDisk.Text = "菜单管理";
            this.menuDisk.Click += new System.EventHandler(this.menuDisk_Click);
            // 
            // menuTable
            // 
            this.menuTable.Name = "menuTable";
            this.menuTable.Size = new System.Drawing.Size(68, 21);
            this.menuTable.Text = "餐桌管理";
            this.menuTable.Click += new System.EventHandler(this.menuTable_Click);
            // 
            // menuOrder
            // 
            this.menuOrder.Name = "menuOrder";
            this.menuOrder.Size = new System.Drawing.Size(44, 21);
            this.menuOrder.Text = "结账";
            this.menuOrder.Click += new System.EventHandler(this.menuOrder_Click);
            // 
            // menuQuit
            // 
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.Size = new System.Drawing.Size(44, 21);
            this.menuQuit.Text = "退出";
            this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click);
            // 
            // tabHall
            // 
            this.tabHall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHall.Location = new System.Drawing.Point(0, 25);
            this.tabHall.Name = "tabHall";
            this.tabHall.SelectedIndex = 0;
            this.tabHall.Size = new System.Drawing.Size(430, 304);
            this.tabHall.TabIndex = 1;
            this.tabHall.SelectedIndexChanged += new System.EventHandler(this.tabHall_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "free.jpg");
            this.imageList1.Images.SetKeyName(1, "notfree.jpg");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 329);
            this.Controls.Add(this.tabHall);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "餐饮管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuManager;
        private System.Windows.Forms.ToolStripMenuItem menuMenber;
        private System.Windows.Forms.ToolStripMenuItem menuDisk;
        private System.Windows.Forms.ToolStripMenuItem menuTable;
        private System.Windows.Forms.ToolStripMenuItem menuOrder;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
        private System.Windows.Forms.TabControl tabHall;
        private System.Windows.Forms.ImageList imageList1;
    }
}