namespace jthacker2747ex2a1
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
            this.businessEntityIdLabel = new System.Windows.Forms.Label();
            this.vendorNameTextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateProvinceComboBox = new System.Windows.Forms.ComboBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.preferredVendorCheckbox = new System.Windows.Forms.CheckBox();
            this.vendorActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.addressModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.moveFirstButton = new System.Windows.Forms.Button();
            this.movePreviousButton = new System.Windows.Forms.Button();
            this.currentPositionLabel = new System.Windows.Forms.Label();
            this.moveNextButton = new System.Windows.Forms.Button();
            this.moveLastButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.creditRatingCombox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // businessEntityIdLabel
            // 
            this.businessEntityIdLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.businessEntityIdLabel.Location = new System.Drawing.Point(111, 38);
            this.businessEntityIdLabel.Name = "businessEntityIdLabel";
            this.businessEntityIdLabel.Size = new System.Drawing.Size(100, 23);
            this.businessEntityIdLabel.TabIndex = 3;
            // 
            // vendorNameTextBox
            // 
            this.vendorNameTextBox.Location = new System.Drawing.Point(111, 76);
            this.vendorNameTextBox.Name = "vendorNameTextBox";
            this.vendorNameTextBox.Size = new System.Drawing.Size(181, 22);
            this.vendorNameTextBox.TabIndex = 0;
            this.vendorNameTextBox.TextChanged += new System.EventHandler(this.controlValueChanged);
            this.vendorNameTextBox.Enter += new System.EventHandler(this.bufferCurrentText);
            this.vendorNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.vendorNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_ValidateNull);
            // 
            // address1TextBox
            // 
            this.address1TextBox.Location = new System.Drawing.Point(111, 107);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(181, 22);
            this.address1TextBox.TabIndex = 1;
            this.address1TextBox.TextChanged += new System.EventHandler(this.controlValueChanged);
            this.address1TextBox.Enter += new System.EventHandler(this.bufferCurrentText);
            this.address1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.address1TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_ValidateNull);
            // 
            // address2TextBox
            // 
            this.address2TextBox.Location = new System.Drawing.Point(111, 138);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(181, 22);
            this.address2TextBox.TabIndex = 2;
            this.address2TextBox.TextChanged += new System.EventHandler(this.controlValueChanged);
            this.address2TextBox.Enter += new System.EventHandler(this.bufferCurrentText);
            this.address2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(111, 169);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 22);
            this.cityTextBox.TabIndex = 3;
            this.cityTextBox.TextChanged += new System.EventHandler(this.controlValueChanged);
            this.cityTextBox.Enter += new System.EventHandler(this.bufferCurrentText);
            this.cityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.cityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_ValidateNull);
            // 
            // stateProvinceComboBox
            // 
            this.stateProvinceComboBox.FormattingEnabled = true;
            this.stateProvinceComboBox.Location = new System.Drawing.Point(217, 169);
            this.stateProvinceComboBox.Name = "stateProvinceComboBox";
            this.stateProvinceComboBox.Size = new System.Drawing.Size(75, 24);
            this.stateProvinceComboBox.TabIndex = 5;
            this.stateProvinceComboBox.SelectedValueChanged += new System.EventHandler(this.controlValueChanged);
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(111, 200);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.postalCodeTextBox.TabIndex = 4;
            this.postalCodeTextBox.TextChanged += new System.EventHandler(this.controlValueChanged);
            this.postalCodeTextBox.Enter += new System.EventHandler(this.bufferCurrentText);
            this.postalCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.postalCodeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_ValidateNull);
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(446, 76);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(121, 22);
            this.accountNumberTextBox.TabIndex = 6;
            this.accountNumberTextBox.TextChanged += new System.EventHandler(this.controlValueChanged);
            this.accountNumberTextBox.Enter += new System.EventHandler(this.bufferCurrentText);
            this.accountNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.accountNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_ValidateNull);
            // 
            // preferredVendorCheckbox
            // 
            this.preferredVendorCheckbox.AutoSize = true;
            this.preferredVendorCheckbox.Location = new System.Drawing.Point(446, 138);
            this.preferredVendorCheckbox.Name = "preferredVendorCheckbox";
            this.preferredVendorCheckbox.Size = new System.Drawing.Size(138, 21);
            this.preferredVendorCheckbox.TabIndex = 20;
            this.preferredVendorCheckbox.Text = "Preferred vendor";
            this.preferredVendorCheckbox.UseVisualStyleBackColor = true;
            this.preferredVendorCheckbox.CheckedChanged += new System.EventHandler(this.controlValueChanged);
            // 
            // vendorActiveCheckBox
            // 
            this.vendorActiveCheckBox.AutoSize = true;
            this.vendorActiveCheckBox.Location = new System.Drawing.Point(446, 169);
            this.vendorActiveCheckBox.Name = "vendorActiveCheckBox";
            this.vendorActiveCheckBox.Size = new System.Drawing.Size(116, 21);
            this.vendorActiveCheckBox.TabIndex = 21;
            this.vendorActiveCheckBox.Text = "Active vendor";
            this.vendorActiveCheckBox.UseVisualStyleBackColor = true;
            this.vendorActiveCheckBox.CheckedChanged += new System.EventHandler(this.controlValueChanged);
            // 
            // addressModifiedDateTimePicker
            // 
            this.addressModifiedDateTimePicker.Enabled = false;
            this.addressModifiedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.addressModifiedDateTimePicker.Location = new System.Drawing.Point(446, 200);
            this.addressModifiedDateTimePicker.Name = "addressModifiedDateTimePicker";
            this.addressModifiedDateTimePicker.Size = new System.Drawing.Size(135, 22);
            this.addressModifiedDateTimePicker.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Vendor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Address 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Address 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "City/State:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Zip:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Acct#:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Credit Rating:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Modified:";
            // 
            // moveFirstButton
            // 
            this.moveFirstButton.Location = new System.Drawing.Point(156, 272);
            this.moveFirstButton.Name = "moveFirstButton";
            this.moveFirstButton.Size = new System.Drawing.Size(56, 23);
            this.moveFirstButton.TabIndex = 16;
            this.moveFirstButton.Text = "|<";
            this.moveFirstButton.UseVisualStyleBackColor = true;
            this.moveFirstButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // movePreviousButton
            // 
            this.movePreviousButton.Location = new System.Drawing.Point(218, 272);
            this.movePreviousButton.Name = "movePreviousButton";
            this.movePreviousButton.Size = new System.Drawing.Size(52, 23);
            this.movePreviousButton.TabIndex = 17;
            this.movePreviousButton.Text = "<";
            this.movePreviousButton.UseVisualStyleBackColor = true;
            this.movePreviousButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // currentPositionLabel
            // 
            this.currentPositionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentPositionLabel.Location = new System.Drawing.Point(276, 272);
            this.currentPositionLabel.Name = "currentPositionLabel";
            this.currentPositionLabel.Size = new System.Drawing.Size(100, 23);
            this.currentPositionLabel.TabIndex = 23;
            this.currentPositionLabel.Text = "000 of 000";
            this.currentPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moveNextButton
            // 
            this.moveNextButton.Location = new System.Drawing.Point(382, 272);
            this.moveNextButton.Name = "moveNextButton";
            this.moveNextButton.Size = new System.Drawing.Size(55, 23);
            this.moveNextButton.TabIndex = 18;
            this.moveNextButton.Text = ">";
            this.moveNextButton.UseVisualStyleBackColor = true;
            this.moveNextButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // moveLastButton
            // 
            this.moveLastButton.Location = new System.Drawing.Point(446, 272);
            this.moveLastButton.Name = "moveLastButton";
            this.moveLastButton.Size = new System.Drawing.Size(52, 23);
            this.moveLastButton.TabIndex = 19;
            this.moveLastButton.Text = ">|";
            this.moveLastButton.UseVisualStyleBackColor = true;
            this.moveLastButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(171, 301);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(253, 301);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(334, 301);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(416, 301);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 15;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // creditRatingCombox
            // 
            this.creditRatingCombox.FormattingEnabled = true;
            this.creditRatingCombox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.creditRatingCombox.Location = new System.Drawing.Point(446, 103);
            this.creditRatingCombox.Name = "creditRatingCombox";
            this.creditRatingCombox.Size = new System.Drawing.Size(121, 24);
            this.creditRatingCombox.TabIndex = 7;
            this.creditRatingCombox.SelectedValueChanged += new System.EventHandler(this.controlValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 342);
            this.Controls.Add(this.creditRatingCombox);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.moveLastButton);
            this.Controls.Add(this.moveNextButton);
            this.Controls.Add(this.currentPositionLabel);
            this.Controls.Add(this.movePreviousButton);
            this.Controls.Add(this.moveFirstButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressModifiedDateTimePicker);
            this.Controls.Add(this.vendorActiveCheckBox);
            this.Controls.Add(this.preferredVendorCheckbox);
            this.Controls.Add(this.accountNumberTextBox);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(this.stateProvinceComboBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(this.vendorNameTextBox);
            this.Controls.Add(this.businessEntityIdLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label businessEntityIdLabel;
        private System.Windows.Forms.TextBox vendorNameTextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.ComboBox stateProvinceComboBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.CheckBox preferredVendorCheckbox;
        private System.Windows.Forms.CheckBox vendorActiveCheckBox;
        private System.Windows.Forms.DateTimePicker addressModifiedDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button moveFirstButton;
        private System.Windows.Forms.Button movePreviousButton;
        private System.Windows.Forms.Label currentPositionLabel;
        private System.Windows.Forms.Button moveNextButton;
        private System.Windows.Forms.Button moveLastButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.ComboBox creditRatingCombox;
    }
}

