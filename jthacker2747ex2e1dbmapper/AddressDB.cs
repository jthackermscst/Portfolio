using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace jthacker2747ex2e1dbmapper
{
    public class AddressDB
    {
        public static Address getAddress(int businessEntityID)
        {
            Address address = null;

            //Create SqlConnection
            SqlConnection connection = new SqlConnection(jthacker2747ex2e1dbmapper.Properties.Settings.Default.AdventureWorksConnectionString);
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
                        string addressLine2 = string.Empty;
                        if (!reader.IsDBNull(ordAddressLine2))
                        {
                            addressLine2 = reader.GetString(ordAddressLine2);
                        }
                        string city = reader.GetString(ordCity);
                        int stateProvinceID = reader.GetInt32(ordStateProvinceID);
                        string postalCode = reader.GetString(ordPostalCode);


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
            
            if (AdventureWorksDbContext.connection == null)
            {
                AdventureWorksDbContext.connection =
                    new SqlConnection(jthacker2747ex2e1dbmapper.Properties.Settings.Default.AdventureWorksConnectionString);
            }

        try { 

            if (AdventureWorksDbContext.connection.State == System.Data.ConnectionState.Closed)
            {
                AdventureWorksDbContext.connection.Open();

            }
                
            // Create SqlCommand
            SqlCommand updateCommand = new SqlCommand();
            updateCommand.CommandText = "spEx2dUpdateAddress";
            updateCommand.Connection = AdventureWorksDbContext.connection;
            updateCommand.Transaction = AdventureWorksDbContext.transaction; //ex2e
            updateCommand.CommandType = System.Data.CommandType.StoredProcedure;
            
            updateCommand.Parameters.AddWithValue("@BusinessEntityID", businessEntityID);
            updateCommand.Parameters.AddWithValue("@AddressLine1", address.AddressLine1);
            if (!address.AddressLine2.Equals(string.Empty))
            {

                updateCommand.Parameters.AddWithValue("@AddressLine2", address.AddressLine2);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@AddressLine2", (object)DBNull.Value);
            }

            updateCommand.Parameters.AddWithValue("@City", address.City);
            updateCommand.Parameters.AddWithValue("@StateProcinceID", address.StateProvinceID);
            updateCommand.Parameters.AddWithValue("@PostalCode", address.PostalCode);
            updateCommand.Parameters.AddWithValue("@ModifiedDate", address.ModifiedDate);

           
                //AdventureWorksDbContext.connection.Open();


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
                        
                        System.DateTime modifiedDate = reader.GetDateTime(ordModifiedDate);

                        address = new Address(
                        addressID, addressLine1, addressLine2, city,
                        stateProvinceID, postalCode, modifiedDate);


                    }
                }
                reader.Close();

            }

            catch (Exception ex)
            {
                //MessageBox.Show("SQL Server error: " + ex.Message,
                //    ex.GetType().ToString());
                throw ex;
            }
            //finally
            //{
            //    AdventureWorksDbContext.connection.Close();

            //}
            return address;

        }
        public static Address insertEmptyAddress(int businessEntityID)
        {
            Address address = null;
            //Create SqlConnection

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

                }

                // Create SqlCommand
                SqlCommand InsertCommand = new SqlCommand();
                InsertCommand.CommandText = "spEx2eInsertEmptyAddress";
                InsertCommand.Connection = AdventureWorksDbContext.connection;
                InsertCommand.Transaction = AdventureWorksDbContext.transaction; //ex2e
                InsertCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter businessEntityIdSqlParameter = new SqlParameter("@BusinessEntityID", businessEntityID);
                //newBusinessEntityIdSqlParameter.Direction = System.Data.ParameterDirection.Output;
                InsertCommand.Parameters.Add(businessEntityIdSqlParameter);

                SqlParameter newAddressIdSqlParameter = new SqlParameter("@newAddressID", System.Data.SqlDbType.Int);
                newAddressIdSqlParameter.Direction = System.Data.ParameterDirection.Output;
                InsertCommand.Parameters.Add(newAddressIdSqlParameter);



                //AdventureWorksDbContext.connection.Open();


                //SqlDataReader reader = InsertCommand.ExecuteReader();

                //if (reader.HasRows)
                //{

                //    int ordAddressID = reader.GetOrdinal("AddressID");
                //    int ordAddressLine1 = reader.GetOrdinal("AddressLine1");
                //    int ordAddressLine2 = reader.GetOrdinal("AddressLine2");
                //    int ordCity = reader.GetOrdinal("City");
                //    int ordStateProvinceID = reader.GetOrdinal("StateProvinceID");
                //    int ordPostalCode = reader.GetOrdinal("PostalCode");
                //    int ordModifiedDate = reader.GetOrdinal("ModifiedDate");

                //    if (reader.Read())
                //    {
                //        //int businessEntityID = reader.GetInt32(ordBusinessEntityID);
                //        int addressID = reader.GetInt32(ordAddressID);
                //        string addressLine1 = reader.GetString(ordAddressLine1);
                //        string addressLine2 = string.Empty;
                //        if (!reader.IsDBNull(ordAddressLine2))
                //        {
                //            addressLine2 = reader.GetString(ordAddressLine2);
                //        }
                //        //string addressLine2 = reader.GetString(ordAddressLine2);
                //        string city = reader.GetString(ordCity);
                //        int stateProvinceID = reader.GetInt32(ordStateProvinceID);
                //        string postalCode = reader.GetString(ordPostalCode);

                //        System.DateTime modifiedDate = reader.GetDateTime(ordModifiedDate);

                //        address = new Address(
                //        addressID, addressLine1, addressLine2, city,
                //        stateProvinceID, postalCode, modifiedDate);


                //    }
                //}
                //reader.Close();
                
                int rowCount = InsertCommand.ExecuteNonQuery();
                int addressID = (int)newAddressIdSqlParameter.Value;
                address = new Address(addressID, string.Empty, string.Empty, 
                    string.Empty, 9, string.Empty, DateTime.Now); 

            }

            catch (Exception ex)
            {
                //MessageBox.Show("SQL Server error: " + ex.Message,
                //    ex.GetType().ToString());
                throw ex;
            }
            //finally
            //{
            //    AdventureWorksDbContext.connection.Close();

            //}
            return address;

        }
    }
}    

