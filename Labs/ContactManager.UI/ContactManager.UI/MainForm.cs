using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnFileExit( object sender, EventArgs e)
        {
            var x = 10;

            Close();
        }

        protected override void OnLoad (EventArgs e )
        {
            base.OnLoad(e);

            BindingList();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutBox();
            form.ShowDialog();
        }

        private void BindList()
        {
            listContacts.Items.Clear();
            listContacts.DisplayMember = nameof(Contact.Name);
            listContacts.Items.AddRange(Contacts.GetAll());
        }

        private void OnContactAdd ( object sender, EventArgs e)
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
                        MessageBox.Show(this, "Choose a better contact." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } catch (Exception ex)
                    {
                        DisplayError(ex);
                    };
            };

            BindList();
        }

        private void DisplayError(Exception ex)
        {
            MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnSafeAdd( ContactForm form)
        {
            try
            {
                Contacts.
            }
        }
    }
}
