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


namespace jthacker2747ex2b1
{
    public partial class Form1 : Form
    {
        //Update Client Table

        private ClientServiceDataSetTableAdapters._2hClientTableAdapter clientTableAdapter;
        private ClientServiceDataSet._2hClientDataTable clientDataTable;
        private ClientServiceDataSet._2hClientRow currentClientRow;
        private int currentClientPosition = -1;

        private ClientServiceDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private ClientServiceDataSet.PersonDataTable personDataTable;
        private ClientServiceDataSet.PersonRow currentPersonRow;


        private ClientServiceDataSetTableAdapters._2hServiceTableAdapter serviceTableAdapter;
        private ClientServiceDataSet._2hServiceDataTable serviceDataTable;
        private ClientServiceDataSet._2hServiceRow currentServiceRow;

        private bool addingNew = false;
        private object previousSender = null;
        private string currentTextBoxText = string.Empty;



        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.clientTableAdapter =
                    new ClientServiceDataSetTableAdapters._2hClientTableAdapter();
            this.clientTableAdapter.ClearBeforeFill = true;
            this.clientDataTable = new ClientServiceDataSet._2hClientDataTable();


            loadComboBox();

            if (serviceIdComboBox.Items.Count > 0)
            {
                this.clientTableAdapter =
                    new ClientServiceDataSetTableAdapters._2hClientTableAdapter();
                this.clientTableAdapter.ClearBeforeFill = true;
                this.clientDataTable = new ClientServiceDataSet._2hClientDataTable();

                this.serviceTableAdapter =
                    new ClientServiceDataSetTableAdapters._2hServiceTableAdapter();
                this.serviceTableAdapter.ClearBeforeFill = true;
                this.serviceDataTable = new ClientServiceDataSet._2hServiceDataTable();

                this.personTableAdapter =
                    new ClientServiceDataSetTableAdapters.PersonTableAdapter();
                this.personTableAdapter.ClearBeforeFill = true;
                this.personDataTable = new ClientServiceDataSet.PersonDataTable();



                try
                {
                    this.clientTableAdapter.Fill(this.clientDataTable);
                    this.currentClientPosition = 0;
                    this.currentClientRow =
                        (ClientServiceDataSet._2hClientRow)this.clientDataTable.Rows[this.currentClientPosition];

                    this.serviceTableAdapter.Fill(this.serviceDataTable);
                    this.currentServiceRow =
                        (ClientServiceDataSet._2hServiceRow)this.serviceDataTable.Rows[this.currentClientPosition];

                    this.personTableAdapter.FillByPersonID(this.personDataTable, currentClientRow.PersonID);
                    this.currentPersonRow =
                        (ClientServiceDataSet.PersonRow)this.personDataTable.Rows[this.currentClientPosition];

                    this.currentPositionLabel.Text = (this.currentClientPosition + 1).ToString()
                        + " of " + this.clientDataTable.Count.ToString();


                    //Enable Buttons
                    setButtonsEnabled(true);
                    //Clear Controls
                    clearClientControls();

                    //Display Client
                    displayClient();

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
        private void loadComboBox()
        {
            ClientServiceDataSetTableAdapters._2hClientTableAdapter clientTableAdapter =
                new ClientServiceDataSetTableAdapters._2hClientTableAdapter();
            clientTableAdapter.ClearBeforeFill = true;
            ClientServiceDataSet._2hClientDataTable clientDataTable =
                 new ClientServiceDataSet._2hClientDataTable();


            ClientServiceDataSetTableAdapters._2hServiceTableAdapter serviceTableAdapter =
                new ClientServiceDataSetTableAdapters._2hServiceTableAdapter();
            clientTableAdapter.ClearBeforeFill = true;
            ClientServiceDataSet._2hServiceDataTable serviceDataTable =
                new ClientServiceDataSet._2hServiceDataTable();

            try
            {

                //clientIdComboBox.DataSource = clientDataTable;
                //clientIdComboBox.ValueMember = "ClientID";
                //clientIdComboBox.DisplayMember = "ClientID";
                clientTableAdapter.Fill(clientDataTable);
                serviceTableAdapter.Fill(serviceDataTable);
                serviceIdComboBox.DataSource = clientDataTable;
                serviceIdComboBox.ValueMember = "ClientID";
                serviceIdComboBox.DisplayMember = "SeviceID";



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
        private void setButtonsEnabled(bool value)
        {
            this.moveNextButton.Enabled = value;
            this.moveLastButton.Enabled = value;
            this.moveFirstButton.Enabled = value;
            this.movePreviousButton.Enabled = value;
            this.deleteButton.Enabled = value;
            this.newButton.Enabled = value;

            if (currentClientPosition == 0)
            {
                this.moveFirstButton.Enabled = false;
                this.movePreviousButton.Enabled = false;

            }
            if (currentClientPosition == this.clientDataTable.Count - 1)
            {
                this.moveNextButton.Enabled = false;
                this.moveLastButton.Enabled = false;
            }
        }
        private void displayClient()
        {
            /////////From Client Table
            this.clientIdTextBox.Text = this.currentClientRow.ClientID.ToString();
            this.personIdTextBox.Text = this.currentClientRow.PersonID.ToString();
            //this.dateOfServiceDateTimePicker1.MinDate =(DateTime)this.currentClientRow.DateOfSevice;
            //this.dateOfServiceDateTimePicker1.MaxDate = (DateTime)this.currentClientRow.DateOfSevice;

            ////////From Person Table
            this.firstNameTextBox.Text = this.currentPersonRow.FirstName;
            this.lastNameTextBox.Text = this.currentPersonRow.LastName;

            ////////From Service Table
            this.typeOfServiceTextBox.Text = this.currentServiceRow.TypeOfService;
            this.chargeTextBox.Text = this.currentServiceRow.ChargePerHour.ToString("C");

            //Display count and position
            this.currentPositionLabel.Text = (this.currentClientPosition + 1).ToString()
                       + " of " + this.clientDataTable.Count.ToString();

        }

        private void clearClientControls()
        {
            this.clientIdTextBox.Text = string.Empty;
            this.personIdTextBox.Text = string.Empty;

            //From Person Table
            this.firstNameTextBox.Text = string.Empty;
            this.lastNameTextBox.Text = string.Empty;

            //From Service Table
            this.typeOfServiceTextBox.Text = string.Empty;
            this.chargeTextBox.Text = string.Empty;



            this.serviceIdComboBox.SelectedIndex = -1;

        }
        private void navButton_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "moveFirstButton":
                    this.currentClientPosition = 0;
                    break;
                case "movePreviousButton":
                    this.currentClientPosition -= 1;
                    break;
                case "moveNextButton":
                    this.currentClientPosition += 1;
                    break;
                case "moveLastButton":
                    this.currentClientPosition =
                        this.clientDataTable.Count - 1;
                    break;


            }
            this.currentClientRow =
                (ClientServiceDataSet._2hClientRow)clientDataTable.Rows[this.currentClientPosition];

            setButtonsEnabled(true);
            clearClientControls();
            displayClient();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            updateClientFields();

            //this.currentClientRow.BeginEdit();
            //this.currentServiceRow.BeginEdit();
            //this.currentPersonRow.BeginEdit();

            //this.currentClientRow.EndEdit();
            //this.currentServiceRow.EndEdit();
            //this.currentPersonRow.EndEdit();

            try
            {
                this.clientTableAdapter.Update(this.clientDataTable);
                this.serviceTableAdapter.Update(this.serviceDataTable);

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
        private void updateClientFields()
        {

            this.currentClientRow.SeviceID = Convert.ToInt32(this.serviceIdComboBox.SelectedValue);

            this.currentServiceRow.ChargePerHour = Convert.ToDecimal(this.chargeTextBox.Text.Trim());
            this.currentServiceRow.TypeOfService = this.typeOfServiceTextBox.Text.Trim();

            this.currentPersonRow.FirstName = this.firstNameTextBox.Text.Trim();
            this.currentPersonRow.LastName = this.lastNameTextBox.Text.Trim();



        }

        private void control_valueChanged(object sender, EventArgs e)
        {
            setButtonsEnabled(false);


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
                clearClientControls();
                displayClient();
                MessageBox.Show("Update Cancelled", "Operation Cancelled");
            }
        }
        private void newButton_Click(object sender, EventArgs e)
        {
            ClientServiceDataSet._2hClientRow bakClientRow = this.currentClientRow;
            this.currentClientRow = this.clientDataTable.New_2hClientRow();

            ClientServiceDataSet._2hServiceRow bakServiceRow = this.currentServiceRow;
            this.currentServiceRow = this.serviceDataTable.New_2hServiceRow();

            ClientServiceDataSet.PersonRow bakPersonRow = this.currentPersonRow;
            this.currentPersonRow = this.personDataTable.NewPersonRow();

            this.currentClientRow.ClientID = -1;
            this.currentClientRow.PersonID = -1;
            this.currentPersonRow.FirstName = string.Empty;
            this.currentPersonRow.LastName = string.Empty;
            this.currentClientRow.SeviceID = -1;
            this.currentServiceRow.TypeOfService = string.Empty;
            this.currentServiceRow.ChargePerHour = 0;

            this.clientDataTable.Add_2hClientRow(this.currentClientRow);
            this.serviceDataTable.Add_2hServiceRow(this.currentServiceRow);
            this.personDataTable.AddPersonRow(this.currentPersonRow);

            try
            {
                this.serviceTableAdapter.Update(this.serviceDataTable);
                this.clientTableAdapter.Update(this.clientDataTable);
                this.addingNew = true;
                this.currentClientPosition = this.clientDataTable.Count - 1;

                displayClient();
                setButtonsEnabled(false);


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

        private void textbox_validateNull(object sender, CancelEventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;
            if (currentTextBox.Text.Trim().Equals(string.Empty))
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.currentClientRow.Delete();
            this.currentServiceRow.Delete();
            this.currentPersonRow.Delete();



            try
            {
                this.clientTableAdapter.Update(
                    this.clientDataTable);
                this.serviceTableAdapter.Update(
                    this.serviceDataTable);

                this.currentClientPosition = 0;
                this.currentClientRow =
                    (ClientServiceDataSet._2hClientRow)clientDataTable.Rows[0];

                setButtonsEnabled(true);
                //clearVendorControls();
                displayClient();
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
                    MessageBox.Show("Save Changes before closing?", "Client Update",
                        MessageBoxButtons.YesNo); 
                    if(saveChanges == DialogResult.Yes)
                {
                    saveButton_Click(null, null);
                }
                }
            
        }
    }
} 

 
