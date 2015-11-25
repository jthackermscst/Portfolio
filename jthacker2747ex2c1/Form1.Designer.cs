namespace jthacker2747ex2c1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connectionStringTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.version1Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.version2Button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.vendorsListView1 = new System.Windows.Forms.ListView();
            this.businessEntityID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.creditRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.preferredVendorStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.activeFlag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.purchasingWebServiceURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modifiedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.connectionString3Label = new System.Windows.Forms.Label();
            this.version3Button = new System.Windows.Forms.Button();
            this.version4Button = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.vendorsListView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.purchaseOrderHeaderListView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Revision = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShipMethodID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShippedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vendorIDLabel2 = new System.Windows.Forms.Label();
            this.activeFlagButton = new System.Windows.Forms.RadioButton();
            this.inactiveRadioButton = new System.Windows.Forms.RadioButton();
            this.vendorIDLabel = new System.Windows.Forms.Label();
            this.SubTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Freight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connectionStringTextBox);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection String variable, String Objects";
            // 
            // connectionStringTextBox
            // 
            this.connectionStringTextBox.Location = new System.Drawing.Point(7, 22);
            this.connectionStringTextBox.Name = "connectionStringTextBox";
            this.connectionStringTextBox.Size = new System.Drawing.Size(278, 22);
            this.connectionStringTextBox.TabIndex = 1;
            this.connectionStringTextBox.Text = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\AdventureWork" +
    "s2014_Data.mdf;Integrated Security=True";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(7, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(278, 164);
            this.listBox1.TabIndex = 0;
            // 
            // version1Button
            // 
            this.version1Button.Location = new System.Drawing.Point(608, 9);
            this.version1Button.Name = "version1Button";
            this.version1Button.Size = new System.Drawing.Size(95, 30);
            this.version1Button.TabIndex = 1;
            this.version1Button.Text = "version 1";
            this.version1Button.UseVisualStyleBackColor = true;
            this.version1Button.Click += new System.EventHandler(this.version1Button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fileNameTextBox);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(311, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 227);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection String builder, Vendor Objects";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(7, 21);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(278, 22);
            this.fileNameTextBox.TabIndex = 1;
            this.fileNameTextBox.Text = "|DataDirectory|\\AdventureWorks2014_Data.mdf";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(7, 59);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(278, 164);
            this.listBox2.TabIndex = 0;
            // 
            // version2Button
            // 
            this.version2Button.Location = new System.Drawing.Point(608, 42);
            this.version2Button.Name = "version2Button";
            this.version2Button.Size = new System.Drawing.Size(95, 30);
            this.version2Button.TabIndex = 3;
            this.version2Button.Text = "version 2";
            this.version2Button.UseVisualStyleBackColor = true;
            this.version2Button.Click += new System.EventHandler(this.version2Button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.vendorsListView1);
            this.groupBox3.Controls.Add(this.connectionString3Label);
            this.groupBox3.Location = new System.Drawing.Point(14, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(727, 211);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Porject Properties/App.Config Connection String, Ordinal Col#, DbNull";
            // 
            // vendorsListView1
            // 
            this.vendorsListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.businessEntityID,
            this.name,
            this.creditRating,
            this.preferredVendorStatus,
            this.activeFlag,
            this.purchasingWebServiceURL,
            this.modifiedDate});
            this.vendorsListView1.Location = new System.Drawing.Point(7, 54);
            this.vendorsListView1.Name = "vendorsListView1";
            this.vendorsListView1.Size = new System.Drawing.Size(714, 139);
            this.vendorsListView1.TabIndex = 1;
            this.vendorsListView1.UseCompatibleStateImageBehavior = false;
            this.vendorsListView1.View = System.Windows.Forms.View.Details;
            // 
            // businessEntityID
            // 
            this.businessEntityID.Text = "ID";
            this.businessEntityID.Width = 40;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 140;
            // 
            // creditRating
            // 
            this.creditRating.Text = "Credit";
            this.creditRating.Width = 65;
            // 
            // preferredVendorStatus
            // 
            this.preferredVendorStatus.Text = "Pref. Vend";
            this.preferredVendorStatus.Width = 76;
            // 
            // activeFlag
            // 
            this.activeFlag.Text = "Active";
            this.activeFlag.Width = 67;
            // 
            // purchasingWebServiceURL
            // 
            this.purchasingWebServiceURL.Text = "URL";
            this.purchasingWebServiceURL.Width = 179;
            // 
            // modifiedDate
            // 
            this.modifiedDate.Text = "Mod. Date";
            this.modifiedDate.Width = 85;
            // 
            // connectionString3Label
            // 
            this.connectionString3Label.AutoSize = true;
            this.connectionString3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectionString3Label.Location = new System.Drawing.Point(7, 22);
            this.connectionString3Label.Name = "connectionString3Label";
            this.connectionString3Label.Size = new System.Drawing.Size(48, 19);
            this.connectionString3Label.TabIndex = 0;
            this.connectionString3Label.Text = "label1";
            // 
            // version3Button
            // 
            this.version3Button.Location = new System.Drawing.Point(608, 75);
            this.version3Button.Name = "version3Button";
            this.version3Button.Size = new System.Drawing.Size(95, 30);
            this.version3Button.TabIndex = 5;
            this.version3Button.Text = "version 3";
            this.version3Button.UseVisualStyleBackColor = true;
            this.version3Button.Click += new System.EventHandler(this.version3Button_Click);
            // 
            // version4Button
            // 
            this.version4Button.Location = new System.Drawing.Point(608, 108);
            this.version4Button.Name = "version4Button";
            this.version4Button.Size = new System.Drawing.Size(95, 30);
            this.version4Button.TabIndex = 6;
            this.version4Button.Text = "version 4";
            this.version4Button.UseVisualStyleBackColor = true;
            this.version4Button.Click += new System.EventHandler(this.version4button_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.vendorIDLabel);
            this.groupBox4.Controls.Add(this.inactiveRadioButton);
            this.groupBox4.Controls.Add(this.activeFlagButton);
            this.groupBox4.Controls.Add(this.vendorsListView2);
            this.groupBox4.Location = new System.Drawing.Point(14, 468);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(727, 189);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "VendorDB Mapper Class, SqlParameter";
            // 
            // vendorsListView2
            // 
            this.vendorsListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.vendorsListView2.Location = new System.Drawing.Point(6, 46);
            this.vendorsListView2.Name = "vendorsListView2";
            this.vendorsListView2.Size = new System.Drawing.Size(714, 139);
            this.vendorsListView2.TabIndex = 3;
            this.vendorsListView2.UseCompatibleStateImageBehavior = false;
            this.vendorsListView2.View = System.Windows.Forms.View.Details;
            this.vendorsListView2.SelectedIndexChanged += new System.EventHandler(this.vendorsListView2_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Credit";
            this.columnHeader3.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pref. Vend";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Active";
            this.columnHeader5.Width = 67;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "URL";
            this.columnHeader6.Width = 179;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mod. Date";
            this.columnHeader7.Width = 85;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.orderCountLabel);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.vendorIDLabel2);
            this.groupBox5.Controls.Add(this.purchaseOrderHeaderListView);
            this.groupBox5.Location = new System.Drawing.Point(23, 673);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(822, 203);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PurchaseOrderHeader table, DBMapper SqlParameter";
            // 
            // purchaseOrderHeaderListView
            // 
            this.purchaseOrderHeaderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Revision,
            this.Status,
            this.EmployeeID,
            this.ShipMethodID,
            this.OrderDate,
            this.ShippedDate,
            this.SubTotal,
            this.Tax,
            this.Freight,
            this.Total});
            this.purchaseOrderHeaderListView.Location = new System.Drawing.Point(12, 50);
            this.purchaseOrderHeaderListView.Name = "purchaseOrderHeaderListView";
            this.purchaseOrderHeaderListView.Size = new System.Drawing.Size(810, 147);
            this.purchaseOrderHeaderListView.TabIndex = 4;
            this.purchaseOrderHeaderListView.UseCompatibleStateImageBehavior = false;
            this.purchaseOrderHeaderListView.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // Revision
            // 
            this.Revision.Text = "Rev";
            this.Revision.Width = 46;
            // 
            // Status
            // 
            this.Status.Text = "Stat";
            this.Status.Width = 45;
            // 
            // EmployeeID
            // 
            this.EmployeeID.Text = "Emp";
            this.EmployeeID.Width = 51;
            // 
            // ShipMethodID
            // 
            this.ShipMethodID.Text = "Ship";
            this.ShipMethodID.Width = 57;
            // 
            // OrderDate
            // 
            this.OrderDate.Text = "Ordered";
            this.OrderDate.Width = 117;
            // 
            // ShippedDate
            // 
            this.ShippedDate.Text = "Shipped";
            this.ShippedDate.Width = 97;
            // 
            // orderCountLabel
            // 
            this.orderCountLabel.AutoSize = true;
            this.orderCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderCountLabel.Location = new System.Drawing.Point(374, 20);
            this.orderCountLabel.Name = "orderCountLabel";
            this.orderCountLabel.Size = new System.Drawing.Size(74, 19);
            this.orderCountLabel.TabIndex = 10;
            this.orderCountLabel.Text = "Key Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Purchase order selected:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vendor ID:";
            // 
            // vendorIDLabel2
            // 
            this.vendorIDLabel2.AutoSize = true;
            this.vendorIDLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vendorIDLabel2.Location = new System.Drawing.Point(87, 22);
            this.vendorIDLabel2.Name = "vendorIDLabel2";
            this.vendorIDLabel2.Size = new System.Drawing.Size(74, 19);
            this.vendorIDLabel2.TabIndex = 7;
            this.vendorIDLabel2.Text = "Key Value";
            // 
            // activeFlagButton
            // 
            this.activeFlagButton.AutoSize = true;
            this.activeFlagButton.Checked = true;
            this.activeFlagButton.Location = new System.Drawing.Point(7, 19);
            this.activeFlagButton.Name = "activeFlagButton";
            this.activeFlagButton.Size = new System.Drawing.Size(67, 21);
            this.activeFlagButton.TabIndex = 4;
            this.activeFlagButton.TabStop = true;
            this.activeFlagButton.Text = "Active";
            this.activeFlagButton.UseVisualStyleBackColor = true;
            // 
            // inactiveRadioButton
            // 
            this.inactiveRadioButton.AutoSize = true;
            this.inactiveRadioButton.Location = new System.Drawing.Point(112, 19);
            this.inactiveRadioButton.Name = "inactiveRadioButton";
            this.inactiveRadioButton.Size = new System.Drawing.Size(77, 21);
            this.inactiveRadioButton.TabIndex = 5;
            this.inactiveRadioButton.Text = "Inactive";
            this.inactiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // vendorIDLabel
            // 
            this.vendorIDLabel.AutoSize = true;
            this.vendorIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vendorIDLabel.Location = new System.Drawing.Point(253, 21);
            this.vendorIDLabel.Name = "vendorIDLabel";
            this.vendorIDLabel.Size = new System.Drawing.Size(128, 19);
            this.vendorIDLabel.TabIndex = 11;
            this.vendorIDLabel.Text = "Vendors selected: ";
            // 
            // SubTotal
            // 
            this.SubTotal.Text = "SubTotal";
            this.SubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SubTotal.Width = 93;
            // 
            // Tax
            // 
            this.Tax.Text = "Tax";
            this.Tax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tax.Width = 79;
            // 
            // Freight
            // 
            this.Freight.Text = "Freight";
            this.Freight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Freight.Width = 71;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Total.Width = 78;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 888);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.version4Button);
            this.Controls.Add(this.version3Button);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.version2Button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.version1Button);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "jthacker2747ex2c";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox connectionStringTextBox;
        private System.Windows.Forms.Button version1Button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button version2Button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView vendorsListView1;
        private System.Windows.Forms.ColumnHeader businessEntityID;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader creditRating;
        private System.Windows.Forms.ColumnHeader preferredVendorStatus;
        private System.Windows.Forms.ColumnHeader activeFlag;
        private System.Windows.Forms.ColumnHeader purchasingWebServiceURL;
        private System.Windows.Forms.ColumnHeader modifiedDate;
        private System.Windows.Forms.Label connectionString3Label;
        private System.Windows.Forms.Button version3Button;
        private System.Windows.Forms.Button version4Button;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView vendorsListView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView purchaseOrderHeaderListView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Revision;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader EmployeeID;
        private System.Windows.Forms.ColumnHeader ShipMethodID;
        private System.Windows.Forms.ColumnHeader OrderDate;
        private System.Windows.Forms.ColumnHeader ShippedDate;
        private System.Windows.Forms.Label vendorIDLabel;
        private System.Windows.Forms.RadioButton inactiveRadioButton;
        private System.Windows.Forms.RadioButton activeFlagButton;
        private System.Windows.Forms.Label orderCountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label vendorIDLabel2;
        private System.Windows.Forms.ColumnHeader SubTotal;
        private System.Windows.Forms.ColumnHeader Tax;
        private System.Windows.Forms.ColumnHeader Freight;
        private System.Windows.Forms.ColumnHeader Total;
    }
}

