using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class CharacterForm : Form
    {
        public CharacterForm()
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

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LoadData( Character character )
        {
            _txtName.Text = character.Name;
            _txtProfession.Text = character.Profession;
            _txtRace.Text = character.Race;
            strength.AllowDrop = character.Validate();
            intelligence.AllowDrop = character.Validate();
            agility.AllowDrop = character.Validate();
            constitution.AllowDrop = character.Validate();
            charisma.AllowDrop = character.Validate();
            
        }

        private Character SaveData()
        {
            var character = new Character();
            character.Name = textBox1.Text.Trim();
            character.Profession = comboBox1.Text;
            character.Race = comboBox2.Text;
            //character.Strength

            return character;
        }
    }
}
