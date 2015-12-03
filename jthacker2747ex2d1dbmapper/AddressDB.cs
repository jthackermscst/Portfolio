using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace jthacker2747ex2d1dbmapper
{
    public class AddressDB
    {
        public static Address getAddress(int businessEntityID)
        {
            Address address = null;

            //Create SqlConnection
            SqlConnection connection = new SqlConnection(jthacker2747ex2d1dbmapper.Properties.Settings.Default.AdventureWorksConnectionString);
            //connectionString3Label.Text = jthacker2747ex2c1.Properties.Settings.Default.AdventureWorksConnectionString;


            // Create SqlCommand
            SqlCommand selectCommand = new SqlCommand();
            selectCommand.CommandText = "spEx2dSelectAddress";
            selectCommand.Connection = connection;
            selectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter businessEntityIdSqlParameter = new SqlParameter("@BusinessEntityID", 1);
            selectCommand.Parameters.Add(businessEntityIdSqlParameter);


            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {

                    int ordAddressID = reader.GetOrdinal("AddressID");
                    int ordAddressLine1 = reader.GetOrdinal("AddressLine1");
                    int ordAddressLine2 = reader.GetOrdinal("AddressLine2");
                    int ordCity = reader.GetOrdinal("City");
                    int ordStateProvinceID = reader.GetOrdinal("StateProvinceID");
                    int ordPostalCode = reader.GetOrdinal("PostalCode");
                    int ordModifiedDate = reader.GetOrdinal("ModifiedDate");

                    if (reader.Read())
                    {
                        //int businessEntityID = reader.GetInt32(ordBusinessEntityID);
                        int addressID = reader.GetInt32(ordAddressID);
                        string addressLine1 = reader.GetString(ordAddressLine1);
                        string addressLine2 = reader.GetString(ordAddressLine2);
                        string city = reader.GetString(ordCity);
                        int stateProvinceID = reader.GetInt32(ordStateProvinceID);
                        string postalCode = reader.GetString(ordPostalCode);
                        //string purchasingWebServiceURL = string.Empty;
                        //if (!reader.IsDBNull(ordPurchasingWebServiceURL))
                        //{
                        //    purchasingWebServiceURL = reader.GetString(ordPurchasingWebServiceURL);
                        //}
                        System.DateTime modifiedDate = reader.GetDateTime(ordModifiedDate);

                        address = new Address(
                        addressID, addressLine1, addressLine2, city,
                        stateProvinceID, postalCode, modifiedDate);


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
            return address;


        }

        public static Address updateAddress(int businessEntityID, Address address)
        {

            //Create SqlConnection
            SqlConnection connection = new SqlConnection(jthacker2747ex2d1dbmapper.Properties.Settings.Default.AdventureWorksConnectionString);

            // Create SqlCommand
            SqlCommand updateCommand = new SqlCommand();
            updateCommand.CommandText = "spEx2dUpdateAddress";
            updateCommand.Connection = connection;
            updateCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter businessEntityIdSqlParameter = new SqlParameter("@BusinessEntityID", businessEntityID);
            updateCommand.Parameters.Add(businessEntityIdSqlParameter);
            SqlParameter addressIDSqlParameter = new SqlParameter("@AddressID", address.AddressID);
            updateCommand.Parameters.Add(addressIDSqlParameter);
            SqlParameter addressLine1SqlParameter = new SqlParameter("@AddressLine1", address.AddressLine1);
            updateCommand.Parameters.Add(addressLine1SqlParameter);
            if (!address.AddressLine2.Equals(string.Empty))
            {

                SqlParameter addressLine2SqlParameter = new SqlParameter("@AddressLine2", address.AddressLine2);
                updateCommand.Parameters.Add(addressLine2SqlParameter);
            }
            else
            {
                SqlParameter addressLine2SqlParameter = new SqlParameter("@AddressLine2", (object)DBNull.Value);
                updateCommand.Parameters.Add(addressLine2SqlParameter);
            }

            SqlParameter citySqlParameter = new SqlParameter("@City", address.City);
            updateCommand.Parameters.Add(citySqlParameter);
            SqlParameter stateProvinceIDSqlParameter = new SqlParameter("@StateProcinceID", address.StateProvinceID);
            updateCommand.Parameters.Add(stateProvinceIDSqlParameter);
            SqlParameter postalCodeSqlParameter = new SqlParameter("@PostalCode", address.PostalCode);
            updateCommand.Parameters.Add(postalCodeSqlParameter);
            SqlParameter modifiedDateSqlParameter = new SqlParameter("@ModifiedDate", address.ModifiedDate);
            updateCommand.Parameters.Add(modifiedDateSqlParameter);


            try
            {
                connection.Open();
                SqlDataReader reader = updateCommand.ExecuteReader();
                if (reader.HasRows)
                {

                    int ordAddressID = reader.GetOrdinal("AddressID");
                    int ordAddressLine1 = reader.GetOrdinal("AddressLine1");
                    int ordAddressLine2 = reader.GetOrdinal("AddressLine2");
                    int ordCity = reader.GetOrdinal("City");
                    int ordStateProvinceID = reader.GetOrdinal("StateProvinceID");
                    int ordPostalCode = reader.GetOrdinal("PostalCode");
                    int ordModifiedDate = reader.GetOrdinal("ModifiedDate");

                    if (reader.Read())
                    {
                        //int businessEntityID = reader.GetInt32(ordBusinessEntityID);
                        int addressID = reader.GetInt32(ordAddressID);
                        string addressLine1 = reader.GetString(ordAddressLine1);
                        string addressLine2 = string.Empty; 
                        if (!reader.IsDBNull(ordAddressLine2))
                        {
                            addressLine2 = reader.GetString(ordAddressLine2);
                        }
                        //string addressLine2 = reader.GetString(ordAddressLine2);
                        string city = reader.GetString(ordCity);
                        int stateProvinceID = reader.GetInt32(ordStateProvinceID);
                        string postalCode = reader.GetString(ordPostalCode);
                        //string purchasingWebServiceURL = string.Empty;
                        //if (!reader.IsDBNull(ordPurchasingWebServiceURL))
                        //{
                        //    purchasingWebServiceURL = reader.GetString(ordPurchasingWebServiceURL);
                        //}
                        System.DateTime modifiedDate = reader.GetDateTime(ordModifiedDate);

                        address = new Address(
                        addressID, addressLine1, addressLine2, city,
                        stateProvinceID, postalCode, modifiedDate);


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
            return address;

        }
    }
}    

