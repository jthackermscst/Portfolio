using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using jthacker2747ex1f1Data;
using jthacker2747ex1f1Data.AdventureWorksDataSetTableAdapters;

namespace jthacker2747ex1f1
{
    public partial class _Default : Page
    {
        private AdventureWorksDataSet adventureWorksDataSet;
        private VendorTableAdapter vendorTableAdapter;
        private PurchaseOrderDescriptionTableAdapter purchaseOrderDescriptionTableAdapter;
        private PurchaseOrderHeaderTableAdapter purchaseOrderHeaderTableAdapter;
        private ShipMethodTableAdapter shipMethodTableAdapter;
        private EmployeeNameTableAdapter employeeNameTableAdapter;
        private PurchaseOrderDetailTableAdapter purchaseOrderDetailTableAdapter;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.adventureWorksDataSet = new AdventureWorksDataSet();
            if (!this.IsPostBack)
            {
                
                this.loadVendors();
                this.loadPurchaseOrderDescriptions();
                this.loadSelectedPurchaseOrder();
                this.loadShipMehtods();
                this.loadEmployeeNames();
            }

        }

        protected void vendorDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.loadPurchaseOrderDescriptions();
            this.loadSelectedPurchaseOrder();

        }

        private void loadVendors()
        {
            this.vendorTableAdapter = new VendorTableAdapter();
            this.vendorTableAdapter.ClearBeforeFill = true;
            this.vendorTableAdapter.Fill(this.adventureWorksDataSet.Vendor);

            this.vendorDropDownList.DataSource = this.adventureWorksDataSet.Vendor;
            this.vendorDropDownList.DataTextField = "Name";
            this.vendorDropDownList.DataValueField = "BusinessEntityID";
            this.vendorDropDownList.DataBind();

            this.vendorDropDownList.SelectedIndex = 1;

        }
        private void loadPurchaseOrderDescriptions()
        {
            this.purchaseOrderDescriptionTableAdapter = new PurchaseOrderDescriptionTableAdapter();
            this.purchaseOrderDescriptionTableAdapter.ClearBeforeFill = true;
            int vendorID = Convert.ToInt32(this.vendorDropDownList.SelectedValue);
            this.purchaseOrderDescriptionTableAdapter.FillByVendorID(adventureWorksDataSet.PurchaseOrderDescription, vendorID);
            this.purchaseOrderIdDropDownList.DataSource = this.adventureWorksDataSet.PurchaseOrderDescription;
            this.purchaseOrderIdDropDownList.DataTextField = "Description";
            this.purchaseOrderIdDropDownList.DataValueField = "PurchaseOrderID";
            this.purchaseOrderIdDropDownList.DataBind();
        }

        protected void purchaseOrderIdDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.loadSelectedPurchaseOrder();
        }
        private void loadSelectedPurchaseOrder()
        {
            this.purchaseOrderHeaderTableAdapter = new PurchaseOrderHeaderTableAdapter();
            this.purchaseOrderHeaderTableAdapter.ClearBeforeFill = true;
            int purchaseOrderID = Convert.ToInt32(this.purchaseOrderIdDropDownList.SelectedValue);
            this.purchaseOrderHeaderTableAdapter.FillByPurchaseOrderID(adventureWorksDataSet.PurchaseOrderHeader, purchaseOrderID);
            AdventureWorksDataSet.PurchaseOrderHeaderRow purchaseOrderRow =
                this.adventureWorksDataSet.PurchaseOrderHeader.First();

            revisionNumberTextBox.Text = purchaseOrderRow.RevisionNumber.ToString();
            statusTextBox.Text = purchaseOrderRow.Status.ToString();
            employeeIDTextBox.Text = purchaseOrderRow.EmployeeID.ToString();
            //shipMethodIdTextBox.Text = purchaseOrderRow.ShipMethodID.ToString();
            this.shipMethodDropDownList.SelectedValue = purchaseOrderRow.ShipMethodID.ToString();
            this.employeeNameDropDownList.SelectedValue = purchaseOrderRow.EmployeeID.ToString();
            shipDateTextBox.Text = purchaseOrderRow.ShipDate.ToShortDateString();
            subtotalLabel.Text = purchaseOrderRow.SubTotal.ToString("n2");
            taxAmtLabel.Text = purchaseOrderRow.TaxAmt.ToString("n2");
            freightTextBox.Text = purchaseOrderRow.TotalDue.ToString("f2");
            totalDueLabel.Text = purchaseOrderRow.TotalDue.ToString("n2");

            this.loadPurchaseOrderDetails();

        }
        private void loadShipMehtods()
        {
            this.shipMethodTableAdapter = new ShipMethodTableAdapter();
            this.shipMethodTableAdapter.ClearBeforeFill = true;
            this.shipMethodTableAdapter.Fill(this.adventureWorksDataSet.ShipMethod);

            this.shipMethodDropDownList.DataSource = this.adventureWorksDataSet.ShipMethod;
            this.shipMethodDropDownList.DataTextField = "Name";
            this.shipMethodDropDownList.DataValueField = "ShipMethodID";
            this.shipMethodDropDownList.DataBind();

        }

        protected void employeeNameDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.loadEmployeeNames();
        }
        private void loadEmployeeNames()
        {
            this.employeeNameTableAdapter = new EmployeeNameTableAdapter();
            this.employeeNameTableAdapter.ClearBeforeFill = true;
            this.employeeNameTableAdapter.Fill(this.adventureWorksDataSet.EmployeeName);

            this.employeeNameDropDownList.DataSource = this.adventureWorksDataSet.ShipMethod;
            this.employeeNameDropDownList.DataTextField = "LastFirstName";
            this.employeeNameDropDownList.DataValueField = "BusinessEntityID";
            this.employeeNameDropDownList.DataBind();
        }
        private void loadPurchaseOrderDetails()
        {
            this.purchaseOrderDetailTableAdapter = new PurchaseOrderDetailTableAdapter();
            this.purchaseOrderDetailTableAdapter.ClearBeforeFill = true;
            int purchaseOrderID = Convert.ToInt32(purchaseOrderIdDropDownList.SelectedValue);
            this.purchaseOrderDetailTableAdapter.FillByPurchaseOrderID(this.adventureWorksDataSet.PurchaseOrderDetail, purchaseOrderID);

            this.purchaseOrderDetailsGridView.DataSource = this.adventureWorksDataSet.PurchaseOrderDetail;
            this.purchaseOrderDetailsGridView.DataBind();
        }
    }
}