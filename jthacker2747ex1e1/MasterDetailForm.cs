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

namespace jthacker2747ex1e1
{
    public partial class MasterDetailForm : Form
    {
        public MasterDetailForm()
        {
            InitializeComponent();
        }

        private void purchaseOrderHeaderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try {
                this.purchaseOrderHeaderBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.adventureWorksDataSet);

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

        private void MasterDetailForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.shipMethodTableAdapter.Fill(this.adventureWorksDataSet.ShipMethod);
                this.vendorTableAdapter.Fill(this.adventureWorksDataSet.Vendor);
                this.employeeNameTableAdapter.Fill(this.adventureWorksDataSet.EmployeeName);
                //this.purchaseOrderDetailTableAdapter.Fill(this.adventureWorksDataSet.PurchaseOrderDetail);

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

        private void vendorComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try {
                int vendorID = (Int32)vendorComboBox.SelectedValue;
                this.purchaseOrderHeaderTableAdapter.FillByVendorID(this.adventureWorksDataSet.PurchaseOrderHeader, vendorID);
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

        private void purchaseOrderHeaderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView currentDataRowView = (DataRowView)purchaseOrderHeaderBindingSource.Current;
                AdventureWorksDataSet.PurchaseOrderHeaderRow currentPOHeaderRow =
                    (AdventureWorksDataSet.PurchaseOrderHeaderRow)currentDataRowView.Row;
                int purchaseOrderID = currentPOHeaderRow.PurchaseOrderID;
                this.purchaseOrderDetailTableAdapter.FillByPurchaseOrderID(this.adventureWorksDataSet.PurchaseOrderDetail, purchaseOrderID);
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

        private void purchaseOrderDetailDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            rowCountLabel.Text = String.Empty;
            rowIndexLabel.Text = String.Empty;
            colIndexLabel.Text = String.Empty;
            detailIDLabel.Text = String.Empty;
            currentCellValueLabel.Text = String.Empty;
            try {
                rowCountLabel.Text = purchaseOrderDetailDataGridView.RowCount.ToString();
                rowIndexLabel.Text = purchaseOrderDetailDataGridView.CurrentCell.RowIndex.ToString();
                colIndexLabel.Text = purchaseOrderDetailDataGridView.CurrentCell.ColumnIndex.ToString();
                DataGridViewRow currentRow = purchaseOrderDetailDataGridView.CurrentRow;
                DataGridViewCell cell1 = currentRow.Cells[1];
                int detailID = Convert.ToInt32(cell1.Value);
                detailIDLabel.Text = detailID.ToString();

                switch (purchaseOrderDetailDataGridView.CurrentCell.ColumnIndex)
                {
                    case 1:
                    case 3:
                    case 4:
                    case 7:
                    case 8:
                    case 9:
                        int i = Convert.ToInt32(purchaseOrderDetailDataGridView.CurrentCell.Value);
                        currentCellValueLabel.Text = i.ToString();
                        break;
                    case 2:
                        DateTime dateTime = (DateTime)purchaseOrderDetailDataGridView.CurrentCell.Value;
                        currentCellValueLabel.Text = dateTime.ToShortDateString();
                        break;
                    case 5:
                    case 6:
                        Decimal d = Convert.ToDecimal(purchaseOrderDetailDataGridView.CurrentCell.Value);
                        currentCellValueLabel.Text = d.ToString("n2");
                        break;
                }
            }
            catch (System.NullReferenceException ex)
            {
                //Ingore
            }
            catch (System.InvalidCastException ex)
            {

            }
        }

        private void purchaseOrderDetailDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Decimal subTotal = 0m;
            foreach (DataGridViewRow currentRow in purchaseOrderDetailDataGridView.Rows) ;
            {
                try {
                    DataGridViewRow currentRow = purchaseOrderDetailDataGridView.CurrentRow;
                    Decimal lineTotal = 0m;
                    lineTotal = Convert.ToInt32(currentRow.Cells[3].Value) * Convert.ToDecimal(currentRow.Cells[5].Value);
                    //currentRow.Cells[6].Value = lineTotal; // LineTotal Field is read Only
                    subTotal += lineTotal;
                }
                catch (System.NullReferenceException ex)
                {
                    //Ingore
                }
            }
            try {
                subTotalLabel2.Text = subTotal.ToString("n2");
                Decimal tax = subTotal * 0.08m;
                taxAmtLabel2.Text = tax.ToString("n2");
                decimal freight = 0m;
                decimal.TryParse(freightTextBox.Text, out freight);
                Decimal totalDue = freight + subTotal + tax;
                totalDueLabel2.Text = totalDue.ToString("n2");
            }
            catch (System.NullReferenceException ex)
            {
                //Ingore
            }

        }

        private void purchaseOrderDetailBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Decimal subtotal = 0m;
            for (int i = 0; i < purchaseOrderDetailBindingSource.Count; i++)
            {
                DataRowView currentDataRowView = (DataRowView)purchaseOrderDetailBindingSource.List[i];
                AdventureWorksDataSet.PurchaseOrderDetailRow detailRow =
                    (AdventureWorksDataSet.PurchaseOrderDetailRow)currentDataRowView.Row;
                subtotal += detailRow.OrderQty * detailRow.UnitPrice;

            }
            subTotalLabel3.Text = subtotal.ToString("n2");
            Decimal tax = subtotal * 0.08m;
            taxAmtLabel3.Text = tax.ToString("n2");
            decimal freight = 0m;
            decimal.TryParse(freightTextBox.Text, out freight);
            Decimal totalDue = freight + subtotal + tax;
            totalDueLabel3.Text = totalDue.ToString("n2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    } }
