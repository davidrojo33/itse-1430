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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnFileExit( object sender, EventArgs e )
        {
            var x = 10;

            Close();
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            BindList();
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            var form = new AboutBox1();
            form.ShowDialog();
        }

        private void BindList()
        {
            _ListCharacters.Items.Clear();

            _ListCharacters.DisplayMember = nameof(Character.Name);

            _ListCharacters.Items.AddRange(_characters.GetAll());
        }

        private void OnCharacterAdd( object sender, EventArgs e )
        {
            var form = new CharacterCreatorForm();

            while (true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    OnSafeAdd(form);
                    break;
                } catch (InvalidOperationException)
                {
                    MessageBox.Show(this, "Choose a better character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch (Exception ex)
                {
                    DisplayError(ex);
                };
            };
            BindList();
        }

        private void DisplayError( Exception ex )
        {
            MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnSafeAdd( CharacterCreatorForm form )
        {
            try
            {
                _characters.Add(form.Character);
            } catch (NotImplementedException e)
            {
                throw new Exception("Not implemented yet", e);
            } catch (Exception e)
            {
                throw;
            };
        }


        private CharacterDatabase _characters = new CharacterDatabase();

        private void OnCharacterEdit( object sender, EventArgs e )
        {
            var from = new CharacterCreatorForm();

            var character = GetSelectedCharacter();
            if (character == null)
                return;

            form.Character = character;

            while (true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    _characters.Update(character.Id, form.Character);
                    break;
                } catch (Exception ex)
                {
                    DisplayError(ex);
                };
            };

            BindList();
        }

        private void OnCharacterDelete( object sender, EventArgs e )
        {
            var selected = GetSelectedCharacter();
            if (selected == null)
                return;

            if (MessageBox.Show(this, $"Are you sure you want to delete {selected.Name}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            _characters.Delete(selected.Id);
            BindList();
        }

        private Character GetSelectedCharacter()
        {
            var value = _ListCharacters.SelectedItem;

            var character = value as Character;

            var character2 = (value is Character) ? (Character)value : null;

            return _ListCharacters.SelectedItem as Character;
        }

        private void OnGameSelected( object sender, EventArgs e )
        {

        }

        protected override void OnFormClosing( FormClosingEventArgs e )
        {
            if (MessageBox.Show(this, "Are you sure?", "Close", MessageBoxButtons.YesNo) ==
                DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            base.OnFormClosing(e);
        }
    }
}