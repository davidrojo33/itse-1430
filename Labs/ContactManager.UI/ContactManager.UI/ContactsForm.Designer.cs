namespace ContactManager.UI
{
    partial class ContactsForm
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
            this.listContacts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listContacts
            // 
            this.listContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listContacts.FormattingEnabled = true;
            this.listContacts.Location = new System.Drawing.Point(0, 0);
            this.listContacts.Name = "listContacts";
            this.listContacts.Size = new System.Drawing.Size(484, 311);
            this.listContacts.TabIndex = 0;
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.listContacts);
            this.Name = "ContactsForm";
            this.Text = "Contacts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listContacts;
    }
}