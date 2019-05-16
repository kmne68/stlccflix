using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MeramecNetFlixProject.Business_Objects;

namespace MeramecNetFlixProject.Data_Access_Layer
{
    public static class MemberDB
    {

        public static List<Member> GetMembers()
        {

            List<Member> objTemp = new List<Member>();
            string SQLStatement = "select member_number, name from member order by member_number";
            SqlCommand objCommand = null;
            SqlConnection objConn = null;
            SqlDataReader objReader = null;

            try
            {
                using (objConn = AccessDataSQLServer.GetConnection())
                {
                    // Open the connection to the database
                    objConn.Open();
                    // Create a command object iwth the SQL statement
                    using (objCommand = new SqlCommand(SQLStatement, objConn))
                    {
                        // Execute the SQL and return a DataReader Object
                        using (objReader = objCommand.ExecuteReader())
                        {
                            while(objReader.Read())
                            {
                                Member objMember = new Member();
                                objMember.Lastname = objReader["lastname"].ToString();
                                objMember.Firstname = objReader["first_name"].ToString();
                                objMember.Address = objReader["address"].ToString();
                             //   objMember.Member_number = objReader["member_number"].ToString();
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(objConn != null)
                {
                    objConn.Close();
                }
            }
            return objTemp;
        }


        public static Member GetMember(int memberNumber)
        {
            string SQLStatement = String.Empty;

            string sqlString = "select member_number, lastName from genre where id = @member_number";
            SqlCommand objCommand = null;
            SqlConnection objConn = null;
            SqlDataReader custReader = null;
            Member objMember = null;

            try
            {
                using(objConn = AccessDataSQLServer.GetConnection())
                {
                    // Open DB connection
                    objConn.Open();
                    // Create command object with SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        // Set command parameter
                        objCommand.Parameters.AddWithValue("@member_number", memberNumber);
                        // Execute the SQL and return DataReader
                        using (custReader = objCommand.ExecuteReader())
                        {
                            while(custReader.Read())
                            {
                                objMember = new Member();
                                // Fill the object if it is found
                           //     objMember.Member_number = custReader["member_number"].ToString();
                                objMember.Lastname = custReader["lastname"].ToString();
                            }
                        }
                    }
                    return objMember;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(objConn != null)
                {
                    objConn.Close();
                }
            }
        }


        public static bool AddMember(Member objMember)
        {
            string SQLStatement = String.Empty;

            int rowsAffected = 0;

            SqlCommand objCommand = null;
            SqlConnection objConn = null;

            string sqlString;

            try
            {
                using (objConn = AccessDataSQLServer.GetConnection())
                {
                    // Open DB connection
                    objConn.Open();
                    sqlString = "INSERT into Member values (@member_number, @lastname)";

                    // Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        // Use the command parameters method to set hte parameter values of hte SQL insert statement
                        objCommand.Parameters.AddWithValue("@member_number", objMember.Member_number);
                        objCommand.Parameters.AddWithValue("@firstname", objMember.Firstname);
                        // Excecute hte SQL command and return the number of rows affectedd
                        rowsAffected = objCommand.ExecuteNonQuery();
                    }
                    if(rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if(objConn != null)
                {
                    objConn.Close();
                }
            }
        }


        public static bool UpdateMember(Member objMember)
        {
            string SQLStatement = String.Empty;
            int rowsAffected = 0;
            SqlCommand objCommand = null;
            SqlConnection objConn = null;
            string sqlString;

            try
            {
                using(objConn = AccessDataSQLServer.GetConnection())
                {
                    objConn.Open();
                    sqlString = "update Member " + Environment.NewLine + " set name = @lastname " + Environment.NewLine +
                        "where member_number = @member_number";

                    // Create a command object with the SQL statement
                    using(objCommand = new SqlCommand(sqlString, objConn))
                    {
                        objCommand.Parameters.AddWithValue("@lastname", objMember.Lastname);
                        objCommand.Parameters.AddWithValue("member_number", objMember.Member_number);
                        // Execute the SQL query and return the number of rows affected
                        rowsAffected = objCommand.ExecuteNonQuery();
                    }
                    if(rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if(objConn != null)
                {
                    objConn.Close();
                }
            }
        }


        public static bool DeleteMember(Member objMember)
        {
            string SQLStatement = String.Empty;

            string connectionString = "Server=mc-sluggo.stlcc.edu; Initial Catalog = IS253_Emery; Persist Security Info = True; User ID = emery; Password = emery";
            int rowsAffected = 0;

            SqlCommand objCommand = null;
            SqlConnection objConn = null;

            string sqlString;

            try
            {
                using(objConn = AccessDataSQLServer.GetConnection())
                {
                    // Open DB connection
                    objConn.Open();
                    sqlString = "delete Member where member_number = @member_number";

                    // Create a command object with the SQL statement
                    using(objCommand = new SqlCommand(sqlString, objConn))
                    {
                        // Use the command parameters method to set hte parameter values of the SQL insert statement
                        objCommand.Parameters.AddWithValue("@member_number", objMember.Member_number);

                        // Execute the SQL and reutrn the number of rows affected
                        rowsAffected = objCommand.ExecuteNonQuery();
                    }
                    if(rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if(objConn != null)
                {
                    objConn.Close();
                }
            }
            
        }


    }
}
