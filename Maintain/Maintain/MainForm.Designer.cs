using System.Windows.Forms;

namespace Maintain
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
            this.screens = new System.Windows.Forms.TabControl();
            this.tabDataSources = new System.Windows.Forms.TabPage();
            this.tabMeasures = new System.Windows.Forms.TabPage();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mainMenuDataSources = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSourcesAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screens.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // screens
            // 
            this.screens.Controls.Add(this.tabDataSources);
            this.screens.Controls.Add(this.tabMeasures);
            this.screens.Location = new System.Drawing.Point(12, 52);
            this.screens.Name = "screens";
            this.screens.SelectedIndex = 0;
            this.screens.Size = new System.Drawing.Size(1315, 595);
            this.screens.TabIndex = 0;
            // 
            // tabDataSources
            // 
            this.tabDataSources.Location = new System.Drawing.Point(4, 22);
            this.tabDataSources.Name = "tabDataSources";
            this.tabDataSources.Padding = new System.Windows.Forms.Padding(3);
            this.tabDataSources.Size = new System.Drawing.Size(1307, 569);
            this.tabDataSources.TabIndex = 0;
            this.tabDataSources.Text = "Data Sources";
            this.tabDataSources.UseVisualStyleBackColor = true;
            // 
            // tabMeasures
            // 
            this.tabMeasures.Location = new System.Drawing.Point(4, 22);
            this.tabMeasures.Name = "tabMeasures";
            this.tabMeasures.Padding = new System.Windows.Forms.Padding(3);
            this.tabMeasures.Size = new System.Drawing.Size(1307, 569);
            this.tabMeasures.TabIndex = 1;
            this.tabMeasures.Text = "Measures";
            this.tabMeasures.UseVisualStyleBackColor = true;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mainMenuDataSources});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1339, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // mainMenuDataSources
            // 
            this.mainMenuDataSources.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataSourcesAdd});
            this.mainMenuDataSources.Name = "mainMenuDataSources";
            this.mainMenuDataSources.Size = new System.Drawing.Size(87, 20);
            this.mainMenuDataSources.Text = "Data Sources";
            // 
            // dataSourcesAdd
            // 
            this.dataSourcesAdd.Name = "dataSourcesAdd";
            this.dataSourcesAdd.Size = new System.Drawing.Size(180, 22);
            this.dataSourcesAdd.Text = "Add";
            this.dataSourcesAdd.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // Maintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 659);
            this.Controls.Add(this.screens);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Maintain";
            this.Text = " ";
            this.screens.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl screens;
        private System.Windows.Forms.TabPage tabDataSources;
        private System.Windows.Forms.TabPage tabMeasures;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mainMenuDataSources;
        private System.Windows.Forms.ToolStripMenuItem dataSourcesAdd;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;

        
        public ToolStripMenuItem QuitButton{get{return quitToolStripMenuItem;}}


        public void Quit()
        {
            Application.Exit();
        }
    }
}

