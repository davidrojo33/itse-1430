/*
 * David Rojo
 * 4/28/19
 * ITSE 1430
 */
using System;
using System.Windows.Forms;

namespace Nile.Windows
{
    public partial class MainForm : Form
    {
        #region Construction

        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            _gridProducts.AutoGenerateColumns = false;

            UpdateList();
        }

        #region Event Handlers5
        
        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            var form = new AboutBox();
            form.ShowDialog();
        }

        private void OnProductAdd( object sender, EventArgs e )
        {
            var child = new ProductDetailForm("Product Details");

            while (true)
            {
                if (child.ShowDialog(this) != DialogResult.OK)
                    return;

                // Handle errors
                try
                {
                    _database.Add(child.Product);
                    break;
                } catch (Exception ex)
                {
                    //Recover from errors
                    DisplayError(ex);
                };
            }
            UpdateList();
        }

        private void OnProductEdit( object sender, EventArgs e )
        {
            var product = GetSelectedProduct();
            if (product == null)
            {
                MessageBox.Show("No products available.");
                return;
            };

            EditProduct(product);
        }        

        private void OnProductDelete( object sender, EventArgs e )
        {
            var product = GetSelectedProduct();
            if (product == null)
                return;

            DeleteProduct(product);
        }        
                
        private void OnEditRow( object sender, DataGridViewCellEventArgs e )
        {
            var grid = sender as DataGridView;

            //Handle column clicks
            if (e.RowIndex < 0)
                return;

            var row = grid.Rows[e.RowIndex];
            var item = row.DataBoundItem as Product;

            if (item != null)
                EditProduct(item);
        }

        private void OnKeyDownGrid( object sender, KeyEventArgs e )
        {
            if (e.KeyCode != Keys.Delete)
                return;

            var product = GetSelectedProduct();
            if (product != null)
                DeleteProduct(product);
			
			//Don't continue with key
            e.SuppressKeyPress = true;
        }

        #endregion

        #region Private Members

        private void DeleteProduct ( Product product )
        {
            //Confirm
            if (MessageBox.Show(this, $"Are you sure you want to delete '{product.Name}'?",
                                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            //Handle errors
            try
            {
                _database.Remove(product.Id);
            } catch (Exception ex)
            {
                DisplayError(ex);
            }
            UpdateList();
        }

        private void EditProduct ( Product product )
        {
            var child = new ProductDetailForm("Product Details");
            child.Product = product;
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //Handle errors

            while (true)
            {
                if (child.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {            
                    _database.Update(child.Product);
                    break;
                } catch (Exception ex)
                {
                    DisplayError(ex);
                };
            };

            UpdateList();
        }

        private Product GetSelectedProduct ()
        {
            if (_gridProducts.SelectedRows.Count > 0)
                return _gridProducts.SelectedRows[0].DataBoundItem as Product;

            return null;
        }

        private void UpdateList ()
        {
            _bsProducts.Clear();
            //Handle errors
            try
            {
                var products = _bsProducts.GetAll().OrderBy(c => c.Name);

                _bsProducts.Id.AddRange(products.ToArray());
            } catch (Exception ex)
            {
                DisplayError(ex);
            };
        }

        private void DisplayError( Exception ex )
        {
            MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private readonly IProductDatabase _database = new Nile.Stores.SqlProductDatabase();
        #endregion
    }
}
