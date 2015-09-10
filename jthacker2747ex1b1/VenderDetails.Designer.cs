namespace jthacker2747ex1b1
{
    partial class VenderDetailsForm
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
            System.Windows.Forms.Label businessEntityIDLabel;
            System.Windows.Forms.Label accountNumberLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label creditRatingLabel;
            System.Windows.Forms.Label preferredVendorStatusLabel;
            System.Windows.Forms.Label activeFlagLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VenderDetailsForm));
            this.adventureWorksDataSet = new jthacker2747ex1b1.AdventureWorksDataSet();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorTableAdapter = new jthacker2747ex1b1.AdventureWorksDataSetTableAdapters.VendorTableAdapter();
            this.tableAdapterManager = new jthacker2747ex1b1.AdventureWorksDataSetTableAdapters.TableAdapterManager();
            this.vendorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vendorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.businessEntityIDTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.creditRatingTextBox = new System.Windows.Forms.TextBox();
            this.preferredVendorStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.activeFlagCheckBox = new System.Windows.Forms.CheckBox();
            this.CloseButton = new System.Windows.Forms.Button();
            businessEntityIDLabel = new System.Windows.Forms.Label();
            accountNumberLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            creditRatingLabel = new System.Windows.Forms.Label();
            preferredVendorStatusLabel = new System.Windows.Forms.Label();
            activeFlagLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingNavigator)).BeginInit();
            this.vendorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // businessEntityIDLabel
            // 
            businessEntityIDLabel.AutoSize = true;
            businessEntityIDLabel.Location = new System.Drawing.Point(82, 77);
            businessEntityIDLabel.Name = "businessEntityIDLabel";
            businessEntityIDLabel.Size = new System.Drawing.Size(125, 17);
            businessEntityIDLabel.TabIndex = 1;
            businessEntityIDLabel.Text = "Business Entity ID:";
            businessEntityIDLabel.Click += new System.EventHandler(this.businessEntityIDLabel_Click);
            // 
            // accountNumberLabel
            // 
            accountNumberLabel.AutoSize = true;
            accountNumberLabel.Location = new System.Drawing.Point(82, 105);
            accountNumberLabel.Name = "accountNumberLabel";
            accountNumberLabel.Size = new System.Drawing.Size(117, 17);
            accountNumberLabel.TabIndex = 3;
            accountNumberLabel.Text = "Account Number:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(82, 133);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // creditRatingLabel
            // 
            creditRatingLabel.AutoSize = true;
            creditRatingLabel.Location = new System.Drawing.Point(82, 161);
            creditRatingLabel.Name = "creditRatingLabel";
            creditRatingLabel.Size = new System.Drawing.Size(94, 17);
            creditRatingLabel.TabIndex = 7;
            creditRatingLabel.Text = "Credit Rating:";
            // 
            // preferredVendorStatusLabel
            // 
            preferredVendorStatusLabel.AutoSize = true;
            preferredVendorStatusLabel.Location = new System.Drawing.Point(82, 191);
            preferredVendorStatusLabel.Name = "preferredVendorStatusLabel";
            preferredVendorStatusLabel.Size = new System.Drawing.Size(166, 17);
            preferredVendorStatusLabel.TabIndex = 9;
            preferredVendorStatusLabel.Text = "Preferred Vendor Status:";
            // 
            // activeFlagLabel
            // 
            activeFlagLabel.AutoSize = true;
            activeFlagLabel.Location = new System.Drawing.Point(82, 221);
            activeFlagLabel.Name = "activeFlagLabel";
            activeFlagLabel.Size = new System.Drawing.Size(81, 17);
            activeFlagLabel.TabIndex = 11;
            activeFlagLabel.Text = "Active Flag:";
            // 
            // adventureWorksDataSet
            // 
            this.adventureWorksDataSet.DataSetName = "AdventureWorksDataSet";
            this.adventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "Vendor";
            this.vendorBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = jthacker2747ex1b1.AdventureWorksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorTableAdapter = this.vendorTableAdapter;
            // 
            // vendorBindingNavigator
            // 
            this.vendorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vendorBindingNavigator.BindingSource = this.vendorBindingSource;
            this.vendorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vendorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vendorBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.vendorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vendorBindingNavigatorSaveItem});
            this.vendorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vendorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vendorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vendorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vendorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vendorBindingNavigator.Name = "vendorBindingNavigator";
            this.vendorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vendorBindingNavigator.Size = new System.Drawing.Size(418, 27);
            this.vendorBindingNavigator.TabIndex = 0;
            this.vendorBindingNavigator.Text = "bindingNavigator1";
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
            // vendorBindingNavigatorSaveItem
            // 
            this.vendorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vendorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vendorBindingNavigatorSaveItem.Image")));
            this.vendorBindingNavigatorSaveItem.Name = "vendorBindingNavigatorSaveItem";
            this.vendorBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.vendorBindingNavigatorSaveItem.Text = "Save Data";
            this.vendorBindingNavigatorSaveItem.Click += new System.EventHandler(this.vendorBindingNavigatorSaveItem_Click);
            // 
            // businessEntityIDTextBox
            // 
            this.businessEntityIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "BusinessEntityID", true));
            this.businessEntityIDTextBox.Location = new System.Drawing.Point(254, 74);
            this.businessEntityIDTextBox.Name = "businessEntityIDTextBox";
            this.businessEntityIDTextBox.Size = new System.Drawing.Size(104, 22);
            this.businessEntityIDTextBox.TabIndex = 2;
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "AccountNumber", true));
            this.accountNumberTextBox.Location = new System.Drawing.Point(254, 102);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(104, 22);
            this.accountNumberTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(254, 130);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(104, 22);
            this.nameTextBox.TabIndex = 6;
            // 
            // creditRatingTextBox
            // 
            this.creditRatingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "CreditRating", true));
            this.creditRatingTextBox.Location = new System.Drawing.Point(254, 158);
            this.creditRatingTextBox.Name = "creditRatingTextBox";
            this.creditRatingTextBox.Size = new System.Drawing.Size(104, 22);
            this.creditRatingTextBox.TabIndex = 8;
            // 
            // preferredVendorStatusCheckBox
            // 
            this.preferredVendorStatusCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.vendorBindingSource, "PreferredVendorStatus", true));
            this.preferredVendorStatusCheckBox.Location = new System.Drawing.Point(254, 186);
            this.preferredVendorStatusCheckBox.Name = "preferredVendorStatusCheckBox";
            this.preferredVendorStatusCheckBox.Size = new System.Drawing.Size(104, 24);
            this.preferredVendorStatusCheckBox.TabIndex = 10;
            this.preferredVendorStatusCheckBox.UseVisualStyleBackColor = true;
            this.preferredVendorStatusCheckBox.CheckedChanged += new System.EventHandler(this.preferredVendorStatusCheckBox_CheckedChanged);
            // 
            // activeFlagCheckBox
            // 
            this.activeFlagCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.vendorBindingSource, "ActiveFlag", true));
            this.activeFlagCheckBox.Location = new System.Drawing.Point(254, 216);
            this.activeFlagCheckBox.Name = "activeFlagCheckBox";
            this.activeFlagCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activeFlagCheckBox.TabIndex = 12;
            this.activeFlagCheckBox.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(85, 283);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 27);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // VenderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 339);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(businessEntityIDLabel);
            this.Controls.Add(this.businessEntityIDTextBox);
            this.Controls.Add(accountNumberLabel);
            this.Controls.Add(this.accountNumberTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(creditRatingLabel);
            this.Controls.Add(this.creditRatingTextBox);
            this.Controls.Add(preferredVendorStatusLabel);
            this.Controls.Add(this.preferredVendorStatusCheckBox);
            this.Controls.Add(activeFlagLabel);
            this.Controls.Add(this.activeFlagCheckBox);
            this.Controls.Add(this.vendorBindingNavigator);
            this.Name = "VenderDetailsForm";
            this.Text = "VenderDetails";
            this.Load += new System.EventHandler(this.VenderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingNavigator)).EndInit();
            this.vendorBindingNavigator.ResumeLayout(false);
            this.vendorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdventureWorksDataSet adventureWorksDataSet;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private AdventureWorksDataSetTableAdapters.VendorTableAdapter vendorTableAdapter;
        private AdventureWorksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vendorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vendorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox businessEntityIDTextBox;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox creditRatingTextBox;
        private System.Windows.Forms.CheckBox preferredVendorStatusCheckBox;
        private System.Windows.Forms.CheckBox activeFlagCheckBox;
        private System.Windows.Forms.Button CloseButton;
    }
}