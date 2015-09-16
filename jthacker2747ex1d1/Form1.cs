using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace jthacker2747ex1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            this.Validate();
            try {
                this.productBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.adventureWorksDataSet);
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Error: Message: " + ex.Message,
                     "vendorBindingNavigatorSaveButton_Click(): " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Message: " + ex.Message,
                     "vendorBindingNavigatorSaveButton_Click(): " + ex.GetType().ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorksDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.adventureWorksDataSet.Product);
            try
            {
                this.productCatSubcatTableAdapter.Fill(this.adventureWorksDataSet.ProductCatSubcat);
                this.unitMeasureTableAdapter.Fill(this.adventureWorksDataSet.UnitMeasure);
                this.productTableAdapter.Fill(this.adventureWorksDataSet.Product);
            
                }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Store_Load(): " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Store_Load(): " + ex.GetType().ToString());
            }
            Binding b = new Binding
               ("Text", productBindingSource, "ProductNumber");
            b.Format += new ConvertEventHandler(FormatProductNumber);
            b.Parse += new ConvertEventHandler(UnformatProductNumber);
            productNumberTextBox.DataBindings.Add(b);


        }
        private void FormatProductNumber(object sender, ConvertEventArgs e)
        {
            if (e.DesiredType != typeof(string)) return;

            string prodNum = e.Value.ToString();
            if (prodNum.Length > 5)
            {
                prodNum = prodNum.Replace("-", string.Empty);
                prodNum = prodNum.Substring(0, 3) + "." + prodNum.Substring(3, 2) + "." + prodNum.Substring(5);
                e.Value = prodNum;
            }
        }
        private void UnformatProductNumber(object sender, ConvertEventArgs e)
        {
            if (e.DesiredType != typeof(string)) return;
            e.Value = e.Value.ToString().Replace(".", string.Empty);

            }

        private void moveFirstButton_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveFirst();
        }

        private void movePreviousButton_Click(object sender, EventArgs e)
        {
            productBindingSource.MovePrevious();

        }

        private void moveNextButton_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveNext();
        }

        private void moveLastButton_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveLast();
        }

        private void moveProductPositionButton_Click(object sender, EventArgs e)
        {
            int position = 0;
            Int32.TryParse(productPositionTextBox.Text.Trim(), out position);
            position--;
            if (position >= 0 && position < productBindingSource.Count)
            {
                productBindingSource.Position = position;
            }
            else
            {
                MessageBox.Show("Invalid row#. \nEnter a value from 1 to " + productBindingSource.Count);
                productPositionTextBox.Focus();
                productPositionTextBox.SelectAll(); 
                
            }
        }
        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {

            productPositionTextBox.Text = (productBindingSource.Position + 1).ToString();
            productPositionLabel.Text = "of" + productBindingSource.Count;

            try
            {
                DataRowView currentDataRowView = (DataRowView)productBindingSource.Current;
                AdventureWorksDataSet.ProductRow currentProductRow =
                    (AdventureWorksDataSet.ProductRow)currentDataRowView.Row;
                int productID = currentProductRow.ProductID;
                this.locationProductInventoryTableAdapter.FillByProductID(
                    this.adventureWorksDataSet.LocationProductInventory, productID);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void productIdToolStripButton_Click(object sender, EventArgs e)
        {
            try {
                int productID = Convert.ToInt32(productIdToolStripTextBox.Text);
                this.productTableAdapter.FillByProductID(this.adventureWorksDataSet.Product, productID);

            }
            catch (FormatException ex)
            {
                MessageBox.Show("ProductId must be an integer.", "Entry Error");

            }
            catch (System.InvalidCastException ex)
            {
                MessageBox.Show("ProductId must be an integer.", "Entry Error");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Store_Load(): " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Store_Load(): " + ex.GetType().ToString());
            }

       }

        private void loadAllToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter.Fill(this.adventureWorksDataSet.Product);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Store_Load(): " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Store_Load(): " + ex.GetType().ToString());
            }
        }

        private void productIdToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void productNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = productNameToolStripTextBox.Text.Trim().ToLower();
                this.productTableAdapter.FillByProductName(this.adventureWorksDataSet.Product, productName);

            }
            catch (FormatException ex)
            {
                MessageBox.Show("ProductName must be a String.", "Entry Error");

            }
            catch (System.InvalidCastException ex)
            {
                MessageBox.Show("ProductId must be a String.", "Entry Error");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Store_Load(): " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Store_Load(): " + ex.GetType().ToString());
            }
        }

        private void cancelEditToolStripButton_Click(object sender, EventArgs e)
        {
            productBindingSource.CancelEdit();
        }

       

       
    }


 }
