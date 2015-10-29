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

namespace jthacker2747ex1k1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _4hServiceTransactionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this._4hServiceTransactionBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.thackTracksDataSet);
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Error: Message: " + ex.Message,
                     "purchaseOrderDetailBindingNavigatorSaveButton_Click(): " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Message: " + ex.Message,
                     "purchaseOrderDetailBindingNavigatorSaveButton_Click(): " + ex.GetType().ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thackTracksDataSet._2hService' table. You can move, or remove it, as needed.

            try
            {
                this._2hServiceTableAdapter.Fill(this.thackTracksDataSet._2hService);
                this._2hEmployeeTableAdapter.Fill(this.thackTracksDataSet._2hEmployee);
                this._2hPersonTableAdapter.Fill(this.thackTracksDataSet1._2hPerson);
                this._4hServiceTransactionTableAdapter.Fill(this.thackTracksDataSet._4hServiceTransaction);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Form_Load(): " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Form_Load(): " + ex.GetType().ToString());
            }
        }



        private void _4hServiceTransactionBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                this.unsubscribeEventHandlers();
                int transID = (Int32)transIDComboBox.SelectedValue;
                this._4hServiceTransactionTableAdapter.FillByTransID(this.thackTracksDataSet._4hServiceTransaction, transID);
                int servID = Int32.Parse(serviceIDTextBox.Text);
                this._2hServiceTableAdapter.FillByServiceID(this.thackTracksDataSet._2hService, servID);
                this.subscribeEventHandlers();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Form_Load(): " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Form_Load(): " + ex.GetType().ToString());
            }
        }
        private void subscribeEventHandlers()
        {
            this._4hServiceTransactionBindingSource.CurrentChanged
                += new System.EventHandler(this._4hServiceTransactionBindingSource_CurrentChanged);


        }
        private void unsubscribeEventHandlers()
        {
            this._4hServiceTransactionBindingSource.CurrentChanged
                -= new System.EventHandler(this._4hServiceTransactionBindingSource_CurrentChanged);


        }
    }
}

