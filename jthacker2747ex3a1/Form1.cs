using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jthacker2747ex3a1ef.Model;

namespace jthacker2747ex3a1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadControls();
            this.vendorComboBox.SelectedIndexChanged 
                += new System.EventHandler(this.vendorComboBox_SelectedIndexChanged);
        }
        private void loadControls()
        {
            List<ShipMethod> shipMethodList = new List<ShipMethod>();
            try
            {
                this.shipMethodComboBox.DataSource = Company.getShipMethods();
                this.shipMethodComboBox.ValueMember = "ShipMethodID"; 
                this.shipMethodComboBox.DisplayMember = "Name";

                this.vendorComboBox.DataSource = Company.getVendors();
                this.vendorComboBox.ValueMember = null;
                this.vendorComboBox.DisplayMember = "Name";
                this.vendorComboBox.SelectedIndex = 1; 


                this.employeeComboBox.DataSource = Company.getEmployees();
                this.employeeComboBox.ValueMember = "BusinessEnityID";
                this.employeeComboBox.DisplayMember = "LastFirstName";



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            

        }

        private void vendorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vendor vendor = (Vendor)vendorComboBox.SelectedValue;
            try
            {
                this.purchaseOrderHeaderBindingSource.DataSource = 
                    vendor.PurchaseOrderHeaders.ToList(); //uses EF Lazy Loading
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \nMeassge: " + ex.Message,
                    "vendorComboBox_SelectedIndexChanged():" + ex.GetType().ToString());
            }

        }

        private void purchaseOrderHeaderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            PurchaseOrderHeader po =
                (PurchaseOrderHeader)this.purchaseOrderHeaderBindingSource.Current;
            try
            {
                this.purchaseOrderDetailBindingSource.DataSource =
                    po.PurchaseOrderDetails.ToList(); //uses EF Lazy Loading
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \nMeassge: " + ex.Message,
                    "vendorComboBox_SelectedIndexChanged():" + ex.GetType().ToString());
            }

        }

        private void purchaseOrderDetailBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
