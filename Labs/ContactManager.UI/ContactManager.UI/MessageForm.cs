﻿/*
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

        private void OnCancel( object sender, EventArgs e )
        {
            Close();
        }

        private void SendMessage( string M )
        {

        }

        private Contact SaveData()
        {
            var contact = new Contact();
            contact.Name = _body.Text;
            contact.Email = _body.Text;

            return contact;
        }
        private void BindList()
        {

        }
    }
}
