﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager.Host.Winforms
{
    /// <summary>Allows adding or editing a game.</summary>
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        /// <summary>Gets or sets the property being edited.</summary>
        public Game Game { get; set; }

        //Called when the user saves the game
        private void OnSave( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            var Game = SaveData();
            
            //Validate at business level
            if (!Game.Validate())
            {
                MessageBox.Show("Game not valid.", "Error", MessageBoxButtons.OK);
            }
            Game = Game;
            DialogResult = DialogResult.OK;
            Close();
        }

        //Called when the user cancels the add/edit
        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private decimal ReadDecimal( TextBox control )
        {
            if (control.Text.Length == 0)
                return 0;

            if (Decimal.TryParse(control.Text, out var value))
                return value;

            return -1;
        }

        //Loads UI with game
        private void LoadData( Game game )
        {
            _txtName.Text = game.Name;
            _txtDescription.Text = game.Description;
            _txtPrice.Text = game.Price.ToString();
            _cbOwned.Checked = game.Owned;
            _cbCompleted.Checked = game.Completed;
        }

        //Saves UI into new game
        private Game SaveData()
        {
            var game = new Game();
            game.Name = _txtName.Text;
            game.Description = _txtDescription.Text;
            game.Price = ReadDecimal(_txtPrice);
            game.Owned = _cbOwned.Checked;
            game.Completed = _cbCompleted.Checked;

            //Demoing ctor
            var game2 = new Game(_txtName.Text, ReadDecimal(_txtPrice));

            return game;
        }

        //Defined in type
        //Derived types may override and change it
        protected virtual void CanBeChanged() { }
        
        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            //Init UI if editing a game
            if (Game != null)
                LoadData(Game);

            ValidateChildren();
        }

        private void OnValidateName( object sender, CancelEventArgs e )
        {
            var tb = sender as TextBox;

            if (tb.Text.Length == 0)
            {
                _errors.SetError(tb, "Name is required.");
                e.Cancel = true;
            } else
                _errors.SetError(tb, "");

        }

        private void OnValidatePrice( object sender, CancelEventArgs e )
        {
            var tb = sender as TextBox;

            var price = ReadDecimal(tb);
            if (price < 0)
            {
                _errors.SetError(tb, "Price must be >= 0.");
                e.Cancel = true;
            } else
                _errors.SetError(tb, "");
        }
    }
}
