using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jthacker2747ex1a1
{
    public partial class ShipDetailsForm : Form
    {
        public ShipDetailsForm()
        {
            InitializeComponent();
        }

        private void shipMethodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shipMethodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adventureWorksDataSet);

        }

        private void ShipDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorksDataSet.ShipMethod' table. You can move, or remove it, as needed.
            this.shipMethodTableAdapter.Fill(this.adventureWorksDataSet.ShipMethod);

        }

        private void shipMethodBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shipMethodBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.adventureWorksDataSet1);

        }

        private void ShipDetailsForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorksDataSet1.ShipMethod' table. You can move, or remove it, as needed.
            this.shipMethodTableAdapter1.Fill(this.adventureWorksDataSet1.ShipMethod);

        }

        private void closeButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
