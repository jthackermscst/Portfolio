namespace jthacker2747ex2b1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeOfServiceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chargeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.newButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.moveLastButton = new System.Windows.Forms.Button();
            this.moveNextButton = new System.Windows.Forms.Button();
            this.currentPositionLabel = new System.Windows.Forms.Label();
            this.movePreviousButton = new System.Windows.Forms.Button();
            this.moveFirstButton = new System.Windows.Forms.Button();
            this.serviceIdComboBox = new System.Windows.Forms.ComboBox();
            this.clientIdTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.personIdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Service ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type of service:";
            // 
            // typeOfServiceTextBox
            // 
            this.typeOfServiceTextBox.Location = new System.Drawing.Point(163, 183);
            this.typeOfServiceTextBox.Name = "typeOfServiceTextBox";
            this.typeOfServiceTextBox.Size = new System.Drawing.Size(108, 22);
            this.typeOfServiceTextBox.TabIndex = 3;
            this.typeOfServiceTextBox.TextChanged += new System.EventHandler(this.control_valueChanged);
            this.typeOfServiceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.typeOfServiceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_validateNull);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Charge/hour:";
            // 
            // chargeTextBox
            // 
            this.chargeTextBox.Location = new System.Drawing.Point(163, 214);
            this.chargeTextBox.Name = "chargeTextBox";
            this.chargeTextBox.Size = new System.Drawing.Size(57, 22);
            this.chargeTextBox.TabIndex = 4;
            this.chargeTextBox.TextChanged += new System.EventHandler(this.control_valueChanged);
            this.chargeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.chargeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_validateNull);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(163, 88);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(108, 22);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.control_valueChanged);
            this.firstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.firstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_validateNull);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(163, 119);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(108, 22);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.control_valueChanged);
            this.lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.lastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_validateNull);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(366, 321);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 8;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(284, 321);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(203, 321);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(121, 321);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // moveLastButton
            // 
            this.moveLastButton.Location = new System.Drawing.Point(396, 292);
            this.moveLastButton.Name = "moveLastButton";
            this.moveLastButton.Size = new System.Drawing.Size(52, 23);
            this.moveLastButton.TabIndex = 13;
            this.moveLastButton.Text = ">|";
            this.moveLastButton.UseVisualStyleBackColor = true;
            this.moveLastButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // moveNextButton
            // 
            this.moveNextButton.Location = new System.Drawing.Point(332, 292);
            this.moveNextButton.Name = "moveNextButton";
            this.moveNextButton.Size = new System.Drawing.Size(55, 23);
            this.moveNextButton.TabIndex = 12;
            this.moveNextButton.Text = ">";
            this.moveNextButton.UseVisualStyleBackColor = true;
            this.moveNextButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // currentPositionLabel
            // 
            this.currentPositionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentPositionLabel.Location = new System.Drawing.Point(226, 292);
            this.currentPositionLabel.Name = "currentPositionLabel";
            this.currentPositionLabel.Size = new System.Drawing.Size(100, 23);
            this.currentPositionLabel.TabIndex = 32;
            this.currentPositionLabel.Text = "000 of 000";
            this.currentPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movePreviousButton
            // 
            this.movePreviousButton.Location = new System.Drawing.Point(168, 292);
            this.movePreviousButton.Name = "movePreviousButton";
            this.movePreviousButton.Size = new System.Drawing.Size(52, 23);
            this.movePreviousButton.TabIndex = 7;
            this.movePreviousButton.Text = "<";
            this.movePreviousButton.UseVisualStyleBackColor = true;
            this.movePreviousButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // moveFirstButton
            // 
            this.moveFirstButton.Location = new System.Drawing.Point(106, 292);
            this.moveFirstButton.Name = "moveFirstButton";
            this.moveFirstButton.Size = new System.Drawing.Size(56, 23);
            this.moveFirstButton.TabIndex = 6;
            this.moveFirstButton.Text = "|<";
            this.moveFirstButton.UseVisualStyleBackColor = true;
            this.moveFirstButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // serviceIdComboBox
            // 
            this.serviceIdComboBox.FormattingEnabled = true;
            this.serviceIdComboBox.Location = new System.Drawing.Point(163, 147);
            this.serviceIdComboBox.Name = "serviceIdComboBox";
            this.serviceIdComboBox.Size = new System.Drawing.Size(57, 24);
            this.serviceIdComboBox.TabIndex = 2;
            this.serviceIdComboBox.SelectedValueChanged += new System.EventHandler(this.control_valueChanged);
            // 
            // clientIdTextBox
            // 
            this.clientIdTextBox.Location = new System.Drawing.Point(163, 27);
            this.clientIdTextBox.Name = "clientIdTextBox";
            this.clientIdTextBox.ReadOnly = true;
            this.clientIdTextBox.Size = new System.Drawing.Size(57, 22);
            this.clientIdTextBox.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "PersonID";
            // 
            // personIdTextBox
            // 
            this.personIdTextBox.Location = new System.Drawing.Point(163, 55);
            this.personIdTextBox.Name = "personIdTextBox";
            this.personIdTextBox.ReadOnly = true;
            this.personIdTextBox.Size = new System.Drawing.Size(59, 22);
            this.personIdTextBox.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 383);
            this.Controls.Add(this.personIdTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clientIdTextBox);
            this.Controls.Add(this.serviceIdComboBox);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.moveLastButton);
            this.Controls.Add(this.moveNextButton);
            this.Controls.Add(this.currentPositionLabel);
            this.Controls.Add(this.movePreviousButton);
            this.Controls.Add(this.moveFirstButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chargeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.typeOfServiceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "jthacker2747ex2b1 Controls";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox typeOfServiceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox chargeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button moveLastButton;
        private System.Windows.Forms.Button moveNextButton;
        private System.Windows.Forms.Label currentPositionLabel;
        private System.Windows.Forms.Button movePreviousButton;
        private System.Windows.Forms.Button moveFirstButton;
        private System.Windows.Forms.ComboBox serviceIdComboBox;
        private System.Windows.Forms.TextBox clientIdTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox personIdTextBox;
    }
}

