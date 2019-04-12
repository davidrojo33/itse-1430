/*
 * Lab3
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManager;

namespace ContactManager.UI
{
    public partial class MainForm : Form, IMessageService
  
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            var form = new AboutBox();
            form.ShowDialog();
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            var contacts = _contact.GetAll();

            BindList();
        }

        private void BindList()
        {
            _lstcontact.Items.Clear();
            _lstcontact.DisplayMember = nameof(Contact.Name);
            var items = _contact.GetAll();

            items = items.OrderBy(GetName);
            _lstcontact.Items.AddRange(items.ToArray());
        }

        private string GetName ( Contact contact)
        {
            return contact.Name;
        }

        private void LoadContacts( Contact contact )
        {
            _lstcontact.Text = contact.Name;
            //_messages.Text = contact.Email;
        }

        private void OnContactAdd( object sender, EventArgs e )
        {
            var form = new ContactForm();

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
                    MessageBox.Show(this, "Choose a better contact.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void OnSafeAdd( ContactForm form )
        {
            try
            {
                _contact.Add(form.Contact);
            } catch (NotImplementedException e)
            {
                //rewriting an exception
                throw new Exception("Not implemented yet", e);
            } catch (Exception e)
            {
                throw;
            };
        }

        private IContactDatabase _contact = new ContactDatabase();

        private void OnContactEdit( object sender, EventArgs e )
        {
            var form = new ContactForm();

            var contact = GetSelectedContact();
            if (contact == null)
                return;

            //Game to edit
            form.Contact = contact;

            while (true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    //UpdateGame(game, form.Game);            
                    _contact.Update(contact.Id, form.Contact);
                    break;
                } catch (Exception ex)
                {
                    DisplayError(ex);
                };
            };

            BindList();
        }

        private void OnContactDelete( object sender, EventArgs e )
        {
            //Get selected game, if any
            var selected = GetSelectedContact();
            if (selected == null)
                return;

            //Display confirmation
            if (MessageBox.Show(this, $"Are you sure you want to delete {selected.Name}?",
                               "Confirm Delete", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                //DeleteGame(selected);
                _contact.Delete(selected.Id);
            } catch (Exception ex)
            {
                DisplayError(ex);
            };
            BindList();

        }

        private Contact GetSelectedContact()
        {
            var value = _lstcontact.SelectedItem;

            //Typesafe conversion
            //_ListGames.Items.OfType<Game>();

            //C-style cast - don't do this
            //var game = (Game)value;

            //Preferred - null if not valid
            var contact = value as Contact;

            return _lstcontact.SelectedItem as Contact;
        }

        protected override void OnFormClosing( FormClosingEventArgs e )
        {
            if (MessageBox.Show(this, "Are you sure?", "Close", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            base.OnFormClosing(e);
        }

        public void SendMessage ( string M )
        {
            var form = new MessageForm();
        }
    }
}
