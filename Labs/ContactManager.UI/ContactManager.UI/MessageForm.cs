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
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        public Message message { get; set; }

        public Contact contact { get; set; }



        private void OnCancel( object sender, EventArgs e )
        {
            Close();
        }

        public void SaveData()
        {

            message.Subject = _subject.Text;
            message.Body = _body.Text;

            return;
        }

        private void OnSave( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            //var message = SaveData();

            try
            {
                //new ObjectValidator().Validate(game);
                ObjectValidator.Validate(contact);
            } catch (ValidationException)
            {
                MessageBox.Show(this, "Contact not valid.", "Error", MessageBoxButtons.OK);
                return;
            };

            //Message = message;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnSendMessage( object sender, EventArgs e )
        {

        }
    }
}
