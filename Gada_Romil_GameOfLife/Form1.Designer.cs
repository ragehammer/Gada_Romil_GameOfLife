namespace Gada_Romil_GameOfLife
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new Gada_Romil_GameOfLife.GraphicsPanel();
            this.toolStripButton_New = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Open = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Start = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Pause = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Next = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Help = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridVisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neighbourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 293);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // toolStripButton_New
            // 
            this.toolStripButton_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_New.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_New.Image")));
            this.toolStripButton_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_New.Name = "toolStripButton_New";
            this.toolStripButton_New.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_New.Text = "New";
            this.toolStripButton_New.Click += new System.EventHandler(this.toolStripButton_New_Click);
            // 
            // toolStripButton_Open
            // 
            this.toolStripButton_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Open.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Open.Image")));
            this.toolStripButton_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Open.Name = "toolStripButton_Open";
            this.toolStripButton_Open.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Open.Text = "Open";
            this.toolStripButton_Open.Click += new System.EventHandler(this.toolStripButton_Open_Click);
            // 
            // toolStripButton_Save
            // 
            this.toolStripButton_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Save.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Save.Image")));
            this.toolStripButton_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Save.Name = "toolStripButton_Save";
            this.toolStripButton_Save.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Save.Text = "Save";
            this.toolStripButton_Save.Click += new System.EventHandler(this.toolStripButton_Save_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_Start
            // 
            this.toolStripButton_Start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Start.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Start.Image")));
            this.toolStripButton_Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Start.Name = "toolStripButton_Start";
            this.toolStripButton_Start.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Start.Text = "Start";
            this.toolStripButton_Start.Click += new System.EventHandler(this.toolStripButton_Start_Click);
            // 
            // toolStripButton_Pause
            // 
            this.toolStripButton_Pause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Pause.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Pause.Image")));
            this.toolStripButton_Pause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Pause.Name = "toolStripButton_Pause";
            this.toolStripButton_Pause.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Pause.Text = "Pause";
            this.toolStripButton_Pause.Click += new System.EventHandler(this.toolStripButton_Pause_Click);
            // 
            // toolStripButton_Next
            // 
            this.toolStripButton_Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Next.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Next.Image")));
            this.toolStripButton_Next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Next.Name = "toolStripButton_Next";
            this.toolStripButton_Next.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Next.Text = "Next";
            this.toolStripButton_Next.Click += new System.EventHandler(this.toolStripButton_Next_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_Help
            // 
            this.toolStripButton_Help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Help.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Help.Image")));
            this.toolStripButton_Help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Help.Name = "toolStripButton_Help";
            this.toolStripButton_Help.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Help.Text = "Help";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_New,
            this.toolStripButton_Open,
            this.toolStripButton_Save,
            this.toolStripSeparator2,
            this.toolStripButton_Start,
            this.toolStripButton_Pause,
            this.toolStripButton_Next,
            this.toolStripSeparator6,
            this.toolStripButton_Help});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(573, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.importToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridVisibleToolStripMenuItem,
            this.headsToolStripMenuItem,
            this.neighbourToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // gridVisibleToolStripMenuItem
            // 
            this.gridVisibleToolStripMenuItem.Checked = true;
            this.gridVisibleToolStripMenuItem.CheckOnClick = true;
            this.gridVisibleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridVisibleToolStripMenuItem.Name = "gridVisibleToolStripMenuItem";
            this.gridVisibleToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.gridVisibleToolStripMenuItem.Text = "Grid Visible";
            this.gridVisibleToolStripMenuItem.Click += new System.EventHandler(this.gridVisibleToolStripMenuItem_Click);
            // 
            // headsToolStripMenuItem
            // 
            this.headsToolStripMenuItem.Checked = true;
            this.headsToolStripMenuItem.CheckOnClick = true;
            this.headsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.headsToolStripMenuItem.Name = "headsToolStripMenuItem";
            this.headsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.headsToolStripMenuItem.Text = "Heads Up Visible";
            this.headsToolStripMenuItem.Click += new System.EventHandler(this.headsToolStripMenuItem_Click);
            // 
            // neighbourToolStripMenuItem
            // 
            this.neighbourToolStripMenuItem.Checked = true;
            this.neighbourToolStripMenuItem.CheckOnClick = true;
            this.neighbourToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.neighbourToolStripMenuItem.Name = "neighbourToolStripMenuItem";
            this.neighbourToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.neighbourToolStripMenuItem.Text = "Neighbor Count Visible ";
            this.neighbourToolStripMenuItem.Click += new System.EventHandler(this.neighbourToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.runToToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // runToToolStripMenuItem
            // 
            this.runToToolStripMenuItem.Name = "runToToolStripMenuItem";
            this.runToToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.runToToolStripMenuItem.Text = "Run To...";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomizeToolStripMenuItem,
            this.customizeToolStripMenuItem,
            this.toolStripSeparator7,
            this.optionsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // randomizeToolStripMenuItem
            // 
            this.randomizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromTimeToolStripMenuItem,
            this.fromSeedToolStripMenuItem});
            this.randomizeToolStripMenuItem.Name = "randomizeToolStripMenuItem";
            this.randomizeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.randomizeToolStripMenuItem.Text = "Randomize";
            // 
            // fromTimeToolStripMenuItem
            // 
            this.fromTimeToolStripMenuItem.Name = "fromTimeToolStripMenuItem";
            this.fromTimeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.fromTimeToolStripMenuItem.Text = "From Time";
            this.fromTimeToolStripMenuItem.Click += new System.EventHandler(this.fromTimeToolStripMenuItem_Click);
            // 
            // fromSeedToolStripMenuItem
            // 
            this.fromSeedToolStripMenuItem.Name = "fromSeedToolStripMenuItem";
            this.fromSeedToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.fromSeedToolStripMenuItem.Text = "From Seed";
            this.fromSeedToolStripMenuItem.Click += new System.EventHandler(this.fromSeedToolStripMenuItem_Click);
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(130, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.reloadToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.runToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem1,
            this.pauseToolStripMenuItem1,
            this.nextToolStripMenuItem1,
            this.optionsToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 114);
            // 
            // startToolStripMenuItem1
            // 
            this.startToolStripMenuItem1.Name = "startToolStripMenuItem1";
            this.startToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.startToolStripMenuItem1.Text = "Start";
            this.startToolStripMenuItem1.Click += new System.EventHandler(this.startToolStripMenuItem1_Click);
            // 
            // pauseToolStripMenuItem1
            // 
            this.pauseToolStripMenuItem1.Name = "pauseToolStripMenuItem1";
            this.pauseToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.pauseToolStripMenuItem1.Text = "Pause";
            this.pauseToolStripMenuItem1.Click += new System.EventHandler(this.pauseToolStripMenuItem1_Click);
            // 
            // nextToolStripMenuItem1
            // 
            this.nextToolStripMenuItem1.Name = "nextToolStripMenuItem1";
            this.nextToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.nextToolStripMenuItem1.Text = "Next";
            this.nextToolStripMenuItem1.Click += new System.EventHandler(this.nextToolStripMenuItem1_Click);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem1.Text = "Options";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.optionsToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 342);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GraphicsPanel panel1;
        private System.Windows.Forms.ToolStripButton toolStripButton_New;
        private System.Windows.Forms.ToolStripButton toolStripButton_Open;
        private System.Windows.Forms.ToolStripButton toolStripButton_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_Start;
        private System.Windows.Forms.ToolStripButton toolStripButton_Pause;
        private System.Windows.Forms.ToolStripButton toolStripButton_Next;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton_Help;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridVisibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neighbourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
    }
}

