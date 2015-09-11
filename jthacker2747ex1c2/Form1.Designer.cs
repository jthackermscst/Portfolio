namespace jthacker2747ex1c2
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
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label productNumberLabel;
            System.Windows.Forms.Label reorderPointLabel;
            System.Windows.Forms.Label listPriceLabel;
            System.Windows.Forms.Label weightUnitMeasureCodeLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label productSubcategoryIDLabel;
            System.Windows.Forms.Label sellStartDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label lowestListPriceLabel;
            System.Windows.Forms.Label listPriceChangeLabel;
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productIdBoundLabel = new System.Windows.Forms.Label();
            this.productNumberBoundLabel = new System.Windows.Forms.Label();
            this.productNameBoundLabel = new System.Windows.Forms.Label();
            this.sellStartDateBoundLabel = new System.Windows.Forms.Label();
            this.productSubcategoryIdBoundLabel = new System.Windows.Forms.Label();
            this.weightBoundLabel = new System.Windows.Forms.Label();
            this.weightUnitMeasureCodeBoundLabel = new System.Windows.Forms.Label();
            this.listPriceBoundLabel = new System.Windows.Forms.Label();
            this.reorderPointBoundLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productIdBoundLabel2 = new System.Windows.Forms.Label();
            this.sellStartDateBoundLabel2 = new System.Windows.Forms.Label();
            this.productNumberBoundLabel2 = new System.Windows.Forms.Label();
            this.productSubcategoryNameLabel = new System.Windows.Forms.Label();
            this.productCategoryIdLabel = new System.Windows.Forms.Label();
            this.productCategoryNameLabel = new System.Windows.Forms.Label();
            this.productUnitMeasureNameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorks2014_DataDataSet = new jthacker2747ex1c2.AdventureWorks2014_DataDataSet();
            this.productSubcategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new jthacker2747ex1c2.AdventureWorks2014_DataDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new jthacker2747ex1c2.AdventureWorks2014_DataDataSetTableAdapters.TableAdapterManager();
            this.productSubcategoryTableAdapter = new jthacker2747ex1c2.AdventureWorks2014_DataDataSetTableAdapters.ProductSubcategoryTableAdapter();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productCategoryTableAdapter = new jthacker2747ex1c2.AdventureWorks2014_DataDataSetTableAdapters.ProductCategoryTableAdapter();
            this.unitMeasureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitMeasureTableAdapter = new jthacker2747ex1c2.AdventureWorks2014_DataDataSetTableAdapters.UnitMeasureTableAdapter();
            this.lowestListPriceLabel1 = new System.Windows.Forms.Label();
            this.listPriceChangeLabel1 = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            productNumberLabel = new System.Windows.Forms.Label();
            reorderPointLabel = new System.Windows.Forms.Label();
            listPriceLabel = new System.Windows.Forms.Label();
            weightUnitMeasureCodeLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            productSubcategoryIDLabel = new System.Windows.Forms.Label();
            sellStartDateLabel = new System.Windows.Forms.Label();
            lowestListPriceLabel = new System.Windows.Forms.Label();
            listPriceChangeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2014_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSubcategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitMeasureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(23, 33);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(78, 17);
            productIDLabel.TabIndex = 1;
            productIDLabel.Text = "Product ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(23, 61);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // productNumberLabel
            // 
            productNumberLabel.AutoSize = true;
            productNumberLabel.Location = new System.Drawing.Point(23, 89);
            productNumberLabel.Name = "productNumberLabel";
            productNumberLabel.Size = new System.Drawing.Size(115, 17);
            productNumberLabel.TabIndex = 5;
            productNumberLabel.Text = "Product Number:";
            // 
            // reorderPointLabel
            // 
            reorderPointLabel.AutoSize = true;
            reorderPointLabel.Location = new System.Drawing.Point(23, 117);
            reorderPointLabel.Name = "reorderPointLabel";
            reorderPointLabel.Size = new System.Drawing.Size(100, 17);
            reorderPointLabel.TabIndex = 7;
            reorderPointLabel.Text = "Reorder Point:";
            // 
            // listPriceLabel
            // 
            listPriceLabel.AutoSize = true;
            listPriceLabel.Location = new System.Drawing.Point(23, 145);
            listPriceLabel.Name = "listPriceLabel";
            listPriceLabel.Size = new System.Drawing.Size(70, 17);
            listPriceLabel.TabIndex = 9;
            listPriceLabel.Text = "List Price:";
            // 
            // weightUnitMeasureCodeLabel
            // 
            weightUnitMeasureCodeLabel.AutoSize = true;
            weightUnitMeasureCodeLabel.Location = new System.Drawing.Point(23, 173);
            weightUnitMeasureCodeLabel.Name = "weightUnitMeasureCodeLabel";
            weightUnitMeasureCodeLabel.Size = new System.Drawing.Size(181, 17);
            weightUnitMeasureCodeLabel.TabIndex = 11;
            weightUnitMeasureCodeLabel.Text = "Weight Unit Measure Code:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(23, 201);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(56, 17);
            weightLabel.TabIndex = 13;
            weightLabel.Text = "Weight:";
            // 
            // productSubcategoryIDLabel
            // 
            productSubcategoryIDLabel.AutoSize = true;
            productSubcategoryIDLabel.Location = new System.Drawing.Point(23, 229);
            productSubcategoryIDLabel.Name = "productSubcategoryIDLabel";
            productSubcategoryIDLabel.Size = new System.Drawing.Size(162, 17);
            productSubcategoryIDLabel.TabIndex = 15;
            productSubcategoryIDLabel.Text = "Product Subcategory ID:";
            // 
            // sellStartDateLabel
            // 
            sellStartDateLabel.AutoSize = true;
            sellStartDateLabel.Location = new System.Drawing.Point(23, 258);
            sellStartDateLabel.Name = "sellStartDateLabel";
            sellStartDateLabel.Size = new System.Drawing.Size(103, 17);
            sellStartDateLabel.TabIndex = 17;
            sellStartDateLabel.Text = "Sell Start Date:";
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productBindingNavigatorSaveItem});
            this.productBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(662, 27);
            this.productBindingNavigator.TabIndex = 0;
            this.productBindingNavigator.Text = "bindingNavigator1";
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
            // productBindingNavigatorSaveItem
            // 
            this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
            this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
            this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.productBindingNavigatorSaveItem.Text = "Save Data";
            this.productBindingNavigatorSaveItem.Click += new System.EventHandler(this.productBindingNavigatorSaveItem_Click);
            // 
            // productIdBoundLabel
            // 
            this.productIdBoundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productIdBoundLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductID", true));
            this.productIdBoundLabel.Location = new System.Drawing.Point(238, 30);
            this.productIdBoundLabel.Name = "productIdBoundLabel";
            this.productIdBoundLabel.Size = new System.Drawing.Size(84, 20);
            this.productIdBoundLabel.TabIndex = 20;
            this.productIdBoundLabel.Text = "label1";
            this.productIdBoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productNumberBoundLabel
            // 
            this.productNumberBoundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productNumberBoundLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductNumber", true));
            this.productNumberBoundLabel.Location = new System.Drawing.Point(238, 84);
            this.productNumberBoundLabel.Name = "productNumberBoundLabel";
            this.productNumberBoundLabel.Size = new System.Drawing.Size(128, 22);
            this.productNumberBoundLabel.TabIndex = 23;
            this.productNumberBoundLabel.Text = "label3";
            this.productNumberBoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productNameBoundLabel
            // 
            this.productNameBoundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productNameBoundLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Name", true));
            this.productNameBoundLabel.Location = new System.Drawing.Point(238, 58);
            this.productNameBoundLabel.Name = "productNameBoundLabel";
            this.productNameBoundLabel.Size = new System.Drawing.Size(180, 20);
            this.productNameBoundLabel.TabIndex = 22;
            this.productNameBoundLabel.Text = "label2";
            this.productNameBoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sellStartDateBoundLabel
            // 
            this.sellStartDateBoundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sellStartDateBoundLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "SellStartDate", true));
            this.sellStartDateBoundLabel.Location = new System.Drawing.Point(238, 254);
            this.sellStartDateBoundLabel.Name = "sellStartDateBoundLabel";
            this.sellStartDateBoundLabel.Size = new System.Drawing.Size(108, 21);
            this.sellStartDateBoundLabel.TabIndex = 33;
            this.sellStartDateBoundLabel.Text = "label9";
            this.sellStartDateBoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productSubcategoryIdBoundLabel
            // 
            this.productSubcategoryIdBoundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productSubcategoryIdBoundLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductSubcategoryID", true));
            this.productSubcategoryIdBoundLabel.Location = new System.Drawing.Point(238, 226);
            this.productSubcategoryIdBoundLabel.Name = "productSubcategoryIdBoundLabel";
            this.productSubcategoryIdBoundLabel.Size = new System.Drawing.Size(74, 20);
            this.productSubcategoryIdBoundLabel.TabIndex = 32;
            this.productSubcategoryIdBoundLabel.Text = "label8";
            this.productSubcategoryIdBoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // weightBoundLabel
            // 
            this.weightBoundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightBoundLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Weight", true));
            this.weightBoundLabel.Location = new System.Drawing.Point(238, 198);
            this.weightBoundLabel.Name = "weightBoundLabel";
            this.weightBoundLabel.Size = new System.Drawing.Size(84, 20);
            this.weightBoundLabel.TabIndex = 31;
            this.weightBoundLabel.Text = "label7";
            this.weightBoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // weightUnitMeasureCodeBoundLabel
            // 
            this.weightUnitMeasureCodeBoundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightUnitMeasureCodeBoundLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "WeightUnitMeasureCode", true));
            this.weightUnitMeasureCodeBoundLabel.Location = new System.Drawing.Point(238, 170);
            this.weightUnitMeasureCodeBoundLabel.Name = "weightUnitMeasureCodeBoundLabel";
            this.weightUnitMeasureCodeBoundLabel.Size = new System.Drawing.Size(74, 20);
            this.weightUnitMeasureCodeBoundLabel.TabIndex = 30;
            this.weightUnitMeasureCodeBoundLabel.Text = "label6";
            this.weightUnitMeasureCodeBoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listPriceBoundLabel
            // 
            this.listPriceBoundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPriceBoundLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ListPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.listPriceBoundLabel.Location = new System.Drawing.Point(238, 142);
            this.listPriceBoundLabel.Name = "listPriceBoundLabel";
            this.listPriceBoundLabel.Size = new System.Drawing.Size(94, 22);
            this.listPriceBoundLabel.TabIndex = 29;
            this.listPriceBoundLabel.Text = "label5";
            this.listPriceBoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // reorderPointBoundLabel
            // 
            this.reorderPointBoundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reorderPointBoundLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ReorderPoint", true));
            this.reorderPointBoundLabel.Location = new System.Drawing.Point(238, 114);
            this.reorderPointBoundLabel.Name = "reorderPointBoundLabel";
            this.reorderPointBoundLabel.Size = new System.Drawing.Size(74, 20);
            this.reorderPointBoundLabel.TabIndex = 28;
            this.reorderPointBoundLabel.Text = "label4";
            this.reorderPointBoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ListPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.label1.Location = new System.Drawing.Point(388, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "label5";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productIdBoundLabel2
            // 
            this.productIdBoundLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productIdBoundLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductID", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "00000"));
            this.productIdBoundLabel2.Location = new System.Drawing.Point(388, 30);
            this.productIdBoundLabel2.Name = "productIdBoundLabel2";
            this.productIdBoundLabel2.Size = new System.Drawing.Size(84, 20);
            this.productIdBoundLabel2.TabIndex = 35;
            this.productIdBoundLabel2.Text = "label1";
            this.productIdBoundLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sellStartDateBoundLabel2
            // 
            this.sellStartDateBoundLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sellStartDateBoundLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "SellStartDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "D"));
            this.sellStartDateBoundLabel2.Location = new System.Drawing.Point(388, 254);
            this.sellStartDateBoundLabel2.Name = "sellStartDateBoundLabel2";
            this.sellStartDateBoundLabel2.Size = new System.Drawing.Size(178, 21);
            this.sellStartDateBoundLabel2.TabIndex = 36;
            this.sellStartDateBoundLabel2.Text = "label9";
            this.sellStartDateBoundLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productNumberBoundLabel2
            // 
            this.productNumberBoundLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productNumberBoundLabel2.Location = new System.Drawing.Point(388, 84);
            this.productNumberBoundLabel2.Name = "productNumberBoundLabel2";
            this.productNumberBoundLabel2.Size = new System.Drawing.Size(128, 22);
            this.productNumberBoundLabel2.TabIndex = 37;
            this.productNumberBoundLabel2.Text = "label3";
            this.productNumberBoundLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productSubcategoryNameLabel
            // 
            this.productSubcategoryNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productSubcategoryNameLabel.Location = new System.Drawing.Point(318, 227);
            this.productSubcategoryNameLabel.Name = "productSubcategoryNameLabel";
            this.productSubcategoryNameLabel.Size = new System.Drawing.Size(114, 20);
            this.productSubcategoryNameLabel.TabIndex = 38;
            this.productSubcategoryNameLabel.Text = "label8";
            this.productSubcategoryNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productCategoryIdLabel
            // 
            this.productCategoryIdLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productCategoryIdLabel.Location = new System.Drawing.Point(438, 227);
            this.productCategoryIdLabel.Name = "productCategoryIdLabel";
            this.productCategoryIdLabel.Size = new System.Drawing.Size(78, 20);
            this.productCategoryIdLabel.TabIndex = 40;
            this.productCategoryIdLabel.Text = "label8";
            this.productCategoryIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productCategoryNameLabel
            // 
            this.productCategoryNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productCategoryNameLabel.Location = new System.Drawing.Point(522, 226);
            this.productCategoryNameLabel.Name = "productCategoryNameLabel";
            this.productCategoryNameLabel.Size = new System.Drawing.Size(107, 20);
            this.productCategoryNameLabel.TabIndex = 41;
            this.productCategoryNameLabel.Text = "label8";
            this.productCategoryNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productUnitMeasureNameLabel
            // 
            this.productUnitMeasureNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productUnitMeasureNameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Weight", true));
            this.productUnitMeasureNameLabel.Location = new System.Drawing.Point(334, 170);
            this.productUnitMeasureNameLabel.Name = "productUnitMeasureNameLabel";
            this.productUnitMeasureNameLabel.Size = new System.Drawing.Size(98, 20);
            this.productUnitMeasureNameLabel.TabIndex = 42;
            this.productUnitMeasureNameLabel.Text = "label7";
            this.productUnitMeasureNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(listPriceChangeLabel);
            this.groupBox1.Controls.Add(this.listPriceChangeLabel1);
            this.groupBox1.Controls.Add(lowestListPriceLabel);
            this.groupBox1.Controls.Add(this.lowestListPriceLabel1);
            this.groupBox1.Location = new System.Drawing.Point(26, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 103);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Summary";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.adventureWorks2014_DataDataSet;
            this.productBindingSource.CurrentChanged += new System.EventHandler(this.productBindingSource_CurrentChanged);
            // 
            // adventureWorks2014_DataDataSet
            // 
            this.adventureWorks2014_DataDataSet.DataSetName = "AdventureWorks2014_DataDataSet";
            this.adventureWorks2014_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productSubcategoryBindingSource
            // 
            this.productSubcategoryBindingSource.DataMember = "ProductSubcategory";
            this.productSubcategoryBindingSource.DataSource = this.adventureWorks2014_DataDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductCategoryTableAdapter = null;
            this.tableAdapterManager.ProductSubcategoryTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UnitMeasureTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = jthacker2747ex1c2.AdventureWorks2014_DataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productSubcategoryTableAdapter
            // 
            this.productSubcategoryTableAdapter.ClearBeforeFill = true;
            // 
            // productCategoryBindingSource
            // 
            this.productCategoryBindingSource.DataMember = "ProductCategory";
            this.productCategoryBindingSource.DataSource = this.adventureWorks2014_DataDataSet;
            // 
            // productCategoryTableAdapter
            // 
            this.productCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // unitMeasureBindingSource
            // 
            this.unitMeasureBindingSource.DataMember = "UnitMeasure";
            this.unitMeasureBindingSource.DataSource = this.adventureWorks2014_DataDataSet;
            // 
            // unitMeasureTableAdapter
            // 
            this.unitMeasureTableAdapter.ClearBeforeFill = true;
            // 
            // lowestListPriceLabel
            // 
            lowestListPriceLabel.AutoSize = true;
            lowestListPriceLabel.Location = new System.Drawing.Point(22, 28);
            lowestListPriceLabel.Name = "lowestListPriceLabel";
            lowestListPriceLabel.Size = new System.Drawing.Size(118, 17);
            lowestListPriceLabel.TabIndex = 0;
            lowestListPriceLabel.Text = "Lowest List Price:";
            // 
            // lowestListPriceLabel1
            // 
            this.lowestListPriceLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowestListPriceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "LowestListPrice", true));
            this.lowestListPriceLabel1.Location = new System.Drawing.Point(152, 25);
            this.lowestListPriceLabel1.Name = "lowestListPriceLabel1";
            this.lowestListPriceLabel1.Size = new System.Drawing.Size(129, 23);
            this.lowestListPriceLabel1.TabIndex = 1;
            this.lowestListPriceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listPriceChangeLabel
            // 
            listPriceChangeLabel.AutoSize = true;
            listPriceChangeLabel.Location = new System.Drawing.Point(23, 60);
            listPriceChangeLabel.Name = "listPriceChangeLabel";
            listPriceChangeLabel.Size = new System.Drawing.Size(123, 17);
            listPriceChangeLabel.TabIndex = 2;
            listPriceChangeLabel.Text = "List Price Change:";
            // 
            // listPriceChangeLabel1
            // 
            this.listPriceChangeLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPriceChangeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ListPriceChange", true));
            this.listPriceChangeLabel1.Location = new System.Drawing.Point(152, 60);
            this.listPriceChangeLabel1.Name = "listPriceChangeLabel1";
            this.listPriceChangeLabel1.Size = new System.Drawing.Size(129, 23);
            this.listPriceChangeLabel1.TabIndex = 3;
            this.listPriceChangeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.productUnitMeasureNameLabel);
            this.Controls.Add(this.productCategoryNameLabel);
            this.Controls.Add(this.productCategoryIdLabel);
            this.Controls.Add(this.productSubcategoryNameLabel);
            this.Controls.Add(this.productNumberBoundLabel2);
            this.Controls.Add(this.sellStartDateBoundLabel2);
            this.Controls.Add(this.productIdBoundLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sellStartDateBoundLabel);
            this.Controls.Add(this.productSubcategoryIdBoundLabel);
            this.Controls.Add(this.weightBoundLabel);
            this.Controls.Add(this.weightUnitMeasureCodeBoundLabel);
            this.Controls.Add(this.listPriceBoundLabel);
            this.Controls.Add(this.reorderPointBoundLabel);
            this.Controls.Add(this.productNumberBoundLabel);
            this.Controls.Add(this.productNameBoundLabel);
            this.Controls.Add(this.productIdBoundLabel);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(productNumberLabel);
            this.Controls.Add(reorderPointLabel);
            this.Controls.Add(listPriceLabel);
            this.Controls.Add(weightUnitMeasureCodeLabel);
            this.Controls.Add(weightLabel);
            this.Controls.Add(productSubcategoryIDLabel);
            this.Controls.Add(sellStartDateLabel);
            this.Controls.Add(this.productBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2014_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSubcategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitMeasureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdventureWorks2014_DataDataSet adventureWorks2014_DataDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private AdventureWorks2014_DataDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private AdventureWorks2014_DataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
        private System.Windows.Forms.Label productIdBoundLabel;
        private System.Windows.Forms.Label productNumberBoundLabel;
        private System.Windows.Forms.Label productNameBoundLabel;
        private System.Windows.Forms.Label sellStartDateBoundLabel;
        private System.Windows.Forms.Label productSubcategoryIdBoundLabel;
        private System.Windows.Forms.Label weightBoundLabel;
        private System.Windows.Forms.Label weightUnitMeasureCodeBoundLabel;
        private System.Windows.Forms.Label listPriceBoundLabel;
        private System.Windows.Forms.Label reorderPointBoundLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label productIdBoundLabel2;
        private System.Windows.Forms.Label sellStartDateBoundLabel2;
        private System.Windows.Forms.Label productNumberBoundLabel2;
        private System.Windows.Forms.Label productSubcategoryNameLabel;
        private System.Windows.Forms.BindingSource productSubcategoryBindingSource;
        private AdventureWorks2014_DataDataSetTableAdapters.ProductSubcategoryTableAdapter productSubcategoryTableAdapter;
        private System.Windows.Forms.Label productCategoryIdLabel;
        private System.Windows.Forms.Label productCategoryNameLabel;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
        private AdventureWorks2014_DataDataSetTableAdapters.ProductCategoryTableAdapter productCategoryTableAdapter;
        private System.Windows.Forms.BindingSource unitMeasureBindingSource;
        private AdventureWorks2014_DataDataSetTableAdapters.UnitMeasureTableAdapter unitMeasureTableAdapter;
        private System.Windows.Forms.Label productUnitMeasureNameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label listPriceChangeLabel1;
        private System.Windows.Forms.Label lowestListPriceLabel1;
    }
}

