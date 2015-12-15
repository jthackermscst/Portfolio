namespace jthacker2747ex3a1
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
            this.purchaseOrderDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.purchaseOrderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shipMethodComboBox = new System.Windows.Forms.ComboBox();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.vendorComboBox = new System.Windows.Forms.ComboBox();
            this.purchaseOrderIDLabel1 = new System.Windows.Forms.Label();
            this.purchaseOrderHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.revisionNumberTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shipDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.subTotalLabel1 = new System.Windows.Forms.Label();
            this.taxAmtLabel1 = new System.Windows.Forms.Label();
            this.freightTextBox = new System.Windows.Forms.TextBox();
            this.totalDueLabel1 = new System.Windows.Forms.Label();
            this.purchaseOrderHeaderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.purchaseOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDetailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderHeaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderHeaderBindingNavigator)).BeginInit();
            this.purchaseOrderHeaderBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // purchaseOrderIDLabel
            // 
            purchaseOrderIDLabel.AutoSize = true;
            purchaseOrderIDLabel.Location = new System.Drawing.Point(12, 99);
            purchaseOrderIDLabel.Name = "purchaseOrderIDLabel";
            purchaseOrderIDLabel.Size = new System.Drawing.Size(130, 17);
            purchaseOrderIDLabel.TabIndex = 30;
            purchaseOrderIDLabel.Text = "Purchase Order ID:";
            // 
            // revisionNumberLabel
            // 
            revisionNumberLabel.AutoSize = true;
            revisionNumberLabel.Location = new System.Drawing.Point(12, 125);
            revisionNumberLabel.Name = "revisionNumberLabel";
            revisionNumberLabel.Size = new System.Drawing.Size(120, 17);
            revisionNumberLabel.TabIndex = 32;
            revisionNumberLabel.Text = "Revision Number:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(12, 153);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(52, 17);
            statusLabel.TabIndex = 34;
            statusLabel.Text = "Status:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(12, 181);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(91, 17);
            employeeIDLabel.TabIndex = 36;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // vendorIDLabel
            // 
            vendorIDLabel.AutoSize = true;
            vendorIDLabel.Location = new System.Drawing.Point(12, 68);
            vendorIDLabel.Name = "vendorIDLabel";
            vendorIDLabel.Size = new System.Drawing.Size(58, 17);
            vendorIDLabel.TabIndex = 38;
            vendorIDLabel.Text = "Vendor:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(12, 212);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(83, 17);
            orderDateLabel.TabIndex = 40;
            orderDateLabel.Text = "Order Date:";
            // 
            // shipDateLabel
            // 
            shipDateLabel.AutoSize = true;
            shipDateLabel.Location = new System.Drawing.Point(12, 240);
            shipDateLabel.Name = "shipDateLabel";
            shipDateLabel.Size = new System.Drawing.Size(74, 17);
            shipDateLabel.TabIndex = 42;
            shipDateLabel.Text = "Ship Date:";
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Location = new System.Drawing.Point(12, 456);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new System.Drawing.Size(73, 17);
            subTotalLabel.TabIndex = 44;
            subTotalLabel.Text = "Sub Total:";
            // 
            // taxAmtLabel
            // 
            taxAmtLabel.AutoSize = true;
            taxAmtLabel.Location = new System.Drawing.Point(12, 488);
            taxAmtLabel.Name = "taxAmtLabel";
            taxAmtLabel.Size = new System.Drawing.Size(63, 17);
            taxAmtLabel.TabIndex = 46;
            taxAmtLabel.Text = "Tax Amt:";
            // 
            // freightLabel
            // 
            freightLabel.AutoSize = true;
            freightLabel.Location = new System.Drawing.Point(12, 517);
            freightLabel.Name = "freightLabel";
            freightLabel.Size = new System.Drawing.Size(56, 17);
            freightLabel.TabIndex = 48;
            freightLabel.Text = "Freight:";
            // 
            // totalDueLabel
            // 
            totalDueLabel.AutoSize = true;
            totalDueLabel.Location = new System.Drawing.Point(12, 539);
            totalDueLabel.Name = "totalDueLabel";
            totalDueLabel.Size = new System.Drawing.Size(74, 17);
            totalDueLabel.TabIndex = 50;
            totalDueLabel.Text = "Total Due:";
            // 
            // purchaseOrderDetailDataGridView
            // 
            this.purchaseOrderDetailDataGridView.AutoGenerateColumns = false;
            this.purchaseOrderDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseOrderDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchaseOrderIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.modifiedDateDataGridViewTextBoxColumn,
            this.Total});
            this.purchaseOrderDetailDataGridView.DataSource = this.purchaseOrderDetailBindingSource;
            this.purchaseOrderDetailDataGridView.Location = new System.Drawing.Point(18, 283);
            this.purchaseOrderDetailDataGridView.Name = "purchaseOrderDetailDataGridView";
            this.purchaseOrderDetailDataGridView.RowTemplate.Height = 24;
            this.purchaseOrderDetailDataGridView.Size = new System.Drawing.Size(679, 143);
            this.purchaseOrderDetailDataGridView.TabIndex = 55;
            // 
            // purchaseOrderDetailBindingSource
            // 
            this.purchaseOrderDetailBindingSource.DataSource = typeof(jthacker2747ex3a1ef.Model.PurchaseOrderDetail);
            this.purchaseOrderDetailBindingSource.CurrentChanged += new System.EventHandler(this.purchaseOrderDetailBindingSource_CurrentChanged);
            // 
            // shipMethodComboBox
            // 
            this.shipMethodComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.purchaseOrderHeaderBindingSource, "PurchaseOrderID", true));
            this.shipMethodComboBox.DisplayMember = "Name";
            this.shipMethodComboBox.FormattingEnabled = true;
            this.shipMethodComboBox.Location = new System.Drawing.Point(148, 235);
            this.shipMethodComboBox.Name = "shipMethodComboBox";
            this.shipMethodComboBox.Size = new System.Drawing.Size(168, 24);
            this.shipMethodComboBox.TabIndex = 54;
            this.shipMethodComboBox.ValueMember = "ShipMethodID";
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.purchaseOrderHeaderBindingSource, "PurchaseOrderID", true));
            this.employeeComboBox.DisplayMember = "LastFirstName";
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(148, 178);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(168, 24);
            this.employeeComboBox.TabIndex = 53;
            this.employeeComboBox.ValueMember = "BusinessEntityID";
            // 
            // vendorComboBox
            // 
            this.vendorComboBox.DisplayMember = "Name";
            this.vendorComboBox.FormattingEnabled = true;
            this.vendorComboBox.Location = new System.Drawing.Point(148, 68);
            this.vendorComboBox.Name = "vendorComboBox";
            this.vendorComboBox.Size = new System.Drawing.Size(241, 24);
            this.vendorComboBox.TabIndex = 52;
            this.vendorComboBox.ValueMember = "BusinessEntityID";
            this.vendorComboBox.SelectedIndexChanged += new System.EventHandler(this.vendorComboBox_SelectedIndexChanged);
            // 
            // purchaseOrderIDLabel1
            // 
            this.purchaseOrderIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purchaseOrderIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "PurchaseOrderID", true));
            this.purchaseOrderIDLabel1.Location = new System.Drawing.Point(147, 95);
            this.purchaseOrderIDLabel1.Name = "purchaseOrderIDLabel1";
            this.purchaseOrderIDLabel1.Size = new System.Drawing.Size(79, 23);
            this.purchaseOrderIDLabel1.TabIndex = 31;
            // 
            // purchaseOrderHeaderBindingSource
            // 
            this.purchaseOrderHeaderBindingSource.DataSource = typeof(jthacker2747ex3a1ef.Model.PurchaseOrderHeader);
            this.purchaseOrderHeaderBindingSource.CurrentChanged += new System.EventHandler(this.purchaseOrderHeaderBindingSource_CurrentChanged);
            // 
            // revisionNumberTextBox
            // 
            this.revisionNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "RevisionNumber", true));
            this.revisionNumberTextBox.Location = new System.Drawing.Point(148, 122);
            this.revisionNumberTextBox.Name = "revisionNumberTextBox";
            this.revisionNumberTextBox.Size = new System.Drawing.Size(78, 22);
            this.revisionNumberTextBox.TabIndex = 33;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(148, 150);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(78, 22);
            this.statusTextBox.TabIndex = 35;
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseOrderHeaderBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(148, 208);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(241, 22);
            this.orderDateDateTimePicker.TabIndex = 41;
            // 
            // shipDateDateTimePicker
            // 
            this.shipDateDateTimePicker.Location = new System.Drawing.Point(405, 235);
            this.shipDateDateTimePicker.Name = "shipDateDateTimePicker";
            this.shipDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.shipDateDateTimePicker.TabIndex = 43;
            // 
            // subTotalLabel1
            // 
            this.subTotalLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subTotalLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "SubTotal", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.subTotalLabel1.Location = new System.Drawing.Point(148, 456);
            this.subTotalLabel1.Name = "subTotalLabel1";
            this.subTotalLabel1.Size = new System.Drawing.Size(78, 23);
            this.subTotalLabel1.TabIndex = 45;
            // 
            // taxAmtLabel1
            // 
            this.taxAmtLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxAmtLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "TaxAmt", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.taxAmtLabel1.Location = new System.Drawing.Point(148, 488);
            this.taxAmtLabel1.Name = "taxAmtLabel1";
            this.taxAmtLabel1.Size = new System.Drawing.Size(78, 23);
            this.taxAmtLabel1.TabIndex = 47;
            // 
            // freightTextBox
            // 
            this.freightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "Freight", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.freightTextBox.Location = new System.Drawing.Point(148, 514);
            this.freightTextBox.Name = "freightTextBox";
            this.freightTextBox.Size = new System.Drawing.Size(78, 22);
            this.freightTextBox.TabIndex = 49;
            // 
            // totalDueLabel1
            // 
            this.totalDueLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalDueLabel1.Location = new System.Drawing.Point(148, 539);
            this.totalDueLabel1.Name = "totalDueLabel1";
            this.totalDueLabel1.Size = new System.Drawing.Size(78, 23);
            this.totalDueLabel1.TabIndex = 51;
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
            this.purchaseOrderHeaderBindingNavigator.Size = new System.Drawing.Size(697, 27);
            this.purchaseOrderHeaderBindingNavigator.TabIndex = 56;
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
            this.purchaseOrderHeaderBindingNavigatorSaveItem.Enabled = false;
            this.purchaseOrderHeaderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("purchaseOrderHeaderBindingNavigatorSaveItem.Image")));
            this.purchaseOrderHeaderBindingNavigatorSaveItem.Name = "purchaseOrderHeaderBindingNavigatorSaveItem";
            this.purchaseOrderHeaderBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.purchaseOrderHeaderBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // purchaseOrderIDDataGridViewTextBoxColumn
            // 
            this.purchaseOrderIDDataGridViewTextBoxColumn.DataPropertyName = "PurchaseOrderID";
            this.purchaseOrderIDDataGridViewTextBoxColumn.HeaderText = "PurchaseOrderID";
            this.purchaseOrderIDDataGridViewTextBoxColumn.Name = "purchaseOrderIDDataGridViewTextBoxColumn";
            this.purchaseOrderIDDataGridViewTextBoxColumn.Visible = false;
            this.purchaseOrderIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProdID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OrderQty";
            this.dataGridViewTextBoxColumn2.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DueDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Due";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ReceivedQty";
            this.dataGridViewTextBoxColumn5.HeaderText = "Rec";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RejectedQty";
            this.dataGridViewTextBoxColumn6.HeaderText = "Reject";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // modifiedDateDataGridViewTextBoxColumn
            // 
            this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.HeaderText = "Modified";
            this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "LineTotal";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 725);
            this.Controls.Add(this.purchaseOrderHeaderBindingNavigator);
            this.Controls.Add(this.purchaseOrderDetailDataGridView);
            this.Controls.Add(this.shipMethodComboBox);
            this.Controls.Add(this.employeeComboBox);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDetailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderHeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderHeaderBindingNavigator)).EndInit();
            this.purchaseOrderHeaderBindingNavigator.ResumeLayout(false);
            this.purchaseOrderHeaderBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView purchaseOrderDetailDataGridView;
        private System.Windows.Forms.ComboBox shipMethodComboBox;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.ComboBox vendorComboBox;
        private System.Windows.Forms.Label purchaseOrderIDLabel1;
        private System.Windows.Forms.TextBox revisionNumberTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker shipDateDateTimePicker;
        private System.Windows.Forms.Label subTotalLabel1;
        private System.Windows.Forms.Label taxAmtLabel1;
        private System.Windows.Forms.TextBox freightTextBox;
        private System.Windows.Forms.Label totalDueLabel1;
        private System.Windows.Forms.BindingSource purchaseOrderHeaderBindingSource;
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
        private System.Windows.Forms.BindingSource purchaseOrderDetailBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}

