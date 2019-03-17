﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterCreator;

namespace CharacterCreator.Winforms
{
    public partial class CharacterCreatorForm : Form
    {

        public CharacterCreatorForm()
        {
            InitializeComponent();
        }

        public Character Character { get; set; }

        private void OnSave( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            var character = SaveData();

            if (!character.Validate())
            {
                MessageBox.Show("Character not valid.", "Error", MessageBoxButtons.OK);

                Character = character;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void OnCancel( object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LoadData( Character character )
        {
            _txtName.Text = character.Name;
            _txtProfession.Text = character.Profession;
            _txtRace.Text = character.Race;
            _txtAttributes.Text = character.Attributes;

        }

        private Character SaveData()
        {
            var character = new Character();
            character.Name = _txtName.Text;
            character.Profession = _txtProfession.Text;
            character.Race = _txtRace.Text;
            character.Attributes = _txtProfession.Text;

            return character;
        }

        
    }
}
