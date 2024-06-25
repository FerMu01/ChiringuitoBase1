using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ChiringuitoDAO.Interfaces;
using ChiringuitoDAO.Model;

namespace ChiringuitoDAO.Implementation
{
    public class OrderImpl : BaseImpl, IOrder
    {
        string query;
        public int Delete(Order t)
        {
            query = @"UPDATE OrderFood SET status=0, lastUpdate= CURRENT_TIMESTAMP, userID=@userID
                      WHERE id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@userID", 1);
            command.Parameters.AddWithValue("@id", t.Id);
            try
            {
                return ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Insert(Order t)
        {
            query = @"INSERT INTO OrderFood (name, total, userID)
                      VALUES (@name, @total, @userID)";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@name", t.Name);
            command.Parameters.AddWithValue("@total", t.Total);
            command.Parameters.AddWithValue("@userID", 1);

            try
            {
                return ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            };
        }

        public DataTable Select()
        {
            query = @"  SELECT id, name As Orden, total AS 'Total Bs.'
                        FROM OrderFood
                        ORDER BY 3";
            SqlCommand command = CreateBasicCommand(query);
            try
            {
                return ExecuteDataTableCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectLikeName(string name)
        {
            throw new NotImplementedException();
        }

        public int Update(Order t)
        {
            query = @"UPDATE OrderFood SET name=@name, total=@total, lastUpdate=CURRENT_TIMESTAMP, userID=@userID
                      WHERE id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@name", t.Name);
            command.Parameters.AddWithValue("@total", t.Total);
            command.Parameters.AddWithValue("@userID", 1);
            command.Parameters.AddWithValue("@id", t.Id);
            try
            {
                return ExecuteBasicCommand(command);
            } catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
