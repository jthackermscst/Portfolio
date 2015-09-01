namespace jthacker2747ex1a1
{
    partial class ShipDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipDetailsForm));
            System.Windows.Forms.Label shipMethodIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label shipBaseLabel;
            System.Windows.Forms.Label shipRateLabel;
            this.adventureWorksDataSet1 = new jthacker2747ex1a1.AdventureWorksDataSet();
            this.shipMethodBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shipMethodTableAdapter1 = new jthacker2747ex1a1.AdventureWorksDataSetTableAdapters.ShipMethodTableAdapter();
            this.tableAdapterManager1 = new jthacker2747ex1a1.AdventureWorksDataSetTableAdapters.TableAdapterManager();
            this.shipMethodBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.shipMethodBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.shipMethodIDTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.shipBaseTextBox1 = new System.Windows.Forms.TextBox();
            this.shipRateTextBox1 = new System.Windows.Forms.TextBox();
            this.closeButton1 = new System.Windows.Forms.Button();
            shipMethodIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            shipBaseLabel = new System.Windows.Forms.Label();
            shipRateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMethodBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMethodBindingSource1BindingNavigator)).BeginInit();
            this.shipMethodBindingSource1BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // adventureWorksDataSet1
            // 
            this.adventureWorksDataSet1.DataSetName = "AdventureWorksDataSet";
            this.adventureWorksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shipMethodBindingSource1
            // 
            this.shipMethodBindingSource1.DataMember = "ShipMethod";
            this.shipMethodBindingSource1.DataSource = this.adventureWorksDataSet1;
            // 
            // shipMethodTableAdapter1
            // 
            this.shipMethodTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ShipMethodTableAdapter = this.shipMethodTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = jthacker2747ex1a1.AdventureWorksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // shipMethodBindingSource1BindingNavigator
            // 
            this.shipMethodBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.shipMethodBindingSource1BindingNavigator.BindingSource = this.shipMethodBindingSource1;
            this.shipMethodBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.shipMethodBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.shipMethodBindingSource1BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.shipMethodBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.shipMethodBindingSource1BindingNavigatorSaveItem});
            this.shipMethodBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.shipMethodBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.shipMethodBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.shipMethodBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.shipMethodBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.shipMethodBindingSource1BindingNavigator.Name = "shipMethodBindingSource1BindingNavigator";
            this.shipMethodBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.shipMethodBindingSource1BindingNavigator.Size = new System.Drawing.Size(403, 27);
            this.shipMethodBindingSource1BindingNavigator.TabIndex = 0;
            this.shipMethodBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "bindingNavigatorMoveFirstItem";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "bindingNavigatorMovePreviousItem";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "bindingNavigatorPositionItem";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 27);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "bindingNavigatorCountItem";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 24);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "bindingNavigatorMoveNextItem";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "bindingNavigatorMoveLastItem";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "bindingNavigatorAddNewItem";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton5.Text = "Add new";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "bindingNavigatorDeleteItem";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton6.Text = "Delete";
            // 
            // shipMethodBindingSource1BindingNavigatorSaveItem
            // 
            this.shipMethodBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shipMethodBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("shipMethodBindingSource1BindingNavigatorSaveItem.Image")));
            this.shipMethodBindingSource1BindingNavigatorSaveItem.Name = "shipMethodBindingSource1BindingNavigatorSaveItem";
            this.shipMethodBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.shipMethodBindingSource1BindingNavigatorSaveItem.Text = "Save Data";
            this.shipMethodBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.shipMethodBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // shipMethodIDLabel
            // 
            shipMethodIDLabel.AutoSize = true;
            shipMethodIDLabel.Location = new System.Drawing.Point(78, 94);
            shipMethodIDLabel.Name = "shipMethodIDLabel";
            shipMethodIDLabel.Size = new System.Drawing.Size(108, 17);
            shipMethodIDLabel.TabIndex = 1;
            shipMethodIDLabel.Text = "Ship Method ID:";
            // 
            // shipMethodIDTextBox1
            // 
            this.shipMethodIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipMethodBindingSource1, "ShipMethodID", true));
            this.shipMethodIDTextBox1.Location = new System.Drawing.Point(192, 91);
            this.shipMethodIDTextBox1.Name = "shipMethodIDTextBox1";
            this.shipMethodIDTextBox1.Size = new System.Drawing.Size(100, 22);
            this.shipMethodIDTextBox1.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(78, 122);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipMethodBindingSource1, "Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(192, 119);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox1.TabIndex = 4;
            // 
            // shipBaseLabel
            // 
            shipBaseLabel.AutoSize = true;
            shipBaseLabel.Location = new System.Drawing.Point(78, 150);
            shipBaseLabel.Name = "shipBaseLabel";
            shipBaseLabel.Size = new System.Drawing.Size(76, 17);
            shipBaseLabel.TabIndex = 5;
            shipBaseLabel.Text = "Ship Base:";
            // 
            // shipBaseTextBox1
            // 
            this.shipBaseTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipMethodBindingSource1, "ShipBase", true));
            this.shipBaseTextBox1.Location = new System.Drawing.Point(192, 147);
            this.shipBaseTextBox1.Name = "shipBaseTextBox1";
            this.shipBaseTextBox1.Size = new System.Drawing.Size(100, 22);
            this.shipBaseTextBox1.TabIndex = 6;
            // 
            // shipRateLabel
            // 
            shipRateLabel.AutoSize = true;
            shipRateLabel.Location = new System.Drawing.Point(78, 178);
            shipRateLabel.Name = "shipRateLabel";
            shipRateLabel.Size = new System.Drawing.Size(74, 17);
            shipRateLabel.TabIndex = 7;
            shipRateLabel.Text = "Ship Rate:";
            // 
            // shipRateTextBox1
            // 
            this.shipRateTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipMethodBindingSource1, "ShipRate", true));
            this.shipRateTextBox1.Location = new System.Drawing.Point(192, 175);
            this.shipRateTextBox1.Name = "shipRateTextBox1";
            this.shipRateTextBox1.Size = new System.Drawing.Size(100, 22);
            this.shipRateTextBox1.TabIndex = 8;
            // 
            // closeButton1
            // 
            this.closeButton1.Location = new System.Drawing.Point(192, 221);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(87, 36);
            this.closeButton1.TabIndex = 9;
            this.closeButton1.Text = "Close";
            this.closeButton1.UseVisualStyleBackColor = true;
            this.closeButton1.Click += new System.EventHandler(this.closeButton1_Click);
            // 
            // ShipDetailsForm
            // 
            this.ClientSize = new System.Drawing.Size(403, 269);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(shipMethodIDLabel);
            this.Controls.Add(this.shipMethodIDTextBox1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(shipBaseLabel);
            this.Controls.Add(this.shipBaseTextBox1);
            this.Controls.Add(shipRateLabel);
            this.Controls.Add(this.shipRateTextBox1);
            this.Controls.Add(this.shipMethodBindingSource1BindingNavigator);
            this.Name = "ShipDetailsForm";
            this.Load += new System.EventHandler(this.ShipDetailsForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMethodBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMethodBindingSource1BindingNavigator)).EndInit();
            this.shipMethodBindingSource1BindingNavigator.ResumeLayout(false);
            this.shipMethodBindingSource1BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdventureWorksDataSet adventureWorksDataSet;
        private System.Windows.Forms.BindingSource shipMethodBindingSource;
        private AdventureWorksDataSetTableAdapters.ShipMethodTableAdapter shipMethodTableAdapter;
        private AdventureWorksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator shipMethodBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton shipMethodBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox shipMethodIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox shipBaseTextBox;
        private System.Windows.Forms.TextBox shipRateTextBox;
        private System.Windows.Forms.Button closeButton;
        private AdventureWorksDataSet adventureWorksDataSet1;
        private System.Windows.Forms.BindingSource shipMethodBindingSource1;
        private AdventureWorksDataSetTableAdapters.ShipMethodTableAdapter shipMethodTableAdapter1;
        private AdventureWorksDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator shipMethodBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton shipMethodBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox shipMethodIDTextBox1;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.TextBox shipBaseTextBox1;
        private System.Windows.Forms.TextBox shipRateTextBox1;
        private System.Windows.Forms.Button closeButton1;
    }
}