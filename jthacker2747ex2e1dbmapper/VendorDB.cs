using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
//using System.Windows.Forms;

namespace jthacker2747ex2e1dbmapper
{
    public class VendorDB
    {
        public static List<Vendor> getVendors()
        {
            
            
            //Create SqlConnection


            SqlConnection connection = new SqlConnection(jthacker2747ex2e1dbmapper.Properties.Settings.Default.AdventureWorksConnectionString);

            // Create SqlCommand
            SqlCommand selectCommand = new SqlCommand();
            selectCommand.CommandText = "spEx2dSelectVendors";
            selectCommand.Connection = connection;
            selectCommand.CommandType = System.Data.CommandType.StoredProcedure;


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

                        Address address = AddressDB.getAddress(businessEntityID);

                        Vendor vendor = new Vendor(
                            businessEntityID, accountNumber, name,
                            creditRating, preferredVendorStatus, activeFlag, purchasingWebServiceURL,
                            modifiedDate, address);

                        vendorList.Add(vendor);

                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("SQL Server error: " + ex.Message,
                //    ex.GetType().ToString());
                throw ex;
            }
            finally
            {
                connection.Close();

            }
            return vendorList;

        }

        public static Vendor getVendor(int businessEntityID)
        {
            Vendor vendor = null;
            
            //Create SqlConnection
            SqlConnection connection = new SqlConnection(jthacker2747ex2e1dbmapper.Properties.Settings.Default.AdventureWorksConnectionString);
            //connectionString3Label.Text = jthacker2747ex2c1.Properties.Settings.Default.AdventureWorksConnectionString;


            // Create SqlCommand
            SqlCommand selectCommand = new SqlCommand();
            selectCommand.CommandText = "spEx2dSelectVendor";
            selectCommand.Connection = connection;
            selectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter businessEntityIdSqlParameter = new SqlParameter("@BusinessEntityID", vendor.BusinessEntityID);
            selectCommand.Parameters.Add(businessEntityIdSqlParameter);


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

                    if (reader.Read())
                    {
                        //int businessEntityID = reader.GetInt32(ordBusinessEntityID);
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

                        Address address = AddressDB.getAddress(businessEntityID);

                        vendor = new Vendor(
                            businessEntityID, accountNumber, name,
                            creditRating, preferredVendorStatus, activeFlag, purchasingWebServiceURL,
                            modifiedDate, address);


                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("SQL Server error: " + ex.Message,
                //    ex.GetType().ToString());
                throw ex;
            }
            finally
            {
                connection.Close();

            }
            return vendor;

        }
        public static Vendor updateVendor(Vendor vendor)
        {

            //Create SqlConnection
            //SqlConnection connection = new SqlConnection(jthacker2747ex2e1dbmapper.Properties.Settings.Default.AdventureWorksConnectionString);

            if (AdventureWorksDbContext.connection == null)
            {
                AdventureWorksDbContext.connection = 
                    new SqlConnection(jthacker2747ex2e1dbmapper.Properties.Settings.Default.AdventureWorksConnectionString);
            }

        try { 
                 
            if (AdventureWorksDbContext.connection.State == System.Data.ConnectionState.Closed)
            {
                AdventureWorksDbContext.connection.Open();
                    AdventureWorksDbContext.transaction =
                        AdventureWorksDbContext.connection.BeginTransaction();

            }

            Address address = AddressDB.updateAddress(vendor.BusinessEntityID, vendor.Address);

            // Create SqlCommand
            SqlCommand UpdateCommand = new SqlCommand();
            UpdateCommand.CommandText = "spEx2dUpdateVendor";
            UpdateCommand.Connection = AdventureWorksDbContext.connection;
            UpdateCommand.Transaction = AdventureWorksDbContext.transaction; //ex2e
            UpdateCommand.CommandType = System.Data.CommandType.StoredProcedure; //ex2e

            SqlParameter businessEntityIdSqlParameter = new SqlParameter("@BusinessEntityID", vendor.BusinessEntityID);
            UpdateCommand.Parameters.Add(businessEntityIdSqlParameter);
            SqlParameter accountNumberSqlParameter = new SqlParameter("@AccountNumber", vendor.AccountNumber);
            UpdateCommand.Parameters.Add(accountNumberSqlParameter);
            SqlParameter nameSqlParameter = new SqlParameter("@Name", vendor.Name );
            UpdateCommand.Parameters.Add(nameSqlParameter);
            SqlParameter creditRatingSqlParameter = new SqlParameter("@CreditRating", vendor.CreditRating );
            UpdateCommand.Parameters.Add(creditRatingSqlParameter);
            SqlParameter preferredVendorSqlParameter = new SqlParameter("@PreferredVendorStatus", vendor.PreferredVendorStatus );
            UpdateCommand.Parameters.Add(preferredVendorSqlParameter);
            SqlParameter activeFlagSqlParameter = new SqlParameter("@ActiveFlag", vendor.ActiveFlag );
            UpdateCommand.Parameters.Add(activeFlagSqlParameter);
               SqlParameter modifiedDateSqlParameter = new SqlParameter("@ModifiedDate", vendor.ModifiedDate);
            UpdateCommand.Parameters.Add(modifiedDateSqlParameter);

            if (!vendor.PurchasingWebServiceURL.Equals(string.Empty))
            {
                SqlParameter purchasingWebServiceURLSqlParameter = new SqlParameter("@PurchasingWebServiceURL", vendor.PurchasingWebServiceURL);
                UpdateCommand.Parameters.Add(purchasingWebServiceURLSqlParameter);
            }
            else
            {
                SqlParameter purchasingWebServiceURLSqlParameter = 
                    new SqlParameter("@PurchasingWebServiceURL", (object)DBNull.Value);
                UpdateCommand.Parameters.Add(purchasingWebServiceURLSqlParameter);

            }

            
                //connection.Open();
                //AdventureWorksDbContext.connection.Open();
                SqlDataReader reader = UpdateCommand.ExecuteReader();
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

                    if (reader.Read())
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

                       // Address address = AddressDB.getAddress(businessEntityID);


                        vendor = new Vendor(
                            businessEntityID, accountNumber, name,
                            creditRating, preferredVendorStatus, activeFlag, purchasingWebServiceURL,
                            modifiedDate, address);
                        
                        

                    }
                }
                reader.Close();
                AdventureWorksDbContext.transaction.Commit();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("SQL Server error: " + ex.Message,
                //    ex.GetType().ToString());
                try {
                    AdventureWorksDbContext.transaction.Rollback();
                }
                catch (Exception exRollback)
                {
                    throw exRollback;
                }
                throw ex;
            }
            finally
            {
                AdventureWorksDbContext.connection.Close(); // ex2e

            }
            return vendor;

        }
        public static Vendor insertEmptyVendor()
        {
            Vendor vendor = null;
            //Create SqlConnection
            //SqlConnection connection = new SqlConnection(jthacker2747ex2e1dbmapper.Properties.Settings.Default.AdventureWorksConnectionString);

            if (AdventureWorksDbContext.connection == null)
            {
                AdventureWorksDbContext.connection =
                    new SqlConnection(jthacker2747ex2e1dbmapper.Properties.Settings.Default.AdventureWorksConnectionString);
            }

            try
            {

                if (AdventureWorksDbContext.connection.State == System.Data.ConnectionState.Closed)
                {
                    AdventureWorksDbContext.connection.Open();
                    AdventureWorksDbContext.transaction =
                        AdventureWorksDbContext.connection.BeginTransaction();

                }

                //Address address = AddressDB.updateAddress(vendor.BusinessEntityID, vendor.Address);

                // Create SqlCommand
                SqlCommand InsertCommand = new SqlCommand();
                InsertCommand.CommandText = "spEx2eInsertEmptyVendor";
                InsertCommand.Connection = AdventureWorksDbContext.connection;
                InsertCommand.Transaction = AdventureWorksDbContext.transaction; //ex2e
                InsertCommand.CommandType = System.Data.CommandType.StoredProcedure; //ex2e

                SqlParameter newBusinessEntityIdSqlParameter = new SqlParameter("@newBusinessEntityID", System.Data.SqlDbType.Int);
                newBusinessEntityIdSqlParameter.Direction = System.Data.ParameterDirection.Output;
                InsertCommand.Parameters.Add(newBusinessEntityIdSqlParameter);

                
                //connection.Open();
                //AdventureWorksDbContext.connection.Open();
                SqlDataReader reader = InsertCommand.ExecuteReader();
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

                    if (reader.Read())
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

                        reader.Close();
                        Address address = AddressDB.insertEmptyAddress(businessEntityID);


                        vendor = new Vendor(
                            businessEntityID, accountNumber, name,
                            creditRating, preferredVendorStatus, activeFlag, purchasingWebServiceURL,
                            modifiedDate, address);



                    }
                }
                //reader.Close();
                AdventureWorksDbContext.transaction.Commit();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("SQL Server error: " + ex.Message,
                //    ex.GetType().ToString());
                try
                {
                    AdventureWorksDbContext.transaction.Rollback();
                }
                catch (Exception exRollback)
                {
                    throw exRollback;
                }
                throw ex;
            }
            finally
            {
                AdventureWorksDbContext.connection.Close(); // ex2e

            }
            return vendor;

        }
    }

    
}