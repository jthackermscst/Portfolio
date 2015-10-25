using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jthacker2747ex1i2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _4hServiceTransactionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._4hServiceTransactionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.thackTracksDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thackTracksDataSet._4hServiceTransaction' table. You can move, or remove it, as needed.
            this._4hServiceTransactionTableAdapter.Fill(this.thackTracksDataSet._4hServiceTransaction);

        }
    }
}
