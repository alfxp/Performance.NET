﻿namespace HeapInspector
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
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heapObjectsGrid = new System.Windows.Forms.DataGridView();
            this.autoRefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTypes = new System.Windows.Forms.TabPage();
            this.tabString = new System.Windows.Forms.TabPage();
            this.stringsGrid = new System.Windows.Forms.DataGridView();
            this.clText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heapObjectsGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabTypes.SuspendLayout();
            this.tabString.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stringsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.newToolStripMenuItem.Text = "Inspect";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.actionsToolStripMenuItem.Image = global::HeapInspector.Properties.Resources.calc;
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoRefreshToolStripMenuItem});
            this.refreshToolStripMenuItem.Image = global::HeapInspector.Properties.Resources.reload_page;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // autoRefreshToolStripMenuItem
            // 
            this.autoRefreshToolStripMenuItem.Name = "autoRefreshToolStripMenuItem";
            this.autoRefreshToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.autoRefreshToolStripMenuItem.Text = "Auto Refresh";
            this.autoRefreshToolStripMenuItem.Click += new System.EventHandler(this.AutoRefreshToolStripMenuItem_Click);
            // 
            // heapObjectsGrid
            // 
            this.heapObjectsGrid.AllowUserToAddRows = false;
            this.heapObjectsGrid.AllowUserToDeleteRows = false;
            this.heapObjectsGrid.AllowUserToResizeRows = false;
            this.heapObjectsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.heapObjectsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.heapObjectsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeName,
            this.Count,
            this.MinSize,
            this.MaxSize,
            this.Total});
            this.heapObjectsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heapObjectsGrid.Location = new System.Drawing.Point(3, 3);
            this.heapObjectsGrid.Name = "heapObjectsGrid";
            this.heapObjectsGrid.RowHeadersVisible = false;
            this.heapObjectsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.heapObjectsGrid.Size = new System.Drawing.Size(786, 394);
            this.heapObjectsGrid.TabIndex = 1;
            // 
            // autoRefreshTimer
            // 
            this.autoRefreshTimer.Interval = 1000;
            this.autoRefreshTimer.Tick += new System.EventHandler(this.AutoRefreshTimer_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTypes);
            this.tabControl1.Controls.Add(this.tabString);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 426);
            this.tabControl1.TabIndex = 2;
            // 
            // tabTypes
            // 
            this.tabTypes.Controls.Add(this.heapObjectsGrid);
            this.tabTypes.Location = new System.Drawing.Point(4, 22);
            this.tabTypes.Name = "tabTypes";
            this.tabTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tabTypes.Size = new System.Drawing.Size(792, 400);
            this.tabTypes.TabIndex = 0;
            this.tabTypes.Text = "Types";
            this.tabTypes.UseVisualStyleBackColor = true;
            // 
            // tabString
            // 
            this.tabString.Controls.Add(this.stringsGrid);
            this.tabString.Location = new System.Drawing.Point(4, 22);
            this.tabString.Name = "tabString";
            this.tabString.Padding = new System.Windows.Forms.Padding(3);
            this.tabString.Size = new System.Drawing.Size(792, 400);
            this.tabString.TabIndex = 1;
            this.tabString.Text = "String";
            this.tabString.UseVisualStyleBackColor = true;
            // 
            // stringsGrid
            // 
            this.stringsGrid.AllowUserToAddRows = false;
            this.stringsGrid.AllowUserToDeleteRows = false;
            this.stringsGrid.AllowUserToResizeRows = false;
            this.stringsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stringsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stringsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clText,
            this.clCount,
            this.clLength});
            this.stringsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stringsGrid.Location = new System.Drawing.Point(3, 3);
            this.stringsGrid.Name = "stringsGrid";
            this.stringsGrid.RowHeadersVisible = false;
            this.stringsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stringsGrid.Size = new System.Drawing.Size(786, 394);
            this.stringsGrid.TabIndex = 2;
            // 
            // clText
            // 
            this.clText.HeaderText = "Text";
            this.clText.Name = "clText";
            // 
            // clCount
            // 
            this.clCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clCount.HeaderText = "Count";
            this.clCount.Name = "clCount";
            this.clCount.Width = 80;
            // 
            // clLength
            // 
            this.clLength.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clLength.HeaderText = "Length";
            this.clLength.Name = "clLength";
            // 
            // TypeName
            // 
            this.TypeName.HeaderText = "Type Name";
            this.TypeName.Name = "TypeName";
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            // 
            // MinSize
            // 
            this.MinSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MinSize.HeaderText = "Min Size (Bytes)";
            this.MinSize.Name = "MinSize";
            this.MinSize.Width = 150;
            // 
            // MaxSize
            // 
            this.MaxSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaxSize.HeaderText = "Max Size (Bytes)";
            this.MaxSize.Name = "MaxSize";
            this.MaxSize.Width = 150;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Total.HeaderText = "Total (Bytes)";
            this.Total.Name = "Total";
            this.Total.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Heap Inspector";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heapObjectsGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabTypes.ResumeLayout(false);
            this.tabString.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stringsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.DataGridView heapObjectsGrid;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoRefreshToolStripMenuItem;
        private System.Windows.Forms.Timer autoRefreshTimer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTypes;
        private System.Windows.Forms.TabPage tabString;
        private System.Windows.Forms.DataGridView stringsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clText;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}

