using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace jthacker2747ex1c2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adventureWorks2014_DataDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorks2014_DataDataSet.UnitMeasure' table. You can move, or remove it, as needed.

            try
            {
                this.unitMeasureTableAdapter.Fill(this.adventureWorks2014_DataDataSet.UnitMeasure);
                this.productCategoryTableAdapter.Fill(this.adventureWorks2014_DataDataSet.ProductCategory);
                this.productSubcategoryTableAdapter.Fill(this.adventureWorks2014_DataDataSet.ProductSubcategory);
                this.productTableAdapter.Fill(this.adventureWorks2014_DataDataSet.Product);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Store_Load(): " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Store_Load(): " + ex.GetType().ToString());
            }

            Binding b = new Binding
                ("Text", productBindingSource, "ProductNumber");
            b.Format += new ConvertEventHandler(FormatProductNumber);
            productNumberBoundLabel2.DataBindings.Add(b);
            
         
        }

        private void FormatProductNumber(object sender, ConvertEventArgs e)
        {
            if (e.DesiredType != typeof(string)) return;

            string prodNum = e.Value.ToString();
            if (prodNum.Length > 5)
            {
                prodNum = prodNum.Replace("-", string.Empty);
                prodNum = prodNum.Substring(0, 3) + "." + prodNum.Substring(3, 2) + "." + prodNum.Substring(5);
                e.Value = prodNum;
            }
        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            int position = productBindingSource.Position;

            int productSubcategoryID = adventureWorks2014_DataDataSet.Product.ElementAt(position).ProductSubcategoryID;
            AdventureWorks2014_DataDataSet.ProductSubcategoryRow subcategoryRow =
                adventureWorks2014_DataDataSet.ProductSubcategory.FindByProductSubcategoryID(productSubcategoryID);
            productSubcategoryNameLabel.Text = subcategoryRow.Name;

            productCategoryIdLabel.Text = subcategoryRow.ProductCategoryID.ToString();

            int productCategoryID = subcategoryRow.ProductCategoryID; 
            AdventureWorks2014_DataDataSet.ProductCategoryRow categoryRow =
                adventureWorks2014_DataDataSet.ProductCategory.FindByProductCategoryID(productCategoryID);
            productCategoryNameLabel.Text = categoryRow.Name;

            //String unitMeasureCode = adventureWorks2014_DataDataSet.UnitMeasure.ElementAt(position).UnitMeasureCode;
            //AdventureWorks2014_DataDataSet.UnitMeasureRow unitMeasureRow =
            //    adventureWorks2014_DataDataSet.UnitMeasure.FindByUnitMeasureCode(unitMeasureCode);
            //productUnitMeasureNameLabel.Text = unitMeasureRow.Name;

            try {
                string unitMeasureCode = adventureWorks2014_DataDataSet.Product.ElementAt(productBindingSource.Position).WeightUnitMeasureCode;
                AdventureWorks2014_DataDataSet.UnitMeasureRow unitMeasureRow =
                    adventureWorks2014_DataDataSet.UnitMeasure.FindByUnitMeasureCode(unitMeasureCode);
                productUnitMeasureNameLabel.Text = unitMeasureRow.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                      "\nMessage: " + ex.Message,
                      "Store_Load(): " + ex.GetType().ToString());
            }
            
                
            }
        }
    }

