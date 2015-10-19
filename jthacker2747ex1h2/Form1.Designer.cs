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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.vendorCountLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loadAllVendorsButton = new System.Windows.Forms.Button();
            this.filterVendorsByNameButton = new System.Windows.Forms.Button();
            this.filterVendorsByCityButton = new System.Windows.Forms.Button();
            this.filterVendorByStateButton = new System.Windows.Forms.Button();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ordersCountLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.startDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.revNumberLabel = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new jthacker2747ex1g2.AdventureWorksDataSetTableAdapters.ProductTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // purchaseOrderIDLabel
            // 
            purchaseOrderIDLabel.AutoSize = true;
            purchaseOrderIDLabel.Location = new System.Drawing.Point(47, 187);
            purchaseOrderIDLabel.Name = "purchaseOrderIDLabel";
            purchaseOrderIDLabel.Size = new System.Drawing.Size(130, 17);
            purchaseOrderIDLabel.TabIndex = 1;
            purchaseOrderIDLabel.Text = "Purchase Order ID:";
            // 
            // revisionNumberLabel
            // 
            revisionNumberLabel.AutoSize = true;
            revisionNumberLabel.Location = new System.Drawing.Point(47, 218);
            revisionNumberLabel.Name = "revisionNumberLabel";
            revisionNumberLabel.Size = new System.Drawing.Size(120, 17);
            revisionNumberLabel.TabIndex = 3;
            revisionNumberLabel.Text = "Revision Number:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(264, 216);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(52, 17);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Status:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(45, 246);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(115, 17);
            employeeIDLabel.TabIndex = 7;
            employeeIDLabel.Text = "Employee Name:";
            // 
            // vendorIDLabel
            // 
            vendorIDLabel.AutoSize = true;
            vendorIDLabel.Location = new System.Drawing.Point(18, 69);
            vendorIDLabel.Name = "vendorIDLabel";
            vendorIDLabel.Size = new System.Drawing.Size(58, 17);
            vendorIDLabel.TabIndex = 9;
            vendorIDLabel.Text = "Vendor:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(45, 369);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(83, 17);
            orderDateLabel.TabIndex = 13;
            orderDateLabel.Text = "Order Date:";
            // 
            // shipDateLabel
            // 
            shipDateLabel.AutoSize = true;
            shipDateLabel.Location = new System.Drawing.Point(45, 397);
            shipDateLabel.Name = "shipDateLabel";
            shipDateLabel.Size = new System.Drawing.Size(74, 17);
            shipDateLabel.TabIndex = 15;
            shipDateLabel.Text = "Ship Date:";
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Location = new System.Drawing.Point(47, 628);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new System.Drawing.Size(73, 17);
            subTotalLabel.TabIndex = 17;
            subTotalLabel.Text = "Sub Total:";
            // 
            // taxAmtLabel
            // 
            taxAmtLabel.AutoSize = true;
            taxAmtLabel.Location = new System.Drawing.Point(47, 653);
            taxAmtLabel.Name = "taxAmtLabel";
            taxAmtLabel.Size = new System.Drawing.Size(63, 17);
            taxAmtLabel.TabIndex = 19;
            taxAmtLabel.Text = "Tax Amt:";
            // 
            // freightLabel
            // 
            freightLabel.AutoSize = true;
            freightLabel.Location = new System.Drawing.Point(47, 678);
            freightLabel.Name = "freightLabel";
            freightLabel.Size = new System.Drawing.Size(56, 17);
            freightLabel.TabIndex = 21;
            freightLabel.Text = "Freight:";
            // 
            // totalDueLabel
            // 
            totalDueLabel.AutoSize = true;
            totalDueLabel.Location = new System.Drawing.Point(47, 703);
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
            this.purchaseOrderHeaderBindingNavigator.Size = new System.Drawing.Size(970, 27);
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
            this.purchaseOrderIDLabel1.Location = new System.Drawing.Point(183, 187);
            this.purchaseOrderIDLabel1.Name = "purchaseOrderIDLabel1";
            this.purchaseOrderIDLabel1.Size = new System.Drawing.Size(73, 23);
            this.purchaseOrderIDLabel1.TabIndex = 2;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(337, 211);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(73, 22);
            this.statusTextBox.TabIndex = 6;
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseOrderHeaderBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(181, 365);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(227, 22);
            this.orderDateDateTimePicker.TabIndex = 14;
            // 
            // shipDateDateTimePicker
            // 
            this.shipDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseOrderHeaderBindingSource, "ShipDate", true));
            this.shipDateDateTimePicker.Location = new System.Drawing.Point(441, 391);
            this.shipDateDateTimePicker.Name = "shipDateDateTimePicker";
            this.shipDateDateTimePicker.Size = new System.Drawing.Size(224, 22);
            this.shipDateDateTimePicker.TabIndex = 16;
            // 
            // subTotalLabel1
            // 
            this.subTotalLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subTotalLabel1.Location = new System.Drawing.Point(183, 622);
            this.subTotalLabel1.Name = "subTotalLabel1";
            this.subTotalLabel1.Size = new System.Drawing.Size(73, 23);
            this.subTotalLabel1.TabIndex = 18;
            // 
            // taxAmtLabel1
            // 
            this.taxAmtLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxAmtLabel1.Location = new System.Drawing.Point(183, 651);
            this.taxAmtLabel1.Name = "taxAmtLabel1";
            this.taxAmtLabel1.Size = new System.Drawing.Size(73, 23);
            this.taxAmtLabel1.TabIndex = 20;
            // 
            // freightTextBox
            // 
            this.freightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "Freight", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.freightTextBox.Location = new System.Drawing.Point(183, 677);
            this.freightTextBox.Name = "freightTextBox";
            this.freightTextBox.Size = new System.Drawing.Size(73, 22);
            this.freightTextBox.TabIndex = 22;
            // 
            // totalDueLabel1
            // 
            this.totalDueLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalDueLabel1.Location = new System.Drawing.Point(183, 702);
            this.totalDueLabel1.Name = "totalDueLabel1";
            this.totalDueLabel1.Size = new System.Drawing.Size(73, 23);
            this.totalDueLabel1.TabIndex = 24;
            // 
            // vendorComboBox
            // 
            this.vendorComboBox.DataSource = this.vendorBindingSource;
            this.vendorComboBox.DisplayMember = "Name";
            this.vendorComboBox.FormattingEnabled = true;
            this.vendorComboBox.Location = new System.Drawing.Point(131, 66);
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
            this.employeeNameComboBox.Location = new System.Drawing.Point(181, 243);
            this.employeeNameComboBox.Name = "employeeNameComboBox";
            this.employeeNameComboBox.Size = new System.Drawing.Size(227, 24);
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
            this.shipMethodComboBox.Location = new System.Drawing.Point(181, 393);
            this.shipMethodComboBox.Name = "shipMethodComboBox";
            this.shipMethodComboBox.Size = new System.Drawing.Size(227, 24);
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
            this.Product,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.CalcLineTotal,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.purchaseOrderDetailDataGridView.DataSource = this.purchaseOrderDetailBindingSource;
            this.purchaseOrderDetailDataGridView.Location = new System.Drawing.Point(50, 424);
            this.purchaseOrderDetailDataGridView.Name = "purchaseOrderDetailDataGridView";
            this.purchaseOrderDetailDataGridView.RowTemplate.Height = 24;
            this.purchaseOrderDetailDataGridView.Size = new System.Drawing.Size(874, 186);
            this.purchaseOrderDetailDataGridView.TabIndex = 27;
            this.purchaseOrderDetailDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.purchaseOrderDetailDataGridView_UserAddedRow);
            // 
            // vendorCountLabel
            // 
            this.vendorCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vendorCountLabel.Location = new System.Drawing.Point(389, 69);
            this.vendorCountLabel.Name = "vendorCountLabel";
            this.vendorCountLabel.Size = new System.Drawing.Size(199, 23);
            this.vendorCountLabel.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loadAllVendorsButton);
            this.groupBox1.Controls.Add(this.filterVendorsByNameButton);
            this.groupBox1.Controls.Add(this.filterVendorsByCityButton);
            this.groupBox1.Controls.Add(this.filterVendorByStateButton);
            this.groupBox1.Controls.Add(this.filterTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.vendorCountLabel);
            this.groupBox1.Controls.Add(vendorIDLabel);
            this.groupBox1.Controls.Add(this.vendorComboBox);
            this.groupBox1.Location = new System.Drawing.Point(29, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 116);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendors";
            // 
            // loadAllVendorsButton
            // 
            this.loadAllVendorsButton.Location = new System.Drawing.Point(512, 14);
            this.loadAllVendorsButton.Name = "loadAllVendorsButton";
            this.loadAllVendorsButton.Size = new System.Drawing.Size(75, 39);
            this.loadAllVendorsButton.TabIndex = 34;
            this.loadAllVendorsButton.Text = "LoadAll";
            this.loadAllVendorsButton.UseVisualStyleBackColor = true;
            this.loadAllVendorsButton.Click += new System.EventHandler(this.loadAllVendorsButton_Click);
            // 
            // filterVendorsByNameButton
            // 
            this.filterVendorsByNameButton.Location = new System.Drawing.Point(430, 14);
            this.filterVendorsByNameButton.Name = "filterVendorsByNameButton";
            this.filterVendorsByNameButton.Size = new System.Drawing.Size(75, 39);
            this.filterVendorsByNameButton.TabIndex = 33;
            this.filterVendorsByNameButton.Text = "Name";
            this.filterVendorsByNameButton.UseVisualStyleBackColor = true;
            this.filterVendorsByNameButton.Click += new System.EventHandler(this.filterVendorsByNameButton_Click);
            // 
            // filterVendorsByCityButton
            // 
            this.filterVendorsByCityButton.Location = new System.Drawing.Point(348, 14);
            this.filterVendorsByCityButton.Name = "filterVendorsByCityButton";
            this.filterVendorsByCityButton.Size = new System.Drawing.Size(75, 39);
            this.filterVendorsByCityButton.TabIndex = 32;
            this.filterVendorsByCityButton.Text = "City";
            this.filterVendorsByCityButton.UseVisualStyleBackColor = true;
            this.filterVendorsByCityButton.Click += new System.EventHandler(this.filterVendorsByCityButton_Click);
            // 
            // filterVendorByStateButton
            // 
            this.filterVendorByStateButton.Location = new System.Drawing.Point(266, 14);
            this.filterVendorByStateButton.Name = "filterVendorByStateButton";
            this.filterVendorByStateButton.Size = new System.Drawing.Size(75, 39);
            this.filterVendorByStateButton.TabIndex = 31;
            this.filterVendorByStateButton.Text = "State";
            this.filterVendorByStateButton.UseVisualStyleBackColor = true;
            this.filterVendorByStateButton.Click += new System.EventHandler(this.filterVendorByStateButton_Click);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(131, 22);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(129, 22);
            this.filterTextBox.TabIndex = 30;
            this.filterTextBox.Text = "Bur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Filter:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ordersCountLabel);
            this.groupBox2.Controls.Add(this.endDateTimePicker1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.startDateTimePicker1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(29, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 86);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Orders By Date";
            // 
            // ordersCountLabel
            // 
            this.ordersCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ordersCountLabel.Location = new System.Drawing.Point(514, 28);
            this.ordersCountLabel.Name = "ordersCountLabel";
            this.ordersCountLabel.Size = new System.Drawing.Size(209, 23);
            this.ordersCountLabel.TabIndex = 4;
            // 
            // endDateTimePicker1
            // 
            this.endDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker1.Location = new System.Drawing.Point(308, 29);
            this.endDateTimePicker1.Name = "endDateTimePicker1";
            this.endDateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.endDateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last date:";
            // 
            // startDateTimePicker1
            // 
            this.startDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker1.Location = new System.Drawing.Point(84, 29);
            this.startDateTimePicker1.Name = "startDateTimePicker1";
            this.startDateTimePicker1.Size = new System.Drawing.Size(143, 22);
            this.startDateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "First date:";
            // 
            // revNumberLabel
            // 
            this.revNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revNumberLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "RevisionNumber", true));
            this.revNumberLabel.Location = new System.Drawing.Point(183, 216);
            this.revNumberLabel.Name = "revNumberLabel";
            this.revNumberLabel.Size = new System.Drawing.Size(73, 23);
            this.revNumberLabel.TabIndex = 31;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
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
            // Product
            // 
            this.Product.DataPropertyName = "ProductID";
            this.Product.DataSource = this.productBindingSource;
            this.Product.DisplayMember = "SubcatProductName";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ValueMember = "ProductID";
            this.Product.Width = 175;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn6.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "LineTotal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn7.HeaderText = "LineTotal";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // CalcLineTotal
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CalcLineTotal.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle5;
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
            this.ClientSize = new System.Drawing.Size(970, 745);
            this.Controls.Add(this.revNumberLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.purchaseOrderDetailDataGridView);
            this.Controls.Add(this.shipMethodComboBox);
            this.Controls.Add(this.employeeNameComboBox);
            this.Controls.Add(purchaseOrderIDLabel);
            this.Controls.Add(this.purchaseOrderIDLabel1);
            this.Controls.Add(revisionNumberLabel);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(employeeIDLabel);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
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
        private System.Windows.Forms.Label vendorCountLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button loadAllVendorsButton;
        private System.Windows.Forms.Button filterVendorsByNameButton;
        private System.Windows.Forms.Button filterVendorsByCityButton;
        private System.Windows.Forms.Button filterVendorByStateButton;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ordersCountLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker startDateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label revNumberLabel;
        private System.Windows.Forms.BindingSource productBindingSource;
        private AdventureWorksDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalcLineTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}

