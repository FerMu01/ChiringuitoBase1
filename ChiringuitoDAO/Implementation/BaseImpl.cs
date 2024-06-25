using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiringuitoDAO.Implementation
{
    public class BaseImpl
    {
        private readonly string connectionString = "Server=FERNANDO\\SQLEXPRESS;Database=dbChiringuito;User Id=fernando;Password=Fer?#28_09!2001;";
        public string query;
        /// <summary>
        /// Creates a basic SQL command with an open connection.
        /// </summary>
        /// <returns>A basic SqlCommand object with an open connection.</returns>
        public SqlCommand CreateBasicCommand()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand
            {
                Connection = connection
            };
            return command;
        }

        /// <summary>
        /// Creates a basic SQL command with the provided query and an open connection.
        /// </summary>
        /// <param name="query">The SQL query string.</param>
        /// <returns>A SqlCommand object with the provided query and an open connection.</returns>
        public SqlCommand CreateBasicCommand(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            return command;
        }

        /// <summary>
        /// Executes a basic SQL command (INSERT, UPDATE, DELETE).
        /// </summary>
        /// <param name="command">The SqlCommand object to execute.</param>
        /// <returns>The number of rows affected.</returns>
        public int ExecuteBasicCommand(SqlCommand command)
        {
            try
            {
                using (command.Connection)
                {
                    command.Connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while executing the command.", ex);
            }
        }

        /// <summary>
        /// Executes a SQL command and returns the result as a DataTable (SELECT).
        /// </summary>
        /// <param name="command">The SqlCommand object to execute.</param>
        /// <returns>A DataTable containing the results of the query.</returns>
        public DataTable ExecuteDataTableCommand(SqlCommand command)
        {
            DataTable dt = new DataTable();
            try
            {
                using (command.Connection)
                {
                    command.Connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while executing the query.", ex);
            }
            return dt;
        }
    }
}
