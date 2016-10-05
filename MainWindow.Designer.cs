namespace Factorio_Launcher {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.LauncherMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LauncherSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.LauncherSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.LauncherExit = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigurationList = new System.Windows.Forms.ListView();
            this.ColIcon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColLastPlayed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConfigIcons = new System.Windows.Forms.ImageList(this.components);
            this.LaunchButton = new System.Windows.Forms.Button();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LauncherMenu,
            this.HelpMenu});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(664, 24);
            this.MainMenuStrip.TabIndex = 0;
            // 
            // LauncherMenu
            // 
            this.LauncherMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LauncherSettings,
            this.LauncherSeparator,
            this.LauncherExit});
            this.LauncherMenu.Name = "LauncherMenu";
            this.LauncherMenu.Size = new System.Drawing.Size(68, 20);
            this.LauncherMenu.Text = "&Launcher";
            // 
            // LauncherSettings
            // 
            this.LauncherSettings.Name = "LauncherSettings";
            this.LauncherSettings.Size = new System.Drawing.Size(116, 22);
            this.LauncherSettings.Text = "&Settings";
            this.LauncherSettings.Click += new System.EventHandler(this.LauncherSettings_Click);
            // 
            // LauncherSeparator
            // 
            this.LauncherSeparator.Name = "LauncherSeparator";
            this.LauncherSeparator.Size = new System.Drawing.Size(113, 6);
            // 
            // LauncherExit
            // 
            this.LauncherExit.Name = "LauncherExit";
            this.LauncherExit.Size = new System.Drawing.Size(116, 22);
            this.LauncherExit.Text = "E&xit";
            this.LauncherExit.Click += new System.EventHandler(this.LauncherExit_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpAbout});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(44, 20);
            this.HelpMenu.Text = "&Help";
            // 
            // HelpAbout
            // 
            this.HelpAbout.Name = "HelpAbout";
            this.HelpAbout.Size = new System.Drawing.Size(107, 22);
            this.HelpAbout.Text = "&About";
            this.HelpAbout.Click += new System.EventHandler(this.HelpAbout_Click);
            // 
            // ConfigurationList
            // 
            this.ConfigurationList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigurationList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColIcon,
            this.ColName,
            this.ColType,
            this.ColLastPlayed});
            this.ConfigurationList.FullRowSelect = true;
            this.ConfigurationList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ConfigurationList.HideSelection = false;
            this.ConfigurationList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ConfigurationList.LargeImageList = this.ConfigIcons;
            this.ConfigurationList.Location = new System.Drawing.Point(12, 27);
            this.ConfigurationList.MultiSelect = false;
            this.ConfigurationList.Name = "ConfigurationList";
            this.ConfigurationList.ShowGroups = false;
            this.ConfigurationList.Size = new System.Drawing.Size(467, 310);
            this.ConfigurationList.SmallImageList = this.ConfigIcons;
            this.ConfigurationList.TabIndex = 1;
            this.ConfigurationList.TileSize = new System.Drawing.Size(168, 40);
            this.ConfigurationList.UseCompatibleStateImageBehavior = false;
            this.ConfigurationList.View = System.Windows.Forms.View.Details;
            // 
            // ColIcon
            // 
            this.ColIcon.Text = "";
            this.ColIcon.Width = 38;
            // 
            // ColName
            // 
            this.ColName.Text = "Name";
            this.ColName.Width = 291;
            // 
            // ColType
            // 
            this.ColType.Text = "Type";
            this.ColType.Width = 82;
            // 
            // ColLastPlayed
            // 
            this.ColLastPlayed.Text = "Last Played";
            this.ColLastPlayed.Width = 119;
            // 
            // ConfigIcons
            // 
            this.ConfigIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ConfigIcons.ImageStream")));
            this.ConfigIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ConfigIcons.Images.SetKeyName(0, "factor64.png");
            // 
            // LaunchButton
            // 
            this.LaunchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LaunchButton.Enabled = false;
            this.LaunchButton.Location = new System.Drawing.Point(485, 295);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(167, 42);
            this.LaunchButton.TabIndex = 2;
            this.LaunchButton.Text = "Launch";
            this.LaunchButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 349);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.ConfigurationList);
            this.Controls.Add(this.MainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Factorio Launcher";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem LauncherMenu;
        private System.Windows.Forms.ToolStripSeparator LauncherSeparator;
        private System.Windows.Forms.ToolStripMenuItem LauncherSettings;
        private System.Windows.Forms.ToolStripMenuItem LauncherExit;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpAbout;
        private System.Windows.Forms.ListView ConfigurationList;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.ColumnHeader ColIcon;
        private System.Windows.Forms.ColumnHeader ColName;
        private System.Windows.Forms.ColumnHeader ColType;
        private System.Windows.Forms.ColumnHeader ColLastPlayed;
        private System.Windows.Forms.ImageList ConfigIcons;
    }
}

