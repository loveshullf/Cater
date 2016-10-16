namespace UI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuManager = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMenber = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDisk = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTable = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(736, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuManager
            // 
            this.menuManager.Name = "menuManager";
            this.menuManager.Size = new System.Drawing.Size(72, 21);
            this.menuManager.Text = "manager";
            this.menuManager.Click += new System.EventHandler(this.menuManager_Click);
            // 
            // menuMenber
            // 
            this.menuMenber.Name = "menuMenber";
            this.menuMenber.Size = new System.Drawing.Size(69, 21);
            this.menuMenber.Text = "member";
            // 
            // menuDisk
            // 
            this.menuDisk.Name = "menuDisk";
            this.menuDisk.Size = new System.Drawing.Size(44, 21);
            this.menuDisk.Text = "dish";
            // 
            // menuTable
            // 
            this.menuTable.Name = "menuTable";
            this.menuTable.Size = new System.Drawing.Size(49, 21);
            this.menuTable.Text = "table";
            // 
            // menuOrder
            // 
            this.menuOrder.Name = "menuOrder";
            this.menuOrder.Size = new System.Drawing.Size(53, 21);
            this.menuOrder.Text = "order";
            // 
            // menuQuit
            // 
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.Size = new System.Drawing.Size(42, 21);
            this.menuQuit.Text = "quit";
            this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 196);
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
    }
}