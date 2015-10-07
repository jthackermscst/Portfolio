namespace jthacker2747ex1g2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label purchaseOrderIDLabel;
            System.Windows.Forms.Label revisionNumberLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label vendorIDLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label shipDateLabel;
            System.Windows.Forms.Label subTotalLabel;
            System.Windows.Forms.Label taxAmtLabel;
            System.Windows.Forms.Label freightLabel;
            System.Windows.Forms.Label totalDueLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.purchaseOrderHeaderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.purchaseOrderHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorksDataSet = new jthacker2747ex1g2.AdventureWorksDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.purchaseOrderHeaderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.purchaseOrderIDLabel1 = new System.Windows.Forms.Label();
            this.revisionNumberTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shipDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.subTotalLabel1 = new System.Windows.Forms.Label();
            this.taxAmtLabel1 = new System.Windows.Forms.Label();
            this.freightTextBox = new System.Windows.Forms.TextBox();
            this.totalDueLabel1 = new System.Windows.Forms.Label();
            this.vendorComboBox = new System.Windows.Forms.ComboBox();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeNameComboBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shipMethodComboBox = new System.Windows.Forms.ComboBox();
            this.shipMethodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseOrderHeaderTableAdapter = new jthacker2747ex1g2.AdventureWorksDataSetTableAdapters.PurchaseOrderHeaderTableAdapter();
            this.tableAdapterManager = new jthacker2747ex1g2.AdventureWorksDataSetTableAdapters.TableAdapterManager();
            this.vendorTableAdapter = new jthacker2747ex1g2.AdventureWorksDataSetTableAdapters.VendorTableAdapter();
            this.employeeNameTableAdapter = new jthacker2747ex1g2.AdventureWorksDataSetTableAdapters.EmployeeNameTableAdapter();
            this.shipMethodTableAdapter = new jthacker2747ex1g2.AdventureWorksDataSetTableAdapters.ShipMethodTableAdapter();
            this.purchaseOrderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseOrderDetailTableAdapter = new jthacker2747ex1g2.AdventureWorksDataSetTableAdapters.PurchaseOrderDetailTableAdapter();
            this.purchaseOrderDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalcLineTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            purchaseOrderIDLabel = new System.Windows.Forms.Label();
            revisionNumberLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            vendorIDLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            shipDateLabel = new System.Windows.Forms.Label();
            subTotalLabel = new System.Windows.Forms.Label();
            taxAmtLabel = new System.Windows.Forms.Label();
            freightLabel = new System.Windows.Forms.Label();
            totalDueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderHeaderBindingNavigator)).BeginInit();
            this.purchaseOrderHeaderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderHeaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMethodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDetailDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // purchaseOrderIDLabel
            // 
            purchaseOrderIDLabel.AutoSize = true;
            purchaseOrderIDLabel.Location = new System.Drawing.Point(39, 93);
            purchaseOrderIDLabel.Name = "purchaseOrderIDLabel";
            purchaseOrderIDLabel.Size = new System.Drawing.Size(130, 17);
            purchaseOrderIDLabel.TabIndex = 1;
            purchaseOrderIDLabel.Text = "Purchase Order ID:";
            // 
            // revisionNumberLabel
            // 
            revisionNumberLabel.AutoSize = true;
            revisionNumberLabel.Location = new System.Drawing.Point(39, 124);
            revisionNumberLabel.Name = "revisionNumberLabel";
            revisionNumberLabel.Size = new System.Drawing.Size(120, 17);
            revisionNumberLabel.TabIndex = 3;
            revisionNumberLabel.Text = "Revision Number:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(256, 122);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(52, 17);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Status:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(37, 152);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(115, 17);
            employeeIDLabel.TabIndex = 7;
            employeeIDLabel.Text = "Employee Name:";
            // 
            // vendorIDLabel
            // 
            vendorIDLabel.AutoSize = true;
            vendorIDLabel.Location = new System.Drawing.Point(39, 65);
            vendorIDLabel.Name = "vendorIDLabel";
            vendorIDLabel.Size = new System.Drawing.Size(58, 17);
            vendorIDLabel.TabIndex = 9;
            vendorIDLabel.Text = "Vendor:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(37, 186);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(83, 17);
            orderDateLabel.TabIndex = 13;
            orderDateLabel.Text = "Order Date:";
            // 
            // shipDateLabel
            // 
            shipDateLabel.AutoSize = true;
            shipDateLabel.Location = new System.Drawing.Point(37, 214);
            shipDateLabel.Name = "shipDateLabel";
            shipDateLabel.Size = new System.Drawing.Size(74, 17);
            shipDateLabel.TabIndex = 15;
            shipDateLabel.Text = "Ship Date:";
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Location = new System.Drawing.Point(39, 488);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new System.Drawing.Size(73, 17);
            subTotalLabel.TabIndex = 17;
            subTotalLabel.Text = "Sub Total:";
            // 
            // taxAmtLabel
            // 
            taxAmtLabel.AutoSize = true;
            taxAmtLabel.Location = new System.Drawing.Point(39, 511);
            taxAmtLabel.Name = "taxAmtLabel";
            taxAmtLabel.Size = new System.Drawing.Size(63, 17);
            taxAmtLabel.TabIndex = 19;
            taxAmtLabel.Text = "Tax Amt:";
            // 
            // freightLabel
            // 
            freightLabel.AutoSize = true;
            freightLabel.Location = new System.Drawing.Point(39, 540);
            freightLabel.Name = "freightLabel";
            freightLabel.Size = new System.Drawing.Size(56, 17);
            freightLabel.TabIndex = 21;
            freightLabel.Text = "Freight:";
            // 
            // totalDueLabel
            // 
            totalDueLabel.AutoSize = true;
            totalDueLabel.Location = new System.Drawing.Point(39, 562);
            totalDueLabel.Name = "totalDueLabel";
            totalDueLabel.Size = new System.Drawing.Size(74, 17);
            totalDueLabel.TabIndex = 23;
            totalDueLabel.Text = "Total Due:";
            // 
            // purchaseOrderHeaderBindingNavigator
            // 
            this.purchaseOrderHeaderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.purchaseOrderHeaderBindingNavigator.BindingSource = this.purchaseOrderHeaderBindingSource;
            this.purchaseOrderHeaderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.purchaseOrderHeaderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.purchaseOrderHeaderBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.purchaseOrderHeaderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.purchaseOrderHeaderBindingNavigatorSaveItem});
            this.purchaseOrderHeaderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.purchaseOrderHeaderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.purchaseOrderHeaderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.purchaseOrderHeaderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.purchaseOrderHeaderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.purchaseOrderHeaderBindingNavigator.Name = "purchaseOrderHeaderBindingNavigator";
            this.purchaseOrderHeaderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.purchaseOrderHeaderBindingNavigator.Size = new System.Drawing.Size(919, 27);
            this.purchaseOrderHeaderBindingNavigator.TabIndex = 0;
            this.purchaseOrderHeaderBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // purchaseOrderHeaderBindingSource
            // 
            this.purchaseOrderHeaderBindingSource.DataMember = "PurchaseOrderHeader";
            this.purchaseOrderHeaderBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // adventureWorksDataSet
            // 
            this.adventureWorksDataSet.DataSetName = "AdventureWorksDataSet";
            this.adventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // purchaseOrderHeaderBindingNavigatorSaveItem
            // 
            this.purchaseOrderHeaderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.purchaseOrderHeaderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("purchaseOrderHeaderBindingNavigatorSaveItem.Image")));
            this.purchaseOrderHeaderBindingNavigatorSaveItem.Name = "purchaseOrderHeaderBindingNavigatorSaveItem";
            this.purchaseOrderHeaderBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.purchaseOrderHeaderBindingNavigatorSaveItem.Text = "Save Data";
            this.purchaseOrderHeaderBindingNavigatorSaveItem.Click += new System.EventHandler(this.purchaseOrderHeaderBindingNavigatorSaveItem_Click);
            // 
            // purchaseOrderIDLabel1
            // 
            this.purchaseOrderIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purchaseOrderIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "PurchaseOrderID", true));
            this.purchaseOrderIDLabel1.Location = new System.Drawing.Point(175, 93);
            this.purchaseOrderIDLabel1.Name = "purchaseOrderIDLabel1";
            this.purchaseOrderIDLabel1.Size = new System.Drawing.Size(73, 23);
            this.purchaseOrderIDLabel1.TabIndex = 2;
            // 
            // revisionNumberTextBox
            // 
            this.revisionNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "RevisionNumber", true));
            this.revisionNumberTextBox.Location = new System.Drawing.Point(175, 121);
            this.revisionNumberTextBox.Name = "revisionNumberTextBox";
            this.revisionNumberTextBox.Size = new System.Drawing.Size(73, 22);
            this.revisionNumberTextBox.TabIndex = 4;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(329, 117);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(73, 22);
            this.statusTextBox.TabIndex = 6;
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseOrderHeaderBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(173, 182);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(227, 22);
            this.orderDateDateTimePicker.TabIndex = 14;
            // 
            // shipDateDateTimePicker
            // 
            this.shipDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseOrderHeaderBindingSource, "ShipDate", true));
            this.shipDateDateTimePicker.Location = new System.Drawing.Point(370, 210);
            this.shipDateDateTimePicker.Name = "shipDateDateTimePicker";
            this.shipDateDateTimePicker.Size = new System.Drawing.Size(224, 22);
            this.shipDateDateTimePicker.TabIndex = 16;
            // 
            // subTotalLabel1
            // 
            this.subTotalLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subTotalLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "SubTotal", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.subTotalLabel1.Location = new System.Drawing.Point(175, 488);
            this.subTotalLabel1.Name = "subTotalLabel1";
            this.subTotalLabel1.Size = new System.Drawing.Size(73, 23);
            this.subTotalLabel1.TabIndex = 18;
            // 
            // taxAmtLabel1
            // 
            this.taxAmtLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxAmtLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "TaxAmt", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.taxAmtLabel1.Location = new System.Drawing.Point(175, 511);
            this.taxAmtLabel1.Name = "taxAmtLabel1";
            this.taxAmtLabel1.Size = new System.Drawing.Size(73, 23);
            this.taxAmtLabel1.TabIndex = 20;
            // 
            // freightTextBox
            // 
            this.freightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "Freight", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.freightTextBox.Location = new System.Drawing.Point(175, 537);
            this.freightTextBox.Name = "freightTextBox";
            this.freightTextBox.Size = new System.Drawing.Size(73, 22);
            this.freightTextBox.TabIndex = 22;
            // 
            // totalDueLabel1
            // 
            this.totalDueLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalDueLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "TotalDue", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.totalDueLabel1.Location = new System.Drawing.Point(175, 562);
            this.totalDueLabel1.Name = "totalDueLabel1";
            this.totalDueLabel1.Size = new System.Drawing.Size(73, 23);
            this.totalDueLabel1.TabIndex = 24;
            // 
            // vendorComboBox
            // 
            this.vendorComboBox.DataSource = this.vendorBindingSource;
            this.vendorComboBox.DisplayMember = "Name";
            this.vendorComboBox.FormattingEnabled = true;
            this.vendorComboBox.Location = new System.Drawing.Point(175, 62);
            this.vendorComboBox.Name = "vendorComboBox";
            this.vendorComboBox.Size = new System.Drawing.Size(227, 24);
            this.vendorComboBox.TabIndex = 25;
            this.vendorComboBox.ValueMember = "BusinessEntityID";
            this.vendorComboBox.SelectedValueChanged += new System.EventHandler(this.vendorComboBox_SelectedValueChanged);
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "Vendor";
            this.vendorBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // employeeNameComboBox
            // 
            this.employeeNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.purchaseOrderHeaderBindingSource, "EmployeeID", true));
            this.employeeNameComboBox.DataSource = this.employeeBindingSource;
            this.employeeNameComboBox.DisplayMember = "LastFirstName";
            this.employeeNameComboBox.FormattingEnabled = true;
            this.employeeNameComboBox.Location = new System.Drawing.Point(173, 149);
            this.employeeNameComboBox.Name = "employeeNameComboBox";
            this.employeeNameComboBox.Size = new System.Drawing.Size(185, 24);
            this.employeeNameComboBox.TabIndex = 26;
            this.employeeNameComboBox.ValueMember = "BusinessEntityID";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // shipMethodComboBox
            // 
            this.shipMethodComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.purchaseOrderHeaderBindingSource, "ShipMethodID", true));
            this.shipMethodComboBox.DataSource = this.shipMethodBindingSource;
            this.shipMethodComboBox.DisplayMember = "Name";
            this.shipMethodComboBox.FormattingEnabled = true;
            this.shipMethodComboBox.Location = new System.Drawing.Point(173, 210);
            this.shipMethodComboBox.Name = "shipMethodComboBox";
            this.shipMethodComboBox.Size = new System.Drawing.Size(185, 24);
            this.shipMethodComboBox.TabIndex = 27;
            this.shipMethodComboBox.ValueMember = "ShipMethodID";
            // 
            // shipMethodBindingSource
            // 
            this.shipMethodBindingSource.DataMember = "ShipMethod";
            this.shipMethodBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // purchaseOrderHeaderTableAdapter
            // 
            this.purchaseOrderHeaderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeNameTableAdapter = null;
            this.tableAdapterManager.PurchaseOrderDetailTableAdapter = null;
            this.tableAdapterManager.PurchaseOrderHeaderTableAdapter = this.purchaseOrderHeaderTableAdapter;
            this.tableAdapterManager.ShipMethodTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = jthacker2747ex1g2.AdventureWorksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorTableAdapter = null;
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // employeeNameTableAdapter
            // 
            this.employeeNameTableAdapter.ClearBeforeFill = true;
            // 
            // shipMethodTableAdapter
            // 
            this.shipMethodTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseOrderDetailBindingSource
            // 
            this.purchaseOrderDetailBindingSource.DataMember = "PurchaseOrderDetail";
            this.purchaseOrderDetailBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // purchaseOrderDetailTableAdapter
            // 
            this.purchaseOrderDetailTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseOrderDetailDataGridView
            // 
            this.purchaseOrderDetailDataGridView.AutoGenerateColumns = false;
            this.purchaseOrderDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseOrderDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.CalcLineTotal,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.purchaseOrderDetailDataGridView.DataSource = this.purchaseOrderDetailBindingSource;
            this.purchaseOrderDetailDataGridView.Location = new System.Drawing.Point(42, 241);
            this.purchaseOrderDetailDataGridView.Name = "purchaseOrderDetailDataGridView";
            this.purchaseOrderDetailDataGridView.RowTemplate.Height = 24;
            this.purchaseOrderDetailDataGridView.Size = new System.Drawing.Size(780, 186);
            this.purchaseOrderDetailDataGridView.TabIndex = 27;
            this.purchaseOrderDetailDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.purchaseOrderDetailDataGridView_UserAddedRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PurchaseOrderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PurchaseOrderID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PurchaseOrderDetailID";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn2.HeaderText = "PODetailID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DueDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "DueDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderQty";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ord";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ProdID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn6.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "LineTotal";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn7.HeaderText = "LineTotal";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // CalcLineTotal
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CalcLineTotal.DefaultCellStyle = dataGridViewCellStyle9;
            this.CalcLineTotal.HeaderText = "LineTotal";
            this.CalcLineTotal.Name = "CalcLineTotal";
            this.CalcLineTotal.Width = 75;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ReceivedQty";
            this.dataGridViewTextBoxColumn8.HeaderText = "RecQty";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "RejectedQty";
            this.dataGridViewTextBoxColumn9.HeaderText = "RejQty";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "StockedQty";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn10.HeaderText = "StockQty";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ModifiedDate";
            this.dataGridViewTextBoxColumn11.HeaderText = "ModifiedDate";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 606);
            this.Controls.Add(this.purchaseOrderDetailDataGridView);
            this.Controls.Add(this.shipMethodComboBox);
            this.Controls.Add(this.employeeNameComboBox);
            this.Controls.Add(this.vendorComboBox);
            this.Controls.Add(purchaseOrderIDLabel);
            this.Controls.Add(this.purchaseOrderIDLabel1);
            this.Controls.Add(revisionNumberLabel);
            this.Controls.Add(this.revisionNumberTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(vendorIDLabel);
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(this.orderDateDateTimePicker);
            this.Controls.Add(shipDateLabel);
            this.Controls.Add(this.shipDateDateTimePicker);
            this.Controls.Add(subTotalLabel);
            this.Controls.Add(this.subTotalLabel1);
            this.Controls.Add(taxAmtLabel);
            this.Controls.Add(this.taxAmtLabel1);
            this.Controls.Add(freightLabel);
            this.Controls.Add(this.freightTextBox);
            this.Controls.Add(totalDueLabel);
            this.Controls.Add(this.totalDueLabel1);
            this.Controls.Add(this.purchaseOrderHeaderBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderHeaderBindingNavigator)).EndInit();
            this.purchaseOrderHeaderBindingNavigator.ResumeLayout(false);
            this.purchaseOrderHeaderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderHeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMethodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDetailDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdventureWorksDataSet adventureWorksDataSet;
        private System.Windows.Forms.BindingSource purchaseOrderHeaderBindingSource;
        private AdventureWorksDataSetTableAdapters.PurchaseOrderHeaderTableAdapter purchaseOrderHeaderTableAdapter;
        private AdventureWorksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator purchaseOrderHeaderBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton purchaseOrderHeaderBindingNavigatorSaveItem;
        private System.Windows.Forms.Label purchaseOrderIDLabel1;
        private System.Windows.Forms.TextBox revisionNumberTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker shipDateDateTimePicker;
        private System.Windows.Forms.Label subTotalLabel1;
        private System.Windows.Forms.Label taxAmtLabel1;
        private System.Windows.Forms.TextBox freightTextBox;
        private System.Windows.Forms.Label totalDueLabel1;
        private System.Windows.Forms.ComboBox vendorComboBox;
        private System.Windows.Forms.ComboBox employeeNameComboBox;
        private System.Windows.Forms.ComboBox shipMethodComboBox;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private AdventureWorksDataSetTableAdapters.VendorTableAdapter vendorTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private AdventureWorksDataSetTableAdapters.EmployeeNameTableAdapter employeeNameTableAdapter;
        private System.Windows.Forms.BindingSource shipMethodBindingSource;
        private AdventureWorksDataSetTableAdapters.ShipMethodTableAdapter shipMethodTableAdapter;
        private System.Windows.Forms.BindingSource purchaseOrderDetailBindingSource;
        private AdventureWorksDataSetTableAdapters.PurchaseOrderDetailTableAdapter purchaseOrderDetailTableAdapter;
        private System.Windows.Forms.DataGridView purchaseOrderDetailDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalcLineTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}

