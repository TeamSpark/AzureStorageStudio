namespace TeamSpark.AzureStorageStudio.GUI.Form
{
	partial class FormMain
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("account 2", 0);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("account 3", 0);
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("account 4", 0);
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("account 5", 0);
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("account 6", 0);
			System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("barriermerchne", 0);
			System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("neogeoteamcloudproduction", 0);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("table 1", 0);
			System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("table 2", 0);
			System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("table 3", 0);
			System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("table 4", 0);
			this.menuMain = new System.Windows.Forms.MenuStrip();
			this.splitMain = new System.Windows.Forms.SplitContainer();
			this.listAccounts = new System.Windows.Forms.ListView();
			this.menuAccounts = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuTables = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.imgTables = new System.Windows.Forms.ImageList(this.components);
			this.imgAccounts = new System.Windows.Forms.ImageList(this.components);
			this.statusTables = new System.Windows.Forms.StatusStrip();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.listTables = new System.Windows.Forms.ListView();
			this.statusAccounts = new System.Windows.Forms.StatusStrip();
			this.toolStripProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
			this.miApplication = new System.Windows.Forms.ToolStripMenuItem();
			this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.menuMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
			this.splitMain.Panel1.SuspendLayout();
			this.splitMain.Panel2.SuspendLayout();
			this.splitMain.SuspendLayout();
			this.statusTables.SuspendLayout();
			this.statusAccounts.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuMain
			// 
			this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miApplication,
            this.miHelp});
			this.menuMain.Location = new System.Drawing.Point(0, 0);
			this.menuMain.Name = "menuMain";
			this.menuMain.Size = new System.Drawing.Size(784, 24);
			this.menuMain.TabIndex = 0;
			this.menuMain.Text = "menuStrip1";
			// 
			// splitMain
			// 
			this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitMain.Location = new System.Drawing.Point(0, 24);
			this.splitMain.Name = "splitMain";
			// 
			// splitMain.Panel1
			// 
			this.splitMain.Panel1.Controls.Add(this.statusAccounts);
			this.splitMain.Panel1.Controls.Add(this.listAccounts);
			// 
			// splitMain.Panel2
			// 
			this.splitMain.Panel2.Controls.Add(this.statusTables);
			this.splitMain.Panel2.Controls.Add(this.listTables);
			this.splitMain.Size = new System.Drawing.Size(784, 537);
			this.splitMain.SplitterDistance = 261;
			this.splitMain.TabIndex = 1;
			// 
			// listAccounts
			// 
			this.listAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listAccounts.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
			this.listAccounts.LabelWrap = false;
			this.listAccounts.LargeImageList = this.imgAccounts;
			this.listAccounts.Location = new System.Drawing.Point(0, 0);
			this.listAccounts.Name = "listAccounts";
			this.listAccounts.Size = new System.Drawing.Size(261, 512);
			this.listAccounts.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listAccounts.TabIndex = 0;
			this.listAccounts.TileSize = new System.Drawing.Size(240, 36);
			this.listAccounts.UseCompatibleStateImageBehavior = false;
			this.listAccounts.View = System.Windows.Forms.View.Tile;
			// 
			// menuAccounts
			// 
			this.menuAccounts.Name = "menuAccounts";
			this.menuAccounts.Size = new System.Drawing.Size(61, 4);
			// 
			// menuTables
			// 
			this.menuTables.Name = "menuTables";
			this.menuTables.Size = new System.Drawing.Size(61, 4);
			// 
			// imgTables
			// 
			this.imgTables.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTables.ImageStream")));
			this.imgTables.TransparentColor = System.Drawing.Color.Transparent;
			this.imgTables.Images.SetKeyName(0, "table.png");
			// 
			// imgAccounts
			// 
			this.imgAccounts.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgAccounts.ImageStream")));
			this.imgAccounts.TransparentColor = System.Drawing.Color.Transparent;
			this.imgAccounts.Images.SetKeyName(0, "database_blue.png");
			// 
			// statusTables
			// 
			this.statusTables.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
			this.statusTables.Location = new System.Drawing.Point(0, 515);
			this.statusTables.Name = "statusTables";
			this.statusTables.Size = new System.Drawing.Size(519, 22);
			this.statusTables.TabIndex = 2;
			this.statusTables.Text = "statusStrip1";
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
			// 
			// listTables
			// 
			this.listTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listTables.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11});
			this.listTables.LabelWrap = false;
			this.listTables.LargeImageList = this.imgTables;
			this.listTables.Location = new System.Drawing.Point(0, 0);
			this.listTables.Name = "listTables";
			this.listTables.Size = new System.Drawing.Size(519, 512);
			this.listTables.TabIndex = 0;
			this.listTables.UseCompatibleStateImageBehavior = false;
			// 
			// statusAccounts
			// 
			this.statusAccounts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar2});
			this.statusAccounts.Location = new System.Drawing.Point(0, 515);
			this.statusAccounts.Name = "statusAccounts";
			this.statusAccounts.Size = new System.Drawing.Size(261, 22);
			this.statusAccounts.TabIndex = 1;
			this.statusAccounts.Text = "statusStrip1";
			// 
			// toolStripProgressBar2
			// 
			this.toolStripProgressBar2.Name = "toolStripProgressBar2";
			this.toolStripProgressBar2.Size = new System.Drawing.Size(100, 16);
			// 
			// miApplication
			// 
			this.miApplication.Name = "miApplication";
			this.miApplication.Size = new System.Drawing.Size(80, 20);
			this.miApplication.Text = "Application";
			// 
			// miHelp
			// 
			this.miHelp.Name = "miHelp";
			this.miHelp.Size = new System.Drawing.Size(44, 20);
			this.miHelp.Text = "Help";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.splitMain);
			this.Controls.Add(this.menuMain);
			this.MainMenuStrip = this.menuMain;
			this.Name = "FormMain";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.menuMain.ResumeLayout(false);
			this.menuMain.PerformLayout();
			this.splitMain.Panel1.ResumeLayout(false);
			this.splitMain.Panel1.PerformLayout();
			this.splitMain.Panel2.ResumeLayout(false);
			this.splitMain.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
			this.splitMain.ResumeLayout(false);
			this.statusTables.ResumeLayout(false);
			this.statusTables.PerformLayout();
			this.statusAccounts.ResumeLayout(false);
			this.statusAccounts.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuMain;
		private System.Windows.Forms.SplitContainer splitMain;
		private System.Windows.Forms.ListView listAccounts;
		private System.Windows.Forms.ContextMenuStrip menuAccounts;
		private System.Windows.Forms.ContextMenuStrip menuTables;
		private System.Windows.Forms.ImageList imgTables;
		private System.Windows.Forms.ImageList imgAccounts;
		private System.Windows.Forms.StatusStrip statusTables;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.ListView listTables;
		private System.Windows.Forms.StatusStrip statusAccounts;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar2;
		private System.Windows.Forms.ToolStripMenuItem miApplication;
		private System.Windows.Forms.ToolStripMenuItem miHelp;
	}
}

