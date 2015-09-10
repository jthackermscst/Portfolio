﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 


namespace jthacker2747ex1b1
{
    public partial class VenderDetailsForm : Form
    {
        public VenderDetailsForm()
        {
            InitializeComponent();
        }

        private void vendorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendorBindingSource.EndEdit();
            try
            {
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

        private void VenderDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorksDataSet.Vendor' table. You can move, or remove it, as needed.

            

            try
            {
                this.vendorTableAdapter.Fill(this.adventureWorksDataSet.Vendor);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "VenderDetails_Load(): " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "VenderDetails_Load(): " + ex.GetType().ToString());
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void businessEntityIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void preferredVendorStatusCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
