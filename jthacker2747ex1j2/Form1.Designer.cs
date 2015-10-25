namespace jthacker2747ex1j2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label transIDLabel;
            System.Windows.Forms.Label clientIDLabel;
            System.Windows.Forms.Label serviceIDLabel;
            System.Windows.Forms.Label hoursLabel;
            System.Windows.Forms.Label empIDLabel;
            this.thackTracksDataSet = new jthacker2747ex1j2.ThackTracksDataSet();
            this._4hServiceTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._4hServiceTransactionTableAdapter = new jthacker2747ex1j2.ThackTracksDataSetTableAdapters._4hServiceTransactionTableAdapter();
            this.tableAdapterManager = new jthacker2747ex1j2.ThackTracksDataSetTableAdapters.TableAdapterManager();
            this._4hServiceTransactionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this._4hServiceTransactionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.transIDComboBox = new System.Windows.Forms.ComboBox();
            this.clientIDTextBox = new System.Windows.Forms.TextBox();
            this.serviceIDTextBox = new System.Windows.Forms.TextBox();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this._2hEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._2hEmployeeTableAdapter = new jthacker2747ex1j2.ThackTracksDataSetTableAdapters._2hEmployeeTableAdapter();
            this.empIDTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.thackTracksDataSet1 = new jthacker2747ex1j2.ThackTracksDataSet();
            this.hPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._2hPersonTableAdapter = new jthacker2747ex1j2.ThackTracksDataSetTableAdapters._2hPersonTableAdapter();
            transIDLabel = new System.Windows.Forms.Label();
            clientIDLabel = new System.Windows.Forms.Label();
            serviceIDLabel = new System.Windows.Forms.Label();
            hoursLabel = new System.Windows.Forms.Label();
            empIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thackTracksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._4hServiceTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._4hServiceTransactionBindingNavigator)).BeginInit();
            this._4hServiceTransactionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._2hEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thackTracksDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hPersonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // thackTracksDataSet
            // 
            this.thackTracksDataSet.DataSetName = "ThackTracksDataSet";
            this.thackTracksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _4hServiceTransactionBindingSource
            // 
            this._4hServiceTransactionBindingSource.DataMember = "4hServiceTransaction";
            this._4hServiceTransactionBindingSource.DataSource = this.thackTracksDataSet;
            this._4hServiceTransactionBindingSource.CurrentChanged += new System.EventHandler(this._4hServiceTransactionBindingSource_CurrentChanged);
            // 
            // _4hServiceTransactionTableAdapter
            // 
            this._4hServiceTransactionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._2hBloggerTableAdapter = null;
            this.tableAdapterManager._2hClientTableAdapter = null;
            this.tableAdapterManager._2hEmployeeTableAdapter = null;
            this.tableAdapterManager._2hPersonAddressTableAdapter = null;
            this.tableAdapterManager._2hPersonTableAdapter = null;
            this.tableAdapterManager._2hServiceTableAdapter = null;
            this.tableAdapterManager._2hTalentTableAdapter = null;
            this.tableAdapterManager._4hServiceTransactionTableAdapter = this._4hServiceTransactionTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = jthacker2747ex1j2.ThackTracksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // _4hServiceTransactionBindingNavigator
            // 
            this._4hServiceTransactionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this._4hServiceTransactionBindingNavigator.BindingSource = this._4hServiceTransactionBindingSource;
            this._4hServiceTransactionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this._4hServiceTransactionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this._4hServiceTransactionBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._4hServiceTransactionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this._4hServiceTransactionBindingNavigatorSaveItem});
            this._4hServiceTransactionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this._4hServiceTransactionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this._4hServiceTransactionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this._4hServiceTransactionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this._4hServiceTransactionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this._4hServiceTransactionBindingNavigator.Name = "_4hServiceTransactionBindingNavigator";
            this._4hServiceTransactionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this._4hServiceTransactionBindingNavigator.Size = new System.Drawing.Size(516, 27);
            this._4hServiceTransactionBindingNavigator.TabIndex = 0;
            this._4hServiceTransactionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // _4hServiceTransactionBindingNavigatorSaveItem
            // 
            this._4hServiceTransactionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._4hServiceTransactionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("_4hServiceTransactionBindingNavigatorSaveItem.Image")));
            this._4hServiceTransactionBindingNavigatorSaveItem.Name = "_4hServiceTransactionBindingNavigatorSaveItem";
            this._4hServiceTransactionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this._4hServiceTransactionBindingNavigatorSaveItem.Text = "Save Data";
            this._4hServiceTransactionBindingNavigatorSaveItem.Click += new System.EventHandler(this._4hServiceTransactionBindingNavigatorSaveItem_Click);
            // 
            // transIDLabel
            // 
            transIDLabel.AutoSize = true;
            transIDLabel.Location = new System.Drawing.Point(69, 53);
            transIDLabel.Name = "transIDLabel";
            transIDLabel.Size = new System.Drawing.Size(66, 17);
            transIDLabel.TabIndex = 1;
            transIDLabel.Text = "Trans ID:";
            // 
            // transIDComboBox
            // 
            this.transIDComboBox.DataSource = this._4hServiceTransactionBindingSource;
            this.transIDComboBox.DisplayMember = "TransID";
            this.transIDComboBox.FormattingEnabled = true;
            this.transIDComboBox.Location = new System.Drawing.Point(151, 50);
            this.transIDComboBox.Name = "transIDComboBox";
            this.transIDComboBox.Size = new System.Drawing.Size(121, 24);
            this.transIDComboBox.TabIndex = 2;
            // 
            // clientIDLabel
            // 
            clientIDLabel.AutoSize = true;
            clientIDLabel.Location = new System.Drawing.Point(69, 84);
            clientIDLabel.Name = "clientIDLabel";
            clientIDLabel.Size = new System.Drawing.Size(64, 17);
            clientIDLabel.TabIndex = 3;
            clientIDLabel.Text = "Client ID:";
            // 
            // clientIDTextBox
            // 
            this.clientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._4hServiceTransactionBindingSource, "ClientID", true));
            this.clientIDTextBox.Location = new System.Drawing.Point(151, 81);
            this.clientIDTextBox.Name = "clientIDTextBox";
            this.clientIDTextBox.ReadOnly = true;
            this.clientIDTextBox.Size = new System.Drawing.Size(56, 22);
            this.clientIDTextBox.TabIndex = 4;
            // 
            // serviceIDLabel
            // 
            serviceIDLabel.AutoSize = true;
            serviceIDLabel.Location = new System.Drawing.Point(69, 112);
            serviceIDLabel.Name = "serviceIDLabel";
            serviceIDLabel.Size = new System.Drawing.Size(76, 17);
            serviceIDLabel.TabIndex = 5;
            serviceIDLabel.Text = "Service ID:";
            // 
            // serviceIDTextBox
            // 
            this.serviceIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._4hServiceTransactionBindingSource, "ServiceID", true));
            this.serviceIDTextBox.Location = new System.Drawing.Point(151, 109);
            this.serviceIDTextBox.Name = "serviceIDTextBox";
            this.serviceIDTextBox.ReadOnly = true;
            this.serviceIDTextBox.Size = new System.Drawing.Size(56, 22);
            this.serviceIDTextBox.TabIndex = 6;
            // 
            // hoursLabel
            // 
            hoursLabel.AutoSize = true;
            hoursLabel.Location = new System.Drawing.Point(69, 168);
            hoursLabel.Name = "hoursLabel";
            hoursLabel.Size = new System.Drawing.Size(50, 17);
            hoursLabel.TabIndex = 9;
            hoursLabel.Text = "Hours:";
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._4hServiceTransactionBindingSource, "Hours", true));
            this.hoursTextBox.Location = new System.Drawing.Point(151, 165);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(74, 22);
            this.hoursTextBox.TabIndex = 10;
            // 
            // _2hEmployeeBindingSource
            // 
            this._2hEmployeeBindingSource.DataMember = "2hEmployee";
            this._2hEmployeeBindingSource.DataSource = this.thackTracksDataSet;
            // 
            // _2hEmployeeTableAdapter
            // 
            this._2hEmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // empIDTextBox
            // 
            this.empIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._4hServiceTransactionBindingSource, "EmpID", true));
            this.empIDTextBox.Location = new System.Drawing.Point(151, 137);
            this.empIDTextBox.Name = "empIDTextBox";
            this.empIDTextBox.ReadOnly = true;
            this.empIDTextBox.Size = new System.Drawing.Size(56, 22);
            this.empIDTextBox.TabIndex = 8;
            // 
            // empIDLabel
            // 
            empIDLabel.AutoSize = true;
            empIDLabel.Location = new System.Drawing.Point(69, 140);
            empIDLabel.Name = "empIDLabel";
            empIDLabel.Size = new System.Drawing.Size(57, 17);
            empIDLabel.TabIndex = 7;
            empIDLabel.Text = "Emp ID:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this._4hServiceTransactionBindingSource, "EmpID", true));
            this.comboBox1.DataSource = this.hPersonBindingSource;
            this.comboBox1.DisplayMember = "FirstName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(213, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "PersonID";
            // 
            // thackTracksDataSet1
            // 
            this.thackTracksDataSet1.DataSetName = "ThackTracksDataSet";
            this.thackTracksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hPersonBindingSource
            // 
            this.hPersonBindingSource.DataMember = "2hPerson";
            this.hPersonBindingSource.DataSource = this.thackTracksDataSet1;
            // 
            // _2hPersonTableAdapter
            // 
            this._2hPersonTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 316);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(transIDLabel);
            this.Controls.Add(this.transIDComboBox);
            this.Controls.Add(clientIDLabel);
            this.Controls.Add(this.clientIDTextBox);
            this.Controls.Add(serviceIDLabel);
            this.Controls.Add(this.serviceIDTextBox);
            this.Controls.Add(empIDLabel);
            this.Controls.Add(this.empIDTextBox);
            this.Controls.Add(hoursLabel);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this._4hServiceTransactionBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thackTracksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._4hServiceTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._4hServiceTransactionBindingNavigator)).EndInit();
            this._4hServiceTransactionBindingNavigator.ResumeLayout(false);
            this._4hServiceTransactionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._2hEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thackTracksDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hPersonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ThackTracksDataSet thackTracksDataSet;
        private System.Windows.Forms.BindingSource _4hServiceTransactionBindingSource;
        private ThackTracksDataSetTableAdapters._4hServiceTransactionTableAdapter _4hServiceTransactionTableAdapter;
        private ThackTracksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator _4hServiceTransactionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton _4hServiceTransactionBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox transIDComboBox;
        private System.Windows.Forms.TextBox clientIDTextBox;
        private System.Windows.Forms.TextBox serviceIDTextBox;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.BindingSource _2hEmployeeBindingSource;
        private ThackTracksDataSetTableAdapters._2hEmployeeTableAdapter _2hEmployeeTableAdapter;
        private System.Windows.Forms.TextBox empIDTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private ThackTracksDataSet thackTracksDataSet1;
        private System.Windows.Forms.BindingSource hPersonBindingSource;
        private ThackTracksDataSetTableAdapters._2hPersonTableAdapter _2hPersonTableAdapter;
    }
}

