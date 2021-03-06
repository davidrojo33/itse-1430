﻿namespace CharacterCreator.Winforms
{
    partial class CharacterForm
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
            this.components = new System.ComponentModel.Container();
            this._txtName = new System.Windows.Forms.Label();
            this._txtProfession = new System.Windows.Forms.Label();
            this._txtRace = new System.Windows.Forms.Label();
            this.strength = new System.Windows.Forms.Label();
            this.intelligence = new System.Windows.Forms.Label();
            this.agility = new System.Windows.Forms.Label();
            this.constitution = new System.Windows.Forms.Label();
            this.charisma = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // _txtName
            // 
            this._txtName.AutoSize = true;
            this._txtName.Location = new System.Drawing.Point(10, 13);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(35, 13);
            this._txtName.TabIndex = 0;
            this._txtName.Text = "Name";
            // 
            // _txtProfession
            // 
            this._txtProfession.AutoSize = true;
            this._txtProfession.Location = new System.Drawing.Point(10, 66);
            this._txtProfession.Name = "_txtProfession";
            this._txtProfession.Size = new System.Drawing.Size(56, 13);
            this._txtProfession.TabIndex = 1;
            this._txtProfession.Text = "Profession";
            // 
            // _txtRace
            // 
            this._txtRace.AutoSize = true;
            this._txtRace.Location = new System.Drawing.Point(10, 122);
            this._txtRace.Name = "_txtRace";
            this._txtRace.Size = new System.Drawing.Size(33, 13);
            this._txtRace.TabIndex = 2;
            this._txtRace.Text = "Race";
            // 
            // strength
            // 
            this.strength.AutoSize = true;
            this.strength.Location = new System.Drawing.Point(221, 15);
            this.strength.Name = "strength";
            this.strength.Size = new System.Drawing.Size(47, 13);
            this.strength.TabIndex = 3;
            this.strength.Text = "Strength";
            // 
            // intelligence
            // 
            this.intelligence.AutoSize = true;
            this.intelligence.Location = new System.Drawing.Point(221, 50);
            this.intelligence.Name = "intelligence";
            this.intelligence.Size = new System.Drawing.Size(61, 13);
            this.intelligence.TabIndex = 4;
            this.intelligence.Text = "Intelligence";
            // 
            // agility
            // 
            this.agility.AutoSize = true;
            this.agility.Location = new System.Drawing.Point(221, 86);
            this.agility.Name = "agility";
            this.agility.Size = new System.Drawing.Size(34, 13);
            this.agility.TabIndex = 5;
            this.agility.Text = "Agility";
            // 
            // constitution
            // 
            this.constitution.AutoSize = true;
            this.constitution.Location = new System.Drawing.Point(221, 125);
            this.constitution.Name = "constitution";
            this.constitution.Size = new System.Drawing.Size(62, 13);
            this.constitution.TabIndex = 6;
            this.constitution.Text = "Constitution";
            // 
            // charisma
            // 
            this.charisma.AutoSize = true;
            this.charisma.Location = new System.Drawing.Point(221, 162);
            this.charisma.Name = "charisma";
            this.charisma.Size = new System.Drawing.Size(50, 13);
            this.charisma.TabIndex = 7;
            this.charisma.Text = "Charisma";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(286, 13);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(286, 48);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(286, 84);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 10;
            this.numericUpDown3.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(286, 123);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown4.TabIndex = 11;
            this.numericUpDown4.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(286, 160);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown5.TabIndex = 12;
            this.numericUpDown5.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnSave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnCancel);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fighter",
            "Hunter",
            "Priest",
            "Rogue",
            "Wizard"});
            this.comboBox1.Location = new System.Drawing.Point(72, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human"});
            this.comboBox2.Location = new System.Drawing.Point(71, 122);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.charisma);
            this.Controls.Add(this.constitution);
            this.Controls.Add(this.agility);
            this.Controls.Add(this.intelligence);
            this.Controls.Add(this.strength);
            this.Controls.Add(this._txtRace);
            this.Controls.Add(this._txtProfession);
            this.Controls.Add(this._txtName);
            this.MinimumSize = new System.Drawing.Size(400, 280);
            this.Name = "CharacterForm";
            this.Text = "CharacterForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _txtName;
        private System.Windows.Forms.Label _txtProfession;
        private System.Windows.Forms.Label _txtRace;
        private System.Windows.Forms.Label strength;
        private System.Windows.Forms.Label intelligence;
        private System.Windows.Forms.Label agility;
        private System.Windows.Forms.Label constitution;
        private System.Windows.Forms.Label charisma;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}