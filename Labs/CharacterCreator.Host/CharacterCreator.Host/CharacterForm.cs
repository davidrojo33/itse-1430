using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Host
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

        protected override void OnLoad( EventArgs e )
        {
            //this.OnLoad(e);
            base.OnLoad(e);

            //Init UI if editing a game
            if (Character != null)
                LoadData(Character);

            ValidateChildren();
        }

        /*private void OnValidateName( object sender, System.ComponentModel.CancelEventArgs e )
        {
            var tb = sender as TextBox;

            if (tb.Text.Length == 0)
            {
                //_errors.SetError(tb, "Name is required.");
                e.Cancel = true;
            } else
               // _errors.SetError(tb, "");
        }*/
    }
}
