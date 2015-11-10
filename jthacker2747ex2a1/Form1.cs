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
namespace jthacker2747ex2a1
{
    public partial class Form1 : Form
    {

        //private AdventureWorksDataSet adventureWorksDataSet;
        private AdventureWorksDataSetTableAdapters.VendorTableAdapter vendorTableAdapter;
        private AdventureWorksDataSet.VendorDataTable vendorDataTable;
        private AdventureWorksDataSet.VendorRow currentVendorRow;

        private AdventureWorksDataSetTableAdapters.BusinessEntityTableAdapter businessEntityTableAdapter;
        private AdventureWorksDataSet.BusinessEntityDataTable businessEntityDataTable;
        private AdventureWorksDataSet.BusinessEntityRow currentBusinessEntityRow;

        private AdventureWorksDataSetTableAdapters.BusinessEntityAddressTableAdapter businessEntityAddressTableAdapter;
        private AdventureWorksDataSet.BusinessEntityAddressDataTable businessEntityAddressDataTable;
        private AdventureWorksDataSet.BusinessEntityAddressRow currentBusinessEntityAddressRow;

        private AdventureWorksDataSetTableAdapters.AddressTableAdapter addressTableAdapter;
        private AdventureWorksDataSet.AddressDataTable addressDataTable;
        private AdventureWorksDataSet.AddressRow currentAddressRow;

        private int currentVendorPosition = 01;
        private string currentTextBoxText;

        private object previousSender;
        //private bool vendorAddressControlChanged = false; 

        private bool addingNew;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            createDataObjects();
            loadStates();
            if (stateProvinceComboBox.Items.Count > 0)
            {
                try
                {
                    this.vendorTableAdapter.Fill(this.vendorDataTable);
                    this.currentVendorPosition = 0;
                    this.currentVendorRow =
                        (AdventureWorksDataSet.VendorRow)vendorDataTable.Rows[0];
                    loadCurrentVendorAddress();
                    setButtonsEnabled(true);
                    clearVendorControls();
                    displayVendor();
                    
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
        }
        private void displayVendor()
        {
            this.businessEntityIdLabel.Text = this.currentVendorRow.BusinessEntityID.ToString();
            this.vendorNameTextBox.Text = this.currentVendorRow.Name;
            this.accountNumberTextBox.Text = this.currentVendorRow.AccountNumber;
            this.creditRatingCombox.SelectedIndex = this.currentVendorRow.CreditRating - 1; 
            this.preferredVendorCheckbox.Checked = this.currentVendorRow.PreferredVendorStatus;
            this.vendorActiveCheckBox.Checked = this.currentVendorRow.ActiveFlag;

            //Display Address

            this.address1TextBox.Text = this.currentAddressRow.AddressLine1;
            if (this.currentAddressRow.IsAddressLine2Null())
                this.address2TextBox.Text = string.Empty;
            else
                this.address2TextBox.Text = this.currentAddressRow.AddressLine2;

            this.cityTextBox.Text = this.currentAddressRow.City;
            this.stateProvinceComboBox.SelectedValue = this.currentAddressRow.StateProvinceID;
            this.postalCodeTextBox.Text = this.currentAddressRow.PostalCode;
            this.addressModifiedDateTimePicker.Value = currentAddressRow.ModifiedDate;


            this.currentPositionLabel.Text = (this.currentVendorPosition + 1).ToString()
                + "of" + this.vendorDataTable.Count.ToString();

            setButtonsEnabled(true);
            this.vendorNameTextBox.Focus();

        }
        private void clearVendorControls ()
        {
            this.businessEntityIdLabel.Text = string.Empty;
            this.vendorNameTextBox.Text = string.Empty;
            this.accountNumberTextBox.Text = string.Empty;
            this.creditRatingCombox.SelectedIndex = - 1;
            this.preferredVendorCheckbox.Checked = false;
            this.vendorActiveCheckBox.Checked = false;

            //Display Address

            this.address1TextBox.Text = string.Empty;
            ////this.address2TextBox.Text = this.currentAddressRow.AddressLine2;
            this.cityTextBox.Text = string.Empty;
            this.stateProvinceComboBox.SelectedValue = this.currentAddressRow.StateProvinceID;
            this.postalCodeTextBox.Text = string.Empty;

        }
        private void navButton_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "moveFirstButton":
                    this.currentVendorPosition = 0;
                    break;
                case "movePreviousButton":
                    this.currentVendorPosition -= 1;
                    break;
                case "moveNextButton":
                    this.currentVendorPosition += 1;
                    break;
                case "moveLastButton":
                    this.currentVendorPosition =
                        this.vendorDataTable.Count - 1;
                    break;


            }
            this.currentVendorRow =
                (AdventureWorksDataSet.VendorRow)vendorDataTable.Rows[currentVendorPosition];
            loadCurrentVendorAddress();
            if (this.currentAddressRow != null)
            {
                setButtonsEnabled(true);
                clearVendorControls();
                displayVendor();
            }
        }
        //private void setNavButtonEnabled()
        //{
        //    this.moveNextButton.Enabled = true;
        //    this.moveLastButton.Enabled = true;
        //    this.moveFirstButton.Enabled = true;
        //    this.movePreviousButton.Enabled = true;

        //    if (currentVendorPosition == 0)
        //    {
        //        this.moveFirstButton.Enabled = false;
        //        this.movePreviousButton.Enabled = false;

        //    }
        //    if (currentVendorPosition == this.vendorDataTable.Count - 1)
        //    {
        //        this.moveNextButton.Enabled = false;
        //        this.moveLastButton.Enabled = false;
        //    }
        //}
        private void setButtonsEnabled(bool value)
        {
            this.moveNextButton.Enabled = value;
            this.moveLastButton.Enabled = value;
            this.moveFirstButton.Enabled = value;
            this.movePreviousButton.Enabled = value;
            this.deleteButton.Enabled = value;
            this.newButton.Enabled = value; 

            if (currentVendorPosition == 0)
            {
                this.moveFirstButton.Enabled = false;
                this.movePreviousButton.Enabled = false;

            }
            if (currentVendorPosition == this.vendorDataTable.Count - 1)
            {
                this.moveNextButton.Enabled = false;
                this.moveLastButton.Enabled = false;
            }
        }

        private void createDataObjects()
        {
            //this.adventureWorksDataSet =
            //new AdventureWorksDataSet();
            //((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).BeginInit();
            //this.adventureWorksDataSet.DataSetName = "AdventureWorksDataSet";
            //this.adventureWorksDataSet.SchemaSerializationMode =
            //    System.Data.SchemaSerializationMode.IncludeSchema;

            // VendorS
            this.vendorTableAdapter =
                new AdventureWorksDataSetTableAdapters.VendorTableAdapter();
            this.vendorTableAdapter.ClearBeforeFill = true;
            this.vendorDataTable = new AdventureWorksDataSet.VendorDataTable();


            //BusinessEntity
            this.businessEntityTableAdapter = new AdventureWorksDataSetTableAdapters.BusinessEntityTableAdapter();
            this.businessEntityTableAdapter.ClearBeforeFill = true;
            this.businessEntityDataTable = new AdventureWorksDataSet.BusinessEntityDataTable();

            //BusinessEntityAddress
            this.businessEntityAddressTableAdapter = new AdventureWorksDataSetTableAdapters.BusinessEntityAddressTableAdapter();
            this.businessEntityAddressTableAdapter.ClearBeforeFill = true;
            this.businessEntityAddressDataTable = new AdventureWorksDataSet.BusinessEntityAddressDataTable();

            //Address
            this.addressTableAdapter = new AdventureWorksDataSetTableAdapters.AddressTableAdapter();
            this.addressTableAdapter.ClearBeforeFill = true;
            this.addressDataTable = new AdventureWorksDataSet.AddressDataTable();

        }

        private void loadStates()
        {
            //State
            AdventureWorksDataSetTableAdapters.StateProvinceTableAdapter stateProvinceTableAdapter =
                new AdventureWorksDataSetTableAdapters.StateProvinceTableAdapter();
            stateProvinceTableAdapter.ClearBeforeFill = true;
            AdventureWorksDataSet.StateProvinceDataTable stateProvinceDataTable =
                new AdventureWorksDataSet.StateProvinceDataTable();


            try
            {

         
                stateProvinceTableAdapter.Fill(stateProvinceDataTable);
                stateProvinceComboBox.DataSource = stateProvinceDataTable;
                stateProvinceComboBox.ValueMember = "StateProvinceID";
                stateProvinceComboBox.DisplayMember = "StateProvinceCode";


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
        private void loadCurrentVendorAddress()
        {
            try
            {


                if (this.vendorDataTable.Count > 0)
                {
                        this.businessEntityTableAdapter.FillByBusinessEntityID(
                            this.businessEntityDataTable, this.currentVendorRow.BusinessEntityID);
                    if (this.businessEntityDataTable.Count > 0)
                    {
                        this.currentBusinessEntityRow =
                            (AdventureWorksDataSet.BusinessEntityRow)this.businessEntityDataTable.Rows[0];
                        this.businessEntityAddressTableAdapter.FillByBusinessEntityID(
                            this.businessEntityAddressDataTable, currentBusinessEntityRow.BusinessEntityID);
                        if (this.businessEntityAddressDataTable.Count > 0)
                        {
                            this.currentBusinessEntityAddressRow =
                                (AdventureWorksDataSet.BusinessEntityAddressRow)this.businessEntityAddressDataTable.Rows[0];
                            this.addressTableAdapter.FillByAddressID(
                                this.addressDataTable, currentBusinessEntityAddressRow.AddressID);
                            if (this.addressDataTable.Count > 0)
                            {
                                this.currentAddressRow =
                                    (AdventureWorksDataSet.AddressRow)this.addressDataTable.Rows[0];

                            }

                        }

                    }
                    clearVendorControls();
                    displayVendor();
                    setButtonsEnabled(true);
                }

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

        private void textBox_ValidateNull(object sender, CancelEventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;
            if(currentTextBox.Text.Trim().Equals(string.Empty))
            {
                currentTextBox.BackColor = Color.FromArgb(255, 196, 196);
                e.Cancel = true;

            }
            else
            {
                currentTextBox.BackColor = SystemColors.Window;
                e.Cancel = false;
            }
        }

        private void bufferCurrentText(object sender, EventArgs e)
        {
            if (sender != this.previousSender)
            {
                this.previousSender = sender;
                TextBox currentTextBox = (TextBox)sender;
                this.currentTextBoxText = currentTextBox.Text;
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                TextBox currentTextBox = (TextBox)sender;
                currentTextBox.Text = this.currentTextBoxText;
            }
        
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(vendorAddressControlsAreValid())
            {
                this.currentVendorRow.BeginEdit();
                this.currentAddressRow.BeginEdit();
                updateVendorAddressRows();
                this.currentVendorRow.EndEdit();
                this.currentAddressRow.EndEdit();
                try {
                    this.vendorTableAdapter.Update(this.vendorDataTable);
                    this.addressTableAdapter.Update(this.addressDataTable);
                    this.addingNew = false;
                    setButtonsEnabled(true);
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

        }
        
        private bool vendorAddressControlsAreValid()
        {
            bool controlsAreValid = true;
            if( controlsAreValid
                && this.cityTextBox.Text.Trim().Equals ("New York")
                && !stateProvinceComboBox.Text.Trim().Equals("NY"))
            {
                MessageBox.Show(this.cityTextBox.Text + "does not Exist in" + stateProvinceComboBox.Text
                     + "Invalid City");
                controlsAreValid = false;
                this.cityTextBox.Focus(); 
            }

            return controlsAreValid;  
            
        }
        private void updateVendorAddressRows()
        {
             this.currentVendorRow.Name = this.vendorNameTextBox.Text;
             this.currentVendorRow.AccountNumber = this.accountNumberTextBox.Text;
             this.currentVendorRow.CreditRating = (byte)(this.creditRatingCombox.SelectedIndex + 1);
             this.currentVendorRow.PreferredVendorStatus = this.preferredVendorCheckbox.Checked;
             this.currentVendorRow.ActiveFlag = this.vendorActiveCheckBox.Checked;

            //Display Address
            this.currentAddressRow.BeginEdit();
            this.currentAddressRow.AddressLine1 = this.address1TextBox.Text;
            if (this.address2TextBox.Text.Trim().Equals(string.Empty))
                this.currentAddressRow.SetAddressLine2Null();
                
            else
                 this.currentAddressRow.AddressLine2 = this.address2TextBox.Text;
             this.currentAddressRow.City = this.cityTextBox.Text;
             this.currentAddressRow.StateProvinceID = (int)(this.stateProvinceComboBox.SelectedValue);
             this.currentAddressRow.PostalCode = this.postalCodeTextBox.Text;
             this.currentAddressRow.ModifiedDate = this.addressModifiedDateTimePicker.Value;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (this.addingNew)
            {
                deleteButton_Click(null, null);
                this.addingNew = false;
            }
            else
            {
                clearVendorControls();
                displayVendor();
                MessageBox.Show("Update Cancelled", "Operation Cancelled");
            }
        }

        private void controlValueChanged(object sender, EventArgs e)
        {
            //this.vendorAddressControlChanged = true;
            setButtonsEnabled(false);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            AdventureWorksDataSet.BusinessEntityRow bakBusinessEntityRow =
                this.currentBusinessEntityRow;
            AdventureWorksDataSet.VendorRow bakVendorRow =
                this.currentVendorRow;
            AdventureWorksDataSet.AddressRow bakAddressRow =
                this.currentAddressRow;
            AdventureWorksDataSet.BusinessEntityAddressRow bakBusinessEntityAddressRow =
                this.currentBusinessEntityAddressRow;


            try
            {
                this.currentBusinessEntityRow =
                    this.businessEntityDataTable.NewBusinessEntityRow();
                this.businessEntityDataTable.AddBusinessEntityRow(this.currentBusinessEntityRow);
                int countNew = this.businessEntityTableAdapter.Update(this.businessEntityDataTable);

                this.currentVendorRow =
                    this.vendorDataTable.NewVendorRow();
                this.currentVendorRow.BusinessEntityID = this.currentBusinessEntityRow.BusinessEntityID;
                this.currentVendorRow.AccountNumber = string.Empty;
                this.currentVendorRow.Name = string.Empty;
                this.currentVendorRow.CreditRating = 1;
                this.currentVendorRow.PreferredVendorStatus = false;
                this.currentVendorRow.ActiveFlag = true;
                this.vendorDataTable.AddVendorRow(this.currentVendorRow);
                this.vendorTableAdapter.Update(this.vendorDataTable);

              

                this.currentAddressRow =
                    this.addressDataTable.NewAddressRow();
                this.currentAddressRow.AddressLine1 = string.Empty;
                this.currentAddressRow.AddressLine2 = string.Empty;
                this.currentAddressRow.City = string.Empty;
                this.currentAddressRow.StateProvinceID = 9;
                this.currentAddressRow.PostalCode = string.Empty;
                this.currentAddressRow.ModifiedDate = System.DateTime.Now;
                this.addressDataTable.AddAddressRow(this.currentAddressRow);
                this.addressTableAdapter.Update(this.addressDataTable);

                this.currentBusinessEntityAddressRow =
                    this.businessEntityAddressDataTable.NewBusinessEntityAddressRow();
                this.currentBusinessEntityAddressRow.BusinessEntityID = currentBusinessEntityRow.BusinessEntityID;
                this.currentBusinessEntityAddressRow.AddressID = this.currentAddressRow.AddressID;
                this.currentBusinessEntityAddressRow.AddressTypeID = 3;
                this.businessEntityAddressDataTable.AddBusinessEntityAddressRow(this.currentBusinessEntityAddressRow);
                this.businessEntityAddressTableAdapter.Update(this.businessEntityAddressDataTable);


                this.addingNew = true; 

                this.currentVendorPosition = this.vendorDataTable.Count - 1;
                displayVendor();
                setButtonsEnabled(false);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "newButton_Clicked(): " + ex.GetType().ToString());
                this.currentBusinessEntityRow = bakBusinessEntityRow;
                this.currentVendorRow = bakVendorRow;
                this.currentAddressRow = bakAddressRow;
                this.currentBusinessEntityAddressRow = bakBusinessEntityAddressRow;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "newButton_Clicked(): " + ex.GetType().ToString());
                this.currentBusinessEntityRow = bakBusinessEntityRow;
                this.currentVendorRow = bakVendorRow;
                this.currentAddressRow = bakAddressRow;
                this.currentBusinessEntityAddressRow = bakBusinessEntityAddressRow;

            }


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {


            this.currentBusinessEntityAddressRow.Delete();
            this.currentAddressRow.Delete();
            this.currentVendorRow.Delete();
            this.currentBusinessEntityRow.Delete();

            try {
                this.businessEntityAddressTableAdapter.Update(
                    this.businessEntityAddressDataTable);
                this.addressTableAdapter.Update(
                    this.addressDataTable);
                this.vendorTableAdapter.Update(
                    this.vendorDataTable);
                this.businessEntityTableAdapter.Update(
                    this.businessEntityDataTable);

                this.currentVendorPosition = 0;
                this.currentVendorRow =
                    (AdventureWorksDataSet.VendorRow)vendorDataTable.Rows[0];
                loadCurrentVendorAddress();
                setButtonsEnabled(true);
                //clearVendorControls();
                displayVendor();
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "deletButton_Click(): " + ex.GetType().ToString());
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "deletButton_Click(): " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "deletButton_Click(): " + ex.GetType().ToString());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!this.newButton.Enabled)
            {
                DialogResult saveChanges =
                    MessageBox.Show("Save changes?", "Row Updates",
                        MessageBoxButtons.OKCancel);
                if (saveChanges == DialogResult.OK)
                {
                    saveButton_Click(null, null);
                }
                //else
                //{
                //    Form1.Close();
                //}
            }
        }
    }
    }

