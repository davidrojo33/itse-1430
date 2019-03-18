using System;

namespace CharacterCreator.Winforms
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
        protected override void Dispose( bool disposing )
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this._ListCharacters = new System.Windows.Forms.ListBox();
            this._ListItems = new System.Windows.Forms.ListBox();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Click += new System.EventHandler(this.OnFileExit);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnFileExit);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.OnCharacterAdd);
            // 
            // _ListCharacters
            // 
            this._ListCharacters.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ListCharacters.FormattingEnabled = true;
            this._ListCharacters.Location = new System.Drawing.Point(0, 24);
            this._ListCharacters.Name = "_ListCharacters";
            this._ListCharacters.Size = new System.Drawing.Size(284, 387);
            this._ListCharacters.TabIndex = 1;
            // 
            // _ListItems
            // 
            this._ListItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ListItems.FormattingEnabled = true;
            this._ListItems.Location = new System.Drawing.Point(0, 24);
            this._ListItems.Name = "_ListItems";
            this._ListItems.Size = new System.Drawing.Size(284, 387);
            this._ListItems.TabIndex = 1;
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.OnFileExit);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "New";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.OnCharacterAdd);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.OnCharacterEdit);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.OnCharacterDelete);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // fileToolStripMenuItem2
            // 
            this.fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            this.fileToolStripMenuItem2.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem2.Text = "File";
            // 
            // editToolStripMenuItem2
            // 
            this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            this.editToolStripMenuItem2.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem2.Text = "Edit";
            // 
            // helpToolStripMenuItem2
            // 
            this.helpToolStripMenuItem2.Name = "helpToolStripMenuItem2";
            this.helpToolStripMenuItem2.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem2.Text = "Help";
            // 
            // fileToolStripMenuItem3
            // 
            this.fileToolStripMenuItem3.Name = "fileToolStripMenuItem3";
            this.fileToolStripMenuItem3.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem3.Text = "File";
            // 
            // editToolStripMenuItem3
            // 
            this.editToolStripMenuItem3.Name = "editToolStripMenuItem3";
            this.editToolStripMenuItem3.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem3.Text = "Edit";
            // 
            // helpToolStripMenuItem3
            // 
            this.helpToolStripMenuItem3.Name = "helpToolStripMenuItem3";
            this.helpToolStripMenuItem3.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem3.Text = "Help";
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem2.Text = "Exit";
            // 
            // newToolStripMenuItem2
            // 
            this.newToolStripMenuItem2.Name = "newToolStripMenuItem2";
            this.newToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem2.Text = "New";
            // 
            // editToolStripMenuItem4
            // 
            this.editToolStripMenuItem4.Name = "editToolStripMenuItem4";
            this.editToolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.editToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem4.Text = "Edit";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // aboutToolStripMenuItem2
            // 
            this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            this.aboutToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.aboutToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem2.Text = "About";
            // 
            // fileToolStripMenuItem4
            // 
            this.fileToolStripMenuItem4.Name = "fileToolStripMenuItem4";
            this.fileToolStripMenuItem4.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem4.Text = "File";
            // 
            // editToolStripMenuItem5
            // 
            this.editToolStripMenuItem5.Name = "editToolStripMenuItem5";
            this.editToolStripMenuItem5.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem5.Text = "Edit";
            // 
            // helpToolStripMenuItem4
            // 
            this.helpToolStripMenuItem4.Name = "helpToolStripMenuItem4";
            this.helpToolStripMenuItem4.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem4.Text = "Help";
            // 
            // exitToolStripMenuItem3
            // 
            this.exitToolStripMenuItem3.Name = "exitToolStripMenuItem3";
            this.exitToolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem3.Text = "Exit";
            this.exitToolStripMenuItem3.Click += new System.EventHandler(this.OnFileExit);
            // 
            // newToolStripMenuItem3
            // 
            this.newToolStripMenuItem3.Name = "newToolStripMenuItem3";
            this.newToolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem3.Text = "New";
            this.newToolStripMenuItem3.Click += new System.EventHandler(this.OnCharacterAdd);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem1.Text = "Edit";
            this.addToolStripMenuItem1.DoubleClick += new System.EventHandler(this.OnCharacterEdit);
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem2.Text = "Delete";
            this.deleteToolStripMenuItem2.DoubleClick += new System.EventHandler(this.OnCharacterDelete);
            // 
            // aboutToolStripMenuItem3
            // 
            this.aboutToolStripMenuItem3.Name = "aboutToolStripMenuItem3";
            this.aboutToolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.aboutToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem3.Text = "About";
            this.aboutToolStripMenuItem3.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // fileToolStripMenuItem5
            // 
            this.fileToolStripMenuItem5.Name = "fileToolStripMenuItem5";
            this.fileToolStripMenuItem5.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem5.Text = "File";
            // 
            // editToolStripMenuItem6
            // 
            this.editToolStripMenuItem6.Name = "editToolStripMenuItem6";
            this.editToolStripMenuItem6.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem6.Text = "Edit";
            // 
            // helpToolStripMenuItem5
            // 
            this.helpToolStripMenuItem5.Name = "helpToolStripMenuItem5";
            this.helpToolStripMenuItem5.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem5.Text = "Help";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this._ListCharacters);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(260, 420);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CharacterCreator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MainForm_Load( object sender, EventArgs e )
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ListBox _ListCharacters;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        internal System.Windows.Forms.ListBox _ListItems;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem5;
    }
}

