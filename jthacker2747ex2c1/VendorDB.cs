using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace jthacker2747ex2c1
{
    public class VendorDB
    {
        public static List<Vendor> getVendors(int activeFlagParameter)
        {
            //Create SqlConnection
            SqlConnection connection = new SqlConnection(jthacker2747ex2c1.Properties.Settings.Default.AdventureWorksConnectionString);
            //connectionString3Label.Text = jthacker2747ex2c1.Properties.Settings.Default.AdventureWorksConnectionString;


            // Create SqlCommand
            SqlCommand selectCommand = new SqlCommand();
            string sqlText = "SELECT BusinessEntityID, AccountNumber, Name, "
                 + "CreditRating, PreferredVendorStatus, ActiveFlag, PurchasingWebServiceURL, ModifiedDate "
                 + "FROM Purchasing.Vendor WHERE ActiveFlag = @ActiveFlag ORDER BY Name";
            selectCommand.CommandText = sqlText;
            selectCommand.Connection = connection;
            SqlParameter activeFlagSqlParameter = new SqlParameter("@ActiveFlag", 1);
            selectCommand.Parameters.Add(activeFlagSqlParameter); 


            List<Vendor> vendorList = new List<Vendor>();

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    int ordBusinessEntityID = reader.GetOrdinal("BusinessEntityID");
                    int ordAccountNumber = reader.GetOrdinal("AccountNumber");
                    int ordName = reader.GetOrdinal("Name");
                    int ordCreditRating = reader.GetOrdinal("CreditRating");
                    int ordPreferredVendorStatus = reader.GetOrdinal("PreferredVendorStatus");
                    int ordActiveFlag = reader.GetOrdinal("ActiveFlag");
                    int ordPurchasingWebServiceURL = reader.GetOrdinal("PurchasingWebServiceURL");
                    int ordModifiedDate = reader.GetOrdinal("ModifiedDate");

                    while (reader.Read())
                    {
                        int businessEntityID = reader.GetInt32(ordBusinessEntityID);
                        string accountNumber = reader.GetString(ordAccountNumber);
                        string name = reader.GetString(ordName);
                        short creditRating = reader.GetByte(ordCreditRating);
                        bool preferredVendorStatus = reader.GetBoolean(ordPreferredVendorStatus);
                        bool activeFlag = reader.GetBoolean(ordActiveFlag);
                        string purchasingWebServiceURL = string.Empty;
                        if (!reader.IsDBNull(ordPurchasingWebServiceURL))
                        {
                            purchasingWebServiceURL = reader.GetString(ordPurchasingWebServiceURL);
                        }
                        System.DateTime modifiedDate = reader.GetDateTime(ordModifiedDate);

                        Vendor vendor = new Vendor(
                            businessEntityID, accountNumber, name,
                            creditRating, preferredVendorStatus, activeFlag, purchasingWebServiceURL,
                            modifiedDate);

                        vendorList.Add(vendor);

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
            return vendorList;

        }
    }
}