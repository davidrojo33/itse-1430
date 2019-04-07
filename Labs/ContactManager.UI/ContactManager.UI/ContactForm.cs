/*
 * Lab3
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.UI
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        public Contact Contact { get; set; }

        private void OnSave( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            var contact = SaveData();

            try
            {
                //new ObjectValidator().Validate(game);
                ObjectValidator.Validate(contact);
            } catch (ValidationException)
            {
                MessageBox.Show(this, "Contact not valid.", "Error", MessageBoxButtons.OK);
                return;
            };

            Contact = contact;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
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
                    //OnSafeAdd(form);
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

        private void BindList()
        { 
        }

        private void DisplayError( Exception ex )
        {
            MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private Contact SaveData()
        {
            var contact = new Contact();
            contact.Name = _name.Text;
            contact.Email = _email.Text;

            return contact;
        }

        private void OnValidatContact( object sender, System.ComponentModel.CancelEventArgs e )
        {
            var tb = sender as TextBox;

            if (tb.Text.Length == 0)
            {
                _errors.SetError(tb, "Name is required.");
                e.Cancel = true;
            } else
                _errors.SetError(tb, "");
        }

        bool IsValidEmail( string source )
        {
            try
            {
                new System.Net.Mail.MailAddress(source);
                return true;
            } catch
            { };

            return false;
        }

        private void _email_TextChanged( object sender, EventArgs e )
        {

        }
    }
}
