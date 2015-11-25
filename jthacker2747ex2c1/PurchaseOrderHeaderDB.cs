using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace jthacker2747ex2c1
{
    public class PurchaseOrderHeaderDB
    {
        public static List<PurchaseOrderHeader> getPurchaseOrderHeaders(int selectVendorID)
        {
            //Create SqlConnection
            SqlConnection connection = new SqlConnection(jthacker2747ex2c1.Properties.Settings.Default.AdventureWorksConnectionString);
            //connectionString3Label.Text = jthacker2747ex2c1.Properties.Settings.Default.AdventureWorksConnectionString;


            // Create SqlCommand
            SqlCommand selectCommand = new SqlCommand();
            string sqlText = "SELECT PurchaseOrderID, RevisionNumber, Status, " 
                + "EmployeeID, VendorID, ShipMethodID, OrderDate, "
                + "ShipDate, SubTotal, TaxAmt, Freight, TotalDue, ModifiedDate "
                + "FROM Purchasing.PurchaseOrderHeader "
                + "WHERE VendorID = @VendorID "
                + "ORDER BY PurchaseOrderID";
            selectCommand.CommandText = sqlText;
            selectCommand.Connection = connection;
            SqlParameter vendorIDSqlParameter = new SqlParameter("@VendorID", selectVendorID);
            selectCommand.Parameters.Add(vendorIDSqlParameter);


            List<PurchaseOrderHeader> purchaseOrderHeaderList = new List<PurchaseOrderHeader>();

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    int ordPurchaseOrderID = reader.GetOrdinal("PurchaseOrderID");
                    int ordRevisionNumber = reader.GetOrdinal("RevisionNumber");
                    int ordStatus = reader.GetOrdinal("Status");
                    int ordEmployeeID = reader.GetOrdinal("EmployeeID");
                    int ordVendorID = reader.GetOrdinal("VendorID");
                    int ordShipMethodID = reader.GetOrdinal("ShipMethodID");
                    int ordOrderDate = reader.GetOrdinal("OrderDate");
                    int ordShipDate = reader.GetOrdinal("ShipDate");
                    int ordSubTotal = reader.GetOrdinal("SubTotal");
                    int ordTaxAmt = reader.GetOrdinal("TaxAmt");
                    int ordFreight = reader.GetOrdinal("Freight");
                    int ordTotalDue = reader.GetOrdinal("TotalDue");
                    int ordModifiedDate = reader.GetOrdinal("ModifiedDate");

                    while (reader.Read())
                    {
                        int purchaseOrderID = reader.GetInt32(ordPurchaseOrderID);
                        int revisionNumber = reader.GetByte(ordRevisionNumber);
                        int status = reader.GetByte(ordStatus);
                        int employeeID = reader.GetInt32(ordEmployeeID);
                        int vendorID = reader.GetInt32(ordVendorID);
                        int shipMethodID = reader.GetInt32(ordShipMethodID);
                        DateTime orderDate = reader.GetDateTime(ordOrderDate);
                        DateTime? shipDate = null;
                        if (!reader.IsDBNull(ordShipDate))
                        {
                            shipDate = reader.GetDateTime(ordShipDate);
                        }


                        decimal subTotal = reader.GetDecimal(ordSubTotal);
                        decimal taxAmt = reader.GetDecimal(ordTaxAmt);
                        decimal freight = reader.GetDecimal(ordFreight);
                        decimal totalDue = reader.GetDecimal(ordTotalDue); 
                                                
                        DateTime modifiedDate = reader.GetDateTime(ordModifiedDate);

                         

                        PurchaseOrderHeader purchaseOrderHeader = new PurchaseOrderHeader(purchaseOrderID, revisionNumber, 
                            status, employeeID, vendorID,
                            shipMethodID, orderDate, shipDate,
                            subTotal, taxAmt, freight,
                            totalDue, modifiedDate);

                        purchaseOrderHeaderList.Add(purchaseOrderHeader);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Server error: " + ex.Message,
                    ex.GetType().ToString());
            }
            finally
            {
                connection.Close();

            }
            return purchaseOrderHeaderList;

        }
    }
}
    
