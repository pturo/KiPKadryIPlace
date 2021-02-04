using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KiPKadryIPlace.DataAccessLayer
{
    public class DBUtilities
    {
        #region Fields

        // Connection credentials
        private string SERVER;
        private string DATABASE;
        private string USERNAME;
        private string PASSWORD;
        private SqlConnection connection;

        #endregion
        #region Constructor

        public DBUtilities()
        {
            this.SERVER = "localhost\\SQLEXPRESS;";
            this.DATABASE = "KiPKadryIPlaceDB;";
            this.USERNAME = "sa;";
            this.PASSWORD = "root;";

            connection = new SqlConnection(GetStringConnection());
        }

        #endregion
        #region Private Methods

        private string GetStringConnection()
        {
            string connection = "Data Source=" + this.SERVER + "Initial Catalog=" + this.DATABASE
                + "User Id=" + this.USERNAME + "Password=" + this.PASSWORD;

            return connection;
        }

        private void OpenConnection()
        {
            try
            {
                if ((connection != null) && (connection.State == System.Data.ConnectionState.Closed))
                {
                    connection.Open();
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
            }
        }

        private void CloseConnection()
        {
            try
            {
                if ((connection != null) && (connection.State == System.Data.ConnectionState.Open))
                {
                    connection.Close();
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
            }
        }

        // Items iterator within Dictionary
        private Array GetParams(Dictionary<string, string> param)
        {
            var parameters = new List<SqlParameter>();
            foreach (KeyValuePair<string, string> entry in param)
            {
                // Key - @param
                // Value - i.e txtPassword.Text
                parameters.Add(new SqlParameter(entry.Key, entry.Value));
            }
            return parameters.ToArray();
        }

        #endregion
        #region Public Methods

        public bool IsConnected()
        {
            try
            { 
                if((connection != null) && (connection.State == System.Data.ConnectionState.Closed))
                {
                    connection.Open();
                    connection.Close();
                    return true;
                }
                return false;
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                return false;
            }
        }

        public int ExecuteQuery(string query)
        {
            try
            {
                OpenConnection();
                int rowsAffected;
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = query;
                    rowsAffected = cmd.ExecuteNonQuery(); // For Insert, Update and Delete
                    CloseConnection();
                }
                return rowsAffected;
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                return -1;
            }
        }

        public int ExecuteQuery(string query, Dictionary<string, string> parameters)
        {
            try
            {
                OpenConnection();
                int rowsAffected;
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = query;
                    cmd.Parameters.AddRange(GetParams(parameters)); // Parameters will be used to clean up queries
                    rowsAffected = cmd.ExecuteNonQuery();
                    CloseConnection();
                }
                return rowsAffected;
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                return -1;
            }
        }

        public string DataLookUp(string column, string table, string criteria)
        {
            try
            {
                string returnVal = "";
                string query = "select " + column + " from " + table + (criteria.Length > 0 ? " where " + criteria : "");

                DataTable dt = GetData(query);
                if(dt?.Rows?.Count > 0)
                {
                    foreach(DataRow row in dt.Rows)
                    {
                        returnVal = row[column].ToString();
                    }
                }

                return returnVal;
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                return "";
            }
        }

        public string DataLookUp(string column, string table, string criteria, Dictionary<string, string> parameters)
        {
            try
            {
                string returnVal = "";
                string query = "select " + column + " from " + table + (criteria.Length > 0 ? " where " + criteria : "");

                DataTable dt = GetData(query, parameters);
                if (dt?.Rows?.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        returnVal = row[column].ToString();
                    }
                }

                return returnVal;
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                return "";
            }
        }

        public DataTable GetData(string query)
        {
            try
            {
                DataTable dt = new DataTable();

                using (SqlCommand cmd = new SqlCommand())
                {
                    OpenConnection();
                    cmd.Connection = connection;
                    cmd.CommandText = query;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    CloseConnection();
                }
                return dt;
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                return null;
            }
        }

        public DataTable GetData(string query, Dictionary<string, string> parameters)
        {
            try
            {
                DataTable dt = new DataTable();

                using (SqlCommand cmd = new SqlCommand())
                {
                    OpenConnection();
                    cmd.Connection = connection;
                    cmd.CommandText = query;
                    if(parameters != null)
                    {
                        cmd.Parameters.AddRange(GetParams(parameters));
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    CloseConnection();
                }
                return dt;
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                return null;
            }
        }

        #endregion
    }
}
