namespace SureSQL.Forms
{
    partial class form_Main
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
            this.tab_main = new System.Windows.Forms.TabControl();
            this.tabRoot = new System.Windows.Forms.TabPage();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.chk_DelaySearch = new System.Windows.Forms.CheckBox();
            this.lbl_CurrentTag = new System.Windows.Forms.Label();
            this.lbl_CurrentDB = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_NewConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_TSQL = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_MySQL = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_main.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_main
            // 
            this.tab_main.Controls.Add(this.tabRoot);
            this.tab_main.Location = new System.Drawing.Point(12, 123);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(1236, 542);
            this.tab_main.TabIndex = 0;
            // 
            // tabRoot
            // 
            this.tabRoot.Location = new System.Drawing.Point(4, 22);
            this.tabRoot.Name = "tabRoot";
            this.tabRoot.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoot.Size = new System.Drawing.Size(1228, 516);
            this.tabRoot.TabIndex = 0;
            this.tabRoot.Text = "Root";
            this.tabRoot.ToolTipText = "Root of Database";
            this.tabRoot.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(749, 76);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(494, 78);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(249, 20);
            this.txt_Search.TabIndex = 2;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // chk_DelaySearch
            // 
            this.chk_DelaySearch.AutoSize = true;
            this.chk_DelaySearch.Location = new System.Drawing.Point(749, 106);
            this.chk_DelaySearch.Name = "chk_DelaySearch";
            this.chk_DelaySearch.Size = new System.Drawing.Size(90, 17);
            this.chk_DelaySearch.TabIndex = 3;
            this.chk_DelaySearch.Text = "Delay Search";
            this.chk_DelaySearch.UseVisualStyleBackColor = true;
            // 
            // lbl_CurrentTag
            // 
            this.lbl_CurrentTag.AutoSize = true;
            this.lbl_CurrentTag.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentTag.Location = new System.Drawing.Point(13, 86);
            this.lbl_CurrentTag.Name = "lbl_CurrentTag";
            this.lbl_CurrentTag.Size = new System.Drawing.Size(73, 19);
            this.lbl_CurrentTag.TabIndex = 4;
            this.lbl_CurrentTag.Text = "Current: ";
            // 
            // lbl_CurrentDB
            // 
            this.lbl_CurrentDB.AutoSize = true;
            this.lbl_CurrentDB.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentDB.Location = new System.Drawing.Point(79, 86);
            this.lbl_CurrentDB.Name = "lbl_CurrentDB";
            this.lbl_CurrentDB.Size = new System.Drawing.Size(51, 19);
            this.lbl_CurrentDB.TabIndex = 5;
            this.lbl_CurrentDB.Text = "NONE";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1260, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_NewConnection});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem1.Text = "Database";
            // 
            // menu_NewConnection
            // 
            this.menu_NewConnection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_TSQL,
            this.menu_MySQL});
            this.menu_NewConnection.Name = "menu_NewConnection";
            this.menu_NewConnection.Size = new System.Drawing.Size(180, 22);
            this.menu_NewConnection.Text = "New Connection";
            this.menu_NewConnection.Click += new System.EventHandler(this.menu_NewConnection_Click);
            // 
            // menu_TSQL
            // 
            this.menu_TSQL.Name = "menu_TSQL";
            this.menu_TSQL.Size = new System.Drawing.Size(180, 22);
            this.menu_TSQL.Text = "T-SQL";
            this.menu_TSQL.Click += new System.EventHandler(this.menu_TSQL_Click);
            // 
            // menu_MySQL
            // 
            this.menu_MySQL.Name = "menu_MySQL";
            this.menu_MySQL.Size = new System.Drawing.Size(180, 22);
            this.menu_MySQL.Text = "MySQL";
            this.menu_MySQL.Click += new System.EventHandler(this.menu_MySQL_Click);
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1260, 675);
            this.Controls.Add(this.lbl_CurrentDB);
            this.Controls.Add(this.lbl_CurrentTag);
            this.Controls.Add(this.chk_DelaySearch);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tab_main);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "form_Main";
            this.Load += new System.EventHandler(this.form_Main_Load);
            this.tab_main.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_main;
        private System.Windows.Forms.TabPage tabRoot;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.CheckBox chk_DelaySearch;
        private System.Windows.Forms.Label lbl_CurrentTag;
        private System.Windows.Forms.Label lbl_CurrentDB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menu_NewConnection;
        private System.Windows.Forms.ToolStripMenuItem menu_TSQL;
        private System.Windows.Forms.ToolStripMenuItem menu_MySQL;
    }
}