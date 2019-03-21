using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //LoadUI();
        }

       
        private void OnFileExit( object sender, EventArgs e )
        {
            //Local variable
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
            var form = new AboutBox();
            form.ShowDialog();
        }

        private void BindList ()
        {
            //Bind games to listbox
            _ListGames.Items.Clear();
            _ListGames.DisplayMember = nameof(Game.Name);

            //Can use AddRange now that we don't care about null items
            //var enumor = _games.GetAll();
            //var enumoror = enumor.GetEnumerator();
            //while (enumoror.MoveNext())
            //{
            //    var item = enumoror.Current;
            //};
            ////foreach (var item in enumor)
            //{
            //};

            _ListGames.Items.AddRange(_games.GetAll().ToArray());
            //foreach (var game in _games)
            //{
            //    if (game != null)
            //        _listGames.Items.Add(game);
            //};
        }

        private void OnGameAdd( object sender, EventArgs e )
        {
            //Display UI
            var form = new GameForm();

            while (true)
            {
                //Modal
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                //Add
                try
                {
                    //Anything in here that raises an exception will
                    //be sent to the catch block

                    OnSafeAdd(form);
                    break;
                } catch (InvalidOperationException)
                {
                    MessageBox.Show(this, "Choose a better game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch (Exception ex)
                {
                    //Recover from errors
                    DisplayError(ex);
                };
            };

            BindList();
        }

        private void DisplayError( Exception ex )
        {
            MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void OnSafeAdd( GameForm form )
        {
            try
            {
                //_games[GetNextEmptyGame()] = form.Game;
                _games.Add(form.Game);
            } catch (NotImplementedException e)
            { 
                //Rewriting an exception
                throw new Exception("Not implemented yet", e);
            } catch (Exception e)
            {
                //Log a message

                //Rethrow exception
                //throw e;
                throw;
            };
        }

        private IGameDatabase _games = new IGameDatabase();

        private void OnGameEdit( object sender, EventArgs e )
        {
            var form = new GameForm();

            var game = GetSelectedGame();
            if (game == null)
                return;

            //Game to edit
            form.Game = game;

            while (true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    //UpdateGame(game, form.Game);            
                    _games.Update(game.Id, form.Game);
                    break;
                } catch (Exception ex)
                {
                    DisplayError(ex);
                };
            };

            BindList();
        }

        private void OnGameDelete( object sender, EventArgs e )
        {
            //Get selected game, if any
            var selected = GetSelectedGame();
            if (selected == null)
                return;

            //Display confirmation
            if (MessageBox.Show(this, $"Are you sure you want to delete {selected.Name}?",
                               "Confirm Delete", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            //TODO: Delete
            //DeleteGame(selected);
            _games.Delete(selected.Id);
            BindList();
            //_game = null;
        }

        //private void DeleteGame ( Game game)
        //{
        //    for (var index = 0; index < _games.Length; ++index)
        //    {
        //        if (_games[index] == game)
        //        {
        //            _games[index] = null;
        //            break;
        //        };
        //    };
        //}

        private Game GetSelectedGame()
        {
            var value = _ListGames.SelectedItem;

            //C-style cast - don't do this
            //var game = (Game)value;

            //Preferred - null if not valid
            var game = value as Game;

            //Type check
            var game2 = (value is Game) ? (Game)value : null;

            return _ListGames.SelectedItem as Game;
        }

        private void OnGameSelected( object sender, EventArgs e )
        {

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
    }
}