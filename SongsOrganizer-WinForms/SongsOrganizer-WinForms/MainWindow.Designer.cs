﻿namespace SongsOrganizer_WinForms
{
    partial class MainWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.songsGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chooseDirectoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMarkedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songsGridContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editSongContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.markForDeletionContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertChangesContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songsGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.songsGridContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.songsGrid);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // songsGrid
            // 
            this.songsGrid.AllowUserToAddRows = false;
            this.songsGrid.AllowUserToDeleteRows = false;
            this.songsGrid.AllowUserToResizeRows = false;
            this.songsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songsGrid.ContextMenuStrip = this.songsGridContextMenuStrip;
            this.songsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.songsGrid.Location = new System.Drawing.Point(0, 24);
            this.songsGrid.Name = "songsGrid";
            this.songsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.songsGrid.Size = new System.Drawing.Size(800, 426);
            this.songsGrid.TabIndex = 1;
            this.songsGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.songsGrid_CellMouseDoubleClick);
            this.songsGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.songsGrid_CellMouseDown);
            this.songsGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.songsGrid_ColumnHeaderMouseClick);
            this.songsGrid.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.songsGrid_RowPrePaint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseDirectoryMenuItem,
            this.reloadSongsToolStripMenuItem,
            this.revertChangesToolStripMenuItem,
            this.saveChangesToolStripMenuItem,
            this.deleteMarkedToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chooseDirectoryMenuItem
            // 
            this.chooseDirectoryMenuItem.Name = "chooseDirectoryMenuItem";
            this.chooseDirectoryMenuItem.Size = new System.Drawing.Size(110, 20);
            this.chooseDirectoryMenuItem.Text = "Choose Directory";
            this.chooseDirectoryMenuItem.Click += new System.EventHandler(this.chooseDirectoryMenuItem_Click);
            // 
            // reloadSongsToolStripMenuItem
            // 
            this.reloadSongsToolStripMenuItem.Name = "reloadSongsToolStripMenuItem";
            this.reloadSongsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.reloadSongsToolStripMenuItem.Text = "Reload Songs";
            this.reloadSongsToolStripMenuItem.Click += new System.EventHandler(this.reloadSongsToolStripMenuItem_Click);
            // 
            // revertChangesToolStripMenuItem
            // 
            this.revertChangesToolStripMenuItem.Name = "revertChangesToolStripMenuItem";
            this.revertChangesToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.revertChangesToolStripMenuItem.Text = "Revert Changes";
            this.revertChangesToolStripMenuItem.Click += new System.EventHandler(this.revertChangesToolStripMenuItem_Click);
            // 
            // saveChangesToolStripMenuItem
            // 
            this.saveChangesToolStripMenuItem.Name = "saveChangesToolStripMenuItem";
            this.saveChangesToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.saveChangesToolStripMenuItem.Text = "Save Changes";
            this.saveChangesToolStripMenuItem.Click += new System.EventHandler(this.saveChangesToolStripMenuItem_Click);
            // 
            // deleteMarkedToolStripMenuItem
            // 
            this.deleteMarkedToolStripMenuItem.Name = "deleteMarkedToolStripMenuItem";
            this.deleteMarkedToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.deleteMarkedToolStripMenuItem.Text = "Delete Marked";
            this.deleteMarkedToolStripMenuItem.Click += new System.EventHandler(this.deleteMarkedToolStripMenuItem_Click);
            // 
            // songsGridContextMenuStrip
            // 
            this.songsGridContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSongContextMenuItem,
            this.toolStripSeparator1,
            this.markForDeletionContextMenuItem,
            this.revertChangesContextMenuItem});
            this.songsGridContextMenuStrip.Name = "songsGridContextMenuStrip";
            this.songsGridContextMenuStrip.Size = new System.Drawing.Size(181, 98);
            // 
            // editSongContextMenuItem
            // 
            this.editSongContextMenuItem.Name = "editSongContextMenuItem";
            this.editSongContextMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editSongContextMenuItem.Text = "Edit Song";
            this.editSongContextMenuItem.Click += new System.EventHandler(this.editSongContextMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // markForDeletionContextMenuItem
            // 
            this.markForDeletionContextMenuItem.Name = "markForDeletionContextMenuItem";
            this.markForDeletionContextMenuItem.Size = new System.Drawing.Size(180, 22);
            this.markForDeletionContextMenuItem.Text = "Mark for deletion";
            this.markForDeletionContextMenuItem.Click += new System.EventHandler(this.markForDeletionContextMenuItem_Click);
            // 
            // revertChangesContextMenuItem
            // 
            this.revertChangesContextMenuItem.Name = "revertChangesContextMenuItem";
            this.revertChangesContextMenuItem.Size = new System.Drawing.Size(180, 22);
            this.revertChangesContextMenuItem.Text = "Revert changes";
            this.revertChangesContextMenuItem.Click += new System.EventHandler(this.revertChangesContextMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "CloneHero - Songs Organizer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songsGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.songsGridContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView songsGrid;
        private System.Windows.Forms.ToolStripMenuItem chooseDirectoryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadSongsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revertChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMarkedToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip songsGridContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editSongContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem markForDeletionContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revertChangesContextMenuItem;
    }
}

