﻿using System.Windows.Forms;
using MagicMongoDBTool.Module;

namespace MagicMongoDBTool
{
    partial class frmMain
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
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusSelectedObj = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.ManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SrvStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.ExpandAllConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CollapseAllConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataNaviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertSqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AggregationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distinctToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapReduceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateMongoDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.AddUserToAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveUserFromAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.slaveResyncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShutDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SvrPropertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateMongoCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelMongoDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.AddUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.evalJSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RepairDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelMongoCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IndexManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.CompactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DumpAndRestoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestoreMongoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DumpDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DumpCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.ImportCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DosCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportDataFromAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DistributedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplicaSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShardingConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThanksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trvsrvlst = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabView = new System.Windows.Forms.TabControl();
            this.tabSvrStatus = new System.Windows.Forms.TabPage();
            this.tabCommandShell = new System.Windows.Forms.TabPage();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ServerStatusCtl = new MagicMongoDBTool.UserController.ctlServerStatus();
            this.InitGFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabView.SuspendLayout();
            this.tabSvrStatus.SuspendLayout();
            this.tabCommandShell.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.BackColor = System.Drawing.Color.Transparent;
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusSelectedObj,
            this.lblUserInfo});
            this.statusStripMain.Location = new System.Drawing.Point(0, 680);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStripMain.Size = new System.Drawing.Size(1223, 22);
            this.statusStripMain.TabIndex = 8;
            // 
            // toolStripStatusSelectedObj
            // 
            this.toolStripStatusSelectedObj.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusSelectedObj.Name = "toolStripStatusSelectedObj";
            this.toolStripStatusSelectedObj.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusSelectedObj.Text = "Ready";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(29, 17);
            this.lblUserInfo.Text = "User";
            // 
            // toolStripMain
            // 
            this.toolStripMain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1223, 25);
            this.toolStripMain.TabIndex = 7;
            this.toolStripMain.Text = "工具栏";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManagerToolStripMenuItem,
            this.DataNaviToolStripMenuItem,
            this.OperationToolStripMenuItem,
            this.ToolsToolStripMenuItem,
            this.DistributedToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1223, 24);
            this.menuStripMain.TabIndex = 6;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // ManagerToolStripMenuItem
            // 
            this.ManagerToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.ManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddConnectionToolStripMenuItem,
            this.SrvStatusToolStripMenuItem,
            this.RefreshToolStripMenuItem,
            this.toolStripMenuItem10,
            this.ExpandAllConnectionToolStripMenuItem,
            this.CollapseAllConnectionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ExitToolStripMenuItem});
            this.ManagerToolStripMenuItem.Name = "ManagerToolStripMenuItem";
            this.ManagerToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.ManagerToolStripMenuItem.Text = "&Management";
            // 
            // AddConnectionToolStripMenuItem
            // 
            this.AddConnectionToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.AddConnectionToolStripMenuItem.Name = "AddConnectionToolStripMenuItem";
            this.AddConnectionToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.AddConnectionToolStripMenuItem.Text = "&Connection Manager";
            this.AddConnectionToolStripMenuItem.Click += new System.EventHandler(this.AddConnectionToolStripMenuItem_Click);
            // 
            // SrvStatusToolStripMenuItem
            // 
            this.SrvStatusToolStripMenuItem.Name = "SrvStatusToolStripMenuItem";
            this.SrvStatusToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.SrvStatusToolStripMenuItem.Text = "&Status";
            this.SrvStatusToolStripMenuItem.Click += new System.EventHandler(this.SrvStatusToolStripMenuItem_Click);
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.RefreshToolStripMenuItem.Text = "Refresh Connections";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(190, 6);
            // 
            // ExpandAllConnectionToolStripMenuItem
            // 
            this.ExpandAllConnectionToolStripMenuItem.Image = global::MagicMongoDBTool.Properties.Resources.Collpse;
            this.ExpandAllConnectionToolStripMenuItem.Name = "ExpandAllConnectionToolStripMenuItem";
            this.ExpandAllConnectionToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ExpandAllConnectionToolStripMenuItem.Text = "Collapse";
            this.ExpandAllConnectionToolStripMenuItem.Click += new System.EventHandler(this.ExpandAllToolStripMenuItem_Click);
            // 
            // CollapseAllConnectionToolStripMenuItem
            // 
            this.CollapseAllConnectionToolStripMenuItem.Image = global::MagicMongoDBTool.Properties.Resources.Expand;
            this.CollapseAllConnectionToolStripMenuItem.Name = "CollapseAllConnectionToolStripMenuItem";
            this.CollapseAllConnectionToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.CollapseAllConnectionToolStripMenuItem.Text = "Expansion";
            this.CollapseAllConnectionToolStripMenuItem.Click += new System.EventHandler(this.CollapseAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // DataNaviToolStripMenuItem
            // 
            this.DataNaviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConvertSqlToolStripMenuItem,
            this.AggregationToolStripMenuItem,
            this.toolStripMenuItem2,
            this.statusToolStripMenuItem,
            this.commandShellToolStripMenuItem,
            this.collectionToolStripMenuItem,
            this.toolStripMenuItem9,
            this.refreshToolStripMenuItem1});
            this.DataNaviToolStripMenuItem.Name = "DataNaviToolStripMenuItem";
            this.DataNaviToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.DataNaviToolStripMenuItem.Text = "&DataView";
            // 
            // ConvertSqlToolStripMenuItem
            // 
            this.ConvertSqlToolStripMenuItem.Name = "ConvertSqlToolStripMenuItem";
            this.ConvertSqlToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ConvertSqlToolStripMenuItem.Text = "Convert Select Sql";
            this.ConvertSqlToolStripMenuItem.Click += new System.EventHandler(this.ConvertSqlToolStripMenuItem_Click);
            // 
            // AggregationToolStripMenuItem
            // 
            this.AggregationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countToolStripMenuItem,
            this.distinctToolStripMenuItem,
            this.groupToolStripMenuItem,
            this.mapReduceToolStripMenuItem});
            this.AggregationToolStripMenuItem.Name = "AggregationToolStripMenuItem";
            this.AggregationToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.AggregationToolStripMenuItem.Text = "Aggregation";
            // 
            // countToolStripMenuItem
            // 
            this.countToolStripMenuItem.Name = "countToolStripMenuItem";
            this.countToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.countToolStripMenuItem.Text = "Count";
            this.countToolStripMenuItem.Click += new System.EventHandler(this.countToolStripMenuItem_Click);
            // 
            // distinctToolStripMenuItem
            // 
            this.distinctToolStripMenuItem.Name = "distinctToolStripMenuItem";
            this.distinctToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.distinctToolStripMenuItem.Text = "Distinct";
            this.distinctToolStripMenuItem.Click += new System.EventHandler(this.distinctToolStripMenuItem_Click);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.groupToolStripMenuItem.Text = "Group";
            this.groupToolStripMenuItem.Click += new System.EventHandler(this.groupToolStripMenuItem_Click);
            // 
            // mapReduceToolStripMenuItem
            // 
            this.mapReduceToolStripMenuItem.Name = "mapReduceToolStripMenuItem";
            this.mapReduceToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.mapReduceToolStripMenuItem.Text = "MapReduce";
            this.mapReduceToolStripMenuItem.Click += new System.EventHandler(this.mapReduceToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(159, 6);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.statusToolStripMenuItem.Text = "Server Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // commandShellToolStripMenuItem
            // 
            this.commandShellToolStripMenuItem.Name = "commandShellToolStripMenuItem";
            this.commandShellToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.commandShellToolStripMenuItem.Text = "Command Shell";
            this.commandShellToolStripMenuItem.Click += new System.EventHandler(this.commandShellToolStripMenuItem_Click);
            // 
            // collectionToolStripMenuItem
            // 
            this.collectionToolStripMenuItem.Name = "collectionToolStripMenuItem";
            this.collectionToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.collectionToolStripMenuItem.Text = "Collection Data";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(159, 6);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            // 
            // OperationToolStripMenuItem
            // 
            this.OperationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ServerToolStripMenuItem,
            this.DataBaseToolStripMenuItem,
            this.DataCollectionToolStripMenuItem,
            this.DumpAndRestoreToolStripMenuItem});
            this.OperationToolStripMenuItem.Name = "OperationToolStripMenuItem";
            this.OperationToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.OperationToolStripMenuItem.Text = "&Operation";
            // 
            // ServerToolStripMenuItem
            // 
            this.ServerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateMongoDBToolStripMenuItem,
            this.toolStripMenuItem4,
            this.AddUserToAdminToolStripMenuItem,
            this.RemoveUserFromAdminToolStripMenuItem,
            this.toolStripMenuItem3,
            this.slaveResyncToolStripMenuItem,
            this.DisconnectToolStripMenuItem,
            this.ShutDownToolStripMenuItem,
            this.SvrPropertyToolStripMenuItem});
            this.ServerToolStripMenuItem.Name = "ServerToolStripMenuItem";
            this.ServerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ServerToolStripMenuItem.Text = "Server";
            // 
            // CreateMongoDBToolStripMenuItem
            // 
            this.CreateMongoDBToolStripMenuItem.Name = "CreateMongoDBToolStripMenuItem";
            this.CreateMongoDBToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.CreateMongoDBToolStripMenuItem.Text = "New Database";
            this.CreateMongoDBToolStripMenuItem.Click += new System.EventHandler(this.CreateMongoDBToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(202, 6);
            // 
            // AddUserToAdminToolStripMenuItem
            // 
            this.AddUserToAdminToolStripMenuItem.Name = "AddUserToAdminToolStripMenuItem";
            this.AddUserToAdminToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.AddUserToAdminToolStripMenuItem.Text = "Add User To Admin Group";
            this.AddUserToAdminToolStripMenuItem.Click += new System.EventHandler(this.AddUserToAdminToolStripMenuItem_Click);
            // 
            // RemoveUserFromAdminToolStripMenuItem
            // 
            this.RemoveUserFromAdminToolStripMenuItem.Name = "RemoveUserFromAdminToolStripMenuItem";
            this.RemoveUserFromAdminToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.RemoveUserFromAdminToolStripMenuItem.Text = "Del User From Admin Group";
            this.RemoveUserFromAdminToolStripMenuItem.Click += new System.EventHandler(this.RemoveUserFromAdminToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(202, 6);
            // 
            // slaveResyncToolStripMenuItem
            // 
            this.slaveResyncToolStripMenuItem.Name = "slaveResyncToolStripMenuItem";
            this.slaveResyncToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.slaveResyncToolStripMenuItem.Text = "Slave Resync";
            this.slaveResyncToolStripMenuItem.Click += new System.EventHandler(this.slaveResyncToolStripMenuItem_Click);
            // 
            // DisconnectToolStripMenuItem
            // 
            this.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem";
            this.DisconnectToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.DisconnectToolStripMenuItem.Text = "Disconnect";
            this.DisconnectToolStripMenuItem.Click += new System.EventHandler(this.DisconnectToolStripMenuItem_Click);
            // 
            // ShutDownToolStripMenuItem
            // 
            this.ShutDownToolStripMenuItem.Name = "ShutDownToolStripMenuItem";
            this.ShutDownToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ShutDownToolStripMenuItem.Text = "ShutDown Server";
            this.ShutDownToolStripMenuItem.Click += new System.EventHandler(this.ShutDownToolStripMenuItem_Click);
            // 
            // SvrPropertyToolStripMenuItem
            // 
            this.SvrPropertyToolStripMenuItem.Name = "SvrPropertyToolStripMenuItem";
            this.SvrPropertyToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.SvrPropertyToolStripMenuItem.Text = "Server Properties";
            this.SvrPropertyToolStripMenuItem.Click += new System.EventHandler(this.SvrPropertyToolStripMenuItem_Click);
            // 
            // DataBaseToolStripMenuItem
            // 
            this.DataBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateMongoCollectionToolStripMenuItem,
            this.DelMongoDBToolStripMenuItem,
            this.toolStripMenuItem5,
            this.AddUserToolStripMenuItem,
            this.RemoveUserToolStripMenuItem,
            this.toolStripMenuItem11,
            this.evalJSToolStripMenuItem,
            this.RepairDBToolStripMenuItem,
            this.InitGFSToolStripMenuItem});
            this.DataBaseToolStripMenuItem.Name = "DataBaseToolStripMenuItem";
            this.DataBaseToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.DataBaseToolStripMenuItem.Text = "Database";
            // 
            // CreateMongoCollectionToolStripMenuItem
            // 
            this.CreateMongoCollectionToolStripMenuItem.Name = "CreateMongoCollectionToolStripMenuItem";
            this.CreateMongoCollectionToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.CreateMongoCollectionToolStripMenuItem.Text = "New Collection";
            this.CreateMongoCollectionToolStripMenuItem.Click += new System.EventHandler(this.CreateMongoCollectionToolStripMenuItem_Click);
            // 
            // DelMongoDBToolStripMenuItem
            // 
            this.DelMongoDBToolStripMenuItem.Name = "DelMongoDBToolStripMenuItem";
            this.DelMongoDBToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.DelMongoDBToolStripMenuItem.Text = "Del Database";
            this.DelMongoDBToolStripMenuItem.Click += new System.EventHandler(this.DelMongoDBToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(151, 6);
            // 
            // AddUserToolStripMenuItem
            // 
            this.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem";
            this.AddUserToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.AddUserToolStripMenuItem.Text = "Add User";
            this.AddUserToolStripMenuItem.Click += new System.EventHandler(this.AddUserToolStripMenuItem_Click);
            // 
            // RemoveUserToolStripMenuItem
            // 
            this.RemoveUserToolStripMenuItem.Name = "RemoveUserToolStripMenuItem";
            this.RemoveUserToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.RemoveUserToolStripMenuItem.Text = "Del User";
            this.RemoveUserToolStripMenuItem.Click += new System.EventHandler(this.RemoveUserToolStripMenuItem_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(151, 6);
            // 
            // evalJSToolStripMenuItem
            // 
            this.evalJSToolStripMenuItem.Name = "evalJSToolStripMenuItem";
            this.evalJSToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.evalJSToolStripMenuItem.Text = "Eval Javascript";
            this.evalJSToolStripMenuItem.Click += new System.EventHandler(this.evalJSToolStripMenuItem_Click);
            // 
            // RepairDBToolStripMenuItem
            // 
            this.RepairDBToolStripMenuItem.Name = "RepairDBToolStripMenuItem";
            this.RepairDBToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.RepairDBToolStripMenuItem.Text = "Repair Database";
            this.RepairDBToolStripMenuItem.Click += new System.EventHandler(this.RepairDBToolStripMenuItem_Click);
            // 
            // DataCollectionToolStripMenuItem
            // 
            this.DataCollectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DelMongoCollectionToolStripMenuItem,
            this.RenameCollectionToolStripMenuItem,
            this.IndexManageToolStripMenuItem,
            this.ReIndexToolStripMenuItem,
            this.toolStripMenuItem8,
            this.CompactToolStripMenuItem,
            this.viewDataToolStripMenuItem});
            this.DataCollectionToolStripMenuItem.Name = "DataCollectionToolStripMenuItem";
            this.DataCollectionToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.DataCollectionToolStripMenuItem.Text = "Collection";
            // 
            // DelMongoCollectionToolStripMenuItem
            // 
            this.DelMongoCollectionToolStripMenuItem.Name = "DelMongoCollectionToolStripMenuItem";
            this.DelMongoCollectionToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.DelMongoCollectionToolStripMenuItem.Text = "Drop Collection";
            this.DelMongoCollectionToolStripMenuItem.Click += new System.EventHandler(this.DelMongoCollectionToolStripMenuItem_Click);
            // 
            // RenameCollectionToolStripMenuItem
            // 
            this.RenameCollectionToolStripMenuItem.Name = "RenameCollectionToolStripMenuItem";
            this.RenameCollectionToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.RenameCollectionToolStripMenuItem.Text = "Rename";
            this.RenameCollectionToolStripMenuItem.Click += new System.EventHandler(this.RenameCollectionToolStripMenuItem_Click);
            // 
            // IndexManageToolStripMenuItem
            // 
            this.IndexManageToolStripMenuItem.Name = "IndexManageToolStripMenuItem";
            this.IndexManageToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.IndexManageToolStripMenuItem.Text = "Index Management";
            this.IndexManageToolStripMenuItem.Click += new System.EventHandler(this.IndexManageToolStripMenuItem_Click);
            // 
            // ReIndexToolStripMenuItem
            // 
            this.ReIndexToolStripMenuItem.Name = "ReIndexToolStripMenuItem";
            this.ReIndexToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ReIndexToolStripMenuItem.Text = "ReIndex";
            this.ReIndexToolStripMenuItem.Click += new System.EventHandler(this.ReIndexToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(164, 6);
            // 
            // CompactToolStripMenuItem
            // 
            this.CompactToolStripMenuItem.Name = "CompactToolStripMenuItem";
            this.CompactToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.CompactToolStripMenuItem.Text = "Compact";
            this.CompactToolStripMenuItem.Click += new System.EventHandler(this.CompactToolStripMenuItem_Click);
            // 
            // viewDataToolStripMenuItem
            // 
            this.viewDataToolStripMenuItem.Name = "viewDataToolStripMenuItem";
            this.viewDataToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.viewDataToolStripMenuItem.Text = "ViewData";
            this.viewDataToolStripMenuItem.Click += new System.EventHandler(this.viewDataToolStripMenuItem_Click);
            // 
            // DumpAndRestoreToolStripMenuItem
            // 
            this.DumpAndRestoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestoreMongoToolStripMenuItem,
            this.DumpDatabaseToolStripMenuItem,
            this.DumpCollectionToolStripMenuItem,
            this.toolStripMenuItem6,
            this.ImportCollectionToolStripMenuItem,
            this.ExportCollectionToolStripMenuItem});
            this.DumpAndRestoreToolStripMenuItem.Name = "DumpAndRestoreToolStripMenuItem";
            this.DumpAndRestoreToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.DumpAndRestoreToolStripMenuItem.Text = "Dump And Restore";
            // 
            // RestoreMongoToolStripMenuItem
            // 
            this.RestoreMongoToolStripMenuItem.Name = "RestoreMongoToolStripMenuItem";
            this.RestoreMongoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.RestoreMongoToolStripMenuItem.Text = "Restore";
            this.RestoreMongoToolStripMenuItem.Click += new System.EventHandler(this.RestoreMongoToolStripMenuItem_Click);
            // 
            // DumpDatabaseToolStripMenuItem
            // 
            this.DumpDatabaseToolStripMenuItem.Name = "DumpDatabaseToolStripMenuItem";
            this.DumpDatabaseToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.DumpDatabaseToolStripMenuItem.Text = "Dump DataBase";
            this.DumpDatabaseToolStripMenuItem.Click += new System.EventHandler(this.DumpDatabaseToolStripMenuItem_Click);
            // 
            // DumpCollectionToolStripMenuItem
            // 
            this.DumpCollectionToolStripMenuItem.Name = "DumpCollectionToolStripMenuItem";
            this.DumpCollectionToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.DumpCollectionToolStripMenuItem.Text = "Dump Collection";
            this.DumpCollectionToolStripMenuItem.Click += new System.EventHandler(this.DumpCollectionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(175, 6);
            // 
            // ImportCollectionToolStripMenuItem
            // 
            this.ImportCollectionToolStripMenuItem.Name = "ImportCollectionToolStripMenuItem";
            this.ImportCollectionToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ImportCollectionToolStripMenuItem.Text = "Import DataCollection";
            this.ImportCollectionToolStripMenuItem.Click += new System.EventHandler(this.ImportCollectionToolStripMenuItem_Click);
            // 
            // ExportCollectionToolStripMenuItem
            // 
            this.ExportCollectionToolStripMenuItem.Name = "ExportCollectionToolStripMenuItem";
            this.ExportCollectionToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ExportCollectionToolStripMenuItem.Text = "Export DataCollection";
            this.ExportCollectionToolStripMenuItem.Click += new System.EventHandler(this.ExportCollectionToolStripMenuItem_Click);
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DosCommandToolStripMenuItem,
            this.ImportDataFromAccessToolStripMenuItem,
            this.toolStripMenuItem7,
            this.OptionsToolStripMenuItem});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ToolsToolStripMenuItem.Text = "&Tools";
            // 
            // DosCommandToolStripMenuItem
            // 
            this.DosCommandToolStripMenuItem.Name = "DosCommandToolStripMenuItem";
            this.DosCommandToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.DosCommandToolStripMenuItem.Text = "&DOS Command";
            this.DosCommandToolStripMenuItem.Click += new System.EventHandler(this.DosCommandToolStripMenuItem_Click);
            // 
            // ImportDataFromAccessToolStripMenuItem
            // 
            this.ImportDataFromAccessToolStripMenuItem.Name = "ImportDataFromAccessToolStripMenuItem";
            this.ImportDataFromAccessToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ImportDataFromAccessToolStripMenuItem.Text = "&Import Access DB";
            this.ImportDataFromAccessToolStripMenuItem.Click += new System.EventHandler(this.ImportDataFromAccessToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(155, 6);
            // 
            // OptionsToolStripMenuItem
            // 
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.OptionsToolStripMenuItem.Text = "&Options";
            this.OptionsToolStripMenuItem.Click += new System.EventHandler(this.OptionToolStripMenuItem_Click);
            // 
            // DistributedToolStripMenuItem
            // 
            this.DistributedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReplicaSetToolStripMenuItem,
            this.ShardingConfigToolStripMenuItem});
            this.DistributedToolStripMenuItem.Name = "DistributedToolStripMenuItem";
            this.DistributedToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.DistributedToolStripMenuItem.Text = "D&istributed";
            // 
            // ReplicaSetToolStripMenuItem
            // 
            this.ReplicaSetToolStripMenuItem.Name = "ReplicaSetToolStripMenuItem";
            this.ReplicaSetToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ReplicaSetToolStripMenuItem.Text = "&ReplicaSet";
            this.ReplicaSetToolStripMenuItem.Click += new System.EventHandler(this.ReplicaSetToolStripMenuItem_Click);
            // 
            // ShardingConfigToolStripMenuItem
            // 
            this.ShardingConfigToolStripMenuItem.Name = "ShardingConfigToolStripMenuItem";
            this.ShardingConfigToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ShardingConfigToolStripMenuItem.Text = "&Sharding Config";
            this.ShardingConfigToolStripMenuItem.Click += new System.EventHandler(this.ShardingConfigToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem,
            this.ThanksToolStripMenuItem,
            this.UserGuideToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.HelpToolStripMenuItem.Text = "&Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.AboutToolStripMenuItem.Text = "&About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // ThanksToolStripMenuItem
            // 
            this.ThanksToolStripMenuItem.Name = "ThanksToolStripMenuItem";
            this.ThanksToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.ThanksToolStripMenuItem.Text = "&Thanks";
            this.ThanksToolStripMenuItem.Click += new System.EventHandler(this.ThanksToolStripMenuItem_Click);
            // 
            // UserGuideToolStripMenuItem
            // 
            this.UserGuideToolStripMenuItem.Name = "UserGuideToolStripMenuItem";
            this.UserGuideToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.UserGuideToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.UserGuideToolStripMenuItem.Text = "UserGuide";
            this.UserGuideToolStripMenuItem.Click += new System.EventHandler(this.userGuideToolStripMenuItem_Click);
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(61, 4);
            // 
            // trvsrvlst
            // 
            this.trvsrvlst.BackColor = System.Drawing.Color.White;
            this.trvsrvlst.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvsrvlst.Location = new System.Drawing.Point(0, 0);
            this.trvsrvlst.Name = "trvsrvlst";
            this.trvsrvlst.Size = new System.Drawing.Size(334, 631);
            this.trvsrvlst.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.trvsrvlst);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 631);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(337, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 631);
            this.panel2.TabIndex = 2;
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.tabSvrStatus);
            this.tabView.Controls.Add(this.tabCommandShell);
            this.tabView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabView.Location = new System.Drawing.Point(0, 0);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new System.Drawing.Size(886, 631);
            this.tabView.TabIndex = 3;
            // 
            // tabSvrStatus
            // 
            this.tabSvrStatus.Controls.Add(this.ServerStatusCtl);
            this.tabSvrStatus.Location = new System.Drawing.Point(4, 25);
            this.tabSvrStatus.Name = "tabSvrStatus";
            this.tabSvrStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabSvrStatus.Size = new System.Drawing.Size(878, 602);
            this.tabSvrStatus.TabIndex = 0;
            this.tabSvrStatus.Text = "Sever Status";
            this.tabSvrStatus.UseVisualStyleBackColor = true;
            // 
            // tabCommandShell
            // 
            this.tabCommandShell.Controls.Add(this.txtCommand);
            this.tabCommandShell.Location = new System.Drawing.Point(4, 25);
            this.tabCommandShell.Name = "tabCommandShell";
            this.tabCommandShell.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommandShell.Size = new System.Drawing.Size(878, 602);
            this.tabCommandShell.TabIndex = 1;
            this.tabCommandShell.Text = "Shell Command";
            this.tabCommandShell.UseVisualStyleBackColor = true;
            // 
            // txtCommand
            // 
            this.txtCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCommand.Location = new System.Drawing.Point(3, 3);
            this.txtCommand.Multiline = true;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(872, 596);
            this.txtCommand.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(334, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 631);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // ServerStatusCtl
            // 
            this.ServerStatusCtl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerStatusCtl.Location = new System.Drawing.Point(3, 3);
            this.ServerStatusCtl.Margin = new System.Windows.Forms.Padding(5);
            this.ServerStatusCtl.Name = "ServerStatusCtl";
            this.ServerStatusCtl.Size = new System.Drawing.Size(872, 596);
            this.ServerStatusCtl.TabIndex = 2;
            // 
            // InitGFSToolStripMenuItem
            // 
            this.InitGFSToolStripMenuItem.Name = "InitGFSToolStripMenuItem";
            this.InitGFSToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.InitGFSToolStripMenuItem.Text = "Init GFS";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1223, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mongo-Cola";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            this.tabSvrStatus.ResumeLayout(false);
            this.tabCommandShell.ResumeLayout(false);
            this.tabCommandShell.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        /// <summary>
        /// 设置图标
        /// </summary>
        private void SetMenuImage()
        {
            this.ShutDownToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetImage(MagicMongoDBTool.Module.ImageType.ShutDown);

            this.DelMongoCollectionToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetIcon(IconType.No).ToBitmap();
            this.DelMongoDBToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetIcon(IconType.No).ToBitmap();
            this.RemoveUserFromAdminToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetIcon(IconType.No).ToBitmap();
            this.RemoveUserToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetIcon(IconType.No).ToBitmap();


            this.ImportDataFromAccessToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetImage(MagicMongoDBTool.Module.ImageType.AccessDB);
            this.RefreshToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetImage(MagicMongoDBTool.Module.ImageType.Refresh);
            this.OptionsToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetImage(MagicMongoDBTool.Module.ImageType.Option);

            this.ThanksToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetImage(MagicMongoDBTool.Module.ImageType.Smile);
            this.UserGuideToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetIcon(MagicMongoDBTool.Module.IconType.UserGuide).ToBitmap();
        }
        /// <summary>
        /// 初始化Toolbar
        /// </summary>
        private void InitToolBar()
        {
            RefreshToolStripButton = this.RefreshToolStripMenuItem.CloneFromMenuItem();
            ImportDataFromAccessToolStripButton = this.ImportDataFromAccessToolStripMenuItem.CloneFromMenuItem();
            ShutDownToolStripButton = this.ShutDownToolStripMenuItem.CloneFromMenuItem();
            OptionToolStripButton = this.OptionsToolStripMenuItem.CloneFromMenuItem();
            UserGuideToolStripButton = this.UserGuideToolStripMenuItem.CloneFromMenuItem();
#if MONO
            FirstPageToolStripButton.Click += new System.EventHandler(FirstPageToolStripMenuItem_Click);
            PrePageToolStripButton.Click += new System.EventHandler(PrePageToolStripMenuItem_Click);
            NextPageToolStripButton.Click += new System.EventHandler(NextPageToolStripMenuItem_Click);
            LastPageToolStripButton.Click += new System.EventHandler(LastPageToolStripMenuItem_Click);
            QueryDataToolStripButton.Click += new System.EventHandler(QueryDataToolStripMenuItem_Click);
            DataFilterToolStripButton.Click += new System.EventHandler(DataFilterToolStripMenuItem_Click);
            RefreshToolStripButton.Click += new System.EventHandler(RefreshToolStripMenuItem_Click);
            ImportDataFromAccessToolStripButton.Click += new System.EventHandler(ImportDataFromAccessToolStripMenuItem_Click);
            OptionToolStripButton.Click += new System.EventHandler(OptionToolStripMenuItem_Click);
#endif



            //Main ToolTip
            this.toolStripMain.Items.Add(RefreshToolStripButton);
            this.toolStripMain.Items.Add(ShutDownToolStripButton);
#if !MONO
            this.toolStripMain.Items.Add(ImportDataFromAccessToolStripButton);
#endif
            this.toolStripMain.Items.Add(OptionToolStripButton);
            this.toolStripMain.Items.Add(UserGuideToolStripButton);

        }
        /// <summary>
        /// 设定工具栏
        /// </summary>
        private void SetToolBarEnabled()
        {

            RefreshToolStripButton.Enabled = this.RefreshToolStripMenuItem.Enabled;
#if !MONO
            ImportDataFromAccessToolStripButton.Enabled = this.ImportDataFromAccessToolStripMenuItem.Enabled;
#endif
            OptionToolStripButton.Enabled = this.OptionsToolStripMenuItem.Enabled;
        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusSelectedObj;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem ManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SrvStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataNaviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShutDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateMongoDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelMongoDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateMongoCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelMongoCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IndexManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenameCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DosCommandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportDataFromAccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DistributedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReplicaSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShardingConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapReduceToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem AddUserToAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThanksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExpandAllConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CollapseAllConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SvrPropertyToolStripMenuItem;

        private ToolStripButton ImportDataFromAccessToolStripButton;
        private ToolStripButton RefreshToolStripButton;
        private ToolStripButton OptionToolStripButton;
        private ToolStripButton UserGuideToolStripButton;
        private ToolStripButton ShutDownToolStripButton;

        private ToolStripMenuItem DumpAndRestoreToolStripMenuItem;
        private ToolStripMenuItem RestoreMongoToolStripMenuItem;
        private ToolStripMenuItem DumpDatabaseToolStripMenuItem;
        private ToolStripMenuItem DumpCollectionToolStripMenuItem;
        private ToolStripMenuItem ImportCollectionToolStripMenuItem;
        private ToolStripMenuItem ExportCollectionToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem10;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripSeparator toolStripMenuItem8;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripSeparator toolStripMenuItem7;
        private ToolStripMenuItem ReIndexToolStripMenuItem;
        private ToolStripMenuItem AggregationToolStripMenuItem;
        private ToolStripMenuItem countToolStripMenuItem;
        private ToolStripMenuItem distinctToolStripMenuItem;
        private ToolStripMenuItem groupToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem11;
        private ToolStripMenuItem evalJSToolStripMenuItem;
        private ToolStripMenuItem ConvertSqlToolStripMenuItem;
        private ToolStripMenuItem RemoveUserFromAdminToolStripMenuItem;
        private ToolStripMenuItem DisconnectToolStripMenuItem;
        private ToolStripStatusLabel lblUserInfo;
        private TreeView trvsrvlst;
        private ToolStripMenuItem RepairDBToolStripMenuItem;
        private ToolStripMenuItem slaveResyncToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private Splitter splitter1;
        private ToolStripMenuItem UserGuideToolStripMenuItem;
        private ToolStripMenuItem CompactToolStripMenuItem;
        private TextBox txtCommand;
        private UserController.ctlServerStatus ServerStatusCtl;
        private TabControl tabView;
        private TabPage tabSvrStatus;
        private TabPage tabCommandShell;
        private ToolStripMenuItem viewDataToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem statusToolStripMenuItem;
        private ToolStripMenuItem commandShellToolStripMenuItem;
        private ToolStripMenuItem collectionToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem9;
        private ToolStripMenuItem refreshToolStripMenuItem1;
        private ToolStripMenuItem InitGFSToolStripMenuItem;
    }
}