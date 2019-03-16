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
    public partial class CharacterCreator : Form
    {
        public CharacterCreator()
        {
            InitializeComponent();
        }

        //public Character Character { get; set; }

        private void OnSave( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            //var character = SaveData();

            //if (!character.Validate())
            //{
            //    MessageBox.Show("Character not valid.", "Error", MessageBoxButtons.OK);

            //    character = character;
            //    DialogResult = DialogResult.OK;
            //    Close();
            //}
        }

        private void OnCancel( object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        //private void LoadData( Character character)
        //{
            
        //}

        //private Character SaveData()
        //{

        //}
    }
}
