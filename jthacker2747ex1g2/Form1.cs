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

namespace jthacker2747ex1g2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void purchaseOrderHeaderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.purchaseOrderHeaderBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.adventureWorksDataSet);
            this.saveChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.shipMethodTableAdapter.Fill(this.adventureWorksDataSet.ShipMethod);
            this.employeeNameTableAdapter.Fill(this.adventureWorksDataSet.Employee);
            this.vendorTableAdapter.Fill(this.adventureWorksDataSet.Vendor);
            int vendorID = (Int32)vendorComboBox.SelectedValue;
            //this.purchaseOrderHeaderTableAdapter.FillByVendorID(this.adventureWorksDataSet.PurchaseOrderHeader, vendorID);


            //DataRowView currentDataRowView = (DataRowView)purchaseOrderHeaderBindingSource.Current;
            //AdventureWorksDataSet.PurchaseOrderHeaderRow currentPORow =
            //    (AdventureWorksDataSet.PurchaseOrderHeaderRow)currentDataRowView.Row;
            //int purchaseOrderID = currentPORow.PurchaseOrderID;
            //this.purchaseOrderDetailTableAdapter.FillByPurchaseOrderID(
            //    this.adventureWorksDataSet.PurchaseOrderDetail, purchaseOrderID);

            this.loadPOHeadersForCurrentVendor();
            this.subscribeEventHandlers();
           
        }

        private void vendorComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.unsubscribeEventHandlers();
            this.promptToSaveChanges();
            this.loadPOHeadersForCurrentVendor();
            this.subscribeEventHandlers();

        }

        private void purchaseOrderHeaderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.unsubscribeEventHandlers();
            this.promptToSaveChanges();
            this.poHeaderChanged();
            this.subscribeEventHandlers();
        }
        private void purchaseOrderDetailDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.calcTotals();
              
        }
        private void subscribeEventHandlers()
        {
            this.purchaseOrderDetailDataGridView.CellValueChanged 
                += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseOrderDetailDataGridView_CellValueChanged);

            this.vendorComboBox.SelectedValueChanged
               += new System.EventHandler(this.vendorComboBox_SelectedValueChanged);

            this.purchaseOrderHeaderBindingSource.CurrentChanged
                += new System.EventHandler(this.purchaseOrderHeaderBindingSource_CurrentChanged);

        }
        private void unsubscribeEventHandlers()
        {
            this.purchaseOrderDetailDataGridView.CellValueChanged 
                -= new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseOrderDetailDataGridView_CellValueChanged);

            this.vendorComboBox.SelectedValueChanged
               -= new System.EventHandler(this.vendorComboBox_SelectedValueChanged);

            this.purchaseOrderHeaderBindingSource.CurrentChanged
                -= new System.EventHandler(this.purchaseOrderHeaderBindingSource_CurrentChanged);

        }
        private void loadPOHeadersForCurrentVendor()
        {
            try
            {
                int vendorID = (Int32)vendorComboBox.SelectedValue;
                this.purchaseOrderHeaderTableAdapter.FillByVendorID(this.adventureWorksDataSet.PurchaseOrderHeader, vendorID);

                this.poHeaderChanged();
            }
            catch (System.NullReferenceException ex)
            {
                //Ingore
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "vendorCombox_Load(): " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "vendorCombox_Load(): " + ex.GetType().ToString());
            }
        }
        private void poHeaderChanged()
        {
            this.adventureWorksDataSet.PurchaseOrderDetail.Clear();
            try
            {
                DataRowView currentDataRowView = (DataRowView)purchaseOrderHeaderBindingSource.Current;
                AdventureWorksDataSet.PurchaseOrderHeaderRow currentPORow =
                    (AdventureWorksDataSet.PurchaseOrderHeaderRow)currentDataRowView.Row;
                int purchaseOrderID = currentPORow.PurchaseOrderID;
                this.purchaseOrderDetailTableAdapter.FillByPurchaseOrderID(
                    this.adventureWorksDataSet.PurchaseOrderDetail, purchaseOrderID);
                this.calcTotals();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "vendorCombox_Load(): " + ex.GetType().ToString());
            }
            catch (System.NullReferenceException ex)
            {
                //Ingore
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void calcTotals()
        {
            
            Decimal subtotal = 0m;
            foreach (DataGridViewRow currentRow in purchaseOrderDetailDataGridView.Rows)
            {

                if (currentRow.Cells[3].Value != null && currentRow.Cells[5].Value != null)
                {
                    //Decimal lineTotal =
                    //    Convert.ToInt32(currentRow.Cells[3].Value) * Convert.ToDecimal(currentRow.Cells[5].Value);
                    int orderQty = 0;
                    Decimal unitPrice = 0m;
                    Int32.TryParse(currentRow.Cells[3].Value.ToString(), out orderQty);
                    Decimal.TryParse(currentRow.Cells[5].Value.ToString(), out unitPrice);
                    Decimal lineTotal = orderQty * unitPrice;
                    if (lineTotal > 0)
                    {
                        currentRow.Cells[7].Value = lineTotal.ToString("n2");
                        subtotal += lineTotal;

                    }
                }
            }

            Decimal totalDue = 0m;
            Decimal taxAmt = 0.0m;

            subTotalLabel1.Text = subtotal.ToString("n2");

            taxAmt = subtotal * 0.08m;
            taxAmtLabel1.Text = taxAmt.ToString("n2");

            Decimal freight = 0.0m;
            Decimal.TryParse(freightTextBox.Text, out freight);

            totalDue = subtotal + taxAmt + freight;
            totalDueLabel1.Text = totalDue.ToString("n2");

            

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.promptToSaveChanges();
            this.unsubscribeEventHandlers();
        }
        private void promptToSaveChanges()
        {
            this.Validate();
            this.purchaseOrderDetailDataGridView.EndEdit();
            this.purchaseOrderDetailBindingSource.EndEdit();
            this.purchaseOrderHeaderBindingSource.EndEdit();

            if (this.adventureWorksDataSet.HasChanges())
            {
                DialogResult saveChanges =
                    MessageBox.Show("Save changes?", "Purchase Order Updates",
                        MessageBoxButtons.OKCancel);
                if (saveChanges == DialogResult.OK)
                {
                    this.saveChanges();
                }
                else
                {
                    this.adventureWorksDataSet.RejectChanges();
                }
            }
        }
        private void saveChanges() 
        {
            this.Validate();
            this.purchaseOrderDetailDataGridView.EndEdit();
            this.purchaseOrderDetailBindingSource.EndEdit();
            this.purchaseOrderHeaderBindingSource.EndEdit();

            try {
                this.tableAdapterManager.UpdateAll(this.adventureWorksDataSet);
            }
            catch (System.FormatException ex)
            {
                //Ingore
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "vendorCombox_Load(): " + ex.GetType().ToString());
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "vendorCombox_Load(): " + ex.GetType().ToString());
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "vendorCombox_Load(): " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "vendorCombox_Load(): " + ex.GetType().ToString());
            }
        }

        private void purchaseOrderDetailDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataRowView currentDataRowView = (DataRowView)purchaseOrderHeaderBindingSource.Current;
            AdventureWorksDataSet.PurchaseOrderHeaderRow currentPORow =
                (AdventureWorksDataSet.PurchaseOrderHeaderRow)currentDataRowView.Row;
            purchaseOrderDetailDataGridView.CurrentRow.Cells[0].Value = currentPORow.PurchaseOrderID;

        }
    }


}

