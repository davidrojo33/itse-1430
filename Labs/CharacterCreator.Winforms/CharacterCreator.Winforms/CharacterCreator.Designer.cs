namespace CharacterCreator.Winforms
{
    partial class CharacterCreator
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
            this._txtName = new System.Windows.Forms.Label();
            this._txtProfession = new System.Windows.Forms.Label();
            this._txtRace = new System.Windows.Forms.Label();
            this._txtAttributes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _txtName
            // 
            this._txtName.AutoSize = true;
            this._txtName.Location = new System.Drawing.Point(32, 29);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(35, 13);
            this._txtName.TabIndex = 0;
            this._txtName.Text = "Name";
            // 
            // _txtProfession
            // 
            this._txtProfession.AutoSize = true;
            this._txtProfession.Location = new System.Drawing.Point(32, 72);
            this._txtProfession.Name = "_txtProfession";
            this._txtProfession.Size = new System.Drawing.Size(56, 13);
            this._txtProfession.TabIndex = 1;
            this._txtProfession.Text = "Profession";
            // 
            // _txtRace
            // 
            this._txtRace.AutoSize = true;
            this._txtRace.Location = new System.Drawing.Point(32, 114);
            this._txtRace.Name = "_txtRace";
            this._txtRace.Size = new System.Drawing.Size(33, 13);
            this._txtRace.TabIndex = 2;
            this._txtRace.Text = "Race";
            // 
            // _txtAttributes
            // 
            this._txtAttributes.AutoSize = true;
            this._txtAttributes.Location = new System.Drawing.Point(32, 156);
            this._txtAttributes.Name = "_txtAttributes";
            this._txtAttributes.Size = new System.Drawing.Size(51, 13);
            this._txtAttributes.TabIndex = 3;
            this._txtAttributes.Text = "Attributes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(125, 153);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnSave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnCancel);
            // 
            // CharacterCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._txtAttributes);
            this.Controls.Add(this._txtRace);
            this.Controls.Add(this._txtProfession);
            this.Controls.Add(this._txtName);
            this.Name = "CharacterCreator";
            this.Text = "CharacterCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _txtName;
        private System.Windows.Forms.Label _txtProfession;
        private System.Windows.Forms.Label _txtRace;
        private System.Windows.Forms.Label _txtAttributes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}